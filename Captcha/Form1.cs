using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        string selected="";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int pos = selected.IndexOf(""+((PictureBox)(sender)).Tag);
            if (pos >= 0)
            {
                selected = selected.Remove(pos, 1);
                ((PictureBox)(sender)).BorderStyle = BorderStyle.None;
            }
            else
            {
                selected = selected + ((PictureBox)(sender)).Tag;
                ((PictureBox)(sender)).BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected.Length == 3 && selected.IndexOf("4") >= 0 && selected.IndexOf("7") >= 0 && selected.IndexOf("8") >= 0)
                MessageBox.Show("CAPTCHA пройдена");
            else MessageBox.Show("Вы не человек!");
            selected = "";
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            pictureBox5.BorderStyle = BorderStyle.None;
            pictureBox6.BorderStyle = BorderStyle.None;
            pictureBox7.BorderStyle = BorderStyle.None;
            pictureBox8.BorderStyle = BorderStyle.None;
            pictureBox9.BorderStyle = BorderStyle.None;
        }

    }
}
