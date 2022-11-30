using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2__CalculoVectorial
{
    public partial class Grafica : Form
    {
        public Grafica(int i, int j, int k)
        {
            InitializeComponent();
            this.i = i;
            this.j = j;
            this.k = k;
        }
        int i = 0, j = 0, k = 0;
        private void Calcular_Click(object sender, EventArgs e)
        {
            int ejex = 300, ejey = 400;
            System.Drawing.Pen Linea;
            System.Drawing.Graphics vector;

            Linea = new System.Drawing.Pen(System.Drawing.Color.Black);
            vector = this.CreateGraphics();

            //plano cartesino 
            vector.DrawLine(Linea, /*x*/ejex, /*y*/200, ejex, 0); //K
            vector.DrawLine(Linea, ejex, 200, 1, 500);//i
            vector.DrawLine(Linea, ejex, 200, 700, 500 );//j
            Linea = new System.Drawing.Pen(System.Drawing.Color.Red);
            vector.DrawLine(Linea, ejex, 200,300-((i-j)*10),400-((i+j+k)*10));
        }
    }
}
