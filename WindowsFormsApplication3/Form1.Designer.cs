namespace WindowsFormsApplication3
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
            this.components = new System.ComponentModel.Container();
            this.Play = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numcount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Lime;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(98, 146);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseCompatibleTextRendering = true;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.button1_Click);
            this.Play.MouseEnter += new System.EventHandler(this.Play_MouseEnter_1);
            this.Play.MouseLeave += new System.EventHandler(this.Play_MouseLeave_1);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 20.25F);
            this.Title.ForeColor = System.Drawing.Color.Lime;
            this.Title.Location = new System.Drawing.Point(12, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(271, 38);
            this.Title.TabIndex = 1;
            this.Title.Text = "Space Nordic Skiing";
            // 
            // numcount
            // 
            this.numcount.AutoSize = true;
            this.numcount.ForeColor = System.Drawing.Color.Lime;
            this.numcount.Location = new System.Drawing.Point(191, 127);
            this.numcount.Name = "numcount";
            this.numcount.Size = new System.Drawing.Size(24, 13);
            this.numcount.TabIndex = 2;
            this.numcount.Text = "test";
            this.numcount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numcount);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label numcount;
    }
}

