using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultApps.Windows
{

    public partial class FrmCadastroUsuarios : Usuario
    {
        private UsuarioRepository usuarioRepo = new UsuarioRepository();

        public FrmCadastroUsuarios()
        {
            InitializeComponent();
            CarregarTodosUsuarios();
        }

        private void CarregarTodosUsuarios()
        {
            var listaDeUsuarios = usuarioRepo.ListarTodosUsuarios();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DataCadastro", HeaderText = "Data de Cadastro", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" } });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusAtivo", HeaderText = "Status" });

            dataGridView1.DataSource = listaDeUsuarios;
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "StatusAtivo")
            {
                if (e.Value is bool status)
                {
                    e.CellStyle.ForeColor = status ? Color.Green : Color.Red;
                    e.Value = status ? "Ativo" : "Inativo";
                }
            }
        }


        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var usuario = (Usuario)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.Nome;
            txtCpf.Text = usuario.CPF;
            txtEmail.Text = usuario.Email;
            txtDataCadastro.Text = usuario.DataCadastro.ToString("dd/MM/yyyy HH:mm");
            
            btnSalvar.Text = "Salvar alterações";
            btnDeletar.Enabled = true;
        }
    }
}
