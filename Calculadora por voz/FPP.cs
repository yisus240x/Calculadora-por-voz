using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_por_voz
{
    public partial class FPP : Form
    {
        public FPP()
        {
            InitializeComponent();
        }

        private void FPP_Load(object sender, EventArgs e)
        {
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            double teta = Convert.ToInt32(txtTeta.Text);
            double altura = Convert.ToInt32(txtAltura.Text);
            double velocidad = Convert.ToInt32(txtVelocidad.Text);
            double x = Convert.ToInt32(txtX.Text);
            double calculo_1 = 0; 
            double calculo_2 = 0;
            double calculo_t = 0;
            double agree1 = (Math.PI * teta) / 180;
            //x
            double multi_i = velocidad * (Math.Cos(agree1));
            //y
            double multi_j = velocidad * (Math.Sin(agree1));
            double div_j = multi_j / 32;
            double multiJxDiv = multi_j * div_j;
            double proc = x/multi_i;
            calculo_1 = altura + multiJxDiv;
            calculo_2 = 16 * (div_j * div_j);
            calculo_t = calculo_1 - calculo_2;
            double proc2 = multi_j * proc;
            double proc3 = 16 * (proc*proc);
            double procT = proc2 - proc3;

            if (x != 0) {
                lbl1.Text = "r(t) = " + velocidad + "(Cos" + teta + ")t i + [" + altura + " + (" + velocidad + "Sen" + teta + ")t -1/2(32)t^2] j";
                lbl2.Text = "r(t) = " + multi_i + "t i + [" + altura + " + " + multi_j + "t - 16t^2] j";
                lbl3.Text = "r'(t) = " + multi_i + "i + [" + multi_j + " i - 32t] j";
                lbl4.Text = "y'(t) = " + multi_j + " - 32t = 0";
                lbl5.Text = "t = " + multi_j + " / 32 = " + div_j + "seg";
                lbl6.Text = "Altura Maxima";
                lbl7.Text = "y(t) = [" + altura + " + " + multi_j + "(" + div_j + ") - 16(" + div_j + ")^2]";
                lbl8.Text = "= " + calculo_1 + " - " + calculo_2 + " = " + calculo_t;
                lbl9.Text = "r(t) = x(t)";
                lbl10.Text = "x(t) = " + multi_i + "t";
                lbl11.Text = x + " = " + multi_i + "t";
                lbl12.Text = "t = " + x + " / " + multi_i + " = " + proc;
                lbl13.Text = "Altura con t = " + proc;
                lbl14.Text = "y(t) = [" + altura + " + " + multi_j + "(" + proc + ") - 16(" + proc + ")^2]";
                lbl15.Text = proc2 + " - " + proc3 + " = " + procT;
            }
            else{
                lbl1.Text = "r(t) = " + velocidad + "(Cos" + teta + ")t i + [" + altura + " + (" + velocidad + "Sen" + teta + ")t -1/2(32)t^2] j";
                lbl2.Text = "r(t) = " + multi_i + "t i + [" + altura + " + " + multi_j + "t - 16t^2] j";
                lbl3.Text = "r'(t) = " + multi_i + "i + [" + multi_j + " i - 32t] j";
                lbl4.Text = "y'(t) = " + multi_j + " - 32t = 0";
                lbl5.Text = "t = " + multi_j + " / 32 = " + div_j + "seg";
                lbl6.Text = "Altura Maxima";
                lbl7.Text = "y(t) = [" + altura + " + " + multi_j + "(" + div_j + ") - 16(" + div_j + ")^2]";
                lbl8.Text = "= " + calculo_1 + " - " + calculo_2 + " = " + calculo_t;
            }
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtTeta.Clear();
            txtVelocidad.Clear();
            txtX.Clear();
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";
            lbl7.Text = "";
            lbl8.Text = "";
            lbl9.Text = "";
            lbl10.Text = "";
            lbl11.Text = "";
            lbl12.Text = "";
            lbl13.Text = "";
            lbl14.Text = "";
            lbl15.Text = "";
        }
    }
}
