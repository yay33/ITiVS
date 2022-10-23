using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itivscal
{
    public partial class Вычисление_эффективности : Form
    {
        double int_change = -1;
        public Вычисление_эффективности()
        {
            InitializeComponent();
            label1.Text = "";
            progressBar1.Step = 20;
            
            //progressBar1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            if (Convert.ToString(int_change) != textBox6.Text)
            {
                progressBar1.Value = 0;
            }
            try
            {
                double info1 = Convert.ToDouble(textBox1.Text);
                double info2 = Convert.ToDouble(textBox2.Text);
                double info3 = Convert.ToDouble(textBox3.Text);
                double info4 = Convert.ToDouble(textBox4.Text);
                double info5 = Convert.ToDouble(textBox5.Text);

                
                for (int i = 0; i < 5; i++)
                {
                    progressBar1.PerformStep();
                }
                System.Threading.Thread.Sleep(1000);

                textBox6.Text = Convert.ToString(((info1 + info2) * info5) / (info4 - info3));
                int_change = ((info1 + info2) * info5) / (info4 - info3);
            }
            catch
            {
                label1.Visible = true;
                label1.Text = "Введи корректные данные, пожалуйста";
            }   
            
        }
    }
}
