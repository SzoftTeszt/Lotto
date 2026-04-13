namespace Desktop
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblSelectedNumbers = new Label();
            btnSorsol = new Button();
            btnTorol = new Button();
            lblSorsolt = new Label();
            lblTalalt = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 444);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(603, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(194, 444);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTalalt);
            panel3.Controls.Add(lblSorsolt);
            panel3.Controls.Add(lblSelectedNumbers);
            panel3.Controls.Add(btnSorsol);
            panel3.Controls.Add(btnTorol);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 444);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // lblSelectedNumbers
            // 
            lblSelectedNumbers.AutoSize = true;
            lblSelectedNumbers.Location = new Point(41, 24);
            lblSelectedNumbers.Name = "lblSelectedNumbers";
            lblSelectedNumbers.Size = new Size(38, 15);
            lblSelectedNumbers.TabIndex = 6;
            lblSelectedNumbers.Text = "label1";
            // 
            // btnSorsol
            // 
            btnSorsol.Location = new Point(39, 187);
            btnSorsol.Name = "btnSorsol";
            btnSorsol.Size = new Size(75, 23);
            btnSorsol.TabIndex = 5;
            btnSorsol.Text = "Sorsol";
            btnSorsol.UseVisualStyleBackColor = true;
            btnSorsol.Click += btnSorsol_Click;
            // 
            // btnTorol
            // 
            btnTorol.Location = new Point(38, 132);
            btnTorol.Name = "btnTorol";
            btnTorol.Size = new Size(75, 23);
            btnTorol.TabIndex = 4;
            btnTorol.Text = "Töröl";
            btnTorol.UseVisualStyleBackColor = true;
            btnTorol.Click += btnTorol_Click;
            // 
            // lblSorsolt
            // 
            lblSorsolt.AutoSize = true;
            lblSorsolt.Location = new Point(41, 53);
            lblSorsolt.Name = "lblSorsolt";
            lblSorsolt.Size = new Size(38, 15);
            lblSorsolt.TabIndex = 6;
            lblSorsolt.Text = "label1";
            // 
            // lblTalalt
            // 
            lblTalalt.AutoSize = true;
            lblTalalt.Location = new Point(41, 82);
            lblTalalt.Name = "lblTalalt";
            lblTalalt.Size = new Size(38, 15);
            lblTalalt.TabIndex = 6;
            lblTalalt.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.lohere;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Lottó Szimuláció";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblSelectedNumbers;
        private Button btnSorsol;
        private Button btnTorol;
        private Label lblTalalt;
        private Label lblSorsolt;
    }
}
