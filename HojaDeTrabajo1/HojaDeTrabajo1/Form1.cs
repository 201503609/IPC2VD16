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

        //---------------------------------------promedio-----------------------------------------
        private void btn_promedio_Click(object sender, EventArgs e)
        {
            int a, b, c;

            a = Int32.Parse(txt_val1.Text);
            b = Int32.Parse(txt_val1.Text);
            c = Int32.Parse(txt_val1.Text);

            int suma;
            suma = a + b + c;
            double division;
            division = suma / 3;

            txt_resultado.Text = Convert.ToString(division);

        }

        //---------------------------------------Formula General-----------------------------------------
        private void btn_formu_Click(object sender, EventArgs e)
        {
            
            double a = Convert.ToDouble(txt_val1.Text);
            double b = Convert.ToDouble(txt_val2.Text);
            double c = Convert.ToDouble(txt_val3.Text);
            double disc = Math.Pow(b, 2) - 4 * a * c;
            if (a != 0)
            {
                if (disc < 0)
                {
                    txt_resultado.Text = ("Tiene raices imaginarias");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                    txt_resultado.Text = ("X1 = " + x1 + " , "+ " X2 = " + x2);
                }
            }
            else
            {
                txt_resultado.Text = ("El coeficiente cuadratico debe ser diferente de 0");
            }

        }
    }
}
