namespace kursovayaKuznetsova
{
    partial class SellerWorkSpace
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.additionalTools = new System.Windows.Forms.Label();
            this.newItems = new System.Windows.Forms.Button();
            this.purchaseReturn = new System.Windows.Forms.Button();
            this.CloseShift = new System.Windows.Forms.Button();
            this.accountChange = new System.Windows.Forms.Button();
            this.dayRequest = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.sellLabel = new System.Windows.Forms.Label();
            this.addItemGroup = new System.Windows.Forms.GroupBox();
            this.itemDiscountGroup = new System.Windows.Forms.GroupBox();
            this.itemDiscountValue = new System.Windows.Forms.NumericUpDown();
            this.itemDiscountLabel = new System.Windows.Forms.Label();
            this.itemSelfCostDiscount = new System.Windows.Forms.RadioButton();
            this.itemFixedDiscount = new System.Windows.Forms.RadioButton();
            this.itemPercentDiscount = new System.Windows.Forms.RadioButton();
            this.itemWithoutDiscount = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.Button();
            this.itemCount = new System.Windows.Forms.NumericUpDown();
            this.itemPicker = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.terminalPay = new System.Windows.Forms.Button();
            this.moneyPay = new System.Windows.Forms.Button();
            this.mixPay = new System.Windows.Forms.Button();
            this.createRequest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.addItemGroup.SuspendLayout();
            this.itemDiscountGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDiscountValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.37654F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.62346F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.25974F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.74026F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 387);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.additionalTools);
            this.flowLayoutPanel1.Controls.Add(this.newItems);
            this.flowLayoutPanel1.Controls.Add(this.purchaseReturn);
            this.flowLayoutPanel1.Controls.Add(this.CloseShift);
            this.flowLayoutPanel1.Controls.Add(this.accountChange);
            this.flowLayoutPanel1.Controls.Add(this.dayRequest);
            this.flowLayoutPanel1.Controls.Add(this.createRequest);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(139, 381);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // additionalTools
            // 
            this.additionalTools.AutoSize = true;
            this.additionalTools.Location = new System.Drawing.Point(8, 5);
            this.additionalTools.Name = "additionalTools";
            this.additionalTools.Size = new System.Drawing.Size(87, 13);
            this.additionalTools.TabIndex = 0;
            this.additionalTools.Text = "Дополнительно";
            // 
            // newItems
            // 
            this.newItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newItems.AutoSize = true;
            this.newItems.Location = new System.Drawing.Point(8, 21);
            this.newItems.Name = "newItems";
            this.newItems.Size = new System.Drawing.Size(130, 23);
            this.newItems.TabIndex = 1;
            this.newItems.Text = "Приход товара";
            this.newItems.UseVisualStyleBackColor = true;
            // 
            // purchaseReturn
            // 
            this.purchaseReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseReturn.Location = new System.Drawing.Point(8, 50);
            this.purchaseReturn.Name = "purchaseReturn";
            this.purchaseReturn.Size = new System.Drawing.Size(130, 23);
            this.purchaseReturn.TabIndex = 2;
            this.purchaseReturn.Text = "Возврат";
            this.purchaseReturn.UseVisualStyleBackColor = true;
            // 
            // CloseShift
            // 
            this.CloseShift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseShift.Location = new System.Drawing.Point(8, 79);
            this.CloseShift.Name = "CloseShift";
            this.CloseShift.Size = new System.Drawing.Size(130, 23);
            this.CloseShift.TabIndex = 3;
            this.CloseShift.Text = "Закрыть смену";
            this.CloseShift.UseVisualStyleBackColor = true;
            // 
            // accountChange
            // 
            this.accountChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountChange.Location = new System.Drawing.Point(8, 108);
            this.accountChange.Name = "accountChange";
            this.accountChange.Size = new System.Drawing.Size(130, 41);
            this.accountChange.TabIndex = 4;
            this.accountChange.Text = "Изменить информацию о себе";
            this.accountChange.UseVisualStyleBackColor = true;
            // 
            // dayRequest
            // 
            this.dayRequest.Location = new System.Drawing.Point(8, 155);
            this.dayRequest.Name = "dayRequest";
            this.dayRequest.Size = new System.Drawing.Size(130, 23);
            this.dayRequest.TabIndex = 5;
            this.dayRequest.Text = "Отчет за сегодня";
            this.dayRequest.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.sellLabel);
            this.flowLayoutPanel2.Controls.Add(this.addItemGroup);
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Controls.Add(this.terminalPay);
            this.flowLayoutPanel2.Controls.Add(this.moneyPay);
            this.flowLayoutPanel2.Controls.Add(this.mixPay);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(148, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(498, 381);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // sellLabel
            // 
            this.sellLabel.AutoSize = true;
            this.sellLabel.Location = new System.Drawing.Point(8, 5);
            this.sellLabel.Name = "sellLabel";
            this.sellLabel.Size = new System.Drawing.Size(53, 13);
            this.sellLabel.TabIndex = 0;
            this.sellLabel.Text = "Продажа";
            // 
            // addItemGroup
            // 
            this.addItemGroup.Controls.Add(this.itemDiscountGroup);
            this.addItemGroup.Controls.Add(this.add);
            this.addItemGroup.Controls.Add(this.itemCount);
            this.addItemGroup.Controls.Add(this.itemPicker);
            this.addItemGroup.Location = new System.Drawing.Point(8, 21);
            this.addItemGroup.Name = "addItemGroup";
            this.addItemGroup.Size = new System.Drawing.Size(481, 163);
            this.addItemGroup.TabIndex = 1;
            this.addItemGroup.TabStop = false;
            this.addItemGroup.Text = "Добавить товар";
            // 
            // itemDiscountGroup
            // 
            this.itemDiscountGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDiscountGroup.AutoSize = true;
            this.itemDiscountGroup.Controls.Add(this.itemDiscountValue);
            this.itemDiscountGroup.Controls.Add(this.itemDiscountLabel);
            this.itemDiscountGroup.Controls.Add(this.itemSelfCostDiscount);
            this.itemDiscountGroup.Controls.Add(this.itemFixedDiscount);
            this.itemDiscountGroup.Controls.Add(this.itemPercentDiscount);
            this.itemDiscountGroup.Controls.Add(this.itemWithoutDiscount);
            this.itemDiscountGroup.Location = new System.Drawing.Point(7, 47);
            this.itemDiscountGroup.Name = "itemDiscountGroup";
            this.itemDiscountGroup.Size = new System.Drawing.Size(468, 81);
            this.itemDiscountGroup.TabIndex = 4;
            this.itemDiscountGroup.TabStop = false;
            this.itemDiscountGroup.Text = "Скидка на отдельный товар";
            // 
            // itemDiscountValue
            // 
            this.itemDiscountValue.Enabled = false;
            this.itemDiscountValue.Location = new System.Drawing.Point(107, 42);
            this.itemDiscountValue.Name = "itemDiscountValue";
            this.itemDiscountValue.Size = new System.Drawing.Size(120, 20);
            this.itemDiscountValue.TabIndex = 5;
            // 
            // itemDiscountLabel
            // 
            this.itemDiscountLabel.AutoSize = true;
            this.itemDiscountLabel.Enabled = false;
            this.itemDiscountLabel.Location = new System.Drawing.Point(7, 44);
            this.itemDiscountLabel.Name = "itemDiscountLabel";
            this.itemDiscountLabel.Size = new System.Drawing.Size(94, 13);
            this.itemDiscountLabel.TabIndex = 4;
            this.itemDiscountLabel.Text = "Значение скидки";
            // 
            // itemSelfCostDiscount
            // 
            this.itemSelfCostDiscount.AutoSize = true;
            this.itemSelfCostDiscount.Location = new System.Drawing.Point(287, 19);
            this.itemSelfCostDiscount.Name = "itemSelfCostDiscount";
            this.itemSelfCostDiscount.Size = new System.Drawing.Size(120, 17);
            this.itemSelfCostDiscount.TabIndex = 3;
            this.itemSelfCostDiscount.Text = "По себестоимости";
            this.itemSelfCostDiscount.UseVisualStyleBackColor = true;
            // 
            // itemFixedDiscount
            // 
            this.itemFixedDiscount.AutoSize = true;
            this.itemFixedDiscount.Location = new System.Drawing.Point(186, 20);
            this.itemFixedDiscount.Name = "itemFixedDiscount";
            this.itemFixedDiscount.Size = new System.Drawing.Size(95, 17);
            this.itemFixedDiscount.TabIndex = 2;
            this.itemFixedDiscount.Text = "Выбрать цену";
            this.itemFixedDiscount.UseVisualStyleBackColor = true;
            // 
            // itemPercentDiscount
            // 
            this.itemPercentDiscount.AutoSize = true;
            this.itemPercentDiscount.Location = new System.Drawing.Point(99, 20);
            this.itemPercentDiscount.Name = "itemPercentDiscount";
            this.itemPercentDiscount.Size = new System.Drawing.Size(87, 17);
            this.itemPercentDiscount.TabIndex = 1;
            this.itemPercentDiscount.Text = "В процентах";
            this.itemPercentDiscount.UseVisualStyleBackColor = true;
            // 
            // itemWithoutDiscount
            // 
            this.itemWithoutDiscount.AutoSize = true;
            this.itemWithoutDiscount.Checked = true;
            this.itemWithoutDiscount.Location = new System.Drawing.Point(7, 20);
            this.itemWithoutDiscount.Name = "itemWithoutDiscount";
            this.itemWithoutDiscount.Size = new System.Drawing.Size(83, 17);
            this.itemWithoutDiscount.TabIndex = 0;
            this.itemWithoutDiscount.TabStop = true;
            this.itemWithoutDiscount.Text = "Без скидки";
            this.itemWithoutDiscount.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(3, 134);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(472, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            // 
            // itemCount
            // 
            this.itemCount.Location = new System.Drawing.Point(385, 21);
            this.itemCount.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(90, 20);
            this.itemCount.TabIndex = 2;
            this.itemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemPicker
            // 
            this.itemPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPicker.FormattingEnabled = true;
            this.itemPicker.Location = new System.Drawing.Point(7, 20);
            this.itemPicker.Name = "itemPicker";
            this.itemPicker.Size = new System.Drawing.Size(372, 21);
            this.itemPicker.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(481, 112);
            this.dataGridView1.TabIndex = 2;
            // 
            // terminalPay
            // 
            this.terminalPay.Location = new System.Drawing.Point(8, 308);
            this.terminalPay.Name = "terminalPay";
            this.terminalPay.Size = new System.Drawing.Size(161, 61);
            this.terminalPay.TabIndex = 3;
            this.terminalPay.Text = "Продать по терминалу";
            this.terminalPay.UseVisualStyleBackColor = true;
            // 
            // moneyPay
            // 
            this.moneyPay.Location = new System.Drawing.Point(175, 308);
            this.moneyPay.Name = "moneyPay";
            this.moneyPay.Size = new System.Drawing.Size(160, 61);
            this.moneyPay.TabIndex = 4;
            this.moneyPay.Text = "Продать наличными";
            this.moneyPay.UseVisualStyleBackColor = true;
            // 
            // mixPay
            // 
            this.mixPay.Location = new System.Drawing.Point(341, 308);
            this.mixPay.Name = "mixPay";
            this.mixPay.Size = new System.Drawing.Size(148, 61);
            this.mixPay.TabIndex = 5;
            this.mixPay.Text = "Смешанная оплата";
            this.mixPay.UseVisualStyleBackColor = true;
            // 
            // createRequest
            // 
            this.createRequest.Location = new System.Drawing.Point(8, 184);
            this.createRequest.Name = "createRequest";
            this.createRequest.Size = new System.Drawing.Size(130, 23);
            this.createRequest.TabIndex = 6;
            this.createRequest.Text = "Создать заявку";
            this.createRequest.UseVisualStyleBackColor = true;
            // 
            // SellerWorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 387);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(665, 405);
            this.Name = "SellerWorkSpace";
            this.ShowIcon = false;
            this.Text = "Рабочая область";
            this.Load += new System.EventHandler(this.SellerWorkSpace_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.addItemGroup.ResumeLayout(false);
            this.addItemGroup.PerformLayout();
            this.itemDiscountGroup.ResumeLayout(false);
            this.itemDiscountGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDiscountValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label additionalTools;
        private System.Windows.Forms.Button newItems;
        private System.Windows.Forms.Button purchaseReturn;
        private System.Windows.Forms.Button CloseShift;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label sellLabel;
        private System.Windows.Forms.GroupBox addItemGroup;
        private System.Windows.Forms.GroupBox itemDiscountGroup;
        private System.Windows.Forms.NumericUpDown itemDiscountValue;
        private System.Windows.Forms.Label itemDiscountLabel;
        private System.Windows.Forms.RadioButton itemSelfCostDiscount;
        private System.Windows.Forms.RadioButton itemFixedDiscount;
        private System.Windows.Forms.RadioButton itemPercentDiscount;
        private System.Windows.Forms.RadioButton itemWithoutDiscount;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.NumericUpDown itemCount;
        private System.Windows.Forms.ComboBox itemPicker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button accountChange;
        private System.Windows.Forms.Button dayRequest;
        private System.Windows.Forms.Button terminalPay;
        private System.Windows.Forms.Button moneyPay;
        private System.Windows.Forms.Button mixPay;
        private System.Windows.Forms.Button createRequest;
    }
}