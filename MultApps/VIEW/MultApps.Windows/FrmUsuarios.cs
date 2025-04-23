﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultApps.Models.Entities;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;

namespace MultApps.Windows
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();

            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cbmFiltro.Items.AddRange(filtros);


            cmbStatus.SelectedIndex = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //1 Passo pegar os dados da tela.
            //try para capturar erros de conversão de valores.
            try
            {

                if (TemCamposEmBranco())
                {
                    return;
                }
                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = mtbCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                //2 Passo criar o objeto de repositório.
                var usuarioRepository = new UsuarioRepository();

                var emailJaExiste = usuarioRepository.EmailExistente(usuario.Email);
                if (emailJaExiste)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado. ");
                    txtEmail.Focus();
                    return;
                }

                //3 Passo chamar o método de cadastro.
                var sucesso = usuarioRepository.CadastrarUsuario(usuario);

                if (sucesso)
                {
                    MessageBox.Show($"Usuário {usuario.Nome} cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar o usuário {usuario.Nome}");
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }


        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo Nome é obrigatório");
                txtNome.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(mtbCpf.Text))
            {
                MessageBox.Show("Campo Cpf é obrigatório");
                mtbCpf.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo Email é obrigatório");
                txtEmail.Focus();
                return true;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo Senha é obrigatório");
                txtSenha.Focus();
                return true;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Status é obrigatório");
                cmbStatus.Focus();
                return true;
            }
            return false;
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarTodosUsuario();
        }

        private void CarregarTodosUsuario()
        {
            var usuarioRepository = new UsuarioRepository();

            var listarUsuario = usuarioRepository.ListarUsuarios();
            dataGridView1.DataSource = listarUsuario;
        }

        private void limparCampos()
        {
            mtbCpf.Clear();
            txtEmail.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            txtDataCadastro.Clear();
            txtUltimoAcesso.Clear();
            cmbStatus.SelectedIndex = 1;
              

            
        }
    }
}
