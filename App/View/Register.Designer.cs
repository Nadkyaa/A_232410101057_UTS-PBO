namespace A_1057_UTS_PBO.App.View
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small Semibol", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 31);
            label1.Name = "label1";
            label1.Size = new Size(473, 80);
            label1.TabIndex = 0;
            label1.Text = "Daftarkan Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 144);
            label2.Name = "label2";
            label2.Size = new Size(185, 40);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 256);
            label4.Name = "label4";
            label4.Size = new Size(185, 40);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(280, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(280, 27);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(597, 365);
            button1.Name = "button1";
            button1.Size = new Size(164, 40);
            button1.TabIndex = 6;
            button1.Text = "Daftarkan";
            button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}