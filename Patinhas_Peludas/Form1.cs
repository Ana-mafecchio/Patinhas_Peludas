using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Patinhas_Peludas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbNomedoGato_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarRegistro_Click(object sender, EventArgs e)
        {
            string campoNome = tbNomedoAdotante.Text;
            int controleLinhasAfetadas = 0;

            string dadosConexao = "server=localhost;user=root;password=;database=db_patinhaspeludas";
            using (MySqlConnection conn = new MySqlConnection(dadosConexao))
            {
                //utilizo as informações
                conn.Open();
                string scriptInsert = "INSERT INTO tb_informacoes (nome_do_adotante) VALUE (@nome_do_adotante)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert,conn))
                {
                    comando.Parameters.AddWithValue("@nome_do_adotante", campoNome);

                    controleLinhasAfetadas = comando.ExecuteNonQuery();
                }
                conn.Close();
           }
            if (controleLinhasAfetadas > 0)
            {
                MessageBox.Show("Dados salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Ops. Algo deu errado!!!");
            }

        }
    }
}
