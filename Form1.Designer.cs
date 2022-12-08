namespace TextEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UpperMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelString = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelRow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutButton = new System.Windows.Forms.ToolStripButton();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.PasteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textField = new System.Windows.Forms.RichTextBox();
            this.UpperMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperMenu
            // 
            this.UpperMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.UpperMenu.Location = new System.Drawing.Point(0, 0);
            this.UpperMenu.Name = "UpperMenu";
            this.UpperMenu.Size = new System.Drawing.Size(1080, 24);
            this.UpperMenu.TabIndex = 1;
            this.UpperMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.OpenToolStripMenuItem.Text = "Открыть...";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.SaveAsToolStripMenuItem.Text = "Сохранить как...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LabelString,
            this.toolStripStatusLabel3,
            this.LabelRow,
            this.toolStripStatusLabel5,
            this.LabelPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "Строка :";
            // 
            // LabelString
            // 
            this.LabelString.Name = "LabelString";
            this.LabelString.Size = new System.Drawing.Size(13, 17);
            this.LabelString.Text = "1";
            this.LabelString.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel3.Text = "Столбец :";
            // 
            // LabelRow
            // 
            this.LabelRow.Name = "LabelRow";
            this.LabelRow.Size = new System.Drawing.Size(13, 17);
            this.LabelRow.Text = "1";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel5.Text = "Позиция :";
            // 
            // LabelPosition
            // 
            this.LabelPosition.Name = "LabelPosition";
            this.LabelPosition.Size = new System.Drawing.Size(13, 17);
            this.LabelPosition.Text = "1";
            // 
            // toolStripMainMenu
            // 
            this.toolStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.CutButton,
            this.CopyButton,
            this.PasteButton,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStripMainMenu.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainMenu.Name = "toolStripMainMenu";
            this.toolStripMainMenu.Size = new System.Drawing.Size(1080, 25);
            this.toolStripMainMenu.TabIndex = 4;
            this.toolStripMainMenu.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Новый документ";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTipText = "Открыть";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Сохранить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Сохранить как...";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CutButton
            // 
            this.CutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutButton.Image = ((System.Drawing.Image)(resources.GetObject("CutButton.Image")));
            this.CutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutButton.Name = "CutButton";
            this.CutButton.Size = new System.Drawing.Size(23, 22);
            this.CutButton.Text = "toolStripButton5";
            this.CutButton.ToolTipText = "Вырезать";
            this.CutButton.Click += new System.EventHandler(this.CutButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 22);
            this.CopyButton.Text = "toolStripButton6";
            this.CopyButton.ToolTipText = "Копировать";
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteButton.Image")));
            this.PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 22);
            this.PasteButton.Text = "toolStripButton7";
            this.PasteButton.ToolTipText = "Вставить";
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.ToolTipText = "Отправить на печать";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 22);
            this.toolStripLabel1.Text = "Размер шрифта : ";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownWidth = 40;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "48",
            "60",
            "72"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox1.TextChanged += new System.EventHandler(this.toolStripComboBox1_TextChanged);
            // 
            // textField
            // 
            this.textField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textField.Location = new System.Drawing.Point(0, 52);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(1080, 557);
            this.textField.TabIndex = 5;
            this.textField.Text = "";
            this.textField.Click += new System.EventHandler(this.textField_Click);
            this.textField.CursorChanged += new System.EventHandler(this.textField_CursorChanged);
            this.textField.TextChanged += new System.EventHandler(this.textField_TextChanged);
            this.textField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textField_KeyUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1080, 634);
            this.Controls.Add(this.textField);
            this.Controls.Add(this.toolStripMainMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.UpperMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.UpperMenu;
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.UpperMenu.ResumeLayout(false);
            this.UpperMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripMainMenu.ResumeLayout(false);
            this.toolStripMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip UpperMenu;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStrip toolStripMainMenu;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox textField;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel LabelString;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel LabelRow;
        private ToolStripStatusLabel toolStripStatusLabel5;
        private ToolStripStatusLabel LabelPosition;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton CutButton;
        private ToolStripButton CopyButton;
        private ToolStripButton PasteButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton5;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripLabel toolStripLabel1;
    }
}