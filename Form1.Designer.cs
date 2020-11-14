namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.answer_lab = new System.Windows.Forms.Label();
            this.mult_button = new System.Windows.Forms.Button();
            this.plus_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.plus_lab = new System.Windows.Forms.Label();
            this.mult_lab = new System.Windows.Forms.Label();
            this.num_lab = new System.Windows.Forms.Label();
            this.back_but = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer_lab
            // 
            this.answer_lab.AutoSize = true;
            this.answer_lab.Font = new System.Drawing.Font("Segoe Script", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer_lab.ForeColor = System.Drawing.Color.Purple;
            this.answer_lab.Location = new System.Drawing.Point(484, 91);
            this.answer_lab.Name = "answer_lab";
            this.answer_lab.Size = new System.Drawing.Size(69, 80);
            this.answer_lab.TabIndex = 4;
            this.answer_lab.Text = "1";
            // 
            // mult_button
            // 
            this.mult_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mult_button.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mult_button.ForeColor = System.Drawing.Color.DarkMagenta;
            this.mult_button.Location = new System.Drawing.Point(811, 314);
            this.mult_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mult_button.Name = "mult_button";
            this.mult_button.Size = new System.Drawing.Size(165, 182);
            this.mult_button.TabIndex = 8;
            this.mult_button.Text = "*2";
            this.mult_button.UseVisualStyleBackColor = false;
            this.mult_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // plus_button
            // 
            this.plus_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.plus_button.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_button.ForeColor = System.Drawing.Color.DarkMagenta;
            this.plus_button.Location = new System.Drawing.Point(569, 314);
            this.plus_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(167, 182);
            this.plus_button.TabIndex = 9;
            this.plus_button.Text = "+1";
            this.plus_button.UseVisualStyleBackColor = false;
            this.plus_button.Click += new System.EventHandler(this._plusOne_Click);
            // 
            // reset_button
            // 
            this.reset_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.reset_button.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset_button.ForeColor = System.Drawing.Color.DarkMagenta;
            this.reset_button.Location = new System.Drawing.Point(617, 520);
            this.reset_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(313, 192);
            this.reset_button.TabIndex = 10;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = false;
            this.reset_button.Click += new System.EventHandler(this.reset_but_Click);
            // 
            // plus_lab
            // 
            this.plus_lab.AutoSize = true;
            this.plus_lab.BackColor = System.Drawing.Color.Thistle;
            this.plus_lab.Enabled = false;
            this.plus_lab.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus_lab.ForeColor = System.Drawing.Color.Purple;
            this.plus_lab.Location = new System.Drawing.Point(595, 234);
            this.plus_lab.Name = "plus_lab";
            this.plus_lab.Size = new System.Drawing.Size(58, 67);
            this.plus_lab.TabIndex = 11;
            this.plus_lab.Text = "0";
            // 
            // mult_lab
            // 
            this.mult_lab.AutoSize = true;
            this.mult_lab.BackColor = System.Drawing.Color.Thistle;
            this.mult_lab.Enabled = false;
            this.mult_lab.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mult_lab.ForeColor = System.Drawing.Color.Purple;
            this.mult_lab.Location = new System.Drawing.Point(814, 234);
            this.mult_lab.Name = "mult_lab";
            this.mult_lab.Size = new System.Drawing.Size(58, 67);
            this.mult_lab.TabIndex = 12;
            this.mult_lab.Text = "0";
            // 
            // num_lab
            // 
            this.num_lab.AutoSize = true;
            this.num_lab.BackColor = System.Drawing.Color.Violet;
            this.num_lab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.num_lab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num_lab.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.num_lab.ForeColor = System.Drawing.Color.Purple;
            this.num_lab.Location = new System.Drawing.Point(120, 234);
            this.num_lab.Name = "num_lab";
            this.num_lab.Size = new System.Drawing.Size(327, 107);
            this.num_lab.TabIndex = 15;
            this.num_lab.Text = "NUMBER";
            // 
            // back_but
            // 
            this.back_but.Location = new System.Drawing.Point(742, 73);
            this.back_but.Name = "back_but";
            this.back_but.Size = new System.Drawing.Size(260, 80);
            this.back_but.TabIndex = 16;
            this.back_but.Text = "Back";
            this.back_but.UseVisualStyleBackColor = true;
            this.back_but.Click += new System.EventHandler(this.back_but_Click);
            // 
            // play_button
            // 
            this.play_button.BackColor = System.Drawing.Color.Plum;
            this.play_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_button.Font = new System.Drawing.Font("Segoe Script", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.play_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.play_button.Location = new System.Drawing.Point(82, 388);
            this.play_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(430, 248);
            this.play_button.TabIndex = 14;
            this.play_button.Text = "Close";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1076, 733);
            this.Controls.Add(this.back_but);
            this.Controls.Add(this.num_lab);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.mult_lab);
            this.Controls.Add(this.plus_lab);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.mult_button);
            this.Controls.Add(this.answer_lab);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe Script", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Purple;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label answer_lab;
        private System.Windows.Forms.Button mult_button;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Label plus_lab;
        private System.Windows.Forms.Label mult_lab;
        public System.Windows.Forms.Label num_lab;
        private System.Windows.Forms.Button back_but;
        private System.Windows.Forms.Button play_button;
    }
}

