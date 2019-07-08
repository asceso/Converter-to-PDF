namespace Converter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.DownPosition = new System.Windows.Forms.Button();
            this.UpPosition = new System.Windows.Forms.Button();
            this.RemoveFromCollectionButton = new System.Windows.Forms.Button();
            this.AddToCollectionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageCollectionList = new System.Windows.Forms.ListBox();
            this.CreatePDFButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FileNameLabel);
            this.tabPage1.Controls.Add(this.ClearAllBtn);
            this.tabPage1.Controls.Add(this.DownPosition);
            this.tabPage1.Controls.Add(this.UpPosition);
            this.tabPage1.Controls.Add(this.RemoveFromCollectionButton);
            this.tabPage1.Controls.Add(this.AddToCollectionButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ImageCollectionList);
            this.tabPage1.Controls.Add(this.CreatePDFButton);
            this.tabPage1.Controls.Add(this.FileNameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "JPG to PDF";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(8, 10);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(64, 13);
            this.FileNameLabel.TabIndex = 11;
            this.FileNameLabel.Text = "Имя файла";
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearAllBtn.Location = new System.Drawing.Point(8, 425);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(738, 23);
            this.ClearAllBtn.TabIndex = 10;
            this.ClearAllBtn.Text = "Очистить список";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // DownPosition
            // 
            this.DownPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownPosition.Location = new System.Drawing.Point(386, 396);
            this.DownPosition.Name = "DownPosition";
            this.DownPosition.Size = new System.Drawing.Size(360, 23);
            this.DownPosition.TabIndex = 8;
            this.DownPosition.Text = "На позицию вниз";
            this.DownPosition.UseVisualStyleBackColor = true;
            this.DownPosition.Click += new System.EventHandler(this.DownPosition_Click);
            // 
            // UpPosition
            // 
            this.UpPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpPosition.Location = new System.Drawing.Point(8, 396);
            this.UpPosition.Name = "UpPosition";
            this.UpPosition.Size = new System.Drawing.Size(360, 23);
            this.UpPosition.TabIndex = 7;
            this.UpPosition.Text = "На позицию вверх";
            this.UpPosition.UseVisualStyleBackColor = true;
            this.UpPosition.Click += new System.EventHandler(this.UpPosition_Click);
            // 
            // RemoveFromCollectionButton
            // 
            this.RemoveFromCollectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFromCollectionButton.Location = new System.Drawing.Point(386, 367);
            this.RemoveFromCollectionButton.Name = "RemoveFromCollectionButton";
            this.RemoveFromCollectionButton.Size = new System.Drawing.Size(360, 23);
            this.RemoveFromCollectionButton.TabIndex = 6;
            this.RemoveFromCollectionButton.Text = "Удалить элемент";
            this.RemoveFromCollectionButton.UseVisualStyleBackColor = true;
            this.RemoveFromCollectionButton.Click += new System.EventHandler(this.RemoveFromCollectionButton_Click);
            // 
            // AddToCollectionButton
            // 
            this.AddToCollectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCollectionButton.Location = new System.Drawing.Point(8, 367);
            this.AddToCollectionButton.Name = "AddToCollectionButton";
            this.AddToCollectionButton.Size = new System.Drawing.Size(360, 23);
            this.AddToCollectionButton.TabIndex = 5;
            this.AddToCollectionButton.Text = "Добавить элемент";
            this.AddToCollectionButton.UseVisualStyleBackColor = true;
            this.AddToCollectionButton.Click += new System.EventHandler(this.AddToCollectionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Изображения";
            // 
            // ImageCollectionList
            // 
            this.ImageCollectionList.AllowDrop = true;
            this.ImageCollectionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageCollectionList.FormattingEnabled = true;
            this.ImageCollectionList.HorizontalScrollbar = true;
            this.ImageCollectionList.Location = new System.Drawing.Point(8, 73);
            this.ImageCollectionList.Name = "ImageCollectionList";
            this.ImageCollectionList.ScrollAlwaysVisible = true;
            this.ImageCollectionList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ImageCollectionList.Size = new System.Drawing.Size(738, 277);
            this.ImageCollectionList.TabIndex = 3;
            this.ImageCollectionList.SelectedIndexChanged += new System.EventHandler(this.ImageCollectionList_SelectedIndexChanged);
            this.ImageCollectionList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ImageCollectionList_DragDrop);
            // 
            // CreatePDFButton
            // 
            this.CreatePDFButton.Location = new System.Drawing.Point(114, 25);
            this.CreatePDFButton.Name = "CreatePDFButton";
            this.CreatePDFButton.Size = new System.Drawing.Size(155, 21);
            this.CreatePDFButton.TabIndex = 2;
            this.CreatePDFButton.Text = "Создать PDF";
            this.CreatePDFButton.UseVisualStyleBackColor = true;
            this.CreatePDFButton.Click += new System.EventHandler(this.CreatePDFButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Location = new System.Drawing.Point(8, 26);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(100, 20);
            this.FileNameBox.TabIndex = 0;
            this.FileNameBox.Text = "OUTPUT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 481);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(778, 519);
            this.Name = "MainForm";
            this.Text = "Converter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button CreatePDFButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DownPosition;
        private System.Windows.Forms.Button UpPosition;
        private System.Windows.Forms.Button RemoveFromCollectionButton;
        private System.Windows.Forms.Button AddToCollectionButton;
        private System.Windows.Forms.ListBox ImageCollectionList;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Label FileNameLabel;
    }
}

