namespace Guess_The_Number
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
            this.inf_lab = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.check_but = new System.Windows.Forms.Button();
            this.count_lab = new System.Windows.Forms.Label();
            this.number_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inf_lab
            // 
            this.inf_lab.AutoSize = true;
            this.inf_lab.BackColor = System.Drawing.Color.MistyRose;
            this.inf_lab.Enabled = false;
            this.inf_lab.Font = new System.Drawing.Font("Segoe Script", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inf_lab.Location = new System.Drawing.Point(75, 45);
            this.inf_lab.Name = "inf_lab";
            this.inf_lab.Size = new System.Drawing.Size(646, 146);
            this.inf_lab.TabIndex = 0;
            this.inf_lab.Text = "information";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(298, 322);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(100, 38);
            this.tb.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Enabled = false;
            this.lab.Location = new System.Drawing.Point(109, 243);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(266, 32);
            this.lab.TabIndex = 2;
            this.lab.Text = "number of attempts:";
            // 
            // check_but
            // 
            this.check_but.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.check_but.Location = new System.Drawing.Point(263, 386);
            this.check_but.Name = "check_but";
            this.check_but.Size = new System.Drawing.Size(192, 60);
            this.check_but.TabIndex = 3;
            this.check_but.Text = "Check";
            this.check_but.UseVisualStyleBackColor = true;
            this.check_but.Click += new System.EventHandler(this.check_but_Click);
            // 
            // count_lab
            // 
            this.count_lab.AutoSize = true;
            this.count_lab.Enabled = false;
            this.count_lab.Location = new System.Drawing.Point(395, 243);
            this.count_lab.Name = "count_lab";
            this.count_lab.Size = new System.Drawing.Size(31, 32);
            this.count_lab.TabIndex = 4;
            this.count_lab.Text = "0";
            // 
            // number_l
            // 
            this.number_l.AutoSize = true;
            this.number_l.BackColor = System.Drawing.Color.MistyRose;
            this.number_l.Enabled = false;
            this.number_l.Font = new System.Drawing.Font("Segoe Script", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_l.Location = new System.Drawing.Point(75, 476);
            this.number_l.Name = "number_l";
            this.number_l.Size = new System.Drawing.Size(431, 146);
            this.number_l.TabIndex = 5;
            this.number_l.Text = "number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 686);
            this.Controls.Add(this.number_l);
            this.Controls.Add(this.count_lab);
            this.Controls.Add(this.check_but);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.inf_lab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inf_lab;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button check_but;
        private System.Windows.Forms.Label count_lab;
        private System.Windows.Forms.Label number_l;
    }
}

