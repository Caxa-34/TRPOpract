namespace VYZ.Windows
{
    partial class MainMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOtch = new System.Windows.Forms.Button();
            this.btnKaf = new System.Windows.Forms.Button();
            this.btnPrep = new System.Windows.Forms.Button();
            this.btnStud = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(148, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваша роль: Завуч";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(108, 409);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(238, 73);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Завершить сеанс";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(136, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "Главное меню";
            // 
            // btnOtch
            // 
            this.btnOtch.BackColor = System.Drawing.Color.DimGray;
            this.btnOtch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOtch.ForeColor = System.Drawing.Color.White;
            this.btnOtch.Location = new System.Drawing.Point(108, 85);
            this.btnOtch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOtch.Name = "btnOtch";
            this.btnOtch.Size = new System.Drawing.Size(238, 73);
            this.btnOtch.TabIndex = 9;
            this.btnOtch.Text = "Отчеты";
            this.btnOtch.UseVisualStyleBackColor = false;
            this.btnOtch.Click += new System.EventHandler(this.btnOtch_Click);
            // 
            // btnKaf
            // 
            this.btnKaf.BackColor = System.Drawing.Color.DimGray;
            this.btnKaf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKaf.ForeColor = System.Drawing.Color.White;
            this.btnKaf.Location = new System.Drawing.Point(108, 166);
            this.btnKaf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaf.Name = "btnKaf";
            this.btnKaf.Size = new System.Drawing.Size(238, 73);
            this.btnKaf.TabIndex = 10;
            this.btnKaf.Text = "Кафедры и факультеты";
            this.btnKaf.UseVisualStyleBackColor = false;
            this.btnKaf.Click += new System.EventHandler(this.btnKaf_Click);
            // 
            // btnPrep
            // 
            this.btnPrep.BackColor = System.Drawing.Color.DimGray;
            this.btnPrep.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrep.ForeColor = System.Drawing.Color.White;
            this.btnPrep.Location = new System.Drawing.Point(108, 247);
            this.btnPrep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrep.Name = "btnPrep";
            this.btnPrep.Size = new System.Drawing.Size(238, 73);
            this.btnPrep.TabIndex = 11;
            this.btnPrep.Text = "Преподаватели и дисциплины";
            this.btnPrep.UseVisualStyleBackColor = false;
            this.btnPrep.Click += new System.EventHandler(this.btnPrep_Click);
            // 
            // btnStud
            // 
            this.btnStud.BackColor = System.Drawing.Color.DimGray;
            this.btnStud.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStud.ForeColor = System.Drawing.Color.White;
            this.btnStud.Location = new System.Drawing.Point(108, 328);
            this.btnStud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStud.Name = "btnStud";
            this.btnStud.Size = new System.Drawing.Size(238, 73);
            this.btnStud.TabIndex = 12;
            this.btnStud.Text = "Студенты";
            this.btnStud.UseVisualStyleBackColor = false;
            this.btnStud.Click += new System.EventHandler(this.btnStud_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 585);
            this.Controls.Add(this.btnStud);
            this.Controls.Add(this.btnPrep);
            this.Controls.Add(this.btnKaf);
            this.Controls.Add(this.btnOtch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnExit;
        private Label label2;
        private Button btnOtch;
        private Button btnKaf;
        private Button btnPrep;
        private Button btnStud;
    }
}