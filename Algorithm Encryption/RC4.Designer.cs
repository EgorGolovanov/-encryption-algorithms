﻿namespace Algorithm_Encryption
{
    partial class RC4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RC4));
            this.InputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.KeyTB = new System.Windows.Forms.TextBox();
            this.EncButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьЦветЗаливкиТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.TimerAlgorithm = new System.Windows.Forms.Timer(this.components);
            this.LoadTextButton = new System.Windows.Forms.Button();
            this.SaveTextButton = new System.Windows.Forms.Button();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SecondsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GenKeyButton = new System.Windows.Forms.Button();
            this.SaveKeyButton = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputRichTextBox
            // 
            this.InputRichTextBox.Location = new System.Drawing.Point(12, 199);
            this.InputRichTextBox.Name = "InputRichTextBox";
            this.InputRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.InputRichTextBox.Size = new System.Drawing.Size(288, 210);
            this.InputRichTextBox.TabIndex = 1;
            this.InputRichTextBox.Text = "";
            this.InputRichTextBox.TextChanged += new System.EventHandler(this.InputRichTextBox_TextChanged);
            // 
            // KeyTB
            // 
            this.KeyTB.Location = new System.Drawing.Point(178, 94);
            this.KeyTB.Name = "KeyTB";
            this.KeyTB.Size = new System.Drawing.Size(403, 20);
            this.KeyTB.TabIndex = 5;
            this.KeyTB.TextChanged += new System.EventHandler(this.KeyTB_TextChanged);
            // 
            // EncButton
            // 
            this.EncButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncButton.Location = new System.Drawing.Point(178, 415);
            this.EncButton.Name = "EncButton";
            this.EncButton.Size = new System.Drawing.Size(122, 33);
            this.EncButton.TabIndex = 6;
            this.EncButton.Text = "Зашифровать";
            this.EncButton.UseVisualStyleBackColor = true;
            this.EncButton.Click += new System.EventHandler(this.EncButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecButton.Location = new System.Drawing.Point(501, 415);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(129, 33);
            this.DecButton.TabIndex = 8;
            this.DecButton.Text = "Расшифровать";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Location = new System.Drawing.Point(501, 199);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.ReadOnly = true;
            this.OutputRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.OutputRichTextBox.Size = new System.Drawing.Size(288, 210);
            this.OutputRichTextBox.TabIndex = 9;
            this.OutputRichTextBox.Text = "";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyLabel.Location = new System.Drawing.Point(126, 92);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(46, 18);
            this.KeyLabel.TabIndex = 10;
            this.KeyLabel.Text = "Ключ";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(817, 24);
            this.MenuStrip.TabIndex = 11;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem1.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(341, 22);
            this.открытьToolStripMenuItem.Text = "&Загрузить текст из файла";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(338, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(341, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить зашифрованный текст в файл";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(338, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(338, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(341, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.выбратьЦветЗаливкиТекстаToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.настройкиToolStripMenuItem.Text = "&Выбрать цвет текста";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // выбратьЦветЗаливкиТекстаToolStripMenuItem
            // 
            this.выбратьЦветЗаливкиТекстаToolStripMenuItem.Name = "выбратьЦветЗаливкиТекстаToolStripMenuItem";
            this.выбратьЦветЗаливкиТекстаToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.выбратьЦветЗаливкиТекстаToolStripMenuItem.Text = "&Выбрать цвет заливки текста";
            this.выбратьЦветЗаливкиТекстаToolStripMenuItem.Click += new System.EventHandler(this.выбратьЦветЗаливкиТекстаToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.параметрыToolStripMenuItem.Text = "&Выбрать шрифт текста";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.содержаниеToolStripMenuItem.Text = "&Об алгоритме";
            this.содержаниеToolStripMenuItem.Click += new System.EventHandler(this.содержаниеToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            this.опрограммеToolStripMenuItem.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // TimerAlgorithm
            // 
            this.TimerAlgorithm.Interval = 60000;
            this.TimerAlgorithm.Tick += new System.EventHandler(this.TimerAlgorithm_Tick);
            // 
            // LoadTextButton
            // 
            this.LoadTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadTextButton.Location = new System.Drawing.Point(12, 415);
            this.LoadTextButton.Name = "LoadTextButton";
            this.LoadTextButton.Size = new System.Drawing.Size(93, 33);
            this.LoadTextButton.TabIndex = 14;
            this.LoadTextButton.Text = "Загрузить";
            this.LoadTextButton.UseVisualStyleBackColor = true;
            this.LoadTextButton.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // SaveTextButton
            // 
            this.SaveTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTextButton.Location = new System.Drawing.Point(696, 415);
            this.SaveTextButton.Name = "SaveTextButton";
            this.SaveTextButton.Size = new System.Drawing.Size(93, 33);
            this.SaveTextButton.TabIndex = 15;
            this.SaveTextButton.Text = "Сохранить";
            this.SaveTextButton.UseVisualStyleBackColor = true;
            this.SaveTextButton.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel,
            this.SecondsToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 466);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(817, 25);
            this.StatusStrip.TabIndex = 17;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(356, 20);
            this.ToolStripStatusLabel.Text = "Время выполнения алгоритма (в миллисекундах)";
            // 
            // SecondsToolStripStatusLabel
            // 
            this.SecondsToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SecondsToolStripStatusLabel.Name = "SecondsToolStripStatusLabel";
            this.SecondsToolStripStatusLabel.Size = new System.Drawing.Size(17, 20);
            this.SecondsToolStripStatusLabel.Text = "0";
            // 
            // GenKeyButton
            // 
            this.GenKeyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenKeyButton.Location = new System.Drawing.Point(339, 296);
            this.GenKeyButton.Name = "GenKeyButton";
            this.GenKeyButton.Size = new System.Drawing.Size(129, 46);
            this.GenKeyButton.TabIndex = 23;
            this.GenKeyButton.Text = "Сгенерировать ключ";
            this.GenKeyButton.UseVisualStyleBackColor = true;
            this.GenKeyButton.Click += new System.EventHandler(this.GenKeyButton_Click);
            // 
            // SaveKeyButton
            // 
            this.SaveKeyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveKeyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveKeyButton.Location = new System.Drawing.Point(587, 85);
            this.SaveKeyButton.Name = "SaveKeyButton";
            this.SaveKeyButton.Size = new System.Drawing.Size(93, 33);
            this.SaveKeyButton.TabIndex = 24;
            this.SaveKeyButton.Text = "Сохранить";
            this.SaveKeyButton.UseVisualStyleBackColor = true;
            this.SaveKeyButton.Click += new System.EventHandler(this.SaveKeyButton_Click);
            // 
            // RC4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 491);
            this.Controls.Add(this.SaveKeyButton);
            this.Controls.Add(this.GenKeyButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.SaveTextButton);
            this.Controls.Add(this.LoadTextButton);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.EncButton);
            this.Controls.Add(this.KeyTB);
            this.Controls.Add(this.InputRichTextBox);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximumSize = new System.Drawing.Size(833, 530);
            this.MinimumSize = new System.Drawing.Size(833, 530);
            this.Name = "RC4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RC4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RC4_FormClosing);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputRichTextBox;
        private System.Windows.Forms.TextBox KeyTB;
        private System.Windows.Forms.Button EncButton;
        private System.Windows.Forms.Button DecButton;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolStripMenuItem выбратьЦветЗаливкиТекстаToolStripMenuItem;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.Timer TimerAlgorithm;
        private System.Windows.Forms.Button LoadTextButton;
        private System.Windows.Forms.Button SaveTextButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel SecondsToolStripStatusLabel;
        private System.Windows.Forms.Button GenKeyButton;
        private System.Windows.Forms.Button SaveKeyButton;
    }
}