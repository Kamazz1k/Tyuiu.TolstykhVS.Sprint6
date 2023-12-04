
namespace Tyuiu.TolstykhVS.Sprint6.Task0.V25
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.c = new System.Windows.Forms.Button();
            this.buttonSpravka_TVS = new System.Windows.Forms.Button();
            this.GroupBoxYSLOVIE_TVS = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxVVOD_TVS = new System.Windows.Forms.GroupBox();
            this.groupBoxVIVOD_TVS = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxRezult_TVS = new System.Windows.Forms.TextBox();
            this.labelPEREMENNA_TVS = new System.Windows.Forms.Label();
            this.labelREZ_TVS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxYSLOVIE_TVS.SuspendLayout();
            this.groupBoxVVOD_TVS.SuspendLayout();
            this.groupBoxVIVOD_TVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(688, 412);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(97, 26);
            this.c.TabIndex = 0;
            this.c.Text = "Выполнить";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSpravka_TVS
            // 
            this.buttonSpravka_TVS.Location = new System.Drawing.Point(652, 412);
            this.buttonSpravka_TVS.Name = "buttonSpravka_TVS";
            this.buttonSpravka_TVS.Size = new System.Drawing.Size(30, 26);
            this.buttonSpravka_TVS.TabIndex = 1;
            this.buttonSpravka_TVS.Text = "?";
            this.buttonSpravka_TVS.UseVisualStyleBackColor = true;
            this.buttonSpravka_TVS.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // GroupBoxYSLOVIE_TVS
            // 
            this.GroupBoxYSLOVIE_TVS.Controls.Add(this.textBox1);
            this.GroupBoxYSLOVIE_TVS.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxYSLOVIE_TVS.Name = "GroupBoxYSLOVIE_TVS";
            this.GroupBoxYSLOVIE_TVS.Size = new System.Drawing.Size(186, 94);
            this.GroupBoxYSLOVIE_TVS.TabIndex = 2;
            this.GroupBoxYSLOVIE_TVS.TabStop = false;
            this.GroupBoxYSLOVIE_TVS.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Вычислить выражение по формуле:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBoxVVOD_TVS
            // 
            this.groupBoxVVOD_TVS.Controls.Add(this.labelPEREMENNA_TVS);
            this.groupBoxVVOD_TVS.Controls.Add(this.textBox2);
            this.groupBoxVVOD_TVS.Location = new System.Drawing.Point(12, 260);
            this.groupBoxVVOD_TVS.Name = "groupBoxVVOD_TVS";
            this.groupBoxVVOD_TVS.Size = new System.Drawing.Size(495, 94);
            this.groupBoxVVOD_TVS.TabIndex = 3;
            this.groupBoxVVOD_TVS.TabStop = false;
            this.groupBoxVVOD_TVS.Text = "Ввод данных";
            this.groupBoxVVOD_TVS.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxVIVOD_TVS
            // 
            this.groupBoxVIVOD_TVS.Controls.Add(this.labelREZ_TVS);
            this.groupBoxVIVOD_TVS.Controls.Add(this.textBoxRezult_TVS);
            this.groupBoxVIVOD_TVS.Location = new System.Drawing.Point(513, 260);
            this.groupBoxVIVOD_TVS.Name = "groupBoxVIVOD_TVS";
            this.groupBoxVIVOD_TVS.Size = new System.Drawing.Size(272, 94);
            this.groupBoxVIVOD_TVS.TabIndex = 4;
            this.groupBoxVIVOD_TVS.TabStop = false;
            this.groupBoxVIVOD_TVS.Text = "Ввод данных";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBoxRezult_TVS
            // 
            this.textBoxRezult_TVS.Location = new System.Drawing.Point(6, 36);
            this.textBoxRezult_TVS.Name = "textBoxRezult_TVS";
            this.textBoxRezult_TVS.ReadOnly = true;
            this.textBoxRezult_TVS.Size = new System.Drawing.Size(100, 20);
            this.textBoxRezult_TVS.TabIndex = 0;
            this.textBoxRezult_TVS.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelPEREMENNA_TVS
            // 
            this.labelPEREMENNA_TVS.AutoSize = true;
            this.labelPEREMENNA_TVS.Location = new System.Drawing.Point(6, 20);
            this.labelPEREMENNA_TVS.Name = "labelPEREMENNA_TVS";
            this.labelPEREMENNA_TVS.Size = new System.Drawing.Size(82, 13);
            this.labelPEREMENNA_TVS.TabIndex = 4;
            this.labelPEREMENNA_TVS.Text = "Переменная x:";
            this.labelPEREMENNA_TVS.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelREZ_TVS
            // 
            this.labelREZ_TVS.AutoSize = true;
            this.labelREZ_TVS.Location = new System.Drawing.Point(6, 20);
            this.labelREZ_TVS.Name = "labelREZ_TVS";
            this.labelREZ_TVS.Size = new System.Drawing.Size(62, 13);
            this.labelREZ_TVS.TabIndex = 5;
            this.labelREZ_TVS.Text = "Результат:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 185);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxVIVOD_TVS);
            this.Controls.Add(this.groupBoxVVOD_TVS);
            this.Controls.Add(this.GroupBoxYSLOVIE_TVS);
            this.Controls.Add(this.buttonSpravka_TVS);
            this.Controls.Add(this.c);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт6 l Task0 l вариант 25 l Толстых В. С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GroupBoxYSLOVIE_TVS.ResumeLayout(false);
            this.GroupBoxYSLOVIE_TVS.PerformLayout();
            this.groupBoxVVOD_TVS.ResumeLayout(false);
            this.groupBoxVVOD_TVS.PerformLayout();
            this.groupBoxVIVOD_TVS.ResumeLayout(false);
            this.groupBoxVIVOD_TVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button buttonSpravka_TVS;
        private System.Windows.Forms.GroupBox GroupBoxYSLOVIE_TVS;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxVVOD_TVS;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBoxVIVOD_TVS;
        private System.Windows.Forms.TextBox textBoxRezult_TVS;
        private System.Windows.Forms.Label labelPEREMENNA_TVS;
        private System.Windows.Forms.Label labelREZ_TVS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

