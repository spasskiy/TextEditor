using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using System.Drawing;

namespace TextEditor
{
    public partial class MainForm : Form
    {
        string filename;
        bool isFileChanged = false;
        FontSettingsForm form = new FontSettingsForm();


        public MainForm()
        {
            InitializeComponent();            
            saveFileDialog1.Filter = "Text file (*.txt)|*.txt";           
            form.Owner = this;
            toolStripComboBox1.SelectedIndex = 10;


        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveAs();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = openFileDialog1.FileName;            
            string text = File.ReadAllText(filename);
            textField.Text = text;
            this.Text = "Текстовый редактор : " + filename;
            isFileChanged = false;
        }
        private void saveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            filename = saveFileDialog1.FileName;            
            File.WriteAllText(filename, textField.Text);
            this.Text = "Текстовый редактор : " + filename;
            isFileChanged = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveAs();
        }
        private void save()
        {
            if (filename == null)
                saveAs();
            else
            {
                File.WriteAllText(filename, textField.Text);
            }
            this.Text = "Текстовый редактор : " + filename;
            isFileChanged = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

       

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            filename = null;
            textField.Text = "";
            this.Text = "Текстовый редактор";
            isFileChanged = false;
        }
        private void SaveUnsavedFileByExit()
        {
            DialogResult choose = MessageBox.Show("Файл не сохранён. Сохранить?", "Сохранение файла", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(choose == DialogResult.Yes)
            {
                save();
            }
 
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFileChanged)
                SaveUnsavedFileByExit();            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void CopyText()
        {
            Clipboard.SetText(textField.SelectedText);
        }

        private void CutText()
        {
            Clipboard.SetText(textField.SelectedText);
            textField.Text = textField.Text.Remove(textField.SelectionStart, textField.SelectionLength);
        }

        private void PasteText()
        {
            textField.Text = textField.Text.Substring(0, textField.SelectionStart) + 
                Clipboard.GetText() + textField.Text.Substring(textField.SelectionStart, textField.Text.Length - textField.SelectionStart);
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            form.ShowDialog();
        }
        public void SwitchFont(Font font)
        {
            textField.Font = font;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textField_CursorChanged(object sender, EventArgs e)
        {            
            
        }

        private void textField_TextChanged(object sender, EventArgs e)
        {
            if (!isFileChanged)
            {
                isFileChanged = true;
                this.Text = "Текстовый редактор : *" + filename;
            }
            
        }

        private void textField_Click(object sender, EventArgs e)
        {
            calcPosition();

        }

        private void calcPosition()
        {
            LabelString.Text = (1 + textField.GetLineFromCharIndex(textField.SelectionStart)).ToString();

            LabelRow.Text = calcRow(textField.Text, textField.SelectionStart);

            LabelPosition.Text = (textField.SelectionStart + 1).ToString();
        }

        private string calcRow(in string str, in int selection)
        {
            int result = 1;
            int curPosition = selection;
            while(curPosition > 0 && str[curPosition - 1] != '\n')
            {
                result++;
                curPosition--;
            }            
            return result.ToString();
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void textField_KeyPress(object sender, KeyPressEventArgs e)
        {
            calcPosition();
        }

        private void textField_KeyDown(object sender, KeyEventArgs e)
        {
            calcPosition();
        }

        private void textField_KeyUp(object sender, KeyEventArgs e)
        {
            calcPosition();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {            
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintPageHandler;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;
            if (printDialog.ShowDialog() == DialogResult.OK) printDialog.Document.Print();
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {            
            e.Graphics.DrawString(textField.Text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void toolStripComboBox1_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            SwitchFont(new Font(textField.Font.FontFamily, int.Parse(toolStripComboBox1.SelectedItem.ToString()), textField.Font.Style));
        }
    }
}