using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace exemplocrud
{
    class cinema : conexao
    {
        private string cnpj;
        private string nome;
        private string rua;
        private string bairro;
        private string estado;
        private string cidade;
        private int numero;
        private string cep;
        private string telefone;
        private string email;

        public void setCnpj(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public string getCnpj()
        {
            return this.cnpj;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public string getRua()
        {
            return this.rua;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public string getBairro()
        {
            return this.bairro;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public string getEstado()
        {
            return this.estado;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getCidade()
        {
            return this.cidade;
        }

        public void setCep(string cep)
        {
            this.cep = cep;
        }

        public string getCep()
        {
            return this.cep;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return this.email;
        }


        public void inserir()
        {
            string query = "insert into cinema(cnpj, numero, nome, rua, bairro, cidade, cep, telefone, email, estado)values('" + getCnpj() + "','" + getNumero() + "','" + getNome() + "','" + getRua() + "','" + getBairro() + "','" + getCidade() + "','" + getCep() + "','" + getTelefone() + "','" + getEmail() + "','" + getEstado() + "')";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
        public DataTable consultar()
        {
            this.abrirconexao();
            string MSQL = " Select * from cinema";
            MySqlCommand cmd = new MySqlCommand(MSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }   
}
