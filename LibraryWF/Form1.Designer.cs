namespace LibraryWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxListBooks = new System.Windows.Forms.ComboBox();
            this.labelToDelete = new System.Windows.Forms.Label();
            this.labelAddToLibrary = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelNameDelete = new System.Windows.Forms.Label();
            this.textBoxNameDelete = new System.Windows.Forms.TextBox();
            this.buttonNameDelete = new System.Windows.Forms.Button();
            this.buttonOnOf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.ForeColor = System.Drawing.Color.White;
            this.labelNumber.Location = new System.Drawing.Point(13, 189);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(172, 17);
            this.labelNumber.TabIndex = 2;
            this.labelNumber.Text = "Номер места размещения:";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.Color.White;
            this.labelAuthor.Location = new System.Drawing.Point(13, 126);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(13, 65);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(70, 17);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Название:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(16, 214);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(173, 23);
            this.textBoxNumber.TabIndex = 5;
            this.textBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumber_KeyPress);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(16, 146);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(285, 23);
            this.textBoxAuthor.TabIndex = 6;
            this.textBoxAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAuthor_KeyPress);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTitle.Location = new System.Drawing.Point(16, 85);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(285, 23);
            this.textBoxTitle.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(223, 214);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxListBooks
            // 
            this.comboBoxListBooks.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxListBooks.FormattingEnabled = true;
            this.comboBoxListBooks.Location = new System.Drawing.Point(16, 353);
            this.comboBoxListBooks.Name = "comboBoxListBooks";
            this.comboBoxListBooks.Size = new System.Drawing.Size(571, 25);
            this.comboBoxListBooks.TabIndex = 9;
            this.comboBoxListBooks.Text = "Выбрать произведение";
            this.comboBoxListBooks.SelectedIndexChanged += new System.EventHandler(this.comboBoxListBooks_SelectedIndexChanged);
            // 
            // labelToDelete
            // 
            this.labelToDelete.AutoSize = true;
            this.labelToDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelToDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToDelete.ForeColor = System.Drawing.Color.White;
            this.labelToDelete.Location = new System.Drawing.Point(12, 321);
            this.labelToDelete.Name = "labelToDelete";
            this.labelToDelete.Size = new System.Drawing.Size(362, 19);
            this.labelToDelete.TabIndex = 10;
            this.labelToDelete.Text = "Просмотр библиотеки и удаление произведений:";
            // 
            // labelAddToLibrary
            // 
            this.labelAddToLibrary.AutoSize = true;
            this.labelAddToLibrary.BackColor = System.Drawing.Color.Transparent;
            this.labelAddToLibrary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddToLibrary.ForeColor = System.Drawing.Color.White;
            this.labelAddToLibrary.Location = new System.Drawing.Point(12, 22);
            this.labelAddToLibrary.Name = "labelAddToLibrary";
            this.labelAddToLibrary.Size = new System.Drawing.Size(285, 19);
            this.labelAddToLibrary.TabIndex = 11;
            this.labelAddToLibrary.Text = "Добавить произведение в библиотеку:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(16, 263);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(285, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Обновить список библиотеки";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelNameDelete
            // 
            this.labelNameDelete.AutoSize = true;
            this.labelNameDelete.BackColor = System.Drawing.Color.Transparent;
            this.labelNameDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameDelete.ForeColor = System.Drawing.Color.White;
            this.labelNameDelete.Location = new System.Drawing.Point(13, 413);
            this.labelNameDelete.Name = "labelNameDelete";
            this.labelNameDelete.Size = new System.Drawing.Size(273, 19);
            this.labelNameDelete.TabIndex = 13;
            this.labelNameDelete.Text = "Удалить произведений по названию:";
            // 
            // textBoxNameDelete
            // 
            this.textBoxNameDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameDelete.Location = new System.Drawing.Point(16, 443);
            this.textBoxNameDelete.Name = "textBoxNameDelete";
            this.textBoxNameDelete.Size = new System.Drawing.Size(377, 23);
            this.textBoxNameDelete.TabIndex = 14;
            // 
            // buttonNameDelete
            // 
            this.buttonNameDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNameDelete.Location = new System.Drawing.Point(438, 443);
            this.buttonNameDelete.Name = "buttonNameDelete";
            this.buttonNameDelete.Size = new System.Drawing.Size(149, 23);
            this.buttonNameDelete.TabIndex = 15;
            this.buttonNameDelete.Text = "Удалить";
            this.buttonNameDelete.UseVisualStyleBackColor = true;
            this.buttonNameDelete.Click += new System.EventHandler(this.buttonNameDelete_Click);
            // 
            // buttonOnOf
            // 
            this.buttonOnOf.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonOnOf.ForeColor = System.Drawing.Color.White;
            this.buttonOnOf.Location = new System.Drawing.Point(512, 22);
            this.buttonOnOf.Name = "buttonOnOf";
            this.buttonOnOf.Size = new System.Drawing.Size(75, 23);
            this.buttonOnOf.TabIndex = 16;
            this.buttonOnOf.Text = "Вкл";
            this.buttonOnOf.UseVisualStyleBackColor = false;
            this.buttonOnOf.Click += new System.EventHandler(this.buttonOnOf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::LibraryWF.Properties.Resources.Б3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 491);
            this.Controls.Add(this.buttonOnOf);
            this.Controls.Add(this.buttonNameDelete);
            this.Controls.Add(this.textBoxNameDelete);
            this.Controls.Add(this.labelNameDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelAddToLibrary);
            this.Controls.Add(this.labelToDelete);
            this.Controls.Add(this.comboBoxListBooks);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(622, 530);
            this.MinimumSize = new System.Drawing.Size(622, 530);
            this.Name = "Form1";
            this.Text = "Форма добавления и удаления книг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxListBooks;
        private System.Windows.Forms.Label labelToDelete;
        private System.Windows.Forms.Label labelAddToLibrary;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelNameDelete;
        private System.Windows.Forms.TextBox textBoxNameDelete;
        private System.Windows.Forms.Button buttonNameDelete;
        private System.Windows.Forms.Button buttonOnOf;
    }
}

