using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // carregando o combobox de níveis
            var niveis = Nivel.ObterLista();
            cmbNivel.DataSource = niveis;
            cmbNivel.DisplayMember = "Nome";
            cmbNivel.ValueMember = "Id";
            CarregaGrid();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(cmbNivel.SelectedValue.ToString());
            Usuario usuario = new(
                    txtNome.Text,
                    txtEmail.Text,
                    txtSenha.Text,
                    Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                txtId.Text = usuario.Id.ToString();
                MessageBox.Show($"O usuário {usuario.Nome}, " +
                    $"foi inserido com sucesso, com o ID {usuario.Id} ");
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtConfSenha.Clear();
                txtSenha.Clear();
                txtNome.Focus();
                FrmUsuario_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao gravar o usuário!");
            }



        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }
        private void CarregaGrid(string nome = "")
        {

            // preenchendo o datagrid com os usuários
            var lista = Usuario.ObterLista(nome);
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;
                cont++;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                var msg = MessageBox.Show("Deseja continuar o cadastro ?",
                    "Cadastro de usuário",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (msg == DialogResult.No) this.Close();
            }
            else
            {
                Close();
            }

        }
        private bool VerificaControles()
        {
            if (txtNome.Text != string.Empty
                || txtEmail.Text != string.Empty
                || txtSenha.Text != string.Empty
                || txtConfSenha.Text != string.Empty)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int posicaoLinha = dgvUsuarios.CurrentRow.Index;
            id = Convert.ToInt32(dgvUsuarios.Rows[posicaoLinha].Cells[0].Value);
            MessageBox.Show(id.ToString());
        }
    }
}
