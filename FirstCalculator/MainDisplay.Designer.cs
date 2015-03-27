namespace FirstCalculator
{
    partial class MainDisplay
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
            this.Display = new System.Windows.Forms.TextBox();
            this.equalsButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.positiveNegativeButton = new System.Windows.Forms.Button();
            this.numberOneButton = new System.Windows.Forms.Button();
            this.numberTwoButton = new System.Windows.Forms.Button();
            this.numberThreeButton = new System.Windows.Forms.Button();
            this.numberFourButton = new System.Windows.Forms.Button();
            this.numberFiveButton = new System.Windows.Forms.Button();
            this.numberSixButton = new System.Windows.Forms.Button();
            this.numberSevenButton = new System.Windows.Forms.Button();
            this.numberEigthButton = new System.Windows.Forms.Button();
            this.numberNineButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.allClearButton = new System.Windows.Forms.Button();
            this.memRecoverButton = new System.Windows.Forms.Button();
            this.memStoreButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.percentageButton = new System.Windows.Forms.Button();
            this.oneOverXButton = new System.Windows.Forms.Button();
            this.piValueButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(12, 27);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(238, 36);
            this.Display.TabIndex = 0;
            this.Display.TabStop = false;
            this.Display.Text = "0";
            this.Display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Display.TextChanged += new System.EventHandler(this.Display_TextChanged);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(213, 219);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(38, 64);
            this.equalsButton.TabIndex = 1;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.zeroButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(12, 254);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(61, 29);
            this.zeroButton.TabIndex = 2;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(79, 254);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(61, 29);
            this.decimalButton.TabIndex = 3;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // positiveNegativeButton
            // 
            this.positiveNegativeButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveNegativeButton.Location = new System.Drawing.Point(146, 254);
            this.positiveNegativeButton.Name = "positiveNegativeButton";
            this.positiveNegativeButton.Size = new System.Drawing.Size(61, 29);
            this.positiveNegativeButton.TabIndex = 4;
            this.positiveNegativeButton.Text = "+/-";
            this.positiveNegativeButton.UseVisualStyleBackColor = true;
            this.positiveNegativeButton.Click += new System.EventHandler(this.positiveNegativeButton_Click);
            // 
            // numberOneButton
            // 
            this.numberOneButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberOneButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOneButton.Location = new System.Drawing.Point(12, 219);
            this.numberOneButton.Name = "numberOneButton";
            this.numberOneButton.Size = new System.Drawing.Size(61, 29);
            this.numberOneButton.TabIndex = 5;
            this.numberOneButton.Text = "1";
            this.numberOneButton.UseVisualStyleBackColor = false;
            this.numberOneButton.Click += new System.EventHandler(this.numberOneButton_Click);
            // 
            // numberTwoButton
            // 
            this.numberTwoButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberTwoButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTwoButton.Location = new System.Drawing.Point(79, 219);
            this.numberTwoButton.Name = "numberTwoButton";
            this.numberTwoButton.Size = new System.Drawing.Size(61, 29);
            this.numberTwoButton.TabIndex = 6;
            this.numberTwoButton.Text = "2";
            this.numberTwoButton.UseVisualStyleBackColor = false;
            this.numberTwoButton.Click += new System.EventHandler(this.numberTwoButton_Click);
            // 
            // numberThreeButton
            // 
            this.numberThreeButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberThreeButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberThreeButton.Location = new System.Drawing.Point(146, 219);
            this.numberThreeButton.Name = "numberThreeButton";
            this.numberThreeButton.Size = new System.Drawing.Size(61, 29);
            this.numberThreeButton.TabIndex = 7;
            this.numberThreeButton.Text = "3";
            this.numberThreeButton.UseVisualStyleBackColor = false;
            this.numberThreeButton.Click += new System.EventHandler(this.numberThreeButton_Click);
            // 
            // numberFourButton
            // 
            this.numberFourButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberFourButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFourButton.Location = new System.Drawing.Point(12, 184);
            this.numberFourButton.Name = "numberFourButton";
            this.numberFourButton.Size = new System.Drawing.Size(61, 29);
            this.numberFourButton.TabIndex = 8;
            this.numberFourButton.Text = "4";
            this.numberFourButton.UseVisualStyleBackColor = false;
            this.numberFourButton.Click += new System.EventHandler(this.numberFourButton_Click);
            // 
            // numberFiveButton
            // 
            this.numberFiveButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberFiveButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberFiveButton.Location = new System.Drawing.Point(79, 184);
            this.numberFiveButton.Name = "numberFiveButton";
            this.numberFiveButton.Size = new System.Drawing.Size(61, 29);
            this.numberFiveButton.TabIndex = 9;
            this.numberFiveButton.Text = "5";
            this.numberFiveButton.UseVisualStyleBackColor = false;
            this.numberFiveButton.Click += new System.EventHandler(this.numberFiveButton_Click);
            // 
            // numberSixButton
            // 
            this.numberSixButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberSixButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSixButton.Location = new System.Drawing.Point(146, 184);
            this.numberSixButton.Name = "numberSixButton";
            this.numberSixButton.Size = new System.Drawing.Size(61, 29);
            this.numberSixButton.TabIndex = 10;
            this.numberSixButton.Text = "6";
            this.numberSixButton.UseVisualStyleBackColor = false;
            this.numberSixButton.Click += new System.EventHandler(this.numberSixButton_Click);
            // 
            // numberSevenButton
            // 
            this.numberSevenButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberSevenButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSevenButton.Location = new System.Drawing.Point(12, 149);
            this.numberSevenButton.Name = "numberSevenButton";
            this.numberSevenButton.Size = new System.Drawing.Size(61, 29);
            this.numberSevenButton.TabIndex = 11;
            this.numberSevenButton.Text = "7";
            this.numberSevenButton.UseVisualStyleBackColor = false;
            this.numberSevenButton.Click += new System.EventHandler(this.numberSevenButton_Click);
            // 
            // numberEigthButton
            // 
            this.numberEigthButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberEigthButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberEigthButton.Location = new System.Drawing.Point(79, 149);
            this.numberEigthButton.Name = "numberEigthButton";
            this.numberEigthButton.Size = new System.Drawing.Size(61, 29);
            this.numberEigthButton.TabIndex = 12;
            this.numberEigthButton.Text = "8";
            this.numberEigthButton.UseVisualStyleBackColor = false;
            this.numberEigthButton.Click += new System.EventHandler(this.numberEigthButton_Click);
            // 
            // numberNineButton
            // 
            this.numberNineButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numberNineButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberNineButton.Location = new System.Drawing.Point(146, 149);
            this.numberNineButton.Name = "numberNineButton";
            this.numberNineButton.Size = new System.Drawing.Size(61, 29);
            this.numberNineButton.TabIndex = 13;
            this.numberNineButton.Text = "9";
            this.numberNineButton.UseVisualStyleBackColor = false;
            this.numberNineButton.Click += new System.EventHandler(this.numberNineButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.Location = new System.Drawing.Point(212, 184);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(38, 29);
            this.additionButton.TabIndex = 14;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subtractionButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionButton.Location = new System.Drawing.Point(212, 149);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(38, 29);
            this.subtractionButton.TabIndex = 15;
            this.subtractionButton.Text = "-";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(212, 114);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(38, 29);
            this.multiplicationButton.TabIndex = 16;
            this.multiplicationButton.Text = "x";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(212, 79);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(38, 29);
            this.divisionButton.TabIndex = 17;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryButton.Location = new System.Drawing.Point(12, 79);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(40, 29);
            this.clearEntryButton.TabIndex = 18;
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.clearEntryButton_Click);
            // 
            // allClearButton
            // 
            this.allClearButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClearButton.Location = new System.Drawing.Point(58, 79);
            this.allClearButton.Name = "allClearButton";
            this.allClearButton.Size = new System.Drawing.Size(40, 29);
            this.allClearButton.TabIndex = 19;
            this.allClearButton.Text = "AC";
            this.allClearButton.UseVisualStyleBackColor = true;
            this.allClearButton.Click += new System.EventHandler(this.allClearButton_Click);
            // 
            // memRecoverButton
            // 
            this.memRecoverButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memRecoverButton.Location = new System.Drawing.Point(121, 79);
            this.memRecoverButton.Name = "memRecoverButton";
            this.memRecoverButton.Size = new System.Drawing.Size(40, 29);
            this.memRecoverButton.TabIndex = 20;
            this.memRecoverButton.Text = "MR";
            this.memRecoverButton.UseVisualStyleBackColor = true;
            this.memRecoverButton.Click += new System.EventHandler(this.memRecoverButton_Click);
            // 
            // memStoreButton
            // 
            this.memStoreButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memStoreButton.Location = new System.Drawing.Point(167, 79);
            this.memStoreButton.Name = "memStoreButton";
            this.memStoreButton.Size = new System.Drawing.Size(40, 29);
            this.memStoreButton.TabIndex = 21;
            this.memStoreButton.Text = "MS";
            this.memStoreButton.UseVisualStyleBackColor = true;
            this.memStoreButton.Click += new System.EventHandler(this.memStoreButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrtButton.Location = new System.Drawing.Point(12, 114);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(34, 29);
            this.sqrtButton.TabIndex = 22;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareButton.Location = new System.Drawing.Point(52, 114);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(34, 29);
            this.squareButton.TabIndex = 23;
            this.squareButton.Text = "^2";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // percentageButton
            // 
            this.percentageButton.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageButton.Location = new System.Drawing.Point(132, 114);
            this.percentageButton.Name = "percentageButton";
            this.percentageButton.Size = new System.Drawing.Size(34, 29);
            this.percentageButton.TabIndex = 25;
            this.percentageButton.Text = "%";
            this.percentageButton.UseVisualStyleBackColor = true;
            this.percentageButton.Click += new System.EventHandler(this.percentageButton_Click);
            // 
            // oneOverXButton
            // 
            this.oneOverXButton.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneOverXButton.Location = new System.Drawing.Point(172, 114);
            this.oneOverXButton.Name = "oneOverXButton";
            this.oneOverXButton.Size = new System.Drawing.Size(34, 29);
            this.oneOverXButton.TabIndex = 26;
            this.oneOverXButton.Text = "1/x";
            this.oneOverXButton.UseVisualStyleBackColor = true;
            this.oneOverXButton.Click += new System.EventHandler(this.oneOverXButton_Click);
            // 
            // piValueButton
            // 
            this.piValueButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piValueButton.Location = new System.Drawing.Point(92, 115);
            this.piValueButton.Name = "piValueButton";
            this.piValueButton.Size = new System.Drawing.Size(34, 29);
            this.piValueButton.TabIndex = 27;
            this.piValueButton.Text = "π";
            this.piValueButton.UseVisualStyleBackColor = true;
            this.piValueButton.Click += new System.EventHandler(this.piValueButton_Click);
            // 
            // MainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 295);
            this.Controls.Add(this.piValueButton);
            this.Controls.Add(this.oneOverXButton);
            this.Controls.Add(this.percentageButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.memStoreButton);
            this.Controls.Add(this.memRecoverButton);
            this.Controls.Add(this.allClearButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.numberNineButton);
            this.Controls.Add(this.numberEigthButton);
            this.Controls.Add(this.numberSevenButton);
            this.Controls.Add(this.numberSixButton);
            this.Controls.Add(this.numberFiveButton);
            this.Controls.Add(this.numberFourButton);
            this.Controls.Add(this.numberThreeButton);
            this.Controls.Add(this.numberTwoButton);
            this.Controls.Add(this.numberOneButton);
            this.Controls.Add(this.positiveNegativeButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainDisplay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button positiveNegativeButton;
        private System.Windows.Forms.Button numberOneButton;
        private System.Windows.Forms.Button numberTwoButton;
        private System.Windows.Forms.Button numberThreeButton;
        private System.Windows.Forms.Button numberFourButton;
        private System.Windows.Forms.Button numberFiveButton;
        private System.Windows.Forms.Button numberSixButton;
        private System.Windows.Forms.Button numberSevenButton;
        private System.Windows.Forms.Button numberEigthButton;
        private System.Windows.Forms.Button numberNineButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button allClearButton;
        private System.Windows.Forms.Button memRecoverButton;
        private System.Windows.Forms.Button memStoreButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button percentageButton;
        private System.Windows.Forms.Button oneOverXButton;
        private System.Windows.Forms.Button piValueButton;
    }
}

