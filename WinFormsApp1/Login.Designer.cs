namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            UidTb = new TextBox();
            PassTb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(548, 336);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 320);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Super Bubble", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 45);
            label1.TabIndex = 1;
            label1.Text = "Fitness System";
            label1.Click += label1_Click;
            // 
            // UidTb
            // 
            UidTb.Location = new Point(69, 336);
            UidTb.Name = "UidTb";
            UidTb.Size = new Size(408, 27);
            UidTb.TabIndex = 2;
            // 
            // PassTb
            // 
            PassTb.Location = new Point(69, 405);
            PassTb.Name = "PassTb";
            PassTb.PasswordChar = '*';
            PassTb.Size = new Size(408, 27);
            PassTb.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sunny Spells", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(69, 468);
            button1.Name = "button1";
            button1.Size = new Size(128, 73);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sunny Spells", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(355, 468);
            button2.Name = "button2";
            button2.Size = new Size(122, 73);
            button2.TabIndex = 5;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 300);
            label2.Name = "label2";
            label2.Size = new Size(160, 33);
            label2.TabIndex = 6;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 369);
            label3.Name = "label3";
            label3.Size = new Size(161, 33);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 654);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PassTb);
            Controls.Add(UidTb);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox UidTb;
        private TextBox PassTb;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}
