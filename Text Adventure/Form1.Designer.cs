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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enemy_hp_value = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.doit_button = new System.Windows.Forms.Button();
            this.donot_button = new System.Windows.Forms.Button();
            this.east_door = new System.Windows.Forms.Button();
            this.north_door = new System.Windows.Forms.Button();
            this.west_door = new System.Windows.Forms.Button();
            this.HP = new System.Windows.Forms.Label();
            this.story1 = new System.Windows.Forms.Label();
            this.story2 = new System.Windows.Forms.Label();
            this.gold_value = new System.Windows.Forms.Label();
            this.hp_value = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(934, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gold";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enemy_hp_value);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.doit_button);
            this.panel1.Controls.Add(this.donot_button);
            this.panel1.Controls.Add(this.east_door);
            this.panel1.Controls.Add(this.north_door);
            this.panel1.Controls.Add(this.west_door);
            this.panel1.Location = new System.Drawing.Point(16, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 474);
            this.panel1.TabIndex = 1;
            // 
            // enemy_hp_value
            // 
            this.enemy_hp_value.Location = new System.Drawing.Point(376, 127);
            this.enemy_hp_value.Name = "enemy_hp_value";
            this.enemy_hp_value.Size = new System.Drawing.Size(240, 23);
            this.enemy_hp_value.TabIndex = 7;
            this.enemy_hp_value.Text = "label2";
            this.enemy_hp_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(376, 153);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(240, 240);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // doit_button
            // 
            this.doit_button.Enabled = false;
            this.doit_button.Location = new System.Drawing.Point(579, 400);
            this.doit_button.Margin = new System.Windows.Forms.Padding(4);
            this.doit_button.Name = "doit_button";
            this.doit_button.Size = new System.Drawing.Size(205, 70);
            this.doit_button.TabIndex = 5;
            this.doit_button.Text = "button2";
            this.doit_button.UseVisualStyleBackColor = true;
            this.doit_button.Visible = false;
            this.doit_button.Click += new System.EventHandler(this.doit_button_Click);
            // 
            // donot_button
            // 
            this.donot_button.Enabled = false;
            this.donot_button.Location = new System.Drawing.Point(213, 400);
            this.donot_button.Margin = new System.Windows.Forms.Padding(4);
            this.donot_button.Name = "donot_button";
            this.donot_button.Size = new System.Drawing.Size(205, 70);
            this.donot_button.TabIndex = 4;
            this.donot_button.Text = "button1";
            this.donot_button.UseVisualStyleBackColor = true;
            this.donot_button.Visible = false;
            this.donot_button.Click += new System.EventHandler(this.donot_button_Click);
            // 
            // east_door
            // 
            this.east_door.Location = new System.Drawing.Point(849, 304);
            this.east_door.Margin = new System.Windows.Forms.Padding(4);
            this.east_door.Name = "east_door";
            this.east_door.Size = new System.Drawing.Size(136, 166);
            this.east_door.TabIndex = 3;
            this.east_door.Text = "Osten";
            this.east_door.UseVisualStyleBackColor = true;
            this.east_door.Click += new System.EventHandler(this.east_door_Click);
            // 
            // north_door
            // 
            this.north_door.Location = new System.Drawing.Point(386, 4);
            this.north_door.Margin = new System.Windows.Forms.Padding(4);
            this.north_door.Name = "north_door";
            this.north_door.Size = new System.Drawing.Size(216, 105);
            this.north_door.TabIndex = 2;
            this.north_door.Text = "Norden";
            this.north_door.UseVisualStyleBackColor = true;
            this.north_door.Click += new System.EventHandler(this.north_door_Click);
            // 
            // west_door
            // 
            this.west_door.Location = new System.Drawing.Point(4, 304);
            this.west_door.Margin = new System.Windows.Forms.Padding(4);
            this.west_door.Name = "west_door";
            this.west_door.Size = new System.Drawing.Size(136, 166);
            this.west_door.TabIndex = 1;
            this.west_door.Text = "Westen";
            this.west_door.UseVisualStyleBackColor = true;
            this.west_door.Click += new System.EventHandler(this.west_door_Click);
            // 
            // HP
            // 
            this.HP.Location = new System.Drawing.Point(934, 36);
            this.HP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(36, 28);
            this.HP.TabIndex = 4;
            this.HP.Text = "HP";
            // 
            // story1
            // 
            this.story1.Location = new System.Drawing.Point(26, 8);
            this.story1.Name = "story1";
            this.story1.Size = new System.Drawing.Size(879, 23);
            this.story1.TabIndex = 5;
            this.story1.Text = "label2";
            // 
            // story2
            // 
            this.story2.Location = new System.Drawing.Point(26, 36);
            this.story2.Name = "story2";
            this.story2.Size = new System.Drawing.Size(879, 23);
            this.story2.TabIndex = 6;
            this.story2.Text = "label3";
            // 
            // gold_value
            // 
            this.gold_value.Location = new System.Drawing.Point(988, 8);
            this.gold_value.Name = "gold_value";
            this.gold_value.Size = new System.Drawing.Size(67, 23);
            this.gold_value.TabIndex = 7;
            this.gold_value.Text = "label4";
            // 
            // hp_value
            // 
            this.hp_value.Location = new System.Drawing.Point(988, 36);
            this.hp_value.Name = "hp_value";
            this.hp_value.Size = new System.Drawing.Size(67, 23);
            this.hp_value.TabIndex = 8;
            this.hp_value.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.hp_value);
            this.Controls.Add(this.gold_value);
            this.Controls.Add(this.story2);
            this.Controls.Add(this.story1);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label enemy_hp_value;

        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label gold_value;

        private System.Windows.Forms.Label story2;
        private System.Windows.Forms.Label hp_value;

        private System.Windows.Forms.Label story1;

        private System.Windows.Forms.PictureBox pictureBox;

        private System.Windows.Forms.Button donot_button;
        private System.Windows.Forms.Button doit_button;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button west_door;
        private System.Windows.Forms.Button north_door;
        private System.Windows.Forms.Button east_door;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}