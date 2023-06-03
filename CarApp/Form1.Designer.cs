namespace CarApp
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.makeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.conditionCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yearNud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.colorTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.transferCaseCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.engineSizeCbx = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.priceNud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeCarBtn = new System.Windows.Forms.Button();
            this.inventoryLst = new System.Windows.Forms.ListBox();
            this.storeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkoutBtn = new System.Windows.Forms.Button();
            this.shoppingLst = new System.Windows.Forms.ListBox();
            this.addShoppingBtn = new System.Windows.Forms.Button();
            this.removeShoppingBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNud)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNud)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 882);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Cart";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.addCarBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 860);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.makeTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 30);
            this.panel1.TabIndex = 6;
            // 
            // makeTxt
            // 
            this.makeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.makeTxt.Location = new System.Drawing.Point(91, 3);
            this.makeTxt.Name = "makeTxt";
            this.makeTxt.Size = new System.Drawing.Size(305, 23);
            this.makeTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Make";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.modelTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 30);
            this.panel2.TabIndex = 6;
            // 
            // modelTxt
            // 
            this.modelTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modelTxt.Location = new System.Drawing.Point(91, 3);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(305, 23);
            this.modelTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.conditionCbx);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(3, 75);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(397, 30);
            this.panel7.TabIndex = 6;
            // 
            // conditionCbx
            // 
            this.conditionCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conditionCbx.FormattingEnabled = true;
            this.conditionCbx.Location = new System.Drawing.Point(91, 3);
            this.conditionCbx.Name = "conditionCbx";
            this.conditionCbx.Size = new System.Drawing.Size(305, 23);
            this.conditionCbx.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Condition";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.yearNud);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 30);
            this.panel3.TabIndex = 6;
            // 
            // yearNud
            // 
            this.yearNud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yearNud.Location = new System.Drawing.Point(91, 3);
            this.yearNud.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNud.Minimum = new decimal(new int[] {
            1672,
            0,
            0,
            0});
            this.yearNud.Name = "yearNud";
            this.yearNud.Size = new System.Drawing.Size(305, 23);
            this.yearNud.TabIndex = 2;
            this.yearNud.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.colorTxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(3, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 30);
            this.panel4.TabIndex = 6;
            // 
            // colorTxt
            // 
            this.colorTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorTxt.Location = new System.Drawing.Point(91, 3);
            this.colorTxt.Name = "colorTxt";
            this.colorTxt.Size = new System.Drawing.Size(305, 23);
            this.colorTxt.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Color";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.transferCaseCbx);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(3, 183);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(397, 30);
            this.panel5.TabIndex = 6;
            // 
            // transferCaseCbx
            // 
            this.transferCaseCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transferCaseCbx.FormattingEnabled = true;
            this.transferCaseCbx.Location = new System.Drawing.Point(91, 0);
            this.transferCaseCbx.Name = "transferCaseCbx";
            this.transferCaseCbx.Size = new System.Drawing.Size(305, 23);
            this.transferCaseCbx.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Transfer Case";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.engineSizeCbx);
            this.panel8.Location = new System.Drawing.Point(3, 219);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(397, 30);
            this.panel8.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Engine Size";
            // 
            // engineSizeCbx
            // 
            this.engineSizeCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.engineSizeCbx.FormattingEnabled = true;
            this.engineSizeCbx.Location = new System.Drawing.Point(91, 3);
            this.engineSizeCbx.Name = "engineSizeCbx";
            this.engineSizeCbx.Size = new System.Drawing.Size(305, 23);
            this.engineSizeCbx.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.priceNud);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(3, 255);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(397, 30);
            this.panel6.TabIndex = 6;
            // 
            // priceNud
            // 
            this.priceNud.Location = new System.Drawing.Point(91, 4);
            this.priceNud.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNud.Name = "priceNud";
            this.priceNud.Size = new System.Drawing.Size(310, 23);
            this.priceNud.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(3, 291);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(202, 23);
            this.addCarBtn.TabIndex = 7;
            this.addCarBtn.Text = "Add Car";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.removeCarBtn);
            this.groupBox2.Controls.Add(this.inventoryLst);
            this.groupBox2.Location = new System.Drawing.Point(430, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 883);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory";
            // 
            // removeCarBtn
            // 
            this.removeCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeCarBtn.Location = new System.Drawing.Point(6, 854);
            this.removeCarBtn.Name = "removeCarBtn";
            this.removeCarBtn.Size = new System.Drawing.Size(158, 23);
            this.removeCarBtn.TabIndex = 1;
            this.removeCarBtn.Text = "Remove Car";
            this.removeCarBtn.UseVisualStyleBackColor = true;
            this.removeCarBtn.Click += new System.EventHandler(this.removeCarBtn_Click);
            // 
            // inventoryLst
            // 
            this.inventoryLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryLst.FormattingEnabled = true;
            this.inventoryLst.ItemHeight = 15;
            this.inventoryLst.Location = new System.Drawing.Point(3, 19);
            this.inventoryLst.Name = "inventoryLst";
            this.inventoryLst.Size = new System.Drawing.Size(525, 829);
            this.inventoryLst.TabIndex = 0;
            // 
            // storeBindingSource
            // 
            this.storeBindingSource.DataSource = typeof(SalesKingAuto.Store);
            // 
            // storeBindingSource1
            // 
            this.storeBindingSource1.DataSource = typeof(SalesKingAuto.Store);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.totalLbl);
            this.groupBox3.Controls.Add(this.taxLbl);
            this.groupBox3.Controls.Add(this.subtotalLbl);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.checkoutBtn);
            this.groupBox3.Controls.Add(this.shoppingLst);
            this.groupBox3.Location = new System.Drawing.Point(1133, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 883);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(204, 839);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(34, 15);
            this.totalLbl.TabIndex = 2;
            this.totalLbl.Text = "$0.00";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(204, 811);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(23, 15);
            this.taxLbl.TabIndex = 2;
            this.taxLbl.Text = "0%";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(204, 794);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(34, 15);
            this.subtotalLbl.TabIndex = 2;
            this.subtotalLbl.Text = "$0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 839);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 824);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "--------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 809);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tax:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 794);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Subtotal:";
            // 
            // checkoutBtn
            // 
            this.checkoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkoutBtn.Location = new System.Drawing.Point(6, 794);
            this.checkoutBtn.Name = "checkoutBtn";
            this.checkoutBtn.Size = new System.Drawing.Size(132, 32);
            this.checkoutBtn.TabIndex = 1;
            this.checkoutBtn.Text = "Checkout";
            this.checkoutBtn.UseVisualStyleBackColor = true;
            this.checkoutBtn.Click += new System.EventHandler(this.checkoutBtn_Click);
            // 
            // shoppingLst
            // 
            this.shoppingLst.FormattingEnabled = true;
            this.shoppingLst.ItemHeight = 15;
            this.shoppingLst.Location = new System.Drawing.Point(6, 19);
            this.shoppingLst.Name = "shoppingLst";
            this.shoppingLst.Size = new System.Drawing.Size(503, 769);
            this.shoppingLst.TabIndex = 0;
            // 
            // addShoppingBtn
            // 
            this.addShoppingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addShoppingBtn.Location = new System.Drawing.Point(967, 252);
            this.addShoppingBtn.Name = "addShoppingBtn";
            this.addShoppingBtn.Size = new System.Drawing.Size(160, 50);
            this.addShoppingBtn.TabIndex = 3;
            this.addShoppingBtn.Text = "Add Cart ->";
            this.addShoppingBtn.UseVisualStyleBackColor = true;
            this.addShoppingBtn.Click += new System.EventHandler(this.addShoppingBtn_Click);
            // 
            // removeShoppingBtn
            // 
            this.removeShoppingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeShoppingBtn.Location = new System.Drawing.Point(964, 367);
            this.removeShoppingBtn.Name = "removeShoppingBtn";
            this.removeShoppingBtn.Size = new System.Drawing.Size(160, 50);
            this.removeShoppingBtn.TabIndex = 4;
            this.removeShoppingBtn.Text = "<- Remove Cart";
            this.removeShoppingBtn.UseVisualStyleBackColor = true;
            this.removeShoppingBtn.Click += new System.EventHandler(this.removeShoppingBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 906);
            this.Controls.Add(this.removeShoppingBtn);
            this.Controls.Add(this.addShoppingBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sales King Automotive";
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearNud)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceNud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeBindingSource1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox modelTxt;
        private TextBox makeTxt;
        private TextBox colorTxt;
        private ComboBox engineSizeCbx;
        private ComboBox conditionCbx;
        private ComboBox transferCaseCbx;
        private NumericUpDown yearNud;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Button addCarBtn;
        private GroupBox groupBox2;
        private ListBox inventoryLst;
        private BindingSource storeBindingSource;
        private BindingSource storeBindingSource1;
        private Button removeCarBtn;
        private GroupBox groupBox3;
        private Button addShoppingBtn;
        private Button removeShoppingBtn;
        private Label totalLbl;
        private Label taxLbl;
        private Label subtotalLbl;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button checkoutBtn;
        private ListBox shoppingLst;
        private NumericUpDown priceNud;
    }
}