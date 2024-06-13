using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Crowned_Gym
{
    public partial class FormAluno : Form
    {
        private readonly Menu _parent;
        public FormAluno(Menu parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @"^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ ]+$", "Nome inválido. Use apenas letras e espaços.");
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", "CPF inválido. Use o formato 000.000.000-00.");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", "Email inválido.");
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @"^\(\d{2}\) \d{4,5}-\d{4}$", "Telefone inválido. Use o formato (99) 99999-9999 ou (99) 9999-9999.");
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @"^\d+$", "Idade inválida. Use apenas números.");
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @"^\d{1}(\,\d{1,2})?$", "Altura inválida. Use o formato 1,80.");
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @"^\d{1,3}(\,\d{1,2})?$", "Peso inválido. Use o formato 70,5.");
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox((System.Windows.Forms.TextBox)sender, @".+", "Endereço inválido.");
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length < 3) {
                MessageBox.Show("Preencha todos os campos corretamente");
                return;
            }
            else
            {
                Aluno aluno = new Aluno(txtNome.Text.Trim(), txtCPF.Text.Trim(), txtEmail.Text.Trim(), txtTelefone.Text.Trim(), int.Parse(txtIdade.Text.Trim()), txtSexo.Text.Trim(), float.Parse(txtAltura.Text.Trim()), float.Parse(txtPeso.Text.Trim()), txtEndereco.Text.Trim(), txtSenha.Text.Trim());
                BdAluno.addAluno(aluno);
                clear();
            }
        }

        private void ValidateTextBox(System.Windows.Forms.TextBox textBox, string pattern, string errorMessage)
        {
            if (!Regex.IsMatch(textBox.Text, pattern))
            {
                textBox.BackColor = System.Drawing.Color.LightCoral;
                toolTip1.SetToolTip(textBox, errorMessage);
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.White;
                toolTip1.SetToolTip(textBox, null);
            }
        }

        public void clear() 
        {
            txtNome.Text = txtCPF.Text = txtEmail.Text = txtTelefone.Text = txtIdade.Text = txtSexo.Text = txtAltura.Text = txtPeso.Text = txtEndereco.Text = txtSenha.Text = string.Empty;
            txtSexo.SelectedIndex = -1;
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            clear();
        }

        
    }
}
