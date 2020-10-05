using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 obj_1 = new Class1();
            int vagonis_raodenoba, mgzavri_raodenoba,max_raodenoba;
            double daxarjuli_elenergia;
            double gavlili_mandzili,daxarjuli_energia;




            vagonis_raodenoba = int.Parse(textBox1.Text);
            mgzavri_raodenoba = int.Parse(textBox2.Text);
            daxarjuli_elenergia = double.Parse(textBox3.Text);
            gavlili_mandzili = double.Parse(textBox4.Text);

            max_raodenoba = obj_1.Mandzili(vagonis_raodenoba, mgzavri_raodenoba);
            daxarjuli_energia = obj_1.Mandzili(daxarjuli_elenergia, gavlili_mandzili);

            label1.Text = "სულ მგზავრთა რაოდენობაა " + max_raodenoba.ToString();
            label2.Text = "დახარჯული ელ.ენერგია: " + daxarjuli_energia.ToString();
        }
    }
}
