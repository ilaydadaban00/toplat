using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazılı_ort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1=Convert.ToInt32(txtNot1.Text);
            int not2 = Convert.ToInt32(txtNot2.Text);
            int not3= Convert.ToInt32(txtNot3.Text);
            int sonuc = (not1 + not2 + not3) / 3;
                
            lblSonuc.Text = sonuc.ToString();
            
        }
    }
}
