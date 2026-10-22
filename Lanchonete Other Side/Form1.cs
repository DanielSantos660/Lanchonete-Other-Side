using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_Other_Side
{
    public partial class Form1 : Form
    {
        int QP = 0, QB = 0, QS = 0, QA1 = 0, QA2 = 0, QA3 = 0, QA4 = 0, QA5 = 0, QA6 = 0, QA7 = 0, QA8 = 0;
        double p1 = 0.0, p2 = 0.0, p3 = 0.0, p4 = 0.0, p5 = 0.0, p6 = 0.0, VTP = 0.0;

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                MAIS9.Visible = true; MENOS9.Visible = true; QT9.Visible = true;
                QA8 = 1; QT9.Text = QA8.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox2.Image;
            }
            else
            {
                MAIS9.Visible = false; MENOS9.Visible = false; QT9.Visible = false;
                QA8 = 0; QT9.Text = QA8.ToString();

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;}*/
            }
        }

        private void MAISP_Click(object sender, EventArgs e)
        {
            QP++;
            QTP.Text = QP.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true ; QTP.Visible = true ;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton3.Text;
            DescP.Visible = true; DescP.Text = "Hambúrguer artesanal básico, com pão tingido com corante natural vegano, uma fatia de queijo cheddar e gergelim.";
            pictureBox1.Visible = true; 
            pictureBox1.Image = Properties.Resources.basic;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton4.Text;
            DescP.Visible = true; DescP.Text = "Descrição";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton5.Text;
            DescP.Visible = true; DescP.Text = "Descrição";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton6.Text;
            DescP.Visible = true; DescP.Text = "Descrição";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton7.Text;
            DescP.Visible = true; DescP.Text = "Descrição";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton7.Text;
            DescP.Visible = true; DescP.Text = "Descrição";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton9.Text;
            DescP.Visible = true; DescP.Text = "Descrição";
        }

        private void MENOSP_Click(object sender, EventArgs e)
        {
            if (QP >= 0)
            {
                QP--;
                QTP.Text = QP.ToString();
            }
            else
            {
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                radioButton8.Checked = false;
                radioButton9.Checked = false;

                MAISP.Visible = false; MENOSP.Visible = false; QTP.Visible = false;
                QP = 0; QTP.Text = "";
                TitleP.Visible = false; TitleP.Text = "";
                DescP.Visible = false; DescP.Text = "";
            }
            
        }

        private void MAIS2_Click(object sender, EventArgs e)
        {
            QA1++;
            QT2.Text = QA1.ToString();
        }

        private void MENOS2_Click(object sender, EventArgs e)
        {
            if (QA1 > 1)
            {
                QA1--;
                QT2.Text = QA1.ToString();
            }
        }

        private void MAIS3_Click(object sender, EventArgs e)
        {
            QA2++;
            QT3.Text = QA2.ToString();
        }

        private void MENOS3_Click(object sender, EventArgs e)
        {
            if (QA2 > 1)
            {
                QA2--;
                QT3.Text = QA2.ToString();
            }
        }

        private void MAIS4_Click(object sender, EventArgs e)
        {
            QA3++;
            QT4.Text = QA3.ToString();
        }

        private void MENOS4_Click(object sender, EventArgs e)
        {
            if (QA3 > 1)
            {
                QA3--;
                QT4.Text = QA3.ToString();
            }
        }

        private void MAIS5_Click(object sender, EventArgs e)
        {
            QA4++;
            QT5.Text = QA4.ToString();
        }

        private void MENOS5_Click(object sender, EventArgs e)
        {
            if (QA4 > 1)
            {
                QA4--;
                QT5.Text = QA4.ToString();
            }
        }

        private void MAIS6_Click(object sender, EventArgs e)
        {
            QA5++;
            QT6.Text = QA5.ToString();
        }

        private void MENOS6_Click(object sender, EventArgs e)
        {
            if (QA5 > 1)
            {
                QA5--;
                QT6.Text = QA5.ToString();
            }
        }

        private void MAIS7_Click(object sender, EventArgs e)
        {
            QA6++;
            QT7.Text = QA6.ToString();
        }

        private void MENOS7_Click(object sender, EventArgs e)
        {
            if (QA6 > 1)
            {
                QA6--;
                QT7.Text = QA6.ToString();
            }
        }

        private void MAIS8_Click(object sender, EventArgs e)
        {
            QA7++;
            QT8.Text = QA7.ToString();
        }

        private void MENOS8_Click(object sender, EventArgs e)
        {
            if (QA7 > 1)
            {
                QA7--;
                QT8.Text = QA7.ToString();
            }
        }

        private void MAIS9_Click(object sender, EventArgs e)
        {
            QA8++;
            QT9.Text = QA8.ToString();
        }

        private void MENOS9_Click(object sender, EventArgs e)
        {
            if (QA8 > 1)
            {
                QA8--;
                QT9.Text = QA8.ToString();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                MAIS8.Visible = true; MENOS8.Visible = true; QT8.Visible = true;
                QA7 = 1; QT8.Text = QA7.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox3.Image;
            }
            else
            {
                MAIS8.Visible = false; MENOS8.Visible = false; QT8.Visible = false;
                QA7 = 0; QT8.Text = QA7.ToString();

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;}*/
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                MAIS7.Visible = true; MENOS7.Visible = true; QT7.Visible = true;
                QA6 = 1; QT7.Text = QA6.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox8.Image;
            }
            else
            {
                MAIS7.Visible = false; MENOS7.Visible = false; QT7.Visible = false;
                QA6 = 0; QT7.Text = QA6.ToString();

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;}*/
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                MAIS6.Visible = true; MENOS6.Visible = true; QT6.Visible = true;
                QA5 = 1; QT6.Text = QA5.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox9.Image;
            }
            else
            {
                MAIS6.Visible = false; MENOS6.Visible = false; QT6.Visible = false;
                QA5 = 0; QT6.Text = QA5.ToString();

                /* TitleAc.Visible = false; TitleAc.Text = "";
                 DescAc.Visible = false; DescAc.Text = "";
                 pictureBox10.Visible = false; pictureBox10.Image = null;*/
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                MAIS5.Visible = true; MENOS5.Visible = true; QT5.Visible = true;
                QA4 = 1; QT5.Text = QA4.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox7.Image;
            }
            else
            {
                MAIS5.Visible = false; MENOS5.Visible = false; QT5.Visible = false;
                QA4 = 0; QT5.Text = QA4.ToString();

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;*/
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                MAIS4.Visible = true; MENOS4.Visible = true; QT4.Visible = true;
                QA3 = 1; QT4.Text = QA3.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox6.Image;
            }
            else
            {
                MAIS4.Visible = false; MENOS4.Visible = false; QT4.Visible = false;
                QA3 = 0; QT4.Text = QA3.ToString();

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;}*/
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                MAIS3.Visible = true; MENOS3.Visible = true; QT3.Visible = true;
                QA2 = 1; QT3.Text = QA2.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox5.Image;
            }
            else
            {
                MAIS3.Visible = false; MENOS3.Visible = false; QT3.Visible = false;
                QA2 = 0; QT3.Text = QA2.ToString();

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;}*/
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is Button && (controle.Name.Contains("MAIS") || controle.Name.Contains("MENOS")))
                {
                    controle.Visible = false;
                }

                if (controle is Label && (controle.Name.Contains("QT") || controle.Name.Contains("Title")))
                {
                    controle.Visible = false;
                }

                if (controle is PictureBox)
                {
                    controle.Visible = false;
                }
            }
            timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                MAIS2.Visible = true; MENOS2.Visible = true; QT2.Visible = true;
                QA1 = 1; QT2.Text = QA1.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Acompanhamento";
                DescAc.Visible = true; DescAc.Text = "blablablablablabla";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox4.Image;
            }
            else
            {
                MAIS2.Visible = false; MENOS2.Visible = false; QT2.Visible = false;
                QA1 = 0; QT2.Text = QA1.ToString();

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;*/
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            Limpar();
            radioButton3.Text = "X - Búrguer básico";
            p1 = 20;
            Pr1.Text = "| R$"+p1.ToString();


        }

        private void Limpar() 
        {
            QP = 0; QB = 0; QS = 0; QA1 = 0; QA2 = 0; QA3 = 0; QA4 = 0; QA5 = 0; QA6 = 0; QA7 = 0; QA8 = 0;

            groupBox2.Visible = true;

            label5.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label12.Visible = true;

            comboBox2.Visible = true;
            comboBox3.Visible = true;

            pictureBox1.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;

            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox9.Visible = true;
            pictureBox8.Visible = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;

            foreach (Control controle in this.Controls)
            {
                if (controle is Button && (controle.Name.Contains("MAIS") || controle.Name.Contains("MENOS")))
                {
                    controle.Visible = false;
                }

                if (controle is Label && controle.Name.Contains("QT"))
                {
                    controle.Visible = false;
                }

                if (controle is CheckBox)
                {
                    controle.Visible = true;
                }

            }
        }
    }
}
