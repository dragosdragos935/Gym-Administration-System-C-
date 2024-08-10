namespace WinFormsApp1
{
    partial class UpdateDelete
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
            Label label9;
            Button button3;
            Button button1;
            Button button2;
            Label label8;
            Label label7;
            Label label6;
            Label label5;
            Label label4;
            Label label3;
            Label label2;
            Label label1;
            Button button4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDelete));
            TimingCb = new ComboBox();
            AmountTb = new TextBox();
            GenderCb = new ComboBox();
            AgeTb = new TextBox();
            PhoneTb = new TextBox();
            NameTb = new TextBox();
            MemberSDVG = new DataGridView();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberSDVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(434, 631);
            label9.Name = "label9";
            label9.Size = new Size(443, 27);
            label9.TabIndex = 37;
            label9.Text = "Developed by: Matei Dragos Catalin";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(284, 541);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 36;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(148, 541);
            button1.Name = "button1";
            button1.Size = new Size(118, 53);
            button1.TabIndex = 35;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 541);
            button2.Name = "button2";
            button2.Size = new Size(118, 53);
            button2.TabIndex = 34;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 462);
            label8.Name = "label8";
            label8.Size = new Size(91, 27);
            label8.TabIndex = 32;
            label8.Text = "Timing";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 369);
            label7.Name = "label7";
            label7.Size = new Size(215, 27);
            label7.TabIndex = 30;
            label7.Text = "Monthly Amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 295);
            label6.Name = "label6";
            label6.Size = new Size(98, 27);
            label6.TabIndex = 29;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(27, 212);
            label5.Name = "label5";
            label5.Size = new Size(53, 27);
            label5.TabIndex = 26;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 127);
            label4.Name = "label4";
            label4.Size = new Size(186, 27);
            label4.TabIndex = 24;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 34);
            label3.Name = "label3";
            label3.Size = new Size(171, 27);
            label3.TabIndex = 22;
            label3.Text = "Member Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sunny Spells", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(556, 80);
            label2.Name = "label2";
            label2.Size = new Size(140, 48);
            label2.TabIndex = 21;
            label2.Text = "Update User";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Super Bubble", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(463, 20);
            label1.Name = "label1";
            label1.Size = new Size(408, 60);
            label1.TabIndex = 20;
            label1.Text = "Fitness Center";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 605);
            button4.Name = "button4";
            button4.Size = new Size(118, 53);
            button4.TabIndex = 41;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TimingCb
            // 
            TimingCb.AllowDrop = true;
            TimingCb.FormattingEnabled = true;
            TimingCb.Items.AddRange(new object[] { "6Am-6Pm", "All Day", "Half of Day" });
            TimingCb.Location = new Point(27, 498);
            TimingCb.Name = "TimingCb";
            TimingCb.Size = new Size(151, 28);
            TimingCb.TabIndex = 33;
            // 
            // AmountTb
            // 
            AmountTb.AllowDrop = true;
            AmountTb.BackColor = SystemColors.Window;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Cursor = Cursors.IBeam;
            AmountTb.Location = new Point(27, 399);
            AmountTb.Multiline = true;
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(239, 34);
            AmountTb.TabIndex = 31;
            // 
            // GenderCb
            // 
            GenderCb.AllowDrop = true;
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Men", "Female", "Another" });
            GenderCb.Location = new Point(27, 325);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(151, 28);
            GenderCb.TabIndex = 28;
            // 
            // AgeTb
            // 
            AgeTb.AllowDrop = true;
            AgeTb.BackColor = SystemColors.Window;
            AgeTb.BorderStyle = BorderStyle.None;
            AgeTb.Cursor = Cursors.IBeam;
            AgeTb.Location = new Point(27, 242);
            AgeTb.Multiline = true;
            AgeTb.Name = "AgeTb";
            AgeTb.Size = new Size(239, 34);
            AgeTb.TabIndex = 27;
            // 
            // PhoneTb
            // 
            PhoneTb.AllowDrop = true;
            PhoneTb.BackColor = SystemColors.Window;
            PhoneTb.BorderStyle = BorderStyle.None;
            PhoneTb.Cursor = Cursors.IBeam;
            PhoneTb.Location = new Point(27, 157);
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(239, 34);
            PhoneTb.TabIndex = 25;
            // 
            // NameTb
            // 
            NameTb.AllowDrop = true;
            NameTb.BackColor = SystemColors.Window;
            NameTb.BorderStyle = BorderStyle.None;
            NameTb.Cursor = Cursors.IBeam;
            NameTb.Location = new Point(27, 64);
            NameTb.Multiline = true;
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(239, 34);
            NameTb.TabIndex = 23;
            NameTb.TextChanged += NameTb_TextChanged;
            // 
            // MemberSDVG
            // 
            MemberSDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberSDVG.Location = new Point(422, 131);
            MemberSDVG.Name = "MemberSDVG";
            MemberSDVG.RowHeadersWidth = 51;
            MemberSDVG.Size = new Size(704, 465);
            MemberSDVG.TabIndex = 40;
            MemberSDVG.CellContentClick += MemberSDVG_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1047, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // UpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1194, 666);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(MemberSDVG);
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
            Name = "UpdateDelete";
            Text = "UpdateDelete";
            Load += UpdateDelete_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NameTb;
        private TextBox PhoneTb;
        private TextBox AgeTb;
        private ComboBox GenderCb;
        private TextBox AmountTb;
        private ComboBox TimingCb;
        private DataGridView MemberSDVG;
        private PictureBox pictureBox1;
    }
}