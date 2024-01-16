namespace DatabaseSQLSelfImprovementApp
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_description = new TextBox();
            txt_imageURL = new TextBox();
            txt_channelYear = new TextBox();
            txt_hostName = new TextBox();
            txt_channelName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(545, 10);
            button1.Name = "button1";
            button1.Size = new Size(107, 29);
            button1.TabIndex = 0;
            button1.Text = "Load Channels";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(545, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(588, 202);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(1042, 10);
            button2.Name = "button2";
            button2.Size = new Size(91, 28);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(658, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(291, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_imageURL);
            groupBox1.Controls.Add(txt_channelYear);
            groupBox1.Controls.Add(txt_hostName);
            groupBox1.Controls.Add(txt_channelName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 237);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Channel";
            // 
            // button3
            // 
            button3.Location = new Point(11, 195);
            button3.Name = "button3";
            button3.Size = new Size(244, 26);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(103, 160);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(152, 23);
            txt_description.TabIndex = 9;
            // 
            // txt_imageURL
            // 
            txt_imageURL.Location = new Point(103, 127);
            txt_imageURL.Name = "txt_imageURL";
            txt_imageURL.Size = new Size(152, 23);
            txt_imageURL.TabIndex = 8;
            // 
            // txt_channelYear
            // 
            txt_channelYear.Location = new Point(103, 91);
            txt_channelYear.Name = "txt_channelYear";
            txt_channelYear.Size = new Size(152, 23);
            txt_channelYear.TabIndex = 7;
            // 
            // txt_hostName
            // 
            txt_hostName.Location = new Point(103, 55);
            txt_hostName.Name = "txt_hostName";
            txt_hostName.Size = new Size(152, 23);
            txt_hostName.TabIndex = 6;
            // 
            // txt_channelName
            // 
            txt_channelName.Location = new Point(103, 24);
            txt_channelName.Name = "txt_channelName";
            txt_channelName.Size = new Size(152, 23);
            txt_channelName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 163);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 129);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 95);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 61);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Host";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 27);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Channel Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(545, 268);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(588, 213);
            dataGridView2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(545, 250);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 8;
            label6.Text = "Videos";
            // 
            // button4
            // 
            button4.Location = new Point(545, 487);
            button4.Name = "button4";
            button4.Size = new Size(588, 26);
            button4.TabIndex = 9;
            button4.Text = "Delete Selected Track";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(527, 261);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 525);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Self Improvement Channels";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private TextBox txt_imageURL;
        private TextBox txt_channelYear;
        private TextBox txt_hostName;
        private TextBox txt_channelName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private TextBox txt_description;
        private DataGridView dataGridView2;
        private Label label6;
        private Button button4;
        private PictureBox pictureBox2;
    }
}
