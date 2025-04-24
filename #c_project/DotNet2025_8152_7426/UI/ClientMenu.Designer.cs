namespace UI
{
    partial class ClientMenu
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            add = new Button();
            textPhone = new TextBox();
            textAddess = new TextBox();
            textName = new TextBox();
            textId = new TextBox();
            phone = new Label();
            address = new Label();
            name = new Label();
            id = new Label();
            update = new TabPage();
            button1 = new Button();
            phoneEdit = new TextBox();
            addressEdit = new TextBox();
            nameEdit = new TextBox();
            idEdit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            delete = new Button();
            idToDelete = new TextBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            textBox1 = new TextBox();
            readAll = new Button();
            filter = new Button();
            button2 = new Button();
            search = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            update.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(update);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(938, 479);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(add);
            tabPage1.Controls.Add(textPhone);
            tabPage1.Controls.Add(textAddess);
            tabPage1.Controls.Add(textName);
            tabPage1.Controls.Add(textId);
            tabPage1.Controls.Add(phone);
            tabPage1.Controls.Add(address);
            tabPage1.Controls.Add(name);
            tabPage1.Controls.Add(id);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(930, 446);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(592, 279);
            add.Name = "add";
            add.Size = new Size(106, 39);
            add.TabIndex = 2;
            add.Text = "הוסף";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(531, 211);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(181, 27);
            textPhone.TabIndex = 1;
            // 
            // textAddess
            // 
            textAddess.Location = new Point(531, 159);
            textAddess.Name = "textAddess";
            textAddess.Size = new Size(181, 27);
            textAddess.TabIndex = 1;
            // 
            // textName
            // 
            textName.Location = new Point(531, 111);
            textName.Name = "textName";
            textName.Size = new Size(181, 27);
            textName.TabIndex = 1;
            // 
            // textId
            // 
            textId.Location = new Point(478, 61);
            textId.Name = "textId";
            textId.Size = new Size(181, 27);
            textId.TabIndex = 1;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phone.Location = new Point(744, 212);
            phone.Name = "phone";
            phone.Size = new Size(52, 23);
            phone.TabIndex = 0;
            phone.Text = "טלפון";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(744, 162);
            address.Name = "address";
            address.Size = new Size(58, 23);
            address.TabIndex = 0;
            address.Text = "כתובת";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(731, 111);
            name.Name = "name";
            name.Size = new Size(71, 23);
            name.TabIndex = 0;
            name.Text = "שם מלא";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(674, 65);
            id.Name = "id";
            id.Size = new Size(128, 23);
            id.TabIndex = 0;
            id.Text = "מס' תעודת זהות";
            // 
            // update
            // 
            update.Controls.Add(button1);
            update.Controls.Add(phoneEdit);
            update.Controls.Add(addressEdit);
            update.Controls.Add(nameEdit);
            update.Controls.Add(idEdit);
            update.Controls.Add(label1);
            update.Controls.Add(label2);
            update.Controls.Add(label3);
            update.Controls.Add(label4);
            update.Location = new Point(4, 29);
            update.Name = "update";
            update.Padding = new Padding(3);
            update.Size = new Size(930, 446);
            update.TabIndex = 1;
            update.Text = "עידכון";
            update.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(606, 292);
            button1.Name = "button1";
            button1.Size = new Size(106, 39);
            button1.TabIndex = 11;
            button1.Text = "עדכן";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // phoneEdit
            // 
            phoneEdit.Location = new Point(545, 224);
            phoneEdit.Name = "phoneEdit";
            phoneEdit.Size = new Size(181, 27);
            phoneEdit.TabIndex = 7;
            // 
            // addressEdit
            // 
            addressEdit.Location = new Point(545, 172);
            addressEdit.Name = "addressEdit";
            addressEdit.Size = new Size(181, 27);
            addressEdit.TabIndex = 8;
            // 
            // nameEdit
            // 
            nameEdit.Location = new Point(545, 124);
            nameEdit.Name = "nameEdit";
            nameEdit.Size = new Size(181, 27);
            nameEdit.TabIndex = 9;
            // 
            // idEdit
            // 
            idEdit.Location = new Point(492, 74);
            idEdit.Name = "idEdit";
            idEdit.Size = new Size(181, 27);
            idEdit.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(758, 225);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 3;
            label1.Text = "טלפון";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(758, 175);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 4;
            label2.Text = "כתובת";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(745, 124);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 5;
            label3.Text = "שם מלא";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(688, 78);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 6;
            label4.Text = "מס' תעודת זהות";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(delete);
            tabPage3.Controls.Add(idToDelete);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(930, 446);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "מחיקה";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(406, 184);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 2;
            delete.Text = "מחק";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // idToDelete
            // 
            idToDelete.Location = new Point(331, 130);
            idToDelete.Name = "idToDelete";
            idToDelete.Size = new Size(232, 27);
            idToDelete.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(361, 92);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 0;
            label5.Text = "הכנס מס' תעודת זהות";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(readAll);
            tabPage4.Controls.Add(filter);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(search);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(listBox1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(930, 446);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "תצוגה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 27);
            textBox1.TabIndex = 13;
            textBox1.Text = "הלקוחות שאורך שמם קטן מ15 תוים";
            // 
            // readAll
            // 
            readAll.Location = new Point(372, 71);
            readAll.Name = "readAll";
            readAll.Size = new Size(160, 29);
            readAll.TabIndex = 12;
            readAll.Text = "להצגת כל הלקוחות";
            readAll.UseVisualStyleBackColor = true;
            readAll.Click += readAll_Click;
            // 
            // filter
            // 
            filter.Location = new Point(83, 54);
            filter.Name = "filter";
            filter.Size = new Size(94, 29);
            filter.TabIndex = 10;
            filter.Text = "סנן";
            filter.UseVisualStyleBackColor = true;
            filter.Click += filter_Click;
            // 
            // button2
            // 
            button2.Location = new Point(606, 51);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "חפש";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // search
            // 
            search.FormattingEnabled = true;
            search.Location = new Point(554, 17);
            search.Name = "search";
            search.Size = new Size(181, 28);
            search.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(740, 18);
            label12.Name = "label12";
            label12.Size = new Size(176, 23);
            label12.TabIndex = 7;
            label12.Text = "חיפוש לפי מזהה מוצר:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(252, 22);
            label11.Name = "label11";
            label11.Size = new Size(77, 23);
            label11.TabIndex = 8;
            label11.Text = "סינון לפי:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 114);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(922, 324);
            listBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.צילום_מסך_2025_04_21_202628;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 51);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ClientMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 537);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Name = "ClientMenu";
            Text = "ClientMenu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage update;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private PictureBox pictureBox1;
        private Label id;
        private Button add;
        private TextBox textPhone;
        private TextBox textAddess;
        private TextBox textName;
        private TextBox textId;
        private Label phone;
        private Label address;
        private Label name;
        private Button button1;
        private TextBox phoneEdit;
        private TextBox addressEdit;
        private TextBox nameEdit;
        private TextBox idEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button delete;
        private TextBox idToDelete;
        private Label label5;
        private TextBox textBox1;
        private Button readAll;
        private Button filter;
        private Button button2;
        private ComboBox search;
        private Label label12;
        private Label label11;
        private ListBox listBox1;
    }
}