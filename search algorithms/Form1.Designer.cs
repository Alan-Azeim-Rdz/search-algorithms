namespace search_algorithms
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
            txtNumbers = new TextBox();
            txtSearch = new TextBox();
            rbtnSequential = new RadioButton();
            rbtnBinary = new RadioButton();
            rbtnHash = new RadioButton();
            btnSearch = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(31, 21);
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(174, 23);
            txtNumbers.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(31, 90);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(174, 23);
            txtSearch.TabIndex = 1;
            // 
            // rbtnSequential
            // 
            rbtnSequential.AutoSize = true;
            rbtnSequential.Location = new Point(59, 189);
            rbtnSequential.Name = "rbtnSequential";
            rbtnSequential.Size = new Size(117, 19);
            rbtnSequential.TabIndex = 2;
            rbtnSequential.TabStop = true;
            rbtnSequential.Text = "Search Secuential";
            rbtnSequential.UseVisualStyleBackColor = true;
            // 
            // rbtnBinary
            // 
            rbtnBinary.AutoSize = true;
            rbtnBinary.Location = new Point(59, 227);
            rbtnBinary.Name = "rbtnBinary";
            rbtnBinary.Size = new Size(96, 19);
            rbtnBinary.TabIndex = 3;
            rbtnBinary.TabStop = true;
            rbtnBinary.Text = "Search Binary";
            rbtnBinary.UseVisualStyleBackColor = true;
            // 
            // rbtnHash
            // 
            rbtnHash.AutoSize = true;
            rbtnHash.Location = new Point(59, 263);
            rbtnHash.Name = "rbtnHash";
            rbtnHash.Size = new Size(90, 19);
            rbtnHash.TabIndex = 4;
            rbtnHash.TabStop = true;
            rbtnHash.Text = "Search Hash";
            rbtnHash.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(31, 133);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(381, 21);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 15);
            lblResult.TabIndex = 6;
            lblResult.Text = "lblResult";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnSearch);
            Controls.Add(rbtnHash);
            Controls.Add(rbtnBinary);
            Controls.Add(rbtnSequential);
            Controls.Add(txtSearch);
            Controls.Add(txtNumbers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumbers;
        private TextBox txtSearch;
        private RadioButton rbtnSequential;
        private RadioButton rbtnBinary;
        private RadioButton rbtnHash;
        private Button btnSearch;
        private Label lblResult;
    }
}
