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
            this.east_door = new System.Windows.Forms.Button();
            this.north_door = new System.Windows.Forms.Button();
            this.west_door = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(688, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "gold";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.east_door);
            this.panel1.Controls.Add(this.north_door);
            this.panel1.Controls.Add(this.west_door);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 426);
            this.panel1.TabIndex = 1;
            // 
            // east_door
            // 
            this.east_door.Location = new System.Drawing.Point(565, 288);
            this.east_door.Name = "east_door";
            this.east_door.Size = new System.Drawing.Size(102, 135);
            this.east_door.TabIndex = 3;
            this.east_door.Text = "Osten";
            this.east_door.UseVisualStyleBackColor = true;
            this.east_door.Click += new System.EventHandler(this.east_door_Click);
            // 
            // north_door
            // 
            this.north_door.Location = new System.Drawing.Point(279, 3);
            this.north_door.Name = "north_door";
            this.north_door.Size = new System.Drawing.Size(102, 135);
            this.north_door.TabIndex = 2;
            this.north_door.Text = "Norden";
            this.north_door.UseVisualStyleBackColor = true;
            this.north_door.Click += new System.EventHandler(this.north_door_Click);
            // 
            // west_door
            // 
            this.west_door.Location = new System.Drawing.Point(3, 288);
            this.west_door.Name = "west_door";
            this.west_door.Size = new System.Drawing.Size(102, 135);
            this.west_door.TabIndex = 1;
            this.west_door.Text = "Westen";
            this.west_door.UseVisualStyleBackColor = true;
            this.west_door.Click += new System.EventHandler(this.west_door_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button west_door;
        private System.Windows.Forms.Button north_door;
        private System.Windows.Forms.Button east_door;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}