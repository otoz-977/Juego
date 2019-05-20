namespace juego
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.choice_two = new System.Windows.Forms.RadioButton();
            this.choice_one = new System.Windows.Forms.RadioButton();
            this.Ans = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(30, 322);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(750, 78);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Ans);
            this.panel1.Controls.Add(this.choice_two);
            this.panel1.Controls.Add(this.choice_one);
            this.panel1.Location = new System.Drawing.Point(41, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 44);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // choice_two
            // 
            this.choice_two.AutoSize = true;
            this.choice_two.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_two.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choice_two.Location = new System.Drawing.Point(182, 5);
            this.choice_two.Name = "choice_two";
            this.choice_two.Size = new System.Drawing.Size(131, 29);
            this.choice_two.TabIndex = 1;
            this.choice_two.TabStop = true;
            this.choice_two.Text = "radioButton2";
            this.choice_two.UseVisualStyleBackColor = true;
            this.choice_two.CheckedChanged += new System.EventHandler(this.choice_two_CheckedChanged);
            // 
            // choice_one
            // 
            this.choice_one.AutoSize = true;
            this.choice_one.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_one.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choice_one.Location = new System.Drawing.Point(45, 5);
            this.choice_one.Name = "choice_one";
            this.choice_one.Size = new System.Drawing.Size(131, 29);
            this.choice_one.TabIndex = 0;
            this.choice_one.TabStop = true;
            this.choice_one.Text = "radioButton1";
            this.choice_one.UseVisualStyleBackColor = true;
            this.choice_one.CheckedChanged += new System.EventHandler(this.choice_one_CheckedChanged);
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(386, 15);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(71, 20);
            this.Ans.TabIndex = 2;
            this.Ans.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::juego.Properties.Resources.main_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton choice_two;
        private System.Windows.Forms.RadioButton choice_one;
        private System.Windows.Forms.TextBox Ans;
    }
}

