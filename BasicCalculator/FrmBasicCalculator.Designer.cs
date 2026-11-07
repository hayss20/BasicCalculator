namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            num1tb = new TextBox();
            num2tb = new TextBox();
            opecb = new ComboBox();
            resultrtb = new RichTextBox();
            computebtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // num1tb
            // 
            num1tb.BackColor = SystemColors.ScrollBar;
            num1tb.BorderStyle = BorderStyle.None;
            num1tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1tb.ForeColor = Color.Black;
            num1tb.Location = new Point(52, 58);
            num1tb.Name = "num1tb";
            num1tb.Size = new Size(157, 20);
            num1tb.TabIndex = 0;
            // 
            // num2tb
            // 
            num2tb.BackColor = SystemColors.ScrollBar;
            num2tb.BorderStyle = BorderStyle.None;
            num2tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2tb.ForeColor = Color.Black;
            num2tb.Location = new Point(52, 131);
            num2tb.Name = "num2tb";
            num2tb.Size = new Size(157, 20);
            num2tb.TabIndex = 1;
            // 
            // opecb
            // 
            opecb.FlatStyle = FlatStyle.Flat;
            opecb.Font = new Font("Segoe UI", 9F);
            opecb.FormattingEnabled = true;
            opecb.Items.AddRange(new object[] { "+", "-", "*", "/" });
            opecb.Location = new Point(52, 93);
            opecb.Name = "opecb";
            opecb.Size = new Size(55, 23);
            opecb.TabIndex = 2;
            // 
            // resultrtb
            // 
            resultrtb.BackColor = SystemColors.Info;
            resultrtb.BorderStyle = BorderStyle.None;
            resultrtb.Font = new Font("Segoe UI", 11F);
            resultrtb.Location = new Point(52, 168);
            resultrtb.Name = "resultrtb";
            resultrtb.Size = new Size(157, 96);
            resultrtb.TabIndex = 3;
            resultrtb.Text = "";
            // 
            // computebtn
            // 
            computebtn.BackColor = Color.SandyBrown;
            computebtn.FlatAppearance.BorderSize = 0;
            computebtn.FlatStyle = FlatStyle.Flat;
            computebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            computebtn.ForeColor = Color.White;
            computebtn.Location = new Point(75, 281);
            computebtn.Name = "computebtn";
            computebtn.Size = new Size(113, 34);
            computebtn.TabIndex = 4;
            computebtn.Text = "Compute";
            computebtn.UseVisualStyleBackColor = false;
            computebtn.Click += computebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 5;
            label1.Text = "Basic Calculator";
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(258, 333);
            Controls.Add(label1);
            Controls.Add(computebtn);
            Controls.Add(resultrtb);
            Controls.Add(opecb);
            Controls.Add(num2tb);
            Controls.Add(num1tb);
            Name = "FrmBasicCalculator";
            Text = "FrmBasicCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1tb;
        private TextBox num2tb;
        private ComboBox opecb;
        private RichTextBox resultrtb;
        private Button computebtn;
        private Label label1;
    }
}
