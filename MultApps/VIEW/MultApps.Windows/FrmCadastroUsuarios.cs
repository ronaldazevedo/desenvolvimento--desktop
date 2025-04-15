using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultApps.Windows
{
    public partial class FrmCadastroUsuarios : Form
    {
        public FrmCadastroUsuarios()
        {
            InitializeComponent();

        }
        private void CarregarTodasCategorias()
        {
            var categoriaRepository = new CategoriaRepository();
            var listaDeCategorias = categoriaRepository.ListarTodasCategorias();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                MinimumWidth = 100,

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome de usuário",
                MinimumWidth = 300,

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cpf",
                HeaderText = "CPF",
                MinimumWidth = 300,

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                MinimumWidth = 300,

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Senha",
                HeaderText = "Senha",
                MinimumWidth = 300,

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCriação",
                HeaderText = "Data de Criação",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Ultimo Acesso",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
                MinimumWidth = 200

            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                DefaultCellStyle = new DataGridViewCellStyle
                {

                }
            });

            dataGridView1.DataSource = listaDeCategorias;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                if (e.Value != null)
                {
                    StatusFiltro Status = (StatusFiltro)e.Value;
                    switch (Status)
                    {
                        case StatusFiltro.Inativo:
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        case StatusFiltro.Ativo:
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case StatusFiltro.Todos:
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var cadastroId = (int)row.Cells[0].Value;

            var categoriaRepository = new CategoriaRepository();
            var categoria = categoriaRepository.ObterCategoriaPorId(cadastroId);

            if (categoria == null)
            {
                MessageBox.Show($"Categoria: #{cadastroId} não encontrada");
                return;
            }
           
            txtId.Text = categoria.Id.ToString();
            txtNome.Text = categoria.Nome;
            txtCpf.Text = categoria.CPF;
            txtEmail.Text = categoria.mail;
            cmbStatus.SelectedIndex = (int)categoria.Status;
            txtDataCadastro.Text = categoria.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = categoria.DataAlteracao.ToString("dd/MM/yyyy HH:mm");

            btnDeletar.Enabled = true;
            btnSalvar.Text = "Salvar alterações";
        }
    }
}
