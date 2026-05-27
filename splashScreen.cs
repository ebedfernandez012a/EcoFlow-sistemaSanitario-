using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sistemaSanitario
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Increment(5);
                label1.Text = "Iniciando el sistema en : " + progressBar1.Value + "%";
            }
            else
            {
                label1.Text = "¡Carga completada! Entrando...";

                timer1.Tag = Convert.ToInt32(timer1.Tag) + 1;

                if (Convert.ToInt32(timer1.Tag) >= 15)
                {
                    timer1.Stop();
                    this.Close();
                }
            }
        }
    }
}
