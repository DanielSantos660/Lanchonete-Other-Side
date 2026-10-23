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
        //quantidade
        int QP = 0, QB = 0, QS = 0, QA1 = 0, QA2 = 0, QA3 = 0, QA4 = 0, QA5 = 0, QA6 = 0, QA7 = 0, QA8 = 0;
        //preço
        double p1 = 0.00, p2 = 0.00, p3 = 0.00, p4 = 0.00, p5 = 0.00, p6 = 0.00, p7 = 0.00;
        double pac1 = 15.00, pac2 = 20.00, pac3 = 15.00, pac4 = 25.00, pac5 = 5.00, pac6 = 5.00, pac7 = 5.00, pac8 = 5.00;
        double ps = 0.00, pb = 0.00;
        //public
        public string nome = "";

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                MAIS9.Visible = true; MENOS9.Visible = true; QT9.Visible = true;
                QA8 = 1; QT9.Text = QA8.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Barbecue";
                DescAc.Visible = true; DescAc.Text = "Molho barbecue fresco.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox2.Image;
                pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS9.Visible = false; MENOS9.Visible = false; QT9.Visible = false;
                QA8 = 0; QT9.Text = QA8.ToString();
                pictureBox2.BorderStyle = BorderStyle.None;

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;}*/
            }
        }

        private void MAISP_Click(object sender, EventArgs e)
        {
            if (QP <= 9)
            {
                QP++;
                QTP.Text = QP.ToString();
            }
            
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
            DescP.Visible = true; DescP.Text = "Duplo hambúrguer, com pão tingido com corante natural vegano, duas fatias de queijo, alface, tomate, maionese e gergelim.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.Conected;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton5.Text;
            DescP.Visible = true; DescP.Text = "Hambúrguer artesanal, com pão tingido com corante natural vegano, uma fatia de queijo, bacon, gergelim e molho especial.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.Transmission;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton6.Text;
            DescP.Visible = true; DescP.Text = "Hambúrguer artesanal vegano, à base de proteína de soja e temperos, com pão tingido com corante natural vegano molho especial vegano e gergelim.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.alien;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton7.Text;
            DescP.Visible = true; DescP.Text = "Hambúrguer de frango frito e pão tingidos com corante natural vegano, uma fatia de queijo, alface, gergelim e molho especial.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.chicken;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = radioButton8.Text;
            DescP.Visible = true; DescP.Text = "Hot Dog artesanal, com pão tingido com corante natural vegano, uma salsicha, ketchup, batata palha e molho especial.";
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.dogao;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            MAISP.Visible = true; MENOSP.Visible = true; QTP.Visible = true;
            QP = 1; QTP.Text = QP.ToString();
            TitleP.Visible = true; TitleP.Text = "Fatia de Pizza";
            DescP.Visible = true; DescP.Text = "Fatia da saborosa pizza três queijos (Mussarela, Parmesão e Provolone)";
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.pizza;
        }

        private void MENOSP_Click(object sender, EventArgs e)
        {
            if (QP > 1)
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
                pictureBox1.Visible = false;
                pictureBox1.Image = null;
            }
            
        }

        private void MAIS2_Click(object sender, EventArgs e)
        {
            if (QA1 < 10)
            {
                QA1++;
                QT2.Text = QA1.ToString();
            }
        }

        private void MENOS2_Click(object sender, EventArgs e)
        {
            if (QA1 > 1)
            {
                QA1--;
                QT2.Text = QA1.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text;
        }

        private void MAIS3_Click(object sender, EventArgs e)
        {
            if (QA2 < 10)
            {
                QA2++;
                QT3.Text = QA2.ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    pb = 0.00;
                    pictureBox11.Visible = false; pictureBox11.Image = null;
                    label6.Visible = false; label6.Text = "";
                    TitleB.Visible = false; TitleB.Text = "";
                    DescB.Visible = false; DescB.Text = "";
                    MAISB.Visible = false; MENOSB.Visible = false; QTB.Visible = false; QB = 0; QTB.Text = "";

                    break;
                case 1:
                    pb = 7.50;
                    pictureBox11.Visible = true; pictureBox11.Image = Properties.Resources.coca;
                    label6.Visible = true; label6.Text = "R$ 7,50";
                    TitleB.Visible = true; TitleB.Text = "Coca-Cola";
                    DescB.Visible = true; DescB.Text = "Refrigerante de cola, com gás e açúcar.";
                    MAISB.Visible = true; MENOSB.Visible = true; QTB.Visible = true; QB = 1; QTB.Text = QB.ToString();
                    break;
                case 2:
                    pb = 7.50;
                    pictureBox11.Visible = true; pictureBox11.Image = Properties.Resources.sprite;
                    label6.Visible = true; label6.Text = "R$ 7,50";
                    TitleB.Visible = true; TitleB.Text = "Sprite";
                    DescB.Visible = true; DescB.Text = "Refrigerante de limão, com gás e açúcar.";
                    MAISB.Visible = true; MENOSB.Visible = true; QTB.Visible = true; QB = 1; QTB.Text = QB.ToString();
                    break;
                case 3:
                    pb = 7.50;
                    pictureBox11.Visible = true; pictureBox11.Image = Properties.Resources.guarana;
                    label6.Visible = true; label6.Text = "R$ 7,50";
                    TitleB.Visible = true; TitleB.Text = "Guaraná Antártica";
                    DescB.Visible = true; DescB.Text = "Refrigerante de guaraná, com gás e açúcar.";
                    MAISB.Visible = true; MENOSB.Visible = true; QTB.Visible = true; QB = 1; QTB.Text = QB.ToString();
                    break;
                case 4:
                    pb = 7.50;
                    pictureBox11.Visible = true; pictureBox11.Image = Properties.Resources.laranja;
                    label6.Visible = true; label6.Text = "R$ 7,50";
                    TitleB.Visible = true; TitleB.Text = "Fanta Laranja";
                    DescB.Visible = true; DescB.Text = "Refrigerante de laranja, com gás e açúcar.";
                    MAISB.Visible = true; MENOSB.Visible = true; QTB.Visible = true; QB = 1; QTB.Text = QB.ToString();
                    break;
                case 5:
                    pb = 7.50;
                    pictureBox11.Visible = true; pictureBox11.Image = Properties.Resources.uva ;
                    label6.Visible = true; label6.Text = "R$ 7,50";
                    TitleB.Visible = true; TitleB.Text = "Fanta Limão";
                    DescB.Visible = true; DescB.Text = "Refrigerante de uva, com gás e açúcar.";
                    MAISB.Visible = true; MENOSB.Visible = true; QTB.Visible = true; QB = 1; QTB.Text = QB.ToString();
                    break;
                case 6:
                    pb = 10.00;
                    pictureBox11.Visible = true; pictureBox11.Image = Properties.Resources.limao;
                    label6.Visible = true; label6.Text = "R$ 10,00";
                    TitleB.Visible = true; TitleB.Text = "Suco de Limão";
                    DescB.Visible = true; DescB.Text = "Suco natural de limão, sem gás e com pouco açúcar.";
                    MAISB.Visible = true; MENOSB.Visible = true; QTB.Visible = true; QB = 1; QTB.Text = QB.ToString();
                    break;
                case 7:
                    pb = 10.00;
                    pictureBox11.Visible = true; pictureBox11.Image = Properties.Resources.maracuja;
                    label6.Visible = true; label6.Text = "R$ 10,00";
                    TitleB.Visible = true; TitleB.Text = "Suco de Maracujá";
                    DescB.Visible = true; DescB.Text = "Suco natural de maracujá, sem gás e com pouco açúcar.";
                    MAISB.Visible = true; MENOSB.Visible = true; QTB.Visible = true; QB = 1; QTB.Text = QB.ToString();
                    break;
                
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    ps = 0.00;
                    pictureBox12.Visible = false; pictureBox12.Image = null;
                    label9.Visible = false; label9.Text = "";
                    TitleS.Visible = false; TitleS.Text = "";
                    DescS.Visible = false; DescS.Text = "";
                    MAISS.Visible = false; MENOSS.Visible = false; QTS.Visible = false; QS = 0; QTS.Text = "";

                    break;
                case 1:
                    ps = 10.00;
                    pictureBox12.Visible = true; pictureBox12.Image = Properties.Resources.creme;
                    label9.Visible = true; label9.Text = "R$ 10,00";
                    TitleS.Visible = true; TitleS.Text = "Sorvete de creme";
                    DescS.Visible = true; DescS.Text = "Sorvete de creme ao leite.";
                    MAISS.Visible = true; MENOSS.Visible = true; QTS.Visible = true; QS = 1; QTS.Text = QS.ToString();
                    break;
                case 2:
                    pb = 10.00;
                    pictureBox12.Visible = true; pictureBox12.Image = Properties.Resources.chocolate;
                    label9.Visible = true; label9.Text = "R$ 10,00";
                    TitleS.Visible = true; TitleS.Text = "Sorvete de chocolate";
                    DescS.Visible = true; DescS.Text = "Sorvete de chocolate ao leite.";
                    MAISS.Visible = true; MENOSS.Visible = true; QTS.Visible = true; QS = 1; QTS.Text = QS.ToString();
                    break;
                case 3:
                    pb = 10.00;
                    pictureBox12.Visible = true; pictureBox12.Image = Properties.Resources.morango;
                    label9.Visible = true; label9.Text = "R$ 10,00";
                    TitleS.Visible = true; TitleS.Text = "Sorvete de morango";
                    DescS.Visible = true; DescS.Text = "Sorvete de morango ao leite.";
                    MAISS.Visible = true; MENOSS.Visible = true; QTS.Visible = true; QS = 1; QTS.Text = QS.ToString();
                    break;
                case 4:
                    pb = 20.00;
                    pictureBox12.Visible = true; pictureBox12.Image = Properties.Resources.pizzadoce;
                    label9.Visible = true; label9.Text = "R$ 20,00";
                    TitleS.Visible = true; TitleS.Text = "Pizza doce";
                    DescS.Visible = true; DescS.Text = "Pizza de chocolate com morangos.";
                    MAISS.Visible = true; MENOSS.Visible = true; QTS.Visible = true; QS = 1; QTS.Text = QS.ToString();
                    break;
                case 5:
                    pb = 30.00;
                    pictureBox12.Visible = true; pictureBox12.Image = Properties.Resources.petit;
                    label9.Visible = true; label9.Text = "R$ 30,00";
                    TitleS.Visible = true; TitleS.Text = "Petit Gateau";
                    DescS.Visible = true; DescS.Text = "Petit Gateau com sorvete de creme.";
                    MAISS.Visible = true; MENOSS.Visible = true; QTS.Visible = true; QS = 1; QTS.Text = QS.ToString();
                    break;
                case 6:
                    pb = 15.00;
                    pictureBox12.Visible = true; pictureBox12.Image = Properties.Resources.cocada;
                    label9.Visible = true; label9.Text = "R$ 15,00";
                    TitleS.Visible = true; TitleS.Text = "Cocada cremosa";
                    DescS.Visible = true; DescS.Text = "Cocada cremosa caramelizada.";
                    MAISS.Visible = true; MENOSS.Visible = true; QTS.Visible = true; QS = 1; QTS.Text = QS.ToString();
                    break;
                case 7:
                    pb = 15.00;
                    pictureBox12.Visible = true; pictureBox12.Image = Properties.Resources.pudim;
                    label9.Visible = true; label9.Text = "R$ 10,00";
                    TitleS.Visible = true; TitleS.Text = "Pudim";
                    DescS.Visible = true; DescS.Text = "Pudim de leite condensado.";
                    MAISS.Visible = true; MENOSS.Visible = true; QTS.Visible = true; QS = 1; QTS.Text = QS.ToString();
                    break;

            }
        }

        private void MAISB_Click(object sender, EventArgs e)
        {
            if (QB < 10)
            {
                QB++;
                QTB.Text = QB.ToString();
            }
        }

        private void MENOSB_Click(object sender, EventArgs e)
        {
            if (QB > 1)
            {
                QB--;
                QTB.Text = QB.ToString();
            }
        }

        private void MAISS_Click(object sender, EventArgs e)
        {
            if (QS < 10)
            {
                QS++;
                QTS.Text = QS.ToString();
            }
        }

        private void MENOSS_Click(object sender, EventArgs e)
        {
            if (QS > 1)
            {
                QS--;
                QTS.Text = QS.ToString();
            }
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
            if (QA3 < 10)
            {
                QA3++;
                QT4.Text = QA3.ToString();
            }
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
            if (QA4 < 10)
            {
                QA4++;
                QT5.Text = QA4.ToString();
            }
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
            if (QA5 < 10)
            {
                QA5++;
                QT6.Text = QA5.ToString();
            }
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
            if (QA6 < 10)
            {
                QA6++;
                QT7.Text = QA6.ToString();
            }
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
            if (QA7 < 10)
            {
                QA7++;
                QT8.Text = QA7.ToString();
            }
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
            if (QA8 < 10)
            {
                QA8++;
                QT9.Text = QA8.ToString();
            }
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

                TitleAc.Visible = true; TitleAc.Text = "Molho Especial";
                DescAc.Visible = true; DescAc.Text = "Molho especial fresco, à base de ingredientes devidamente selecionados.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox3.Image;
                pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS8.Visible = false; MENOS8.Visible = false; QT8.Visible = false;
                QA7 = 0; QT8.Text = QA7.ToString();
                pictureBox3.BorderStyle = BorderStyle.None;

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

                TitleAc.Visible = true; TitleAc.Text = "Maionese";
                DescAc.Visible = true; DescAc.Text = "Molho maionese fresco.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox8.Image;
                pictureBox8.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS7.Visible = false; MENOS7.Visible = false; QT7.Visible = false;
                QA6 = 0; QT7.Text = QA6.ToString();
                pictureBox8.BorderStyle = BorderStyle.None;

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

                TitleAc.Visible = true; TitleAc.Text = "Ketchup";
                DescAc.Visible = true; DescAc.Text = "Molho ketchup fresco.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox9.Image;
                pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS6.Visible = false; MENOS6.Visible = false; QT6.Visible = false;
                QA5 = 0; QT6.Text = QA5.ToString();
                pictureBox9.BorderStyle = BorderStyle.None;

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

                TitleAc.Visible = true; TitleAc.Text = "Nachos";
                DescAc.Visible = true; DescAc.Text = "Porção de nachos com guacamole.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox7.Image;
                pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS5.Visible = false; MENOS5.Visible = false; QT5.Visible = false;
                QA4 = 0; QT5.Text = QA4.ToString();
                pictureBox7.BorderStyle = BorderStyle.None;

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

                TitleAc.Visible = true; TitleAc.Text = "Frango Frito";
                DescAc.Visible = true; DescAc.Text = "Porção de frango frito crocante.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox6.Image;
                pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS4.Visible = false; MENOS4.Visible = false; QT4.Visible = false;
                QA3 = 0; QT4.Text = QA3.ToString();
                pictureBox6.BorderStyle = BorderStyle.None;

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

                TitleAc.Visible = true; TitleAc.Text = "Cheddar Fries";
                DescAc.Visible = true; DescAc.Text = "Porção grande de batata frita com cheddar e bacon.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox5.Image;
                pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS3.Visible = false; MENOS3.Visible = false; QT3.Visible = false;
                QA2 = 0; QT3.Text = QA2.ToString();
                pictureBox5.BorderStyle = BorderStyle.None;

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;}*/
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control controle in panel1.Controls)
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
            groupBox2.Visible = false;
            timer1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                MAIS2.Visible = true; MENOS2.Visible = true; QT2.Visible = true;
                QA1 = 1; QT2.Text = QA1.ToString();

                TitleAc.Visible = true; TitleAc.Text = "Batata Frita";
                DescAc.Visible = true; DescAc.Text = "Porção média de batata frita.";
                pictureBox10.Visible = true; pictureBox10.Image = pictureBox4.Image;
                pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MAIS2.Visible = false; MENOS2.Visible = false; QT2.Visible = false;
                QA1 = 0; QT2.Text = QA1.ToString();
                pictureBox4.BorderStyle = BorderStyle.None;

                /*TitleAc.Visible = false; TitleAc.Text = "";
                DescAc.Visible = false; DescAc.Text = "";
                pictureBox10.Visible = false; pictureBox10.Image = null;*/
            }

        }

        public Form1()
        {
            InitializeComponent();

            panel1.AutoScrollMinSize = Size.Empty;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
            Limpar();
            radioButton3.Text = "X - Búrguer básico";
            p1 = 20.00;
            Pr1.Text = "| R$" + p1.ToString();

            radioButton4.Text = "Conected";
            p2 = 30.00;
            Pr2.Text = "| R$" + p2.ToString();

            radioButton5.Text = "Bacon Transmission";
            p3 = 25.00;
            Pr3.Text = "| R$" + p3.ToString();

            radioButton6.Text = "Alien (Vegano)";
            p4 = 25.00;
            Pr4.Text = "| R$" + p4.ToString();

            radioButton7.Text = "Chicken Green";
            p5 = 25.00;
            Pr5.Text = "| R$" + p5.ToString();

            radioButton8.Text = "Hot Dog Espacial";
            p6 = 30.00;
            Pr6.Text = "| R$" + p6.ToString();

            radioButton9.Text = "Fatia de pizza (3 queijos)";
            p7 = 25.00;
            Pr7.Text = "| R$" + p7.ToString();


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

            foreach (Control controle in panel1.Controls)
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
                if (controle is Label && (controle.Name.StartsWith("lA")))
                {
                    controle.Visible = true;
                }

            }
        }
    }
}
