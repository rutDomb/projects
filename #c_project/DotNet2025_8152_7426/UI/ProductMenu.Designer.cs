
namespace UI
{
    partial class ProductMenu
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            add = new Button();
            category = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            QuantityInStock = new TextBox();
            price = new TextBox();
            name = new TextBox();
            tabPage2 = new TabPage();
            edit = new Button();
            catregoryEdit = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            QuantityInStockEdit = new TextBox();
            priceEdit = new TextBox();
            codeEdit = new TextBox();
            nameEdit = new TextBox();
            tabPage3 = new TabPage();
            delete = new Button();
            code = new TextBox();
            label5 = new Label();
            tabPage4 = new TabPage();
            textBox1 = new TextBox();
            readAll = new Button();
            filter = new Button();
            button1 = new Button();
            search = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            listBox1 = new ListBox();
            toolTip1 = new ToolTip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 85);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.Yes;
            tabControl1.RightToLeftLayout = true;
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(905, 490);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(add);
            tabPage1.Controls.Add(category);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(QuantityInStock);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(name);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.RightToLeft = RightToLeft.Yes;
            tabPage1.Size = new Size(897, 457);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            add.Location = new Point(393, 325);
            add.Name = "add";
            add.Size = new Size(137, 38);
            add.TabIndex = 4;
            add.Text = "הוסף";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "בגדים", "נעליים", "גרביים", "תיקים", "מכשירים" });
            category.Location = new Point(367, 130);
            category.Name = "category";
            category.Size = new Size(228, 28);
            category.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(623, 238);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 1;
            label3.Text = "כמות במלאי";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(648, 181);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 1;
            label4.Text = "מחיר";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(623, 135);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 1;
            label2.Text = "קטגוריה";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(619, 80);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 1;
            label1.Text = "שם מוצר";
            // 
            // QuantityInStock
            // 
            QuantityInStock.Location = new Point(367, 234);
            QuantityInStock.Name = "QuantityInStock";
            QuantityInStock.Size = new Size(228, 27);
            QuantityInStock.TabIndex = 0;
            // 
            // price
            // 
            price.Location = new Point(367, 181);
            price.Name = "price";
            price.Size = new Size(228, 27);
            price.TabIndex = 0;
            // 
            // name
            // 
            name.Location = new Point(367, 80);
            name.Name = "name";
            name.Size = new Size(228, 27);
            name.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(edit);
            tabPage2.Controls.Add(catregoryEdit);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(QuantityInStockEdit);
            tabPage2.Controls.Add(priceEdit);
            tabPage2.Controls.Add(codeEdit);
            tabPage2.Controls.Add(nameEdit);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(897, 457);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "עריכה";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            edit.Location = new Point(623, 379);
            edit.Name = "edit";
            edit.Size = new Size(137, 38);
            edit.TabIndex = 11;
            edit.Text = "עדכן";
            edit.UseVisualStyleBackColor = true;
            edit.Click += button1_Click;
            // 
            // catregoryEdit
            // 
            catregoryEdit.FormattingEnabled = true;
            catregoryEdit.Items.AddRange(new object[] { "בגדים", "נעליים", "גרביים", "תיקים", "מכשירים" });
            catregoryEdit.Location = new Point(489, 191);
            catregoryEdit.Name = "catregoryEdit";
            catregoryEdit.Size = new Size(228, 28);
            catregoryEdit.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(733, 309);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 6;
            label6.Text = "כמות במלאי";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(784, 251);
            label7.Name = "label7";
            label7.Size = new Size(47, 23);
            label7.TabIndex = 7;
            label7.Text = "מחיר";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(759, 196);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 8;
            label8.Text = "קטגוריה";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(759, 85);
            label10.Name = "label10";
            label10.Size = new Size(75, 23);
            label10.TabIndex = 9;
            label10.Text = "קוד מוצר";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(759, 138);
            label9.Name = "label9";
            label9.Size = new Size(76, 23);
            label9.TabIndex = 9;
            label9.Text = "שם מוצר";
            // 
            // QuantityInStockEdit
            // 
            QuantityInStockEdit.Location = new Point(489, 308);
            QuantityInStockEdit.Name = "QuantityInStockEdit";
            QuantityInStockEdit.Size = new Size(228, 27);
            QuantityInStockEdit.TabIndex = 3;
            // 
            // priceEdit
            // 
            priceEdit.Location = new Point(489, 247);
            priceEdit.Name = "priceEdit";
            priceEdit.Size = new Size(228, 27);
            priceEdit.TabIndex = 4;
            // 
            // codeEdit
            // 
            codeEdit.Location = new Point(489, 84);
            codeEdit.Name = "codeEdit";
            codeEdit.Size = new Size(228, 27);
            codeEdit.TabIndex = 5;
            // 
            // nameEdit
            // 
            nameEdit.Location = new Point(489, 137);
            nameEdit.Name = "nameEdit";
            nameEdit.Size = new Size(228, 27);
            nameEdit.TabIndex = 5;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(delete);
            tabPage3.Controls.Add(code);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(897, 457);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "מחיקה";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Location = new Point(437, 220);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 2;
            delete.Text = "מחק";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // code
            // 
            code.Location = new Point(377, 163);
            code.Name = "code";
            code.Size = new Size(209, 27);
            code.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(428, 105);
            label5.Name = "label5";
            label5.Size = new Size(138, 28);
            label5.TabIndex = 0;
            label5.Text = "הכנס קוד מוצר";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(readAll);
            tabPage4.Controls.Add(filter);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(search);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(listBox1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(897, 457);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "תצוגה";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "מוצרים שמחירם קטן מ200";
            // 
            // readAll
            // 
            readAll.Location = new Point(347, 94);
            readAll.Name = "readAll";
            readAll.Size = new Size(160, 29);
            readAll.TabIndex = 4;
            readAll.Text = "להצגת כל המוצרים";
            readAll.UseVisualStyleBackColor = true;
            readAll.Click += readAll_Click;
            // 
            // filter
            // 
            filter.Location = new Point(58, 75);
            filter.Name = "filter";
            filter.Size = new Size(94, 29);
            filter.TabIndex = 3;
            filter.Text = "סנן";
            filter.UseVisualStyleBackColor = true;
            filter.Click += filter_Click;
            // 
            // button1
            // 
            button1.Location = new Point(581, 74);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "חפש";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // search
            // 
            search.FormattingEnabled = true;
            search.Location = new Point(529, 40);
            search.Name = "search";
            search.Size = new Size(181, 28);
            search.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(715, 41);
            label12.Name = "label12";
            label12.Size = new Size(176, 23);
            label12.TabIndex = 1;
            label12.Text = "חיפוש לפי מזהה מוצר:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(195, 43);
            label11.Name = "label11";
            label11.Size = new Size(77, 23);
            label11.TabIndex = 1;
            label11.Text = "סינון לפי:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(888, 324);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.צילום_מסך_2025_04_21_202628;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 49);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ProductMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 581);
            Controls.Add(pictureBox1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductMenu";
            Text = "ProductMenu";
            Load += ProductMenu_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox name;
        private Label label1;
        private ComboBox category;
        private ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private TextBox price;
        private Label label4;
        private Label label3;
        private TextBox QuantityInStock;
        private Button add;
        private ListBox listBox1;
        private Label label5;
        private TextBox code;
        private Button delete;
        private Button edit;
        private ComboBox catregoryEdit;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox QuantityInStockEdit;
        private TextBox priceEdit;
        private TextBox nameEdit;
        private Label label10;
        private TextBox codeEdit;
        private Label label11;
        private ComboBox comboBox1;
        private ComboBox search;
        private Label label12;
        private Button filter;
        private Button button1;
        private PictureBox pictureBox1;
        private Button readAll;
        private TextBox textBox1;
    }
}