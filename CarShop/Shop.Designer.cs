namespace CarShop
{
    partial class Shop
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.listBox_ventors = new System.Windows.Forms.ListBox();
            this.label_Ventors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Models = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Colors = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_Ordered = new System.Windows.Forms.ListBox();
            this.button_ADD = new System.Windows.Forms.Button();
            this.label5_ = new System.Windows.Forms.Label();
            this.listBox_allCars = new System.Windows.Forms.ListBox();
            this.button_makeOrder = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_Buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_ventors
            // 
            this.listBox_ventors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_ventors.FormattingEnabled = true;
            this.listBox_ventors.ItemHeight = 18;
            this.listBox_ventors.Location = new System.Drawing.Point(21, 42);
            this.listBox_ventors.Name = "listBox_ventors";
            this.listBox_ventors.Size = new System.Drawing.Size(125, 274);
            this.listBox_ventors.TabIndex = 0;
            this.listBox_ventors.SelectedIndexChanged += new System.EventHandler(this.listBox_ventors_SelectedIndexChanged);
            // 
            // label_Ventors
            // 
            this.label_Ventors.AutoSize = true;
            this.label_Ventors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Ventors.Location = new System.Drawing.Point(21, 14);
            this.label_Ventors.Name = "label_Ventors";
            this.label_Ventors.Size = new System.Drawing.Size(59, 18);
            this.label_Ventors.TabIndex = 1;
            this.label_Ventors.Text = "Ventros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(176, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Models";
            // 
            // listBox_Models
            // 
            this.listBox_Models.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Models.FormattingEnabled = true;
            this.listBox_Models.ItemHeight = 18;
            this.listBox_Models.Location = new System.Drawing.Point(169, 42);
            this.listBox_Models.Name = "listBox_Models";
            this.listBox_Models.Size = new System.Drawing.Size(135, 274);
            this.listBox_Models.TabIndex = 2;
            this.listBox_Models.SelectedIndexChanged += new System.EventHandler(this.listBox_Models_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(324, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Colors";
            // 
            // listBox_Colors
            // 
            this.listBox_Colors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Colors.FormattingEnabled = true;
            this.listBox_Colors.ItemHeight = 18;
            this.listBox_Colors.Location = new System.Drawing.Point(327, 42);
            this.listBox_Colors.Name = "listBox_Colors";
            this.listBox_Colors.Size = new System.Drawing.Size(133, 166);
            this.listBox_Colors.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(332, 269);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(329, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(570, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Order";
            // 
            // listBox_Ordered
            // 
            this.listBox_Ordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Ordered.FormattingEnabled = true;
            this.listBox_Ordered.ItemHeight = 18;
            this.listBox_Ordered.Location = new System.Drawing.Point(538, 42);
            this.listBox_Ordered.Name = "listBox_Ordered";
            this.listBox_Ordered.Size = new System.Drawing.Size(199, 274);
            this.listBox_Ordered.TabIndex = 8;
            // 
            // button_ADD
            // 
            this.button_ADD.Location = new System.Drawing.Point(395, 266);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(75, 23);
            this.button_ADD.TabIndex = 10;
            this.button_ADD.Text = "Add";
            this.button_ADD.UseVisualStyleBackColor = true;
            this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // label5_
            // 
            this.label5_.AutoSize = true;
            this.label5_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5_.Location = new System.Drawing.Point(833, 9);
            this.label5_.Name = "label5_";
            this.label5_.Size = new System.Drawing.Size(84, 18);
            this.label5_.TabIndex = 12;
            this.label5_.Text = "Selled Cars";
            // 
            // listBox_allCars
            // 
            this.listBox_allCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_allCars.FormattingEnabled = true;
            this.listBox_allCars.ItemHeight = 18;
            this.listBox_allCars.Location = new System.Drawing.Point(824, 42);
            this.listBox_allCars.Name = "listBox_allCars";
            this.listBox_allCars.Size = new System.Drawing.Size(163, 274);
            this.listBox_allCars.TabIndex = 11;
            // 
            // button_makeOrder
            // 
            this.button_makeOrder.Location = new System.Drawing.Point(743, 154);
            this.button_makeOrder.Name = "button_makeOrder";
            this.button_makeOrder.Size = new System.Drawing.Size(75, 23);
            this.button_makeOrder.TabIndex = 13;
            this.button_makeOrder.Text = "Make Order";
            this.button_makeOrder.UseVisualStyleBackColor = true;
            this.button_makeOrder.Click += new System.EventHandler(this.button_makeOrder_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(24, 344);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(439, 31);
            this.button_refresh.TabIndex = 14;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_Buy
            // 
            this.button_Buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Buy.Location = new System.Drawing.Point(873, 348);
            this.button_Buy.Name = "button_Buy";
            this.button_Buy.Size = new System.Drawing.Size(93, 36);
            this.button_Buy.TabIndex = 15;
            this.button_Buy.Text = "Sell";
            this.button_Buy.UseVisualStyleBackColor = true;
            this.button_Buy.Click += new System.EventHandler(this.button_Buy_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 410);
            this.Controls.Add(this.button_Buy);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_makeOrder);
            this.Controls.Add(this.label5_);
            this.Controls.Add(this.listBox_allCars);
            this.Controls.Add(this.button_ADD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_Ordered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_Colors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Models);
            this.Controls.Add(this.label_Ventors);
            this.Controls.Add(this.listBox_ventors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shop";
            this.Text = "Car Shop";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_ventors;
        private System.Windows.Forms.Label label_Ventors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Models;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Colors;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_Ordered;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.Label label5_;
        private System.Windows.Forms.ListBox listBox_allCars;
        private System.Windows.Forms.Button button_makeOrder;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_Buy;
    }
}

