using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using MultApps.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Usuário é obrigatorio");
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatorio");
                txtSenha.Focus();
                return;
            }

            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.ObterUsuarioPorEmail(txtUsuario.Text);

            if (usuario != null|| usuario.Email != txtUsuario.Text) 
            {
                MessageBox.Show("Usuário não encontrado");
                txtUsuario.Focus();
                return;

            }

            if (usuario.Status == StatusEnum.Inativo)
            {
                MessageBox.Show("Usuário está Inativo");
                txtUsuario.Focus();
                return;
            }

            var senhaConfere = CriptografiaService.Verificar(txtSenha.Text , usuario.Senha);

            if (senhaConfere)
            {
                MessageBox.Show("Usuário e senha correto");
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválida");
            }
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("UInforme o email do seu usuário");
                txtUsuario.Focus();
                return;

            }

            var usuarioRepositoty = new UsuarioRepository();

            var novaSenha = CriptografiaService.Criptografar("13456");

            var senhaAtualizou = usuarioRepositoty.AtualizarSenha(novaSenha, txtUsuario.Text);

            if (senhaAtualizou)
            { 
                MessageBox.Show ($"Senha atualizada com sucesso. A nova senha é: 123456");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a senha");
            }
        }
    }
}
