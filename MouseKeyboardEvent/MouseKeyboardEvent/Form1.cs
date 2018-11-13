using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseKeyboardEvent
{
    public partial class Form1 : Form
    {

        KeyPressEventHandler keyPressedMethod;
        int countKeystrokes = 0;
        int countBackSpace = 0;
        public Form1()
        {
            InitializeComponent();

  
            // define an event handler for this textbox to handle keypresses
            keyPressedMethod = new KeyPressEventHandler(CustomKeyPress);
            textBox1.KeyPress += keyPressedMethod;
        }
        
        private void CustomKeyPress(object sender, KeyPressEventArgs e)
        {
            // Only duplicate the keystroke onscreen if it is an alphanumeric or numeric character
            if ((e.KeyChar >= (char)Keys.A && e.KeyChar <= 122) || (e.KeyChar >= (char)Keys.D0 && e.KeyChar <= (char)Keys.D9) )
            {
                // 122 is the ascii value for lowercase 'z' char
                lblCopy.Text += e.KeyChar.ToString();
            }

            if(e.KeyChar == Convert.ToChar(8))
            {
                countBackSpace++;
                lblBackSpaceCount.Text = "BackSpace Count: "+ countBackSpace;
            }
            else
            {
                countKeystrokes++;
                lblCount.Text = "Text Count: " + countKeystrokes.ToString();
            }
        }

        private void pictureBox1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            Point mousePt = new Point(e.X, e.Y);
            

            if((e.X > 115 && e.X < 130) && (e.Y > 15 && e.Y < 30))

            {
                MessageBox.Show("Good job!");
            }
            else
            {
                MessageBox.Show("Hey, it's not my nose!!");
            }
        }


    }
}
