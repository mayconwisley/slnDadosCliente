using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
namespace DadosCliente
{
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        ObjCliente objCliente;
        int idCliente;
        private void ListarCliente()
        {
            try
            {
                DgvListaCliente.DataSource = Negocio.Cliente.Listar.Cadastro();
                LblCliente.Text = "Total de Clientes: " + DgvListaCliente.Rows.Count.ToString("000");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Cadastro(char opc)
        {
            objCliente = new ObjCliente();
            try
            {
                objCliente.Id = idCliente;
                objCliente.Nome = TxtNome.Text.Trim();
                switch (opc)
                {
                    case 'G':
                        Negocio.Cliente.Gravar.Cadastro(objCliente);
                        break;
                    case 'A':
                        Negocio.Cliente.Alterar.Cadastro(objCliente);
                        break;
                    case 'E':
                        Negocio.Cliente.Excluir.Cadastro(objCliente);
                        break;
                    default:
                        MessageBox.Show("Algo deu errado");
                        break;
                }
                ListarCliente();
                TxtNome.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Cadastro('G');
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Cadastro('A');
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Cadastro('E');
        }

        private void DgvListaCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idCliente = int.Parse(DgvListaCliente.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtNome.Text = DgvListaCliente.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }
    }
}
