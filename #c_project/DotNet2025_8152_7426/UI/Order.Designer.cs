namespace UI
{
    partial class Order
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amount = new NumericUpDown();
            addToOrder = new Button();
            ShoppingCart = new ListBox();
            toOrder = new Button();
            label4 = new Label();
            salesOfProduct = new ListBox();
            label6 = new Label();
            button1 = new Button();
            nameProduct = new ComboBox();
            label5 = new Label();
            totalPrice = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.צילום_מסך_2025_04_21_202628;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 51);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Adobe Devanagari", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 25);
            label1.Name = "label1";
            label1.Size = new Size(140, 38);
            label1.TabIndex = 1;
            label1.Text = "ביצוע הזמנה";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(703, 121);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 2;
            label2.Text = "שם מוצר";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(670, 167);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 2;
            label3.Text = "כמות להזמנה";
            // 
            // amount
            // 
            amount.Location = new Point(506, 163);
            amount.Name = "amount";
            amount.Size = new Size(150, 27);
            amount.TabIndex = 4;
            // 
            // addToOrder
            // 
            addToOrder.Location = new Point(595, 212);
            addToOrder.Name = "addToOrder";
            addToOrder.Size = new Size(102, 33);
            addToOrder.TabIndex = 5;
            addToOrder.Text = "הוסף לסל";
            addToOrder.UseVisualStyleBackColor = true;
            addToOrder.Click += addToOrder_Click;
            // 
            // ShoppingCart
            // 
            ShoppingCart.FormattingEnabled = true;
            ShoppingCart.Location = new Point(32, 111);
            ShoppingCart.Name = "ShoppingCart";
            ShoppingCart.RightToLeft = RightToLeft.Yes;
            ShoppingCart.Size = new Size(374, 304);
            ShoppingCart.TabIndex = 6;
            // 
            // toOrder
            // 
            toOrder.Location = new Point(32, 441);
            toOrder.Name = "toOrder";
            toOrder.Size = new Size(121, 32);
            toOrder.TabIndex = 7;
            toOrder.Text = "ביצוע הזמנה";
            toOrder.UseVisualStyleBackColor = true;
            toOrder.Click += toOrder_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(162, 77);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 8;
            label4.Text = "סל קניות";
            // 
            // salesOfProduct
            // 
            salesOfProduct.FormattingEnabled = true;
            salesOfProduct.Location = new Point(422, 291);
            salesOfProduct.Name = "salesOfProduct";
            salesOfProduct.Size = new Size(384, 124);
            salesOfProduct.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 268);
            label6.Name = "label6";
            label6.Size = new Size(181, 20);
            label6.TabIndex = 10;
            label6.Text = ":רשימת מבצעים של המוצר";
            // 
            // button1
            // 
            button1.Location = new Point(579, 421);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "הצג";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameProduct
            // 
            nameProduct.FormattingEnabled = true;
            nameProduct.Location = new Point(506, 120);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(184, 28);
            nameProduct.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(357, 421);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 14;
            label5.Text = "ס\"הכ";
            // 
            // totalPrice
            // 
            totalPrice.Location = new Point(241, 418);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(103, 27);
            totalPrice.TabIndex = 15;
            totalPrice.TextChanged += totalPrice_TextChanged;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 485);
            Controls.Add(totalPrice);
            Controls.Add(label5);
            Controls.Add(nameProduct);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(salesOfProduct);
            Controls.Add(label4);
            Controls.Add(toOrder);
            Controls.Add(ShoppingCart);
            Controls.Add(addToOrder);
            Controls.Add(amount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown amount;
        private Button addToOrder;
        private ListBox ShoppingCart;
        private Button toOrder;
        private Label label4;
        private ListBox salesOfProduct;
        private Label label6;
        private Button button1;
        private ComboBox nameProduct;
        private Label label5;
        private TextBox totalPrice;
    }
}