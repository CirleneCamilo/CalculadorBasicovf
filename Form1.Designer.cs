namespace CalculadorBasicovf
{
    partial class CalculadorBasicovf
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt01 = new System.Windows.Forms.Label();
            this.CaixaTxt01 = new System.Windows.Forms.TextBox();
            this.CaixaTxt02 = new System.Windows.Forms.TextBox();
            this.Bt01 = new System.Windows.Forms.Button();
            this.Bt02 = new System.Windows.Forms.Button();
            this.Bt03 = new System.Windows.Forms.Button();
            this.Bt04 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite outro número:";
            // 
            // Txt01
            // 
            this.Txt01.AutoSize = true;
            this.Txt01.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Txt01.Location = new System.Drawing.Point(94, 234);
            this.Txt01.Name = "Txt01";
            this.Txt01.Size = new System.Drawing.Size(132, 26);
            this.Txt01.TabIndex = 3;
            this.Txt01.Text = "Resultado:";
            // 
            // CaixaTxt01
            // 
            this.CaixaTxt01.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaixaTxt01.Location = new System.Drawing.Point(210, 85);
            this.CaixaTxt01.Name = "CaixaTxt01";
            this.CaixaTxt01.Size = new System.Drawing.Size(187, 34);
            this.CaixaTxt01.TabIndex = 4;
            // 
            // CaixaTxt02
            // 
            this.CaixaTxt02.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaixaTxt02.Location = new System.Drawing.Point(210, 179);
            this.CaixaTxt02.Name = "CaixaTxt02";
            this.CaixaTxt02.Size = new System.Drawing.Size(187, 34);
            this.CaixaTxt02.TabIndex = 5;
            // 
            // Bt01
            // 
            this.Bt01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt01.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt01.Location = new System.Drawing.Point(519, 65);
            this.Bt01.Name = "Bt01";
            this.Bt01.Size = new System.Drawing.Size(94, 64);
            this.Bt01.TabIndex = 6;
            this.Bt01.Text = "+";
            this.Bt01.UseVisualStyleBackColor = false;
            this.Bt01.Click += new System.EventHandler(this.Bt01_Click);
            // 
            // Bt02
            // 
            this.Bt02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt02.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt02.Location = new System.Drawing.Point(630, 65);
            this.Bt02.Name = "Bt02";
            this.Bt02.Size = new System.Drawing.Size(94, 64);
            this.Bt02.TabIndex = 7;
            this.Bt02.Text = "-";
            this.Bt02.UseVisualStyleBackColor = false;
            this.Bt02.Click += new System.EventHandler(this.Bt02_Click);
            // 
            // Bt03
            // 
            this.Bt03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt03.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt03.Location = new System.Drawing.Point(519, 153);
            this.Bt03.Name = "Bt03";
            this.Bt03.Size = new System.Drawing.Size(94, 76);
            this.Bt03.TabIndex = 8;
            this.Bt03.Text = "*";
            this.Bt03.UseVisualStyleBackColor = false;
            this.Bt03.Click += new System.EventHandler(this.Bt03_Click);
            // 
            // Bt04
            // 
            this.Bt04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Bt04.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bt04.Location = new System.Drawing.Point(630, 153);
            this.Bt04.Name = "Bt04";
            this.Bt04.Size = new System.Drawing.Size(94, 76);
            this.Bt04.TabIndex = 9;
            this.Bt04.Text = "/";
            this.Bt04.UseVisualStyleBackColor = false;
            this.Bt04.Click += new System.EventHandler(this.Bt04_Click);
            // 
            // CalculadorBasicovf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bt04);
            this.Controls.Add(this.Bt03);
            this.Controls.Add(this.Bt02);
            this.Controls.Add(this.Bt01);
            this.Controls.Add(this.CaixaTxt02);
            this.Controls.Add(this.CaixaTxt01);
            this.Controls.Add(this.Txt01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculadorBasicovf";
            this.Text = "Calculador Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Txt01;
        private TextBox CaixaTxt01;
        private TextBox CaixaTxt02;
        private Button Bt01;
        private Button Bt02;
        private Button Bt03;
        private Button Bt04;
    }
}