namespace UI
{
    partial class management
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
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(598, 156);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(176, 116);
            button4.TabIndex = 0;
            button4.Text = "לקוחות";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(376, 156);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(176, 116);
            button1.TabIndex = 0;
            button1.Text = "מבצעים";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 156);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(176, 116);
            button2.TabIndex = 0;
            button2.Text = "מוצרים";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.צילום_מסך_2025_04_21_202628;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 51);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Margin = new Padding(3, 4, 3, 4);
            Name = "management";
            Text = "management";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}