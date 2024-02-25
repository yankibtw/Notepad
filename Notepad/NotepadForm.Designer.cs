namespace Notepad
{
    partial class NotepadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotepadForm));
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кусивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирныйШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuChangeCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuChangeCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuChangeCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuChangePaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuChangeDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuChangeSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTextContainer = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripAllLength = new System.Windows.Forms.ToolStripStatusLabel();
            this.SymbolsQty = new System.Windows.Forms.ToolStripStatusLabel();
            this.ManageMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.СancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ManageMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.MainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.FontToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1067, 25);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolMenuStrip,
            this.PrintToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.NewFileToolStripMenuItemClick);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
            // 
            // SaveToolMenuStrip
            // 
            this.SaveToolMenuStrip.Name = "SaveToolMenuStrip";
            this.SaveToolMenuStrip.Size = new System.Drawing.Size(180, 22);
            this.SaveToolMenuStrip.Text = "Сохранить";
            this.SaveToolMenuStrip.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PrintToolStripMenuItem.Text = "Печать";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintDialog);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Tag = "ExitTool";
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitFromApplication);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменениеЦветаToolStripMenuItem,
            this.размерToolStripMenuItem,
            this.выделитьToolStripMenuItem});
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.FontToolStripMenuItem.Text = "Шрифт";
            // 
            // изменениеЦветаToolStripMenuItem
            // 
            this.изменениеЦветаToolStripMenuItem.Name = "изменениеЦветаToolStripMenuItem";
            this.изменениеЦветаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменениеЦветаToolStripMenuItem.Text = "Изменение цвета";
            this.изменениеЦветаToolStripMenuItem.Click += new System.EventHandler(this.ChangeColorToolStripMenuItem_Click);
            // 
            // размерToolStripMenuItem
            // 
            this.размерToolStripMenuItem.Name = "размерToolStripMenuItem";
            this.размерToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.размерToolStripMenuItem.Text = "Размер";
            this.размерToolStripMenuItem.Click += new System.EventHandler(this.ChangeFontSizeToolStripMenuItem_Click);
            // 
            // выделитьToolStripMenuItem
            // 
            this.выделитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кусивToolStripMenuItem,
            this.жирныйШрифтToolStripMenuItem});
            this.выделитьToolStripMenuItem.Name = "выделитьToolStripMenuItem";
            this.выделитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выделитьToolStripMenuItem.Text = "Выделить";
            // 
            // кусивToolStripMenuItem
            // 
            this.кусивToolStripMenuItem.Name = "кусивToolStripMenuItem";
            this.кусивToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.кусивToolStripMenuItem.Text = "Кусив";
            this.кусивToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            // 
            // жирныйШрифтToolStripMenuItem
            // 
            this.жирныйШрифтToolStripMenuItem.Name = "жирныйШрифтToolStripMenuItem";
            this.жирныйШрифтToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.жирныйШрифтToolStripMenuItem.Text = "Жирный шрифт";
            this.жирныйШрифтToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuChangeCancel,
            this.MainMenuChangeCut,
            this.MainMenuChangeCopy,
            this.MainMenuChangePaste,
            this.MainMenuChangeDeleteAll,
            this.MainMenuChangeSelectAll});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // MainMenuChangeCancel
            // 
            this.MainMenuChangeCancel.Name = "MainMenuChangeCancel";
            this.MainMenuChangeCancel.Size = new System.Drawing.Size(180, 22);
            this.MainMenuChangeCancel.Text = "Отменить";
            this.MainMenuChangeCancel.Click += new System.EventHandler(this.СancelToolStripMenuItem_Click);
            // 
            // MainMenuChangeCut
            // 
            this.MainMenuChangeCut.Name = "MainMenuChangeCut";
            this.MainMenuChangeCut.Size = new System.Drawing.Size(180, 22);
            this.MainMenuChangeCut.Text = "Вырезать";
            this.MainMenuChangeCut.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // MainMenuChangeCopy
            // 
            this.MainMenuChangeCopy.Name = "MainMenuChangeCopy";
            this.MainMenuChangeCopy.Size = new System.Drawing.Size(180, 22);
            this.MainMenuChangeCopy.Text = "Копировать";
            this.MainMenuChangeCopy.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // MainMenuChangePaste
            // 
            this.MainMenuChangePaste.Name = "MainMenuChangePaste";
            this.MainMenuChangePaste.Size = new System.Drawing.Size(180, 22);
            this.MainMenuChangePaste.Text = "Вставить";
            this.MainMenuChangePaste.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // MainMenuChangeDeleteAll
            // 
            this.MainMenuChangeDeleteAll.Name = "MainMenuChangeDeleteAll";
            this.MainMenuChangeDeleteAll.Size = new System.Drawing.Size(180, 22);
            this.MainMenuChangeDeleteAll.Text = "Удалить";
            this.MainMenuChangeDeleteAll.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // MainMenuChangeSelectAll
            // 
            this.MainMenuChangeSelectAll.Name = "MainMenuChangeSelectAll";
            this.MainMenuChangeSelectAll.Size = new System.Drawing.Size(180, 22);
            this.MainMenuChangeSelectAll.Text = "Выделить все";
            this.MainMenuChangeSelectAll.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.InfoTextContainer_Click);
            // 
            // MainTextContainer
            // 
            this.MainTextContainer.BackColor = System.Drawing.SystemColors.Window;
            this.MainTextContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTextContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTextContainer.Location = new System.Drawing.Point(0, 25);
            this.MainTextContainer.Name = "MainTextContainer";
            this.MainTextContainer.Size = new System.Drawing.Size(1067, 529);
            this.MainTextContainer.TabIndex = 1;
            this.MainTextContainer.Text = "";
            this.MainTextContainer.TextChanged += new System.EventHandler(this.MainTextContainer_TextChanged);
            this.MainTextContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTextInput_PCMClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            this.printDialog1.HelpRequest += new System.EventHandler(this.PrintDialog);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripAllLength,
            this.SymbolsQty});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripAllLength
            // 
            this.ToolStripAllLength.Name = "ToolStripAllLength";
            this.ToolStripAllLength.Size = new System.Drawing.Size(0, 17);
            // 
            // SymbolsQty
            // 
            this.SymbolsQty.Name = "SymbolsQty";
            this.SymbolsQty.Size = new System.Drawing.Size(70, 17);
            this.SymbolsQty.Text = "Символов: ";
            // 
            // ManageMenuStrip
            // 
            this.ManageMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СancelToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.DeleteToolStripMenuItem,
            this.SelectAllToolStripMenuItem});
            this.ManageMenuStrip.Name = "contextMenuStrip1";
            this.ManageMenuStrip.Size = new System.Drawing.Size(143, 136);
            // 
            // СancelToolStripMenuItem
            // 
            this.СancelToolStripMenuItem.Name = "СancelToolStripMenuItem";
            this.СancelToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.СancelToolStripMenuItem.Text = "Отменить";
            this.СancelToolStripMenuItem.Click += new System.EventHandler(this.СancelToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.CutToolStripMenuItem.Text = "Вырезать";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.CopyToolStripMenuItem.Text = "Копировать";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.PasteToolStripMenuItem.Text = "Вставить";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.DeleteToolStripMenuItem.Text = "Удалить";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.SelectAllToolStripMenuItem.Text = "Выбрать все";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainTextContainer);
            this.Controls.Add(this.MainMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NotepadForm";
            this.Text = "Блокнот";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotepadForm_FormClosing);
            this.Load += new System.EventHandler(this.NotepadForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ManageMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainTextContainer_TextChanged1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox MainTextContainer;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem изменениеЦветаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кусивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жирныйШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripAllLength;
        private System.Windows.Forms.ContextMenuStrip ManageMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuChangeCancel;
        private System.Windows.Forms.ToolStripMenuItem MainMenuChangeCut;
        private System.Windows.Forms.ToolStripMenuItem MainMenuChangeCopy;
        private System.Windows.Forms.ToolStripMenuItem MainMenuChangePaste;
        private System.Windows.Forms.ToolStripMenuItem MainMenuChangeDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem MainMenuChangeSelectAll;
        private System.Windows.Forms.ToolStripStatusLabel SymbolsQty;
    }
}

