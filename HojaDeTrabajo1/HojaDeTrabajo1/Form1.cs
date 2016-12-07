using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HojaDeTrabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //----------------------variables a utilizar------------------------------------------
        double a = 0;
        double b = 0;
        double c = 0;
        double resultado;
        

        //----------------------metodo para calcular MCD-----------------------------------------
        private void btn_mcm_Click(object sender, EventArgs e)
        {
            int A, B, C, Resto, MCD;
            A = int.Parse(txt_val1.Text);
            B = int.Parse(txt_val2.Text);
            C = int.Parse(txt_val3.Text);
            Resto = A % B;
            while (Resto != 0)
            {
                A = B;
                B = Resto;
                Resto = A % B;
            }
            MCD = B;
            Resto = MCD % C;
            while (Resto != 0)
            {
                MCD = C;
                C = Resto;
                Resto = MCD % B;
            }
            MCD = C;
            txt_resultado.Text = Convert.ToString(MCD);
        }
    }
}
