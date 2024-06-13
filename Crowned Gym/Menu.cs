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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância do formulário de login
            FormLogin FormLogin = new FormLogin();

            // Exibe o formulário de login
            FormLogin.Show();

            // Esconde o formulário Menu atual
            this.Hide();
            FormLogin.FormClosed += (s, args) => this.Close();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
