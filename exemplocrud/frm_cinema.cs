using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplocrud
{
    public partial class frm_cinema : Form
    {
        public frm_cinema()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        cinema c = new cinema();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            // try - finally
            // 
            try
            {
                c.setCnpj(txt_cnpj.Text);
                c.setNumero(int.Parse(txt_numero.Text));
                c.setNome(txt_nome.Text);
                c.setRua(txt_rua.Text);
                c.setBairro(txt_bairro.Text);
                c.setCidade(txt_cidade.Text);
                c.setCep(txt_cep.Text);
                c.setTelefone(txt_telefone.Text);
                c.setEmail(txt_email.Text);
                c.setEstado(txt_estado.Text);
                c.inserir();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }


        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.consultar();
        }
    }
}
