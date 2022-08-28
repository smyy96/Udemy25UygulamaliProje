using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passaParola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text=="akdeniz")
                        {
                            a.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            a.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b.BackColor = Color.Green;
                            a.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            c.BackColor = Color.Green;
                        }
                        else
                        {
                            c.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "karpuz")
                        {
                            d.BackColor = Color.Green;
                        }
                        else
                        {
                            d.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            e1.BackColor = Color.Green;
                        }
                        else
                        {
                            e1.BackColor = Color.Red;
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            f.BackColor = Color.Green;
                        }
                        else
                        {
                            f.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            g.BackColor = Color.Green;
                        }
                        else
                        {
                            g.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            h.BackColor = Color.Green;
                        }
                        else
                        {
                            h.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b.BackColor = Color.Green;
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b.BackColor = Color.Green;
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b.BackColor = Color.Green;
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b.BackColor = Color.Green;
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b.BackColor = Color.Green;
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            b.BackColor = Color.Green;
                        }
                        else
                        {
                            b.BackColor = Color.Red;
                        }
                        break;






                    default:
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Cevapla";
            soruno++;
            this.Text = soruno.ToString();
            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin başkenti?";
                a.BackColor = Color.Yellow;
            }
            if (soruno==2)
            {
                richTextBox1.Text = "Marmara bölgesindeki yeşilliğiyle ünlü ilimiz?";
                b.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                c.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                d.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "yeni kelimesinin zıt anlamı?";
                e1.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahların yazılı emri?";
                f.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                g.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                h.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "gülüyle ünlü ilimiz?";
                ı.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "mersinin diğer ismi?";
                i.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "askeri bir topluluk?";
                j.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "malatyanın meşhur meyvesi?";
                k.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = ".... devri - çicek ismi?";
                l.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Pyılın üçüncü ayı?";
                m.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "üflemel, çalgı?";
                n.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "halk şairi?";
                o.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "çocukların sevmediği sebze?";
                p.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                r.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "ingilizcede yılan?";
                s.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "mega star?";
                t.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "ümit kelimesi eş anlamlısı?";
                u.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "kahvaltısıyla ünlü ilimiz?";
                v.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "şimsek kelimesinin eş anlamlısı?";
                y.BackColor = Color.Yellow;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "ege bölgesinin meshur kahvaltı ögünü?";
                z.BackColor = Color.Yellow;
            }
        }
    }
}
