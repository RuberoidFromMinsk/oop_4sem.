namespace Lab1_Task2
{
    partial class Form1
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
            this.userSizeInput = new System.Windows.Forms.TextBox();
            this.collectionSizeLabel = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.ascendingBtn = new System.Windows.Forms.Button();
            this.descendingBtn = new System.Windows.Forms.Button();
            this.listField = new System.Windows.Forms.TextBox();
            this.resultField = new System.Windows.Forms.TextBox();
            this.minBtn = new System.Windows.Forms.Button();
            this.rangeBtn = new System.Windows.Forms.Button();
            this.maxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userSizeInput
            // 
            this.userSizeInput.Location = new System.Drawing.Point(59, 22);
            this.userSizeInput.Margin = new System.Windows.Forms.Padding(4);
            this.userSizeInput.Name = "userSizeInput";
            this.userSizeInput.Size = new System.Drawing.Size(154, 22);
            this.userSizeInput.TabIndex = 0;
            // 
            // collectionSizeLabel
            // 
            this.collectionSizeLabel.AutoSize = true;
            this.collectionSizeLabel.Location = new System.Drawing.Point(12, 25);
            this.collectionSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.collectionSizeLabel.Name = "collectionSizeLabel";
            this.collectionSizeLabel.Size = new System.Drawing.Size(39, 17);
            this.collectionSizeLabel.TabIndex = 1;
            this.collectionSizeLabel.Text = "Size:";
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(15, 62);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(198, 46);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Create";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // ascendingBtn
            // 
            this.ascendingBtn.Location = new System.Drawing.Point(15, 135);
            this.ascendingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ascendingBtn.Name = "ascendingBtn";
            this.ascendingBtn.Size = new System.Drawing.Size(92, 46);
            this.ascendingBtn.TabIndex = 3;
            this.ascendingBtn.Text = "Asc";
            this.ascendingBtn.UseVisualStyleBackColor = true;
            this.ascendingBtn.Click += new System.EventHandler(this.AscendingBtn_Click);
            // 
            // descendingBtn
            // 
            this.descendingBtn.Location = new System.Drawing.Point(115, 135);
            this.descendingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.descendingBtn.Name = "descendingBtn";
            this.descendingBtn.Size = new System.Drawing.Size(98, 46);
            this.descendingBtn.TabIndex = 4;
            this.descendingBtn.Text = "Desc";
            this.descendingBtn.UseVisualStyleBackColor = true;
            this.descendingBtn.Click += new System.EventHandler(this.DescendingBtn_Click);
            // 
            // listField
            // 
            this.listField.Location = new System.Drawing.Point(223, 11);
            this.listField.Margin = new System.Windows.Forms.Padding(4);
            this.listField.Multiline = true;
            this.listField.Name = "listField";
            this.listField.Size = new System.Drawing.Size(199, 170);
            this.listField.TabIndex = 5;
            // 
            // resultField
            // 
            this.resultField.Location = new System.Drawing.Point(223, 205);
            this.resultField.Margin = new System.Windows.Forms.Padding(4);
            this.resultField.Multiline = true;
            this.resultField.Name = "resultField";
            this.resultField.Size = new System.Drawing.Size(199, 193);
            this.resultField.TabIndex = 7;
            // 
            // minBtn
            // 
            this.minBtn.Location = new System.Drawing.Point(113, 296);
            this.minBtn.Margin = new System.Windows.Forms.Padding(4);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(98, 46);
            this.minBtn.TabIndex = 8;
            this.minBtn.Text = "Min";
            this.minBtn.UseVisualStyleBackColor = true;
            this.minBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // rangeBtn
            // 
            this.rangeBtn.Location = new System.Drawing.Point(13, 350);
            this.rangeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rangeBtn.Name = "rangeBtn";
            this.rangeBtn.Size = new System.Drawing.Size(198, 46);
            this.rangeBtn.TabIndex = 9;
            this.rangeBtn.Text = "> 0";
            this.rangeBtn.UseVisualStyleBackColor = true;
            this.rangeBtn.Click += new System.EventHandler(this.RangeBtn_Click);
            // 
            // maxBtn
            // 
            this.maxBtn.Location = new System.Drawing.Point(13, 296);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(4);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.Size = new System.Drawing.Size(92, 46);
            this.maxBtn.TabIndex = 10;
            this.maxBtn.Text = "Max";
            this.maxBtn.UseVisualStyleBackColor = true;
            this.maxBtn.Click += new System.EventHandler(this.MaxBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 409);
            this.Controls.Add(this.maxBtn);
            this.Controls.Add(this.rangeBtn);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.listField);
            this.Controls.Add(this.descendingBtn);
            this.Controls.Add(this.ascendingBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.collectionSizeLabel);
            this.Controls.Add(this.userSizeInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userSizeInput;
        private System.Windows.Forms.Label collectionSizeLabel;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button ascendingBtn;
        private System.Windows.Forms.Button descendingBtn;
        private System.Windows.Forms.TextBox listField;
        private System.Windows.Forms.TextBox resultField;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button rangeBtn;
        private System.Windows.Forms.Button maxBtn;
    }
}

