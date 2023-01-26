namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Sin = new System.Windows.Forms.Button();
            this.button_plusPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Sin
            // 
            this.button_Sin.Location = new System.Drawing.Point(196, 257);
            this.button_Sin.Name = "button_Sin";
            this.button_Sin.Size = new System.Drawing.Size(112, 34);
            this.button_Sin.TabIndex = 2;
            this.button_Sin.Text = "Sin";
            this.button_Sin.UseVisualStyleBackColor = true;
            this.button_Sin.Click += new System.EventHandler(this.button_Sin_Click);
            // 
            // button_plusPlus
            // 
            this.button_plusPlus.Location = new System.Drawing.Point(470, 257);
            this.button_plusPlus.Name = "button_plusPlus";
            this.button_plusPlus.Size = new System.Drawing.Size(112, 34);
            this.button_plusPlus.TabIndex = 3;
            this.button_plusPlus.Text = "++";
            this.button_plusPlus.UseVisualStyleBackColor = true;
            this.button_plusPlus.Click += new System.EventHandler(this.button_plusPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_plusPlus);
            this.Controls.Add(this.button_Sin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button_Sin;
        private Button button_plusPlus;
    }
}