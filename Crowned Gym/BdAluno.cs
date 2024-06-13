using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowned_Gym
{
    internal class BdAluno
    {
        public static MySqlConnection getConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=aluno";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Conexão com o Banco de Dados \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void addAluno(Aluno aluno)
        {
            string sql = "INSERT INTO tabela_aluno VALUES (NULL, @NomeAluno, @CPFAluno, @EmailAluno, @TelefoneAluno, @IdadeALuno, @SexoAluno, @AlturaAluno, @PesoAluno, @EnderecoAluno, @SenhaAluno, NULL)";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@NomeAluno", MySqlDbType.VarChar).Value = aluno.Nome;
            cmd.Parameters.Add("@CPFAluno", MySqlDbType.VarChar).Value = aluno.CPF;
            cmd.Parameters.Add("@EmailAluno", MySqlDbType.VarChar).Value = aluno.Email;
            cmd.Parameters.Add("@TelefoneAluno", MySqlDbType.VarChar).Value = aluno.Telefone;
            cmd.Parameters.Add("@IdadeAluno", MySqlDbType.Byte).Value = aluno.Idade;
            cmd.Parameters.Add("@SexoAluno", MySqlDbType.Enum).Value = aluno.Sexo;
            cmd.Parameters.Add("@AlturaAluno", MySqlDbType.Decimal).Value = aluno.Altura;
            cmd.Parameters.Add("@PesoAluno", MySqlDbType.Decimal).Value = aluno.Peso;
            cmd.Parameters.Add("@EnderecoAluno", MySqlDbType.Text).Value = aluno.Endereco;
            cmd.Parameters.Add("@SenhaAluno", MySqlDbType.VarChar).Value = aluno.Senha;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno adicionado com sucesso. ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu ao adicionar aluno:  \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            con.Close();
        }

        public static void atualizarAluno(Aluno aluno, string id)
        {
            string sql = "UPDATE tabela_aluno SET Nome = @NomeAluno, CPF = @CPFAluno, Email = @EmailAluno, Telefone = @TelefoneAluno, Idade = @IdadeALuno, Sexo = @SexoAluno, Altura = @AlturaAluno, Peso = @PesoAluno, Endereco = @EnderecoAluno, Senha = @SenhaAluno WHERE ID = @IDAluno";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@NomeAluno", MySqlDbType.VarChar).Value = aluno.Nome;
            cmd.Parameters.Add("@CPFAluno", MySqlDbType.VarChar).Value = aluno.CPF;
            cmd.Parameters.Add("@EmailAluno", MySqlDbType.VarChar).Value = aluno.Email;
            cmd.Parameters.Add("@TelefoneAluno", MySqlDbType.VarChar).Value = aluno.Telefone;
            cmd.Parameters.Add("@IdadeAluno", MySqlDbType.Byte).Value = aluno.Idade;
            cmd.Parameters.Add("@SexoAluno", MySqlDbType.Enum).Value = aluno.Sexo;
            cmd.Parameters.Add("@AlturaAluno", MySqlDbType.Decimal).Value = aluno.Altura;
            cmd.Parameters.Add("@PesoAluno", MySqlDbType.Decimal).Value = aluno.Peso;
            cmd.Parameters.Add("@EnderecoAluno", MySqlDbType.Text).Value = aluno.Endereco;
            cmd.Parameters.Add("@SenhaAluno", MySqlDbType.VarChar).Value = aluno.Senha;
            cmd.Parameters.Add("@IDAluno", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno atualizado com sucesso. ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu ao atualizar aluno:  \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            con.Close();
        }

        public static void deletarAluno(string id) 
        {
            string sql = "DELETE FROM tabela_aluno WHERE ID = @IDAluno";
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@IDAluno", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno deletado com sucesso. ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Um erro ocorreu ao deletar aluno:  \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv) 
        {
            string sql = query;
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            con.Close();
        }

    }
}
