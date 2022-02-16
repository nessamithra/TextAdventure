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
        public Roomhandler roomhandler;
        public Room r;
        
        public Form1()
        {
            character = new Character();
            roomhandler = new Roomhandler();
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

        private void GoThroughDoor()
        {
            east_door.Enabled = false;
            north_door.Enabled = false;
            west_door.Enabled = false;
            
            r = roomhandler.getRoom();
            string[] text = r.GetTexts();
            doit_button.Text = text[0];
            donot_button.Text = text[1];
            
            donot_button.Enabled = true;
            doit_button.Enabled = true;
            doit_button.Visible = true;
            donot_button.Visible = true;
        }

        private void donot_button_Click(object sender, EventArgs e)
        {
            if (r.DoNot())
            {
                finishEvent();
            }
        }

        private void doit_button_Click(object sender, EventArgs e)
        {
            if (r.DoIt())
            {
                finishEvent();
            }
        }
        
        private void finishEvent()
        {
            donot_button.Enabled = false;
            doit_button.Enabled = false;
            doit_button.Visible = false;
            donot_button.Visible = false;
            
            east_door.Enabled = true;
            north_door.Enabled = true;
            west_door.Enabled = true;
        }
    }
}