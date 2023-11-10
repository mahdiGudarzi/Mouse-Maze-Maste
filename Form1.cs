using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class fm : Form
    {

        private bool play = false;
        public fm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.play = true;
           

        }

        private void fm_mouseEvent(object sender, EventArgs e) {
           
            if (this.play)
            {
                MessageBox.Show("بازی رو باختی دوباره شروع کن  ");
                this.play = false;
            }
           
           

        }

        private void labEnd_MouseEvent(object sender, EventArgs e)
        {
            if (this.play)
            {
                MessageBox.Show("بردی :D");
                this.play = false;
            }
           
        }

        private void fm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                button1_Click(sender, e);


            }
            else if (e.KeyCode == Keys.Escape)
            { 
                
               if (!this.play)
                {
                    MessageBox.Show("بازی رو خاتمه دادید !");
                    this.play = false;

                }
            
            
            }

        }


    }
}
