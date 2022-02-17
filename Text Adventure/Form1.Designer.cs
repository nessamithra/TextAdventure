namespace Text_Adventure
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.HP = new System.Windows.Forms.Label();
            this.story1 = new System.Windows.Forms.Label();
            this.story2 = new System.Windows.Forms.Label();
            this.gold_value = new System.Windows.Forms.Label();
            this.hp_value = new System.Windows.Forms.Label();
            this.west_door = new System.Windows.Forms.Button();
            this.north_door = new System.Windows.Forms.Button();
            this.east_door = new System.Windows.Forms.Button();
            this.donot_button = new System.Windows.Forms.Button();
            this.doit_button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.enemy_hp_value = new System.Windows.Forms.Label();
            this.retry = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            this.leveltext = new System.Windows.Forms.Label();
            this.level_value = new System.Windows.Forms.Label();
            this.xpText = new System.Windows.Forms.Label();
            this.xp_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(686, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gold";
            // 
            // HP
            // 
            this.HP.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.HP.Location = new System.Drawing.Point(686, 29);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(41, 23);
            this.HP.TabIndex = 4;
            this.HP.Text = "HP";
            // 
            // story1
            // 
            this.story1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.story1.Location = new System.Drawing.Point(20, 6);
            this.story1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.story1.Name = "story1";
            this.story1.Size = new System.Drawing.Size(528, 19);
            this.story1.TabIndex = 5;
            // 
            // story2
            // 
            this.story2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.story2.Location = new System.Drawing.Point(20, 29);
            this.story2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.story2.Name = "story2";
            this.story2.Size = new System.Drawing.Size(528, 19);
            this.story2.TabIndex = 6;
            // 
            // gold_value
            // 
            this.gold_value.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gold_value.Location = new System.Drawing.Point(741, 6);
            this.gold_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gold_value.Name = "gold_value";
            this.gold_value.Size = new System.Drawing.Size(50, 19);
            this.gold_value.TabIndex = 7;
            this.gold_value.Text = "label4";
            // 
            // hp_value
            // 
            this.hp_value.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.hp_value.Location = new System.Drawing.Point(741, 29);
            this.hp_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hp_value.Name = "hp_value";
            this.hp_value.Size = new System.Drawing.Size(50, 19);
            this.hp_value.TabIndex = 8;
            this.hp_value.Text = "label4";
            // 
            // west_door
            // 
            this.west_door.BackgroundImage = global::Text_Adventure.Properties.Resources.DungeonDoor14;
            this.west_door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.west_door.Location = new System.Drawing.Point(78, 82);
            this.west_door.Margin = new System.Windows.Forms.Padding(0);
            this.west_door.Name = "west_door";
            this.west_door.Size = new System.Drawing.Size(141, 215);
            this.west_door.TabIndex = 1;
            this.west_door.UseVisualStyleBackColor = true;
            this.west_door.Click += new System.EventHandler(this.west_door_Click);
            // 
            // north_door
            // 
            this.north_door.BackgroundImage = global::Text_Adventure.Properties.Resources.DungeonDoor6;
            this.north_door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.north_door.Location = new System.Drawing.Point(373, 130);
            this.north_door.Margin = new System.Windows.Forms.Padding(0);
            this.north_door.Name = "north_door";
            this.north_door.Size = new System.Drawing.Size(71, 100);
            this.north_door.TabIndex = 2;
            this.north_door.UseVisualStyleBackColor = true;
            this.north_door.Click += new System.EventHandler(this.north_door_Click);
            // 
            // east_door
            // 
            this.east_door.BackgroundImage = global::Text_Adventure.Properties.Resources.DungeonDoor14;
            this.east_door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.east_door.Location = new System.Drawing.Point(603, 82);
            this.east_door.Margin = new System.Windows.Forms.Padding(0);
            this.east_door.Name = "east_door";
            this.east_door.Size = new System.Drawing.Size(142, 215);
            this.east_door.TabIndex = 3;
            this.east_door.UseVisualStyleBackColor = true;
            this.east_door.Click += new System.EventHandler(this.east_door_Click);
            // 
            // donot_button
            // 
            this.donot_button.BackgroundImage = global::Text_Adventure.Properties.Resources.Button15;
            this.donot_button.Enabled = false;
            this.donot_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donot_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.donot_button.Location = new System.Drawing.Point(20, 369);
            this.donot_button.Name = "donot_button";
            this.donot_button.Size = new System.Drawing.Size(150, 62);
            this.donot_button.TabIndex = 4;
            this.donot_button.Text = "button1";
            this.donot_button.UseVisualStyleBackColor = true;
            this.donot_button.Visible = false;
            this.donot_button.Click += new System.EventHandler(this.donot_button_Click);
            // 
            // doit_button
            // 
            this.doit_button.BackgroundImage = global::Text_Adventure.Properties.Resources.Button15;
            this.doit_button.Enabled = false;
            this.doit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doit_button.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.doit_button.Location = new System.Drawing.Point(624, 369);
            this.doit_button.Name = "doit_button";
            this.doit_button.Size = new System.Drawing.Size(150, 62);
            this.doit_button.TabIndex = 5;
            this.doit_button.Text = "button2";
            this.doit_button.UseVisualStyleBackColor = true;
            this.doit_button.Visible = false;
            this.doit_button.Click += new System.EventHandler(this.doit_button_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(319, 180);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(180, 195);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // enemy_hp_value
            // 
            this.enemy_hp_value.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.enemy_hp_value.Image = global::Text_Adventure.Properties.Resources.HP_Bar;
            this.enemy_hp_value.Location = new System.Drawing.Point(319, 211);
            this.enemy_hp_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemy_hp_value.Name = "enemy_hp_value";
            this.enemy_hp_value.Size = new System.Drawing.Size(180, 19);
            this.enemy_hp_value.TabIndex = 7;
            this.enemy_hp_value.Text = "label2";
            this.enemy_hp_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // retry
            // 
            this.retry.BackgroundImage = global::Text_Adventure.Properties.Resources.Button10;
            this.retry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retry.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.retry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.retry.Location = new System.Drawing.Point(360, 389);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(100, 42);
            this.retry.TabIndex = 8;
            this.retry.Text = "Retry";
            this.retry.UseVisualStyleBackColor = true;
            this.retry.Visible = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // background
            // 
            this.background.Image = global::Text_Adventure.Properties.Resources.Dungeon;
            this.background.Location = new System.Drawing.Point(9, 55);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(779, 385);
            this.background.TabIndex = 9;
            this.background.TabStop = false;
            // 
            // leveltext
            // 
            this.leveltext.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.leveltext.Location = new System.Drawing.Point(553, 6);
            this.leveltext.Name = "leveltext";
            this.leveltext.Size = new System.Drawing.Size(46, 23);
            this.leveltext.TabIndex = 10;
            this.leveltext.Text = "Level";
            // 
            // level_value
            // 
            this.level_value.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.level_value.Location = new System.Drawing.Point(614, 6);
            this.level_value.Name = "level_value";
            this.level_value.Size = new System.Drawing.Size(66, 23);
            this.level_value.TabIndex = 11;
            this.level_value.Text = "lvlValue";
            // 
            // xpText
            // 
            this.xpText.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.xpText.Location = new System.Drawing.Point(553, 29);
            this.xpText.Name = "xpText";
            this.xpText.Size = new System.Drawing.Size(46, 23);
            this.xpText.TabIndex = 12;
            this.xpText.Text = "XP";
            // 
            // xp_value
            // 
            this.xp_value.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.xp_value.Location = new System.Drawing.Point(614, 29);
            this.xp_value.Name = "xp_value";
            this.xp_value.Size = new System.Drawing.Size(66, 23);
            this.xp_value.TabIndex = 13;
            this.xp_value.Text = "xpvalue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xp_value);
            this.Controls.Add(this.xpText);
            this.Controls.Add(this.level_value);
            this.Controls.Add(this.leveltext);
            this.Controls.Add(this.west_door);
            this.Controls.Add(this.east_door);
            this.Controls.Add(this.donot_button);
            this.Controls.Add(this.doit_button);
            this.Controls.Add(this.retry);
            this.Controls.Add(this.background);
            this.Controls.Add(this.enemy_hp_value);
            this.Controls.Add(this.hp_value);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.gold_value);
            this.Controls.Add(this.story2);
            this.Controls.Add(this.story1);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.north_door);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Text Adventure";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.background)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label xpText;
        private System.Windows.Forms.Label xp_value;

        private System.Windows.Forms.Label leveltext;
        private System.Windows.Forms.Label level_value;

        private System.Windows.Forms.PictureBox background;

        private System.Windows.Forms.Button retry;

        private System.Windows.Forms.Label enemy_hp_value;

        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label gold_value;

        private System.Windows.Forms.Label story2;
        private System.Windows.Forms.Label hp_value;

        private System.Windows.Forms.Label story1;

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Button donot_button;
        private System.Windows.Forms.Button doit_button;

        private System.Windows.Forms.Button west_door;
        private System.Windows.Forms.Button north_door;
        private System.Windows.Forms.Button east_door;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}