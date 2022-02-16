using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Adventure
{
    public partial class Form1 : Form
    {
        public static Character character;
        
        public Form1()
        {
            character = new Character();
            InitializeComponent();
        }

        private void west_door_Click(object sender, EventArgs e)
        {
            GoThroughDoor();
        }

        private void north_door_Click(object sender, EventArgs e)
        {
            GoThroughDoor();
        }

        private void east_door_Click(object sender, EventArgs e)
        {
            GoThroughDoor();
        }

        private static void GoThroughDoor()
        {
            
        }
    }
}