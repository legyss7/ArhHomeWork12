namespace ClinicDesctop
{
    partial class Form1
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
            gbButton = new Button();
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            SuspendLayout();
            // 
            // gbButton
            // 
            gbButton.Location = new Point(670, 409);
            gbButton.Name = "gbButton";
            gbButton.Size = new Size(94, 29);
            gbButton.TabIndex = 0;
            gbButton.Text = "Обновить";
            gbButton.UseVisualStyleBackColor = true;
            gbButton.Click += gbButton_Click;
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 12);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(776, 379);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Фамилия";
            columnHeaderSurName.Width = 200;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewClients);
            Controls.Add(gbButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя клиника";
            ResumeLayout(false);
        }

        #endregion

        private Button gbButton;
        private ListView listViewClients;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
    }
}
