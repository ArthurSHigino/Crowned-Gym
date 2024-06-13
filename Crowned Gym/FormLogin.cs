using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowned_Gym
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário Menu
            Menu menuForm = new Menu();

            // Exibe o formulário Menu
            menuForm.Show();

            // (Opcional) Esconde o formulário de login atual
            this.Hide();

            menuForm.FormClosed += (s, args) => this.Close();

        }


    }
}
