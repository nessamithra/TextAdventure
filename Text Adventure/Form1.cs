﻿using System;
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
        public Room r = null;
        Bitmap pictureChest = new Bitmap("./../../resource/Chest.png");
        Bitmap pictureOpenChest = new Bitmap("./../../resource/openChest.png");
        Bitmap pictureSlime = new Bitmap("./../../resource/Slime.png");
        Bitmap pictureDungeon = new Bitmap("./../../resource/Dungeon.png");

        public Form1()
        {
            InitializeComponent();
            north_door.SendToBack();
            background.SendToBack();
            background.Controls.Add(pictureBox);
            pictureBox.Visible = false;
            background.Image = pictureDungeon;
            character = new Character();
            roomhandler = new Roomhandler();
            setText();
        }

        private void west_door_Click(object sender, EventArgs e)
        {
            story1.Text = "You are going west.";
            GoThroughDoor();
        }

        private void north_door_Click(object sender, EventArgs e)
        {
            story1.Text = "You are going north.";
            GoThroughDoor();
        }

        private void east_door_Click(object sender, EventArgs e)
        {
            story1.Text = "You are going east.";
            GoThroughDoor();
        }

        private void GoThroughDoor()
        {
            east_door.Enabled = false;
            north_door.Enabled = false;
            west_door.Enabled = false;
            east_door.Visible = false;
            north_door.Visible = false;
            west_door.Visible = false;
            pictureBox.Visible = true;

            r = roomhandler.getRoom();
            setPictures();
            string[] text = r.GetTexts();
            doit_button.Text = text[0];
            donot_button.Text = text[1];

            donot_button.Enabled = true;
            doit_button.Enabled = true;
            doit_button.Visible = true;
            donot_button.Visible = true;
            setText();
        }

        private void donot_button_Click(object sender, EventArgs e)
        {
            try
            {
                string story = r.DoNot();
                story1.Text = story2.Text;
                story2.Text = story;
                finishEvent();
            }
            catch (PlayerIsDeadException exeption)
            {
                Gameover();
            }
        }

        private void doit_button_Click(object sender, EventArgs e)
        {
            try
            {
                string[] story = r.DoIt();
                story1.Text = story[0];
                story2.Text = story[1];
                if (story[1].Contains("killed") || r.GetType().Equals(typeof(ChestRoom)))
                {
                    finishEvent();
                }

                setText();
            }
            catch (PlayerIsDeadException exception)
            {
                Gameover();
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
            east_door.Visible = true;
            north_door.Visible = true;
            west_door.Visible = true;

            // See if chest got opened. If it doesn't set r to null
            if (r.GetType().Equals(typeof(ChestRoom)))
            {
                if (!(r as ChestRoom).Open)
                {
                    r = null;
                    pictureBox.Visible = false;
                }
            }
            else
            {
                r = null;
            }

            setPictures();
            setText();
        }

        private void setText()
        {
            gold_value.Text = character.Gold.ToString();
            hp_value.Text = $"{character.HP.ToString()}/{character.MaxHp.ToString()}";
            level_value.Text = character.Level.ToString();
            xp_value.Text = $"{character.Xp.ToString()}/{(character.Level * 5).ToString()}";
            if (r != null && r.GetType() == typeof(EnemyRoom))
            {
                textProgressBar1.Maximum = (r as EnemyRoom).MaxHP;
                textProgressBar1.Value = (r as EnemyRoom).HP;
                textProgressBar1.Visible = true;
            }
            else
            {
                textProgressBar1.Visible = false;
            }
        }

        private void setPictures()
        {
            if (r != null && r.GetType() == typeof(EnemyRoom))
            {
                pictureBox.Image = pictureSlime;
                story2.Text = "A slime appears!";
            }
            else if (r != null && r.GetType() == typeof(ChestRoom))
            {
                if ((r as ChestRoom).Open)
                {
                    pictureBox.Image = pictureOpenChest;
                    r = null;
                }
                else
                {
                    pictureBox.Image = pictureChest;
                    story2.Text = "You've found a chest!";
                }
            }
            else
            {
                pictureBox.Visible = false;
            }

            pictureBox.BackColor = Color.Transparent;
        }

        private void Gameover()
        {
            r = null;
            setText();
            setPictures();
            donot_button.Enabled = false;
            doit_button.Enabled = false;
            doit_button.Visible = false;
            donot_button.Visible = false;
            story2.Text = "You died. Game over. You can try again.";
            retry.Visible = true;
        }

        private void retry_Click(object sender, EventArgs e)
        {
            character = new Character();
            setText();
            east_door.Enabled = true;
            north_door.Enabled = true;
            west_door.Enabled = true;
            east_door.Visible = true;
            north_door.Visible = true;
            west_door.Visible = true;
            retry.Visible = false;
        }
    }
}