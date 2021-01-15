using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Tienda
{
    public partial class Form1 : Form
    {
        //Datos en la base de datos
        //Coca cola
        int c1 = 1, c2 = 2, c3 = 3, c4 = 4;
        string n1 = "Coca-cola", n2 = "pepsi", n3 = "Pan Bimbo", n4 = "Leche";
        string d1 = "355 ml", d2 = "355 ml", d3 = "640 gramos 23 piezas", d4 = "1 Lt";

        private void btnpagar_Click(object sender, EventArgs e)
        {
            //Añadir clase para desplegar nueva pantalla

        }

        int can1 = 10, can2 = 10, can3 = 14, can4 = 20;

        private void txt_box_Enter(object sender, EventArgs e)
        {
            subj.Changed(txt_box.Text);
        }

        private void txt_box_Leave(object sender, EventArgs e)
        {
            subj.Changed(txt_box.Text);
        }

       

        float p1 = 13, p2 = 12, p3 = 30, p4 = 16;
        float T=0;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            int x;
            
            x = Convert.ToInt32(txtcodigo.Text);
            if (x == 1)
            {
                txtlista.Text = txtlista.Text + "\r\n" + c1.ToString() + " " + n1 + " " + d1 +  " " + "$" + p1.ToString() ;
                T = T + p1;
                lblTotal.Text = "Total = $" + T.ToString();
            }


        }   

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Subject subj = new Subject();

        public Form1()
        {
            InitializeComponent();

            Observer obs1 = new Observer(textBox_observer1);
            Observer obs2 = new Observer(textBox_observer2);

            subj.Subscribe(obs1);
            subj.Subscribe(obs2);

            subj.Changed(txt_box.Text);
        }

       // private void textBox_subject_LostFocus(object sender, EventArgs e)
        //{
         //   subj.changed(textBox_subject.Text);
      //  }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
