namespace WinFormsApp1
{
    partial class ViewMembers
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
            TextBox SearchMember;
            Label label5;
            Button button1;
            Button button2;
            Button button3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMembers));
            MemberSDVG = new DataGridView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            SearchMember = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberSDVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sunny Spells", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(539, 69);
            label2.Name = "label2";
            label2.Size = new Size(162, 48);
            label2.TabIndex = 23;
            label2.Text = "View Members";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Super Bubble", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(446, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 60);
            label1.TabIndex = 22;
            label1.Text = "Fitness Center";
            // 
            // SearchMember
            // 
            SearchMember.BackColor = SystemColors.Window;
            SearchMember.BorderStyle = BorderStyle.None;
            SearchMember.Cursor = Cursors.IBeam;
            SearchMember.Location = new Point(12, 59);
            SearchMember.Multiline = true;
            SearchMember.Name = "SearchMember";
            SearchMember.Size = new Size(239, 34);
            SearchMember.TabIndex = 29;
            SearchMember.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 29);
            label5.Name = "label5";
            label5.Size = new Size(72, 27);
            label5.TabIndex = 28;
            label5.Text = "Name";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(151, 99);
            button1.Name = "button1";
            button1.Size = new Size(157, 53);
            button1.TabIndex = 37;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(15, 99);
            button2.Name = "button2";
            button2.Size = new Size(118, 53);
            button2.TabIndex = 36;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(15, 158);
            button3.Name = "button3";
            button3.Size = new Size(118, 53);
            button3.TabIndex = 38;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MemberSDVG
            // 
            MemberSDVG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberSDVG.Location = new Point(359, 120);
            MemberSDVG.Name = "MemberSDVG";
            MemberSDVG.RowHeadersWidth = 51;
            MemberSDVG.Size = new Size(795, 515);
            MemberSDVG.TabIndex = 39;
            MemberSDVG.CellContentClick += MemberSDVG_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1039, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ViewMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1308, 664);
            Controls.Add(pictureBox1);
            Controls.Add(MemberSDVG);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(SearchMember);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMembers";
            Text = "ViewMembers";
            Load += ViewMembers_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SearchMember;
        private DataGridView MemberSDVG;
        private PictureBox pictureBox1;
    }
}