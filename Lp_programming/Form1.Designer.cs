namespace Lp_programming
{
    partial class windowForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methodLabel = new System.Windows.Forms.Label();
            this.minMaxBox = new System.Windows.Forms.ComboBox();
            this.minMaxLabel = new System.Windows.Forms.Label();
            this.variablesLabel = new System.Windows.Forms.Label();
            this.limitLabel = new System.Windows.Forms.Label();
            this.variablesBox = new System.Windows.Forms.TextBox();
            this.limitBox = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.tablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.functionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.metodsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // metodsToolStripMenuItem
            // 
            this.metodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphicToolStripMenuItem,
            this.simplexToolStripMenuItem,
            this.basisToolStripMenuItem});
            this.metodsToolStripMenuItem.Name = "metodsToolStripMenuItem";
            this.metodsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.metodsToolStripMenuItem.Text = "Метод";
            // 
            // graphicToolStripMenuItem
            // 
            this.graphicToolStripMenuItem.Name = "graphicToolStripMenuItem";
            this.graphicToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.graphicToolStripMenuItem.Text = "Графический";
            this.graphicToolStripMenuItem.Click += new System.EventHandler(this.graphicToolStripMenuItem_Click);
            // 
            // simplexToolStripMenuItem
            // 
            this.simplexToolStripMenuItem.Name = "simplexToolStripMenuItem";
            this.simplexToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.simplexToolStripMenuItem.Text = "Симлекс";
            this.simplexToolStripMenuItem.Click += new System.EventHandler(this.simplexToolStripMenuItem_Click);
            // 
            // basisToolStripMenuItem
            // 
            this.basisToolStripMenuItem.Name = "basisToolStripMenuItem";
            this.basisToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.basisToolStripMenuItem.Text = "Иск. базиса";
            this.basisToolStripMenuItem.Click += new System.EventHandler(this.basisToolStripMenuItem_Click);
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.methodLabel.Location = new System.Drawing.Point(6, 16);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(234, 20);
            this.methodLabel.TabIndex = 1;
            this.methodLabel.Text = "Метод искуственного базиса:";
            // 
            // minMaxBox
            // 
            this.minMaxBox.FormattingEnabled = true;
            this.minMaxBox.Location = new System.Drawing.Point(10, 98);
            this.minMaxBox.Name = "minMaxBox";
            this.minMaxBox.Size = new System.Drawing.Size(121, 21);
            this.minMaxBox.TabIndex = 2;
            this.minMaxBox.Click += new System.EventHandler(this.minMaxBox_Click);
            // 
            // minMaxLabel
            // 
            this.minMaxLabel.AutoSize = true;
            this.minMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.minMaxLabel.Location = new System.Drawing.Point(7, 67);
            this.minMaxLabel.Name = "minMaxLabel";
            this.minMaxLabel.Size = new System.Drawing.Size(151, 17);
            this.minMaxLabel.TabIndex = 3;
            this.minMaxLabel.Text = "Сводимость функции:";
            // 
            // variablesLabel
            // 
            this.variablesLabel.AutoSize = true;
            this.variablesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.variablesLabel.Location = new System.Drawing.Point(7, 133);
            this.variablesLabel.Name = "variablesLabel";
            this.variablesLabel.Size = new System.Drawing.Size(179, 17);
            this.variablesLabel.TabIndex = 4;
            this.variablesLabel.Text = "Количество переменных: ";
            // 
            // limitLabel
            // 
            this.limitLabel.AutoSize = true;
            this.limitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.limitLabel.Location = new System.Drawing.Point(7, 200);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(226, 17);
            this.limitLabel.TabIndex = 6;
            this.limitLabel.Text = "Количество строк(ограничений):";
            // 
            // variablesBox
            // 
            this.variablesBox.Location = new System.Drawing.Point(10, 168);
            this.variablesBox.Name = "variablesBox";
            this.variablesBox.Size = new System.Drawing.Size(75, 20);
            this.variablesBox.TabIndex = 8;
            // 
            // limitBox
            // 
            this.limitBox.Location = new System.Drawing.Point(10, 240);
            this.limitBox.Name = "limitBox";
            this.limitBox.Size = new System.Drawing.Size(75, 20);
            this.limitBox.TabIndex = 9;
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox.Controls.Add(this.StartButton);
            this.groupBox.Controls.Add(this.methodLabel);
            this.groupBox.Controls.Add(this.limitBox);
            this.groupBox.Controls.Add(this.minMaxBox);
            this.groupBox.Controls.Add(this.variablesBox);
            this.groupBox.Controls.Add(this.minMaxLabel);
            this.groupBox.Controls.Add(this.limitLabel);
            this.groupBox.Controls.Add(this.variablesLabel);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(247, 322);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(83, 280);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.functionPanel);
            this.groupBox2.Controls.Add(this.tablePanel);
            this.groupBox2.Location = new System.Drawing.Point(284, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(13, 76);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.groupBox);
            this.panel.Controls.Add(this.groupBox2);
            this.panel.Location = new System.Drawing.Point(12, 27);
            this.panel.Margin = new System.Windows.Forms.Padding(6);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(300, 328);
            this.panel.TabIndex = 12;
            // 
            // tablePanel
            // 
            this.tablePanel.AutoSize = true;
            this.tablePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tablePanel.Location = new System.Drawing.Point(7, 57);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(0, 0);
            this.tablePanel.TabIndex = 2;
            // 
            // functionPanel
            // 
            this.functionPanel.AutoSize = true;
            this.functionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.functionPanel.Location = new System.Drawing.Point(7, 20);
            this.functionPanel.Name = "functionPanel";
            this.functionPanel.Size = new System.Drawing.Size(0, 0);
            this.functionPanel.TabIndex = 3;
            // 
            // windowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(861, 516);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "windowForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.ComboBox minMaxBox;
        private System.Windows.Forms.Label minMaxLabel;
        private System.Windows.Forms.Label variablesLabel;
        private System.Windows.Forms.Label limitLabel;
        private System.Windows.Forms.TextBox variablesBox;
        private System.Windows.Forms.TextBox limitBox;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.FlowLayoutPanel tablePanel;
        private System.Windows.Forms.FlowLayoutPanel functionPanel;
    }
}

