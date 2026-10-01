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
    public partial class Form1 : Form
    {
        int QP = 0, QB = 0, QS = 0, QA1 = 0, QA2 = 0, QA3 = 0, QA4 = 0, QA5 = 0, QA6 = 0, QA7 = 0, QA8 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            QP = 0; QB = 0; QS = 0; QA1 = 0; QA2 = 0; QA3 = 0; QA4 = 0; QA5 = 0; QA6 = 0; QA7 = 0; QA8 = 0;

            groupBox2.Visible = true;

            label5.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label12.Visible = true;

            pictureBox1.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;

            foreach(Control controle in this.Controls)
            {
                if (controle is Button && (controle.Name.Contains("MAIS") || controle.Name.Contains("MENOS"))) 
                {
                    controle.Visible = false;
                }

                if (controle is Label && controle.Name.Contains("QT"))
                {
                    controle.Visible = false;
                }
            }
            
           

        }
    }
}
