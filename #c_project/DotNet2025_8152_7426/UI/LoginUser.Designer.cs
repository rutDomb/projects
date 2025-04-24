namespace UI
{
    partial class LoginUser
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
            id = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(301, 114);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 0;
            label1.Text = "הכנס תעודת זהות";
            // 
            // id
            // 
            id.Location = new Point(275, 173);
            id.Name = "id";
            id.Size = new Size(206, 27);
            id.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(326, 242);
            button1.Name = "button1";
            button1.Size = new Size(110, 40);
            button1.TabIndex = 2;
            button1.Text = "כניסה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(id);
            Controls.Add(label1);
            Name = "LoginUser";
            Text = "LoginUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox id;
        private Button button1;
    }
}