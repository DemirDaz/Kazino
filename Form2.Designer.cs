namespace Kazino
{
    partial class Form2
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
            this.roll = new System.Windows.Forms.Button();
            this.spin1 = new System.Windows.Forms.PictureBox();
            this.spin2 = new System.Windows.Forms.PictureBox();
            this.spin3 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            this.SuspendLayout();
            // 
            // roll
            // 
            this.roll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roll.BackColor = System.Drawing.Color.Transparent;
            this.roll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roll.CausesValidation = false;
            this.roll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roll.FlatAppearance.BorderSize = 0;
            this.roll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.roll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.roll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roll.ForeColor = System.Drawing.Color.Transparent;
            this.roll.Location = new System.Drawing.Point(780, 114);
            this.roll.Margin = new System.Windows.Forms.Padding(0);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(62, 52);
            this.roll.TabIndex = 0;
            this.roll.UseVisualStyleBackColor = false;
            this.roll.Click += new System.EventHandler(this.button1_Click);
            // 
            // spin1
            // 
            this.spin1.BackColor = System.Drawing.Color.Transparent;
            this.spin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spin1.ErrorImage = null;
            this.spin1.InitialImage = null;
            this.spin1.Location = new System.Drawing.Point(512, 212);
            this.spin1.Name = "spin1";
            this.spin1.Size = new System.Drawing.Size(49, 56);
            this.spin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spin1.TabIndex = 1;
            this.spin1.TabStop = false;
            this.spin1.Visible = false;
            // 
            // spin2
            // 
            this.spin2.BackColor = System.Drawing.Color.Transparent;
            this.spin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spin2.ErrorImage = null;
            this.spin2.InitialImage = null;
            this.spin2.Location = new System.Drawing.Point(593, 212);
            this.spin2.Name = "spin2";
            this.spin2.Size = new System.Drawing.Size(49, 56);
            this.spin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spin2.TabIndex = 1;
            this.spin2.TabStop = false;
            this.spin2.Visible = false;
            // 
            // spin3
            // 
            this.spin3.BackColor = System.Drawing.Color.Transparent;
            this.spin3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.spin3.ErrorImage = null;
            this.spin3.InitialImage = null;
            this.spin3.Location = new System.Drawing.Point(673, 212);
            this.spin3.Name = "spin3";
            this.spin3.Size = new System.Drawing.Size(49, 56);
            this.spin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spin3.TabIndex = 1;
            this.spin3.TabStop = false;
            this.spin3.Visible = false;
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.ErrorImage = null;
            this.score.Image = global::Kazino.Properties.Resources.gogo;
            this.score.InitialImage = null;
            this.score.Location = new System.Drawing.Point(-5, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(877, 419);
            this.score.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.score.TabIndex = 2;
            this.score.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kazino.Properties.Resources.casino3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 418);
            this.Controls.Add(this.score);
            this.Controls.Add(this.spin3);
            this.Controls.Add(this.spin2);
            this.Controls.Add(this.spin1);
            this.Controls.Add(this.roll);
            this.MinimumSize = new System.Drawing.Size(881, 457);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.spin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button roll;
        private System.Windows.Forms.PictureBox spin1;
        private System.Windows.Forms.PictureBox spin2;
        private System.Windows.Forms.PictureBox spin3;
        private System.Windows.Forms.PictureBox score;
    }
}