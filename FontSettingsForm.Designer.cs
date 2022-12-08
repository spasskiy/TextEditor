namespace TextEditor
{
    partial class FontSettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExampleText = new System.Windows.Forms.Label();
            this.fontSizeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пример :";
            // 
            // ExampleText
            // 
            this.ExampleText.AutoSize = true;
            this.ExampleText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExampleText.Location = new System.Drawing.Point(7, 138);
            this.ExampleText.Name = "ExampleText";
            this.ExampleText.Size = new System.Drawing.Size(106, 37);
            this.ExampleText.TabIndex = 1;
            this.ExampleText.Text = "AaBbZz";
            // 
            // fontSizeBox
            // 
            this.fontSizeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "36",
            "72"});
            this.fontSizeBox.FormattingEnabled = true;
            this.fontSizeBox.Items.AddRange(new object[] {
            "6",
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "24",
            "28",
            "32",
            "72"});
            this.fontSizeBox.Location = new System.Drawing.Point(12, 37);
            this.fontSizeBox.Name = "fontSizeBox";
            this.fontSizeBox.Size = new System.Drawing.Size(101, 23);
            this.fontSizeBox.TabIndex = 3;
            this.fontSizeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.fontSizeBox.VisibleChanged += new System.EventHandler(this.comboBox1_VisibleChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Размер шрифта :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Начертание :";
            // 
            // styleComboBox
            // 
            this.styleComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Обычный",
            "Курсив",
            "Полужирный"});
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Items.AddRange(new object[] {
            "Обычный",
            "Полужирный",
            "Курсив"});
            this.styleComboBox.Location = new System.Drawing.Point(130, 37);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(121, 23);
            this.styleComboBox.TabIndex = 6;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FontSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 324);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontSizeBox);
            this.Controls.Add(this.ExampleText);
            this.Controls.Add(this.label1);
            this.Name = "FontSettingsForm";
            this.Text = "Настройка шрифта";
            this.Load += new System.EventHandler(this.FontSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label ExampleText;
        private ComboBox comboBox1;
        private ComboBox fontSizeBox;
        private Label label2;
        private Label label3;
        private ComboBox styleComboBox;
        private Button button1;
        private Button button2;
    }
}