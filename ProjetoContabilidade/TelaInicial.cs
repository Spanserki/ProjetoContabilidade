using FirebirdSql.Data.FirebirdClient;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoContabilidade
{

    public partial class PaginaInicio : Form
    {
        //String de conexão com o banco 
        private string FBconexao ="******************************************";
        FbConnection FBconn;//Variavel "conn" do tipo Connection

        //Variaveis do tipo string para atribuirem os resultados de pesquisa do CheckBox
        public string checadoBaixa;
        public string checadoAdi;
        public string checadoEvento;
        public string checadocheque;

        public PaginaInicio()
        {
            InitializeComponent();

            btn_Contabilizar.Enabled = false;
            btn_Contabilizar.BackColor = Color.Gray;
            btn_Contabilizar.ForeColor = Color.White;


        }

        public bool ValidardData()
        {
            //Aqui criamos um metodo que vai conter uma condição
            //caso o componente como descrito abaixo, "MaskedDataInicial e Final"
            //sejam verdadeiros e possuam algum valor, executa o programa normal
            //mas se não possuirem valores verdadeiros, chamamos uma condição If Else 
            //que estara dentro do botão carregar

            try//Caso as condiçoes sejam verdadeiras
            {
                Convert.ToDateTime(maskedDataInicial.Text);
                Convert.ToDateTime(maskedDataFinal.Text);
                return true;
            }
            catch (Exception)//Caso as condiçoes sejam falsas
            {
                return false;
            }

        }
        public bool ValidarBtnConectar()
        {
            try
            {
                FBconn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void BtnCarregar_Click(object sender, EventArgs e)
        {
            TelaCarregamento tela = new TelaCarregamento();
            tela.Show();

            if (!ValidardData())//Se as condiçoes forem contrarias do Metodo "ValidarData"
                                //executa as intruçoes abaixo e retorna para o sistema
            {
                tela.Close();
                MessageBox.Show("Data Invalida", "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                return;
                
            }
            if (!ValidarBtnConectar())
            {
                tela.Close();
                MessageBox.Show("Clique em conectar!", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBaixa.Checked == false && checkAdiantamentos.Checked == false
                && checkCheque.Checked == false && checkEventos.Checked == false)
            {
                tela.Close();
                MessageBox.Show("Marque uma das opções", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Contabilizar.Enabled = false;
                btn_Contabilizar.BackColor = Color.Gray;
                btn_Contabilizar.ForeColor = Color.White;
                FBconn.Close();
                return;
            }

            //Instanciamos um comando Select a uma variavel buscando informaçoes 
            //começando pela Data e depois os CheckBox, todos com parametros

            FbCommand cmd = new FbCommand("select ******************************************", FBconn);

            FbParameter evento = new FbParameter();
            evento.ParameterName = "evento";//CheckBox Evento
            evento.Value = checadoEvento;

            FbParameter cheque = new FbParameter();
            cheque.ParameterName = "cheque";//CheckBox Cheque
            cheque.Value = checadocheque;

            FbParameter baixa = new FbParameter();//CheckBox baixa
            baixa.ParameterName = "baixa";
            baixa.Value = checadoBaixa;

            FbParameter adiantamento = new FbParameter();//CheckBoxAdiantamento
            adiantamento.ParameterName = "adi";
            adiantamento.Value = checadoAdi;


            //Criamos dois parametros para as data Inicio e Fim
            FbParameter DataInicio = new FbParameter();
            FbParameter DataFinal = new FbParameter();

            //Atribuimos o caminho da variavel dentro da select @DataInic
            DataInicio.ParameterName = "DataInic";

            //Atribuimos o valor do Campo digitado e convertemos para "DateTime"
            DataInicio.Value = Convert.ToDateTime(maskedDataInicial.Text);

            DataFinal.ParameterName = "DataFin";
            DataFinal.Value = Convert.ToDateTime(maskedDataFinal.Text);

            if (FBconn.State != ConnectionState.Open)//Verificamos se o estado de conexão esta aberto ou fechado
            {
                FBconn.Open(); //Abrimos a conexão
            }


            //Adicionamos os parametros para dentro do comando (cmd) que contem a Select 
            cmd.Parameters.Add(DataInicio);
            cmd.Parameters.Add(DataFinal);
            cmd.Parameters.Add(baixa);
            cmd.Parameters.Add(adiantamento);
            cmd.Parameters.Add(evento);
            cmd.Parameters.Add(cheque);

            //Criamos um objeto (DA) e instanciamos o comando (cmd)
            //assim o objeto (DA) tera as "informaçoes" dos dados de (cmd)

            FbDataAdapter DA = new FbDataAdapter(cmd);

            //Adicionamos um DataTable com nome "registros" para armazenar oa dados do objeto (DA)

            DataTable registros = new DataTable();
            DA.Fill(registros);

            //Adicionamos ao DataGrid os registros
            dataGridView1.DataSource = registros;

            dataGridView1.Columns[0].HeaderText = "Data Lançamento";
            dataGridView1.Columns[1].HeaderText = "Conta Débito";
            dataGridView1.Columns[2].HeaderText = "Conta Crédito";
            dataGridView1.Columns[3].HeaderText = "Código histórico padrão";
            dataGridView1.Columns[4].HeaderText = "Histórico Complementar";
            dataGridView1.Columns[5].HeaderText = "Valor";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView1.AllowUserToAddRows = false;

            var cmd2 = new FbCommand("******************************************", FBconn);
            var cmd3 = new FbCommand("******************************************", FBconn);


            string SQLcon = @"******************************************";

            int contNaoCadastrada = 0;

            try
            {

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    cmd2.Parameters.AddWithValue("@ContaDebito", dataGridView1.Rows[i].Cells[1].Value);
                    cmd3.Parameters.AddWithValue("@ContaCredito", dataGridView1.Rows[i].Cells[2].Value);

                    var resultCodigoReduzidoDebito = Convert.ToInt32(cmd2.ExecuteScalar());

                    var resultCodigoReduzidoCredito = Convert.ToInt32(cmd3.ExecuteScalar());


                    SqlConnection SQLconexao = new SqlConnection(SQLcon);

                    var CT_debito = "******************************************";
                    var CT_credito = "******************************************";


                    SQLconexao.Open();

                    SqlCommand SQLdebito = new SqlCommand(CT_debito, SQLconexao);
                    SqlCommand SQLcredito = new SqlCommand(CT_credito, SQLconexao);


                    SQLdebito.Parameters.AddWithValue("@Debito", resultCodigoReduzidoDebito);
                    SQLcredito.Parameters.AddWithValue("@Credito", resultCodigoReduzidoCredito);


                    var resultContaDebito = SQLdebito.ExecuteScalar();
                    var resultContaCredito = SQLcredito.ExecuteScalar();

                    
                    if (resultContaDebito == null)
                    {
                        dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        contNaoCadastrada++;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.Green;
                        dataGridView1.Rows[i].Cells[1].Value = resultContaDebito;
                    }
                 
                    if (resultContaCredito == null)
                    {
                        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Red;
                        contNaoCadastrada++;
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.Green;
                        dataGridView1.Rows[i].Cells[2].Value = resultContaCredito;


                    }
                    if (resultCodigoReduzidoDebito <= 0)
                    {
                        dataGridView1.Rows[i].Cells[1].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[1].Value = null;

                    }
                    else if (resultCodigoReduzidoCredito <= 0)
                    {
                        dataGridView1.Rows[i].Cells[2].Style.BackColor = Color.White;
                        dataGridView1.Rows[i].Cells[2].Value = null;

                    }

                    cmd2.Parameters.Clear();
                    cmd3.Parameters.Clear();
                    SQLdebito.Parameters.Clear();
                    SQLcredito.Parameters.Clear();

                    SQLconexao.Close();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
               "Atenção",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
               return;
               
            }
            
            if (contNaoCadastrada == 0)
            {
                btn_Contabilizar.Enabled = true;
                btn_Contabilizar.BackColor = Color.Green;
            }
            else
            {
                tela.Close();
                btn_Contabilizar.Enabled = false;
                btn_Contabilizar.BackColor = Color.Red;
                MessageBox.Show("Existem contas não cadastradas no Plano de Contas", "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                
            }
            tela.Close();
            FBconn.Close();//Fechamos a conexão

        
        }


        private void btnContabilizar_Click(object sender, EventArgs e)
        {



        }

        private void PaginaInicio_Load(object sender, EventArgs e)
        {

        }

        public void maskedDataInicial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            FBconn = new FbConnection(FBconexao);
            btn_conectar.BackColor = Color.Green;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja SAIR da aplicação ?", "Sair",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) == DialogResult.No) return;
            Application.Exit();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedDataFinal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void checkBaixa_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBaixa.Checked == true)
            {
                checadoBaixa = "fn_baixa";
            }
            else if (checkBaixa.Checked == false)
            {
                checadoBaixa = "";

            }

        }

        private void checkBaixa_Click(object sender, EventArgs e)
        {

        }

        private void checkAdiantamentos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdiantamentos.Checked == true)
            {
                checadoAdi = "fn_adiantamento";
            }
            else if (checkAdiantamentos.Checked == false)
            {
                checadoAdi = "";
            }
        }

        private void maskedDataInicial_Click(object sender, EventArgs e)
        {

        }

        private void checkEventos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEventos.Checked == true)
            {
                checadoEvento = "ct_eventos";
            }
            else if (checkEventos.Checked == false)
            {
                checadoEvento = "";
            }
        }

        private void checkCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCheque.Checked == true)
            {
                checadocheque = "fn_emissaocheque";
            }

            else if (checkCheque.Checked == false)
            {
                checadocheque = "";
            }
        }

        private void btn_Contabilizar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja contabilizar esses dados ?", "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            string SQLcon = @"******************************************";

            SqlConnection conexao = new SqlConnection(SQLcon);

            var inserir = "******************************************";
            var SqlInserir = new SqlCommand(inserir, conexao);

            var maximo = "(Select MAX(REFERENCIA)+1" +
             "******************************************" +
             "with (nolock) " +
             "where CODIGO_EMPRESA = 9)";
            var SqlMaximo = new SqlCommand(maximo, conexao);

            conexao.Open();

            try
            {

                for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
                {
                    int ctRef = ((int)SqlMaximo.ExecuteScalar());

                    SqlInserir.Parameters.Clear();
                    SqlInserir.Parameters.AddWithValue("@Data", Convert.ToDateTime(dataGridView1.Rows[i].Cells[0].Value));
                    SqlInserir.Parameters.AddWithValue("@Devedora", dataGridView1.Rows[i].Cells[1].Value);
                    SqlInserir.Parameters.AddWithValue("@Credora", dataGridView1.Rows[i].Cells[2].Value);
                    SqlInserir.Parameters.AddWithValue("@Historico", Convert.ToString(dataGridView1.Rows[i].Cells[4].Value));
                    SqlInserir.Parameters.AddWithValue("@Valor", Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
                    SqlInserir.Parameters.AddWithValue("@Maximo", ctRef);
                    SqlInserir.ExecuteNonQuery();

                }
                MessageBox.Show("Dados inseridos com sucesso",
                "Mensagem do sistema",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Erro",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                 return;
            }
            conexao.Close();

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

        }

    }

}
