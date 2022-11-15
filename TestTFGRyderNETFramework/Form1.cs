using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTFGRyderNETFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int numero = 47;
            label1.Text = "Texto cambiado";

            numero = 76;
            
            
            numero = 77;
            
            
            numero = 78;
            
            MessageBox.Show("Ha pasado el breakpoint");
            //throw new System.NotImplementedException();
        }
    }
}