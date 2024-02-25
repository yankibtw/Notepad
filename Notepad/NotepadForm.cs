using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using System.Drawing.Printing;

namespace Notepad
{
    public partial class NotepadForm : Form
    {
        private string currentFilePath;
        private bool isSaved = false;
        public NotepadForm()
        {
            InitializeComponent();
        }
        private void NotepadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSaved)
            {
                DialogResult messageResult = MessageBox.Show($"Вы хотитите сохранить изменения в файле перед закрытием?", "Выход", MessageBoxButtons.YesNoCancel);
                  switch (messageResult)
                  {
                        case DialogResult.Yes:
                            SaveToolStripMenuItemClick(sender, e);
                            isSaved = true;
                            break;
                        case DialogResult.No:
                            e.Cancel = false;
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                  }
            }
        }
        private void ExitFromApplication(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                DialogResult messageResult = MessageBox.Show($"Вы хотитите сохранить изменения в файле перед закрытием?", "Выход", MessageBoxButtons.YesNoCancel);

                switch (messageResult)
                {
                    case DialogResult.Yes:
                        SaveToolStripMenuItemClick(sender, e);
                        isSaved = true;
                        break;
                    case DialogResult.No:
                        Application.Exit();
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
            else { Application.Exit(); }
            
        }
        private void PrintDialog(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            else
            {
                MessageBox.Show("Сначала откройте файл для печати.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            using (StreamReader reader = new StreamReader(currentFilePath))
            {
                Font printFont = new Font("Arial", 14);
                float yPos = 0;
                int count = 0;
                float leftMargin = e.MarginBounds.Left;
                float topMargin = e.MarginBounds.Top;
                string line = null;

                while (count < e.MarginBounds.Height / printFont.GetHeight(e.Graphics) &&
                       ((line = reader.ReadLine()) != null))
                {
                    yPos = topMargin + (count * printFont.GetHeight(e.Graphics));
                    e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                    count++;
                }
            }
        }
        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                SaveFileDialog mainFileToSave = new SaveFileDialog
                {
                    Filter = "Текстовый документ |*.txt",
                    Title = "Сохранить файл в формате txt"
                };

                if (mainFileToSave.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                currentFilePath = mainFileToSave.FileName;

                UpdateFormTitle();
            }
            File.WriteAllText(currentFilePath, MainTextContainer.Text);
            isSaved = true;
        }
        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {
            OpenFileDialog mainFileToOpen = new OpenFileDialog
            {
                Filter = "Текстовый документ |*.txt",
                Title = "Открыть файл в формате txt"
            };

            if (mainFileToOpen.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            currentFilePath = mainFileToOpen.FileName;
            MainTextContainer.Text = File.ReadAllText(currentFilePath);
            UpdateFormTitle();
            isSaved = true;
        }
        private void NewFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            MainTextContainer.Text = string.Empty;
            currentFilePath = null;

            UpdateFormTitle();
        }
        private void UpdateFormTitle()
        {
            string fileName = string.IsNullOrEmpty(currentFilePath) ? "Без названия" : Path.GetFileName(currentFilePath);
            Text = "Блокнот - " + fileName;
        }
        private void ChangeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                MainTextContainer.SelectionColor = colorDialog.Color;
            }
        }
        private void ChangeFontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = InputBox.Show("Введите размер шрифта:", "Изменение размера шрифта");
            if (float.TryParse(input, out float newSize))
            {
                Font currentFont = MainTextContainer.SelectionFont;
                MainTextContainer.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);
            }
            else
            {
                MessageBox.Show("Введите корректный размер шрифта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static class InputBox
        {
            public static string Show(string prompt, string title)
            {
                Form form = new Form();
                Label label = new Label();
                TextBox textBox = new TextBox();
                Button buttonOk = new Button();
                Button buttonCancel = new Button();

                form.Text = title;
                label.Text = prompt;

                buttonOk.Text = "OK";
                buttonCancel.Text = "Отмена";
                buttonOk.DialogResult = DialogResult.OK;
                buttonCancel.DialogResult = DialogResult.Cancel;

                label.SetBounds(9, 20, 372, 13);
                textBox.SetBounds(12, 36, 372, 20);
                buttonOk.SetBounds(228, 72, 75, 23);
                buttonCancel.SetBounds(309, 72, 75, 23);

                label.AutoSize = true;
                textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
                buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

                form.ClientSize = new Size(396, 107);
                form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
                form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.AcceptButton = buttonOk;
                form.CancelButton = buttonCancel;

                DialogResult dialogResult = form.ShowDialog();
                return (dialogResult == DialogResult.OK) ? textBox.Text : string.Empty;
            }
        }
        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = MainTextContainer.SelectionFont;
            FontStyle newStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
            MainTextContainer.SelectionFont = new Font(currentFont, newStyle);
        }
        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font currentFont = MainTextContainer.SelectionFont;
            FontStyle newStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
            MainTextContainer.SelectionFont = new Font(currentFont, newStyle);
        }
        private void InfoTextContainer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Блокнот v.1.0.0\r\n© Инди-компания Y1, 2024. Все права защищены.", "Справка о приложении");
        }
        private void MainTextInput_PCMClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ManageMenuStrip.Show(MainMenuStrip, new Point(e.X, e.Y + 20));
            }
        }

        private void СancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextContainer.Undo();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextContainer.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextContainer.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextContainer.Paste();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextContainer.Text = "";
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainTextContainer.SelectAll();
        }
        private void MainTextContainer_TextChanged(object sender, EventArgs e)
        {
            int charCount = MainTextContainer.Text.Length;
            SymbolsQty.Text = "Символов: " + charCount.ToString();
            isSaved = false;    
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            UpdateFormTitle();
            MainTextContainer_TextChanged(sender, e);

            string relativePath = "../../../img/notepad_icon.ico";
            string fullPath = Path.Combine(Application.StartupPath, relativePath);
            Icon icon = new Icon(fullPath);
            this.Icon = icon;
        }
    }
}
