using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    public partial class MyForm : Form
    {
        Label message = new Label();
        Button[] btn = new Button[4];
        string[] texts = new string[4];
        TableLayoutPanel tlp = new TableLayoutPanel();

        Button btn_tabel;
        int btn_w, btn_h;
        public MyForm()
        {

        }

        public MyForm(string title, string body, string button1, string button2, string button3, string button4)
        {
            texts[0] = button1;
            texts[1] = button2;
            texts[2] = button3;
            texts[3] = button4;

            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Text = title;
            int x = 10;

            for (int i = 0; i < 4; i++)
            {
                btn[i] = new Button
                {
                    Location = new System.Drawing.Point(x, 50),
                    Size = new System.Drawing.Size(80, 25),
                    Text = texts[i]
                };
                btn[i].Click += MyForm_Click;
                x += 100;
                this.Controls.Add(btn[i]);
            }
            message.Location = new System.Drawing.Point(10, 10);
            message.Text = body;
            this.Controls.Add(message);
        }

        public MyForm(int read, int kohad)
        {
            this.tlp.ColumnCount = kohad;
            this.tlp.RowCount = read;
            this.tlp.ColumnStyles.Clear();
            this.tlp.RowStyles.Clear();
            

            for (int i = 0; i < read; i++)
            {
                this.tlp.RowStyles.Add(new RowStyle(SizeType.Percent));
                this.tlp.RowStyles[i].Height = 100 / read;
            }

            for (int j = 0; j < kohad; j++)
            {
                this.tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent));
                this.tlp.ColumnStyles[j].Width = 100 / kohad;
            }

            this.Size = new System.Drawing.Size(kohad * 100, read * 100);
            for (int r = 0; r < read; r++)
            {
                for (int k = 0; k < kohad; k++)
                {
                    btn_tabel = new Button
                    {
                        Text = string.Format("{0}{1}", r, k),
                        Name = string.Format("btn_{0}{1}", r, k),
                        Dock = DockStyle.Fill
                    };
                    this.tlp.Controls.Add(btn_tabel, r, k);
                }
            }
            btn_w = (int)(100 / kohad);
            btn_h = (int)(100 / read);
            this.tlp.Dock = DockStyle.Fill;
            this.tlp.Size = new System.Drawing.Size(tlp.ColumnCount * btn_w, tlp.RowCount * btn_h);
            this.Controls.Add(tlp);
        }

        private void MyForm_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;
            MessageBox.Show("Oli valitud nupp number " + btn_click.Text);
        }
    }
}