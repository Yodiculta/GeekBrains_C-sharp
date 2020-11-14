namespace calculator
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
            this.pusk_but = new System.Windows.Forms.Button();
            this.exit_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pusk_but
            // 
            this.pusk_but.BackColor = System.Drawing.Color.Orchid;
            this.pusk_but.Font = new System.Drawing.Font("Segoe Script", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pusk_but.ForeColor = System.Drawing.Color.Purple;
            this.pusk_but.Location = new System.Drawing.Point(393, 210);
            this.pusk_but.Name = "pusk_but";
            this.pusk_but.Size = new System.Drawing.Size(245, 139);
            this.pusk_but.TabIndex = 0;
            this.pusk_but.Text = "PLAY";
            this.pusk_but.UseVisualStyleBackColor = false;
            this.pusk_but.Click += new System.EventHandler(this.pusk_but_Click);
            // 
            // exit_but
            // 
            this.exit_but.BackColor = System.Drawing.Color.Orchid;
            this.exit_but.Font = new System.Drawing.Font("Segoe Script", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_but.ForeColor = System.Drawing.Color.Purple;
            this.exit_but.Location = new System.Drawing.Point(393, 455);
            this.exit_but.Name = "exit_but";
            this.exit_but.Size = new System.Drawing.Size(245, 150);
            this.exit_but.TabIndex = 1;
            this.exit_but.Text = "EXIT";
            this.exit_but.UseVisualStyleBackColor = false;
            this.exit_but.Click += new System.EventHandler(this.exit_but_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1076, 733);
            this.Controls.Add(this.exit_but);
            this.Controls.Add(this.pusk_but);
            this.Name = "Form2";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pusk_but;
        private System.Windows.Forms.Button exit_but;
    }
}