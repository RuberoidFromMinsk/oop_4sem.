namespace Lab1
{
    partial class TextCalculatorMainWindow
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
            this.userInput1 = new System.Windows.Forms.TextBox();
            this.InputLabel1 = new System.Windows.Forms.Label();
            this.userInput2 = new System.Windows.Forms.TextBox();
            this.InputLabel2 = new System.Windows.Forms.Label();
            this.concatBtn = new System.Windows.Forms.Button();
            this.SubstrToSubstrBtn = new System.Windows.Forms.Button();
            this.removeSubstrBtn = new System.Windows.Forms.Button();
            this.charByIndexBtn = new System.Windows.Forms.Button();
            this.stringLengthBtn = new System.Windows.Forms.Button();
            this.doubleVowelsBtn = new System.Windows.Forms.Button();
            this.outputField = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.userInput3 = new System.Windows.Forms.TextBox();
            this.InputLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userInput1
            // 
            this.userInput1.Location = new System.Drawing.Point(149, 32);
            this.userInput1.Margin = new System.Windows.Forms.Padding(4);
            this.userInput1.Name = "userInput1";
            this.userInput1.Size = new System.Drawing.Size(375, 22);
            this.userInput1.TabIndex = 0;
            this.userInput1.TextChanged += new System.EventHandler(this.userInput1_TextChanged);
            // 
            // InputLabel1
            // 
            this.InputLabel1.AutoSize = true;
            this.InputLabel1.Location = new System.Drawing.Point(146, 9);
            this.InputLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputLabel1.Name = "InputLabel1";
            this.InputLabel1.Size = new System.Drawing.Size(28, 17);
            this.InputLabel1.TabIndex = 1;
            this.InputLabel1.Text = "str:";
            this.InputLabel1.Click += new System.EventHandler(this.InputLabel1_Click);
            // 
            // userInput2
            // 
            this.userInput2.Location = new System.Drawing.Point(148, 90);
            this.userInput2.Margin = new System.Windows.Forms.Padding(4);
            this.userInput2.Name = "userInput2";
            this.userInput2.Size = new System.Drawing.Size(169, 22);
            this.userInput2.TabIndex = 2;
            this.userInput2.TextChanged += new System.EventHandler(this.userInput2_TextChanged);
            // 
            // InputLabel2
            // 
            this.InputLabel2.AutoSize = true;
            this.InputLabel2.Location = new System.Drawing.Point(146, 68);
            this.InputLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputLabel2.Name = "InputLabel2";
            this.InputLabel2.Size = new System.Drawing.Size(59, 17);
            this.InputLabel2.TabIndex = 3;
            this.InputLabel2.Text = "substr1:";
            // 
            // concatBtn
            // 
            this.concatBtn.Location = new System.Drawing.Point(13, 137);
            this.concatBtn.Margin = new System.Windows.Forms.Padding(4);
            this.concatBtn.Name = "concatBtn";
            this.concatBtn.Size = new System.Drawing.Size(125, 89);
            this.concatBtn.TabIndex = 4;
            this.concatBtn.Text = "Объединить";
            this.concatBtn.UseVisualStyleBackColor = true;
            this.concatBtn.Click += new System.EventHandler(this.concatBtn_Click);
            // 
            // SubstrToSubstrBtn
            // 
            this.SubstrToSubstrBtn.Location = new System.Drawing.Point(13, 23);
            this.SubstrToSubstrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SubstrToSubstrBtn.Name = "SubstrToSubstrBtn";
            this.SubstrToSubstrBtn.Size = new System.Drawing.Size(125, 89);
            this.SubstrToSubstrBtn.TabIndex = 5;
            this.SubstrToSubstrBtn.Text = "Замена substr1 на substr2";
            this.SubstrToSubstrBtn.UseVisualStyleBackColor = true;
            this.SubstrToSubstrBtn.Click += new System.EventHandler(this.SubstrToSubstrBtn_Click);
            // 
            // removeSubstrBtn
            // 
            this.removeSubstrBtn.Location = new System.Drawing.Point(542, 137);
            this.removeSubstrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.removeSubstrBtn.Name = "removeSubstrBtn";
            this.removeSubstrBtn.Size = new System.Drawing.Size(125, 89);
            this.removeSubstrBtn.TabIndex = 6;
            this.removeSubstrBtn.Text = "Удалить подстроку";
            this.removeSubstrBtn.UseVisualStyleBackColor = true;
            this.removeSubstrBtn.Click += new System.EventHandler(this.removeSubstrBtn_Click);
            // 
            // charByIndexBtn
            // 
            this.charByIndexBtn.Location = new System.Drawing.Point(687, 137);
            this.charByIndexBtn.Margin = new System.Windows.Forms.Padding(4);
            this.charByIndexBtn.Name = "charByIndexBtn";
            this.charByIndexBtn.Size = new System.Drawing.Size(125, 89);
            this.charByIndexBtn.TabIndex = 7;
            this.charByIndexBtn.Text = "Элемент по индексу";
            this.charByIndexBtn.UseVisualStyleBackColor = true;
            this.charByIndexBtn.Click += new System.EventHandler(this.charByIndexBtn_Click);
            // 
            // stringLengthBtn
            // 
            this.stringLengthBtn.Location = new System.Drawing.Point(542, 32);
            this.stringLengthBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stringLengthBtn.Name = "stringLengthBtn";
            this.stringLengthBtn.Size = new System.Drawing.Size(125, 89);
            this.stringLengthBtn.TabIndex = 8;
            this.stringLengthBtn.Text = "Длина";
            this.stringLengthBtn.UseVisualStyleBackColor = true;
            this.stringLengthBtn.Click += new System.EventHandler(this.stringLengthBtn_Click);
            // 
            // doubleVowelsBtn
            // 
            this.doubleVowelsBtn.Location = new System.Drawing.Point(687, 32);
            this.doubleVowelsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.doubleVowelsBtn.Name = "doubleVowelsBtn";
            this.doubleVowelsBtn.Size = new System.Drawing.Size(125, 89);
            this.doubleVowelsBtn.TabIndex = 9;
            this.doubleVowelsBtn.Text = "Согласные";
            this.doubleVowelsBtn.UseVisualStyleBackColor = true;
            this.doubleVowelsBtn.Click += new System.EventHandler(this.doubleVowelsBtn_Click);
            // 
            // outputField
            // 
            this.outputField.Location = new System.Drawing.Point(148, 140);
            this.outputField.Margin = new System.Windows.Forms.Padding(4);
            this.outputField.Multiline = true;
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(376, 86);
            this.outputField.TabIndex = 10;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(145, 116);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(47, 17);
            this.outputLabel.TabIndex = 11;
            this.outputLabel.Text = "result:";
            // 
            // userInput3
            // 
            this.userInput3.Location = new System.Drawing.Point(355, 90);
            this.userInput3.Margin = new System.Windows.Forms.Padding(4);
            this.userInput3.Name = "userInput3";
            this.userInput3.Size = new System.Drawing.Size(169, 22);
            this.userInput3.TabIndex = 12;
            // 
            // InputLabel3
            // 
            this.InputLabel3.AutoSize = true;
            this.InputLabel3.Location = new System.Drawing.Point(352, 69);
            this.InputLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InputLabel3.Name = "InputLabel3";
            this.InputLabel3.Size = new System.Drawing.Size(59, 17);
            this.InputLabel3.TabIndex = 13;
            this.InputLabel3.Text = "substr2:";
            // 
            // TextCalculatorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 243);
            this.Controls.Add(this.InputLabel3);
            this.Controls.Add(this.userInput3);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputField);
            this.Controls.Add(this.doubleVowelsBtn);
            this.Controls.Add(this.stringLengthBtn);
            this.Controls.Add(this.charByIndexBtn);
            this.Controls.Add(this.removeSubstrBtn);
            this.Controls.Add(this.SubstrToSubstrBtn);
            this.Controls.Add(this.concatBtn);
            this.Controls.Add(this.InputLabel2);
            this.Controls.Add(this.userInput2);
            this.Controls.Add(this.InputLabel1);
            this.Controls.Add(this.userInput1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TextCalculatorMainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInput1;
        private System.Windows.Forms.Label InputLabel1;
        private System.Windows.Forms.TextBox userInput2;
        private System.Windows.Forms.Label InputLabel2;
        private System.Windows.Forms.Button concatBtn;
        private System.Windows.Forms.Button SubstrToSubstrBtn;
        private System.Windows.Forms.Button removeSubstrBtn;
        private System.Windows.Forms.Button charByIndexBtn;
        private System.Windows.Forms.Button stringLengthBtn;
        private System.Windows.Forms.Button doubleVowelsBtn;
        private System.Windows.Forms.TextBox outputField;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox userInput3;
        private System.Windows.Forms.Label InputLabel3;
    }
}

