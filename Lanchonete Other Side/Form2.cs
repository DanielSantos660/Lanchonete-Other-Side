using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_Other_Side
{
    
    public partial class Form2 : Form
    {
        List<ItemPedido> itensPedido = new List<ItemPedido>();
        int pedidos = 0;
        string nome = "";

        public Form2(List<ItemPedido> itensPedido, int pedidos, string nome)
        {
            InitializeComponent();
            this.itensPedido = itensPedido;
            this.nome = nome;

            importar_pedido();
        }

        private void importar_pedido()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox4.Clear();

            label10.Text = "";  
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            decimal total = 0;

            foreach (ItemPedido item in itensPedido)
            {
                textBox1.Text += item.Nome.ToString() + Environment.NewLine;
                textBox2.Text += item.PrecoUnitario.ToString("C2") + Environment.NewLine;
                textBox3.Text += item.Quantidade.ToString() + Environment.NewLine;
                textBox4.Text += item.PrecoFinal.ToString("C2") + Environment.NewLine;
                textBox5.Text += item.pedido.ToString() + Environment.NewLine;
                total += (decimal)item.PrecoFinal;
            }

            label10.Text = total.ToString("C2");
            if (total < 100)
            {
                label11.Text = "0%";
                label12.Text = total.ToString("C2");
            }
            if (total >= 100)
            {
                int desconto = 5;
                decimal valorDesconto = total * desconto / 100;
                label11.Text = desconto.ToString() + "%";
                label12.Text = (total - valorDesconto).ToString("C2");
            }
            if (total >= 150)
            {
                int desconto = 10;
                decimal valorDesconto = total * desconto / 100;
                label11.Text = desconto.ToString() + "%";
                label12.Text = (total - valorDesconto).ToString("C2");
            }
            if (total >= 200)
            {
                int desconto = 15;
                decimal valorDesconto = total * desconto / 100;
                label11.Text = desconto.ToString() + "%";
                label12.Text = (total - valorDesconto).ToString("C2");

            }
            if (total >= 300)
            {
                int desconto = 20;
                decimal valorDesconto = total * desconto / 100;
                label11.Text = desconto.ToString() + "%";
                label12.Text = (total - valorDesconto).ToString("C2");
            }

            label13.Text = nome;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
                {
                    frm.Show();
                    break;
                }
            }
            this.Close();
        }
    }
}
