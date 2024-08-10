namespace WinFormsApp1
{
    partial class Payment
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
            Label label2;
            Label label1;
            Label label5;
            Label label3;
            Label label4;
            Button button3;
            Button button1;
            Button button2;
            Button button4;
            Button button5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            AmountTb = new TextBox();
            Perioder = new DateTimePicker();
            PaymentDGV = new DataGridView();
            pictureBox1 = new PictureBox();
            NameCb = new ComboBox();
            SearchName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sunny Spells", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(512, 69);
            label2.Name = "label2";
            label2.Size = new Size(115, 48);
            label2.TabIndex = 25;
            label2.Text = "Payments";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Super Bubble", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(419, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 60);
            label1.TabIndex = 24;
            label1.Text = "Fitness Center";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(50, 371);
            label5.Name = "label5";
            label5.Size = new Size(171, 27);
            label5.TabIndex = 30;
            label5.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 469);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 32;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(50, 249);
            label4.Name = "label4";
            label4.Size = new Size(200, 27);
            label4.TabIndex = 34;
            label4.Text = "Payment Month";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(39, 624);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 41;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(175, 565);
            button1.Name = "button1";
            button1.Size = new Size(157, 53);
            button1.TabIndex = 40;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(39, 565);
            button2.Name = "button2";
            button2.Size = new Size(118, 53);
            button2.TabIndex = 39;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(683, 115);
            button4.Name = "button4";
            button4.Size = new Size(157, 53);
            button4.TabIndex = 46;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(846, 115);
            button5.Name = "button5";
            button5.Size = new Size(157, 53);
            button5.TabIndex = 47;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // AmountTb
            // 
            AmountTb.AcceptsReturn = true;
            AmountTb.AcceptsTab = true;
            AmountTb.AllowDrop = true;
            AmountTb.BackColor = SystemColors.Window;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Cursor = Cursors.IBeam;
            AmountTb.Location = new Point(50, 499);
            AmountTb.Multiline = true;
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(239, 34);
            AmountTb.TabIndex = 33;
            AmountTb.TextChanged += AmountTb_TextChanged;
            // 
            // Perioder
            // 
            Perioder.Location = new Point(39, 303);
            Perioder.Name = "Perioder";
            Perioder.Size = new Size(250, 27);
            Perioder.TabIndex = 35;
            // 
            // PaymentDGV
            // 
            PaymentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDGV.Location = new Point(438, 175);
            PaymentDGV.Name = "PaymentDGV";
            PaymentDGV.RowHeadersWidth = 51;
            PaymentDGV.Size = new Size(698, 483);
            PaymentDGV.TabIndex = 42;
            PaymentDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(984, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // NameCb
            // 
            NameCb.FormattingEnabled = true;
            NameCb.Items.AddRange(new object[] { "6Am-6Pm", "All Day", "Half of Day" });
            NameCb.Location = new Point(50, 421);
            NameCb.Name = "NameCb";
            NameCb.Size = new Size(264, 28);
            NameCb.TabIndex = 44;
            NameCb.SelectedIndexChanged += NameCb_SelectedIndexChanged;
            // 
            // SearchName
            // 
            SearchName.AcceptsReturn = true;
            SearchName.AcceptsTab = true;
            SearchName.AllowDrop = true;
            SearchName.BackColor = SystemColors.Window;
            SearchName.BorderStyle = BorderStyle.None;
            SearchName.Cursor = Cursors.IBeam;
            SearchName.Location = new Point(438, 135);
            SearchName.Multiline = true;
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(239, 34);
            SearchName.TabIndex = 45;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1221, 693);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(SearchName);
            Controls.Add(NameCb);
            Controls.Add(pictureBox1);
            Controls.Add(PaymentDGV);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(Perioder);
            Controls.Add(label4);
            Controls.Add(AmountTb);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker Perioder;
        private DataGridView PaymentDGV;
        private TextBox AmountTb;
        private PictureBox pictureBox1;
        private ComboBox NameCb;
        private TextBox SearchName;
    }
}