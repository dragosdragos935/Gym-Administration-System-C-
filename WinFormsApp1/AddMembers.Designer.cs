namespace WinFormsApp1
{
    partial class AddMembers
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
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            Label label7;
            Label label8;
            Button button2;
            Button button1;
            Button button3;
            Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMembers));
            NameTb = new TextBox();
            PhoneTb = new TextBox();
            AgeTb = new TextBox();
            GenderCb = new ComboBox();
            AmountTb = new TextBox();
            TimingCb = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Super Bubble", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 60);
            label1.TabIndex = 1;
            label1.Text = "Fitness Center";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sunny Spells", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(431, 69);
            label2.Name = "label2";
            label2.Size = new Size(195, 48);
            label2.TabIndex = 2;
            label2.Text = "Add new member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(54, 175);
            label3.Name = "label3";
            label3.Size = new Size(171, 27);
            label3.TabIndex = 3;
            label3.Text = "Member Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(54, 268);
            label4.Name = "label4";
            label4.Size = new Size(186, 27);
            label4.TabIndex = 5;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(54, 353);
            label5.Name = "label5";
            label5.Size = new Size(53, 27);
            label5.TabIndex = 7;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(54, 436);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(378, 175);
            label7.Name = "label7";
            label7.Size = new Size(215, 27);
            label7.TabIndex = 11;
            label7.Text = "Monthly Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(378, 268);
            label8.Name = "label8";
            label8.Size = new Size(91, 27);
            label8.TabIndex = 13;
            label8.Text = "Timing";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(309, 541);
            button2.Name = "button2";
            button2.Size = new Size(118, 53);
            button2.TabIndex = 16;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(454, 541);
            button1.Name = "button1";
            button1.Size = new Size(118, 53);
            button1.TabIndex = 17;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(595, 541);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 18;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(309, 620);
            label9.Name = "label9";
            label9.Size = new Size(443, 27);
            label9.TabIndex = 19;
            label9.Text = "Developed by: Matei Dragos Catalin";
            // 
            // NameTb
            // 
            NameTb.BackColor = SystemColors.Window;
            NameTb.BorderStyle = BorderStyle.None;
            NameTb.Cursor = Cursors.IBeam;
            NameTb.Location = new Point(54, 205);
            NameTb.Multiline = true;
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(239, 34);
            NameTb.TabIndex = 4;
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = SystemColors.Window;
            PhoneTb.BorderStyle = BorderStyle.None;
            PhoneTb.Cursor = Cursors.IBeam;
            PhoneTb.Location = new Point(54, 298);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(239, 34);
            PhoneTb.TabIndex = 6;
            // 
            // AgeTb
            // 
            AgeTb.BackColor = SystemColors.Window;
            AgeTb.BorderStyle = BorderStyle.None;
            AgeTb.Cursor = Cursors.IBeam;
            AgeTb.Location = new Point(54, 383);
            AgeTb.Multiline = true;
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(239, 34);
            AgeTb.TabIndex = 8;
            // 
            // GenderCb
            // 
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Men", "Female", "Another" });
            GenderCb.Location = new Point(54, 466);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(151, 28);
            GenderCb.TabIndex = 9;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = SystemColors.Window;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Cursor = Cursors.IBeam;
            AmountTb.Location = new Point(378, 205);
            AmountTb.Multiline = true;
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(239, 34);
            AmountTb.TabIndex = 12;
            // 
            // TimingCb
            // 
            TimingCb.FormattingEnabled = true;
            TimingCb.Items.AddRange(new object[] { "6Am-6Pm", "All Day", "Half of Day" });
            TimingCb.Location = new Point(378, 304);
            TimingCb.Name = "TimingCb";
            TimingCb.Size = new Size(151, 28);
            TimingCb.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(878, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1033, 684);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(TimingCb);
            Controls.Add(label8);
            Controls.Add(AmountTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(GenderCb);
            Controls.Add(AgeTb);
            Controls.Add(label5);
            Controls.Add(PhoneTb);
            Controls.Add(label4);
            Controls.Add(NameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMembers";
            Text = "AddMembers";
            Load += AddMembers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTb;
        private TextBox PhoneTb;
        private Label label4;
        private TextBox AgeTb;
        private Label label5;
        private ComboBox GenderCb;
        private Label label6;
        private TextBox AmountTb;
        private Label label7;
        private Label label8;
        private ComboBox TimingCb;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label9;
        private PictureBox pictureBox1;
    }
}
