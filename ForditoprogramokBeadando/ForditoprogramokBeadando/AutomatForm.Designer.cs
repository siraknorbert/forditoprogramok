
namespace ForditoprogramokBeadando
{
    partial class AutomatForm
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
            this.messageLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.validateButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.rulesDataGridView = new System.Windows.Forms.DataGridView();
            this.readerLabel = new System.Windows.Forms.Label();
            this.readerComboBox = new System.Windows.Forms.ComboBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.readRulesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(13, 403);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(82, 20);
            this.messageLabel.TabIndex = 0;
            this.messageLabel.Text = "Messages...";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 13);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(46, 20);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input:";
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(298, 13);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(94, 29);
            this.validateButton.TabIndex = 2;
            this.validateButton.Text = "Validate";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(62, 13);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(230, 27);
            this.inputTextBox.TabIndex = 4;
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Location = new System.Drawing.Point(12, 84);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(379, 302);
            this.resultRichTextBox.TabIndex = 5;
            this.resultRichTextBox.Text = "";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(13, 53);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(90, 20);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Result steps:";
            // 
            // rulesDataGridView
            // 
            this.rulesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rulesDataGridView.Location = new System.Drawing.Point(448, 84);
            this.rulesDataGridView.Name = "rulesDataGridView";
            this.rulesDataGridView.RowHeadersWidth = 51;
            this.rulesDataGridView.RowTemplate.Height = 29;
            this.rulesDataGridView.ShowEditingIcon = false;
            this.rulesDataGridView.Size = new System.Drawing.Size(800, 300);
            this.rulesDataGridView.TabIndex = 7;
            // 
            // readerLabel
            // 
            this.readerLabel.AutoSize = true;
            this.readerLabel.Location = new System.Drawing.Point(448, 13);
            this.readerLabel.Name = "readerLabel";
            this.readerLabel.Size = new System.Drawing.Size(82, 20);
            this.readerLabel.TabIndex = 9;
            this.readerLabel.Text = "File reader:";
            // 
            // readerComboBox
            // 
            this.readerComboBox.FormattingEnabled = true;
            this.readerComboBox.Location = new System.Drawing.Point(536, 10);
            this.readerComboBox.Name = "readerComboBox";
            this.readerComboBox.Size = new System.Drawing.Size(151, 28);
            this.readerComboBox.TabIndex = 8;
            this.readerComboBox.SelectedIndexChanged += new System.EventHandler(this.readerComboBox_SelectedIndexChanged);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(536, 44);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(531, 27);
            this.pathTextBox.TabIndex = 11;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(448, 44);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(83, 20);
            this.pathLabel.TabIndex = 12;
            this.pathLabel.Text = "Path to file:";
            // 
            // readRulesButton
            // 
            this.readRulesButton.Location = new System.Drawing.Point(693, 10);
            this.readRulesButton.Name = "readRulesButton";
            this.readRulesButton.Size = new System.Drawing.Size(94, 29);
            this.readRulesButton.TabIndex = 13;
            this.readRulesButton.Text = "Read";
            this.readRulesButton.UseVisualStyleBackColor = true;
            this.readRulesButton.Click += new System.EventHandler(this.readRulesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select a file reader and a path to the file that contains the rules.";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(1073, 44);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(175, 27);
            this.fileTextBox.TabIndex = 15;
            // 
            // AutomatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 450);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readRulesButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.readerLabel);
            this.Controls.Add(this.readerComboBox);
            this.Controls.Add(this.rulesDataGridView);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.messageLabel);
            this.Name = "AutomatForm";
            this.Text = "AutomatForm";
            ((System.ComponentModel.ISupportInitialize)(this.rulesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.DataGridView rulesDataGridView;
        private System.Windows.Forms.Label readerLabel;
        private System.Windows.Forms.ComboBox readerComboBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button readRulesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileTextBox;
    }
}

