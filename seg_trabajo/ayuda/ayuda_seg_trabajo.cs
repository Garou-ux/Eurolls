using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
namespace seg_trabajo.ayuda
{
    public partial class ayuda_seg_trabajo : Form
    {
        public ayuda_seg_trabajo()
        {
            InitializeComponent();
        }

        private void ayuda_seg_trabajo_Load(object sender, EventArgs e)
        {

        }

        private void picAbrir_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(picAbrir, "Left", -1000);
            t.add(lbl1, "Left", -1000);
            pictureBox2.Visible = true;
            lbl2.Visible = true;
            t.add(pictureBox2,"Left",7);
            t.add(lbl2, "Left", 84);
            pictureBox2.Size = new System.Drawing.Size(669,277);
            t.run();  
        }

     

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));          
            t.add(lbl2, "Left", -1000);
            t.add(pictureBox2, "Left", -1000);
            pic3.Visible = true;
            lbl3.Visible = true;
            pic3.Size = new System.Drawing.Size(711, 289);
            t.add(pic3, "Left", 7);
            t.add(lbl3, "Left", 7);
            
            t.run();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            
            t.add(pic3, "Left", -1000);
            t.add(lbl3, "Left", -1000);
            pic4.Visible = true;
            lbl4.Visible = true;
            t.add(pic4, "Left", 7);
            t.add(lbl4, "Left", 7);
            pic4.Size = new System.Drawing.Size(711, 289);
            t.run();
        }

       
    }
}
