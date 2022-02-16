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
            this.retry = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(700, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gold";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.retry);
            this.panel1.Controls.Add(this.enemy_hp_value);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.doit_button);
            this.panel1.Controls.Add(this.donot_button);
            this.panel1.Controls.Add(this.east_door);
            this.panel1.Controls.Add(this.north_door);
            this.panel1.Controls.Add(this.west_door);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 385);
            this.panel1.TabIndex = 1;
            // 
            // retry
            // 
            this.retry.Location = new System.Drawing.Point(320, 324);
            this.retry.Name = "retry";
            this.retry.Size = new System.Drawing.Size(108, 58);
            this.retry.TabIndex = 8;
            this.retry.Text = "Retry";
            this.retry.UseVisualStyleBackColor = true;
            this.retry.Visible = false;
            this.retry.Click += new System.EventHandler(this.retry_Click);
            // 
            // enemy_hp_value
            // 
            this.enemy_hp_value.Location = new System.Drawing.Point(282, 103);
            this.enemy_hp_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enemy_hp_value.Name = "enemy_hp_value";
            this.enemy_hp_value.Size = new System.Drawing.Size(180, 19);
            this.enemy_hp_value.TabIndex = 7;
            this.enemy_hp_value.Text = "label2";
            this.enemy_hp_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(282, 124);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(180, 195);
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // doit_button
            // 
            this.doit_button.Enabled = false;
            this.doit_button.Location = new System.Drawing.Point(434, 325);
            this.doit_button.Name = "doit_button";
            this.doit_button.Size = new System.Drawing.Size(154, 57);
            this.doit_button.TabIndex = 5;
            this.doit_button.Text = "button2";
            this.doit_button.UseVisualStyleBackColor = true;
            this.doit_button.Visible = false;
            this.doit_button.Click += new System.EventHandler(this.doit_button_Click);
            // 
            // donot_button
            // 
            this.donot_button.Enabled = false;
            this.donot_button.Location = new System.Drawing.Point(160, 325);
            this.donot_button.Name = "donot_button";
            this.donot_button.Size = new System.Drawing.Size(154, 57);
            this.donot_button.TabIndex = 4;
            this.donot_button.Text = "button1";
            this.donot_button.UseVisualStyleBackColor = true;
            this.donot_button.Visible = false;
            this.donot_button.Click += new System.EventHandler(this.donot_button_Click);
            // 
            // east_door
            // 
            this.east_door.Location = new System.Drawing.Point(637, 247);
            this.east_door.Name = "east_door";
            this.east_door.Size = new System.Drawing.Size(102, 135);
            this.east_door.TabIndex = 3;
            this.east_door.Text = "Osten";
            this.east_door.UseVisualStyleBackColor = true;
            this.east_door.Click += new System.EventHandler(this.east_door_Click);
            // 
            // north_door
            // 
            this.north_door.Location = new System.Drawing.Point(290, 3);
            this.north_door.Name = "north_door";
            this.north_door.Size = new System.Drawing.Size(162, 85);
            this.north_door.TabIndex = 2;
            this.north_door.Text = "Norden";
            this.north_door.UseVisualStyleBackColor = true;
            this.north_door.Click += new System.EventHandler(this.north_door_Click);
            // 
            // west_door
            // 
            this.west_door.Location = new System.Drawing.Point(3, 247);
            this.west_door.Name = "west_door";
            this.west_door.Size = new System.Drawing.Size(102, 135);
            this.west_door.TabIndex = 1;
            this.west_door.Text = "Westen";
            this.west_door.UseVisualStyleBackColor = true;
            this.west_door.Click += new System.EventHandler(this.west_door_Click);
            // 
            // HP
            // 
            this.HP.Location = new System.Drawing.Point(700, 29);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(27, 23);
            this.HP.TabIndex = 4;
            this.HP.Text = "HP";
            // 
            // story1
            // 
            this.story1.Location = new System.Drawing.Point(20, 6);
            this.story1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.story1.Name = "story1";
            this.story1.Size = new System.Drawing.Size(659, 19);
            this.story1.TabIndex = 5;
            // 
            // story2
            // 
            this.story2.Location = new System.Drawing.Point(20, 29);
            this.story2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.story2.Name = "story2";
            this.story2.Size = new System.Drawing.Size(659, 19);
            this.story2.TabIndex = 6;
            // 
            // gold_value
            // 
            this.gold_value.Location = new System.Drawing.Point(741, 6);
            this.gold_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gold_value.Name = "gold_value";
            this.gold_value.Size = new System.Drawing.Size(50, 19);
            this.gold_value.TabIndex = 7;
            this.gold_value.Text = "label4";
            // 
            // hp_value
            // 
            this.hp_value.Location = new System.Drawing.Point(741, 29);
            this.hp_value.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hp_value.Name = "hp_value";
            this.hp_value.Size = new System.Drawing.Size(50, 19);
            this.hp_value.TabIndex = 8;
            this.hp_value.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hp_value);
            this.Controls.Add(this.gold_value);
            this.Controls.Add(this.story2);
            this.Controls.Add(this.story1);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }

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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button west_door;
        private System.Windows.Forms.Button north_door;
        private System.Windows.Forms.Button east_door;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}