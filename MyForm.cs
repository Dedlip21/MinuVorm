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
        }

        private void MyForm_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;
            MessageBox.Show("Oli valitud nupp number " + btn_click.Text);
        }
    }
}