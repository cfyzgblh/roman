namespace wordas
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
            components = new System.ComponentModel.Container();
            paragrathLabel = new Label();
            panel1 = new Panel();
            puthLabel = new Label();
            Puthbox = new TextBox();
            panel2 = new Panel();
            paragrathBox = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            CheckFatty = new CheckBox();
            panel3 = new Panel();
            SaveButton = new Button();
            AddButton = new Button();
            CollorBox = new ComboBox();
            siseBox = new TextBox();
            fontBox = new TextBox();
            sizeLabel = new Label();
            colorLabel = new Label();
            fontLabbel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // paragrathLabel
            // 
            paragrathLabel.AutoSize = true;
            paragrathLabel.Location = new Point(3, 69);
            paragrathLabel.Name = "paragrathLabel";
            paragrathLabel.Size = new Size(62, 15);
            paragrathLabel.TabIndex = 0;
            paragrathLabel.Text = "Параграф";
            // 
            // panel1
            // 
            panel1.Controls.Add(puthLabel);
            panel1.Controls.Add(Puthbox);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(paragrathLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 450);
            panel1.TabIndex = 1;
            // 
            // puthLabel
            // 
            puthLabel.AutoSize = true;
            puthLabel.Location = new Point(3, 9);
            puthLabel.Name = "puthLabel";
            puthLabel.Size = new Size(77, 15);
            puthLabel.TabIndex = 2;
            puthLabel.Text = "Введите путь";
            // 
            // Puthbox
            // 
            Puthbox.Location = new Point(0, 27);
            Puthbox.Name = "Puthbox";
            Puthbox.Size = new Size(324, 23);
            Puthbox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(paragrathBox);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 363);
            panel2.TabIndex = 0;
            // 
            // paragrathBox
            // 
            paragrathBox.Dock = DockStyle.Fill;
            paragrathBox.Location = new Point(0, 0);
            paragrathBox.Name = "paragrathBox";
            paragrathBox.Size = new Size(330, 363);
            paragrathBox.TabIndex = 1;
            paragrathBox.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // CheckFatty
            // 
            CheckFatty.AutoSize = true;
            CheckFatty.Location = new Point(6, 47);
            CheckFatty.Name = "CheckFatty";
            CheckFatty.Size = new Size(74, 19);
            CheckFatty.TabIndex = 3;
            CheckFatty.Text = "Жирный";
            CheckFatty.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(SaveButton);
            panel3.Controls.Add(AddButton);
            panel3.Controls.Add(CollorBox);
            panel3.Controls.Add(siseBox);
            panel3.Controls.Add(fontBox);
            panel3.Controls.Add(sizeLabel);
            panel3.Controls.Add(colorLabel);
            panel3.Controls.Add(fontLabbel);
            panel3.Controls.Add(CheckFatty);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(330, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 450);
            panel3.TabIndex = 3;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(322, 381);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(136, 57);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(6, 236);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(452, 49);
            AddButton.TabIndex = 10;
            AddButton.Text = "Добавить параграф";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // CollorBox
            // 
            CollorBox.FormattingEnabled = true;
            CollorBox.Location = new Point(6, 149);
            CollorBox.Name = "CollorBox";
            CollorBox.Size = new Size(452, 23);
            CollorBox.TabIndex = 9;
            // 
            // siseBox
            // 
            siseBox.Location = new Point(6, 193);
            siseBox.Name = "siseBox";
            siseBox.Size = new Size(452, 23);
            siseBox.TabIndex = 8;
            // 
            // fontBox
            // 
            fontBox.Location = new Point(6, 105);
            fontBox.Name = "fontBox";
            fontBox.Size = new Size(452, 23);
            fontBox.TabIndex = 7;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new Point(6, 175);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(47, 15);
            sizeLabel.TabIndex = 6;
            sizeLabel.Text = "Размер";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new Point(6, 131);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(33, 15);
            colorLabel.TabIndex = 5;
            colorLabel.Text = "Цвет";
            // 
            // fontLabbel
            // 
            fontLabbel.AutoSize = true;
            fontLabbel.Location = new Point(6, 87);
            fontLabbel.Name = "fontLabbel";
            fontLabbel.Size = new Size(46, 15);
            fontLabbel.TabIndex = 4;
            fontLabbel.Text = "Шрифт";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label paragrathLabel;
        private Panel panel1;
        private Label puthLabel;
        private TextBox Puthbox;
        private Panel panel2;
        private RichTextBox paragrathBox;
        private ContextMenuStrip contextMenuStrip1;
        private CheckBox CheckFatty;
        private Panel panel3;
        private TextBox siseBox;
        private TextBox fontBox;
        private Label sizeLabel;
        private Label colorLabel;
        private Label fontLabbel;
        private Button AddButton;
        private ComboBox CollorBox;
        private Button SaveButton;
    }
}