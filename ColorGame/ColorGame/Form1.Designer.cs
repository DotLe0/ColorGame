namespace ColorGame
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
            this.bnt_Red = new System.Windows.Forms.Button();
            this.bnt_Green = new System.Windows.Forms.Button();
            this.bnt_blue = new System.Windows.Forms.Button();
            this.bnt_yellow = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.bnt_play = new System.Windows.Forms.Button();
            this.bnt_checkOrder = new System.Windows.Forms.Button();
            this.lbl_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnt_Red
            // 
            this.bnt_Red.BackColor = System.Drawing.Color.Red;
            this.bnt_Red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnt_Red.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bnt_Red.FlatAppearance.BorderSize = 0;
            this.bnt_Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Red.ForeColor = System.Drawing.Color.White;
            this.bnt_Red.Location = new System.Drawing.Point(12, 115);
            this.bnt_Red.Name = "bnt_Red";
            this.bnt_Red.Size = new System.Drawing.Size(105, 129);
            this.bnt_Red.TabIndex = 0;
            this.bnt_Red.UseVisualStyleBackColor = false;
            this.bnt_Red.Click += new System.EventHandler(this.bnt_Red_Click);
            // 
            // bnt_Green
            // 
            this.bnt_Green.BackColor = System.Drawing.Color.Lime;
            this.bnt_Green.FlatAppearance.BorderSize = 0;
            this.bnt_Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Green.Location = new System.Drawing.Point(134, 115);
            this.bnt_Green.Name = "bnt_Green";
            this.bnt_Green.Size = new System.Drawing.Size(105, 129);
            this.bnt_Green.TabIndex = 1;
            this.bnt_Green.UseVisualStyleBackColor = false;
            this.bnt_Green.Click += new System.EventHandler(this.bnt_Green_Click);
            // 
            // bnt_blue
            // 
            this.bnt_blue.BackColor = System.Drawing.Color.Cyan;
            this.bnt_blue.FlatAppearance.BorderSize = 0;
            this.bnt_blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_blue.Location = new System.Drawing.Point(12, 260);
            this.bnt_blue.Name = "bnt_blue";
            this.bnt_blue.Size = new System.Drawing.Size(105, 129);
            this.bnt_blue.TabIndex = 2;
            this.bnt_blue.UseVisualStyleBackColor = false;
            this.bnt_blue.Click += new System.EventHandler(this.bnt_blue_Click);
            // 
            // bnt_yellow
            // 
            this.bnt_yellow.BackColor = System.Drawing.Color.Yellow;
            this.bnt_yellow.FlatAppearance.BorderSize = 0;
            this.bnt_yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_yellow.Location = new System.Drawing.Point(134, 260);
            this.bnt_yellow.Name = "bnt_yellow";
            this.bnt_yellow.Size = new System.Drawing.Size(105, 129);
            this.bnt_yellow.TabIndex = 3;
            this.bnt_yellow.UseVisualStyleBackColor = false;
            this.bnt_yellow.Click += new System.EventHandler(this.bnt_yellow_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl_score.ForeColor = System.Drawing.Color.White;
            this.lbl_score.Location = new System.Drawing.Point(12, 72);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(77, 25);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "[score]";
            // 
            // bnt_play
            // 
            this.bnt_play.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bnt_play.Location = new System.Drawing.Point(12, 13);
            this.bnt_play.Name = "bnt_play";
            this.bnt_play.Size = new System.Drawing.Size(75, 44);
            this.bnt_play.TabIndex = 6;
            this.bnt_play.Text = "Play";
            this.bnt_play.UseVisualStyleBackColor = true;
            this.bnt_play.Click += new System.EventHandler(this.bnt_play_Click);
            // 
            // bnt_checkOrder
            // 
            this.bnt_checkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.bnt_checkOrder.Location = new System.Drawing.Point(164, 13);
            this.bnt_checkOrder.Name = "bnt_checkOrder";
            this.bnt_checkOrder.Size = new System.Drawing.Size(75, 44);
            this.bnt_checkOrder.TabIndex = 7;
            this.bnt_checkOrder.Text = "Check order";
            this.bnt_checkOrder.UseVisualStyleBackColor = true;
            this.bnt_checkOrder.Click += new System.EventHandler(this.bnt_checkOrder_Click);
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.lbl_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl_state.ForeColor = System.Drawing.Color.White;
            this.lbl_state.Location = new System.Drawing.Point(93, 21);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(62, 25);
            this.lbl_state.TabIndex = 8;
            this.lbl_state.Text = "State";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(254, 400);
            this.Controls.Add(this.lbl_state);
            this.Controls.Add(this.bnt_checkOrder);
            this.Controls.Add(this.bnt_play);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.bnt_yellow);
            this.Controls.Add(this.bnt_blue);
            this.Controls.Add(this.bnt_Green);
            this.Controls.Add(this.bnt_Red);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnt_Red;
        private System.Windows.Forms.Button bnt_Green;
        private System.Windows.Forms.Button bnt_blue;
        private System.Windows.Forms.Button bnt_yellow;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button bnt_play;
        private System.Windows.Forms.Button bnt_checkOrder;
        private System.Windows.Forms.Label lbl_state;
    }
}

