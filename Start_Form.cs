﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    class Start_Form:System.Windows.Forms.Form
    {
        public Start_Form()
        {
            Button Start_btn = new Button
            {
                Text = "Minu oma aken",
                Location = new System.Drawing.Point(10, 10)
            };
            Start_btn.Click += Start_btn_Click;
            this.Controls.Add(Start_btn);
            Button Start_btn_2 = new Button
            {
                Text = "Veel aken",
                Location = new System.Drawing.Point(100, 100);
                this.Controls.Add(Start_btn_2);
            Start_btn_2.Click += Start_btn_2_Click;
    }

        private void Start_btn_2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm("Я балдежная форма", "Vali midagi", "Üks", "Kaks", "Kolm", "Neli");
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
    }
}
