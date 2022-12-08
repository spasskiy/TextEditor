using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace TextEditor
{
    public partial class FontSettingsForm : Form
    {
        public FontSettingsForm()
        {
            InitializeComponent();
            fontSizeBox.SelectedIndex = 3;
            styleComboBox.SelectedItem = 0;

        }

        private void FontSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_VisibleChanged(object sender, EventArgs e)
        {          
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        
                ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontSizeBox.SelectedItem.ToString()), ExampleText.Font.Style);           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (styleComboBox.SelectedItem.ToString())
            {
                case "Обычный":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontSizeBox.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "Полужирный":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontSizeBox.SelectedItem.ToString()), FontStyle.Bold);
                    break;
                case "Курсив":
                    ExampleText.Font = new Font(ExampleText.Font.FontFamily, int.Parse(fontSizeBox.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                default:                    
                    break;
            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            main.SwitchFont(ExampleText.Font);
            Hide();
        }
    }
}
