using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votantes_aleatorios
{
    
    public partial class Form1 : Form
    {
        double an, gl, xh;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    double el;
                    el = Convert.ToDouble(textBox1.Text);
                    Presidentes oPre = new Presidentes();
                    oPre.Elecciones(el, ref an, ref gl, ref xh);
                    lblNoboa.Visible = true;
                    lblLasso.Visible = true;
                    lblHervas.Visible = true;
                    lblNoboa.Text = an.ToString();
                    lblLasso.Text = gl.ToString();
                    lblHervas.Text = xh.ToString();

                    lblGanador.Visible = true;
                    label6.Visible = true;

                    lblGanador.Text = oPre.ganador(an, gl, xh);
                }
                catch
                {
                    MessageBox.Show("Dato mal ingresado");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
            an = 0;
            gl = 0;
            xh = 0;
            lblNoboa.Visible = false;
            lblLasso.Visible = false;
            lblHervas.Visible = false;
            label6.Visible = false;
            lblGanador.Visible = false;
        }
    }
}
