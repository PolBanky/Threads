namespace Threads
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxThread = new System.Windows.Forms.ListBox();
            this.listBoxPitch = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBSPP = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxShowForm2 = new System.Windows.Forms.CheckBox();
            this.labelThreadChoiseResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aLabel4 = new Threads.aLabel();
            this.aLabel3 = new Threads.aLabel();
            this.aLabel2 = new Threads.aLabel();
            this.aLabel1 = new Threads.aLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxThread
            // 
            this.listBoxThread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxThread.FormattingEnabled = true;
            this.listBoxThread.Location = new System.Drawing.Point(12, 28);
            this.listBoxThread.Name = "listBoxThread";
            this.listBoxThread.Size = new System.Drawing.Size(150, 67);
            this.listBoxThread.TabIndex = 1;
            this.listBoxThread.SelectedIndexChanged += new System.EventHandler(this.listBoxThread_SelectedIndexChanged);
            // 
            // listBoxPitch
            // 
            this.listBoxPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPitch.FormattingEnabled = true;
            this.listBoxPitch.Location = new System.Drawing.Point(12, 125);
            this.listBoxPitch.Name = "listBoxPitch";
            this.listBoxPitch.Size = new System.Drawing.Size(150, 80);
            this.listBoxPitch.TabIndex = 2;
            this.listBoxPitch.SelectedIndexChanged += new System.EventHandler(this.listBoxPitch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номинальный диаметр резьбы d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шаг резьбы P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Внутренний диаметр гайки d1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Диаметр по дну впадины d3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBSPP);
            this.groupBox1.Controls.Add(this.radioButtonM);
            this.groupBox1.Location = new System.Drawing.Point(431, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стандарт резьбы";
            // 
            // radioButtonBSPP
            // 
            this.radioButtonBSPP.AutoSize = true;
            this.radioButtonBSPP.Location = new System.Drawing.Point(7, 44);
            this.radioButtonBSPP.Name = "radioButtonBSPP";
            this.radioButtonBSPP.Size = new System.Drawing.Size(53, 17);
            this.radioButtonBSPP.TabIndex = 1;
            this.radioButtonBSPP.Text = "BSPP";
            this.radioButtonBSPP.UseVisualStyleBackColor = true;
            this.radioButtonBSPP.CheckedChanged += new System.EventHandler(this.radioButtonBSPP_CheckedChanged);
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Checked = true;
            this.radioButtonM.Location = new System.Drawing.Point(7, 20);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(92, 17);
            this.radioButtonM.TabIndex = 0;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Метрическая";
            this.radioButtonM.UseVisualStyleBackColor = true;
            this.radioButtonM.CheckedChanged += new System.EventHandler(this.radioButtonM_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Диаметр канавки болта (max)";
            // 
            // checkBoxShowForm2
            // 
            this.checkBoxShowForm2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxShowForm2.AutoSize = true;
            this.checkBoxShowForm2.Location = new System.Drawing.Point(431, 353);
            this.checkBoxShowForm2.Name = "checkBoxShowForm2";
            this.checkBoxShowForm2.Size = new System.Drawing.Size(122, 23);
            this.checkBoxShowForm2.TabIndex = 11;
            this.checkBoxShowForm2.Text = "Расчет на прочность";
            this.checkBoxShowForm2.UseVisualStyleBackColor = true;
            this.checkBoxShowForm2.CheckedChanged += new System.EventHandler(this.checkBoxShowForm2_CheckedChanged);
            // 
            // labelThreadChoiseResult
            // 
            this.labelThreadChoiseResult.AutoSize = true;
            this.labelThreadChoiseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelThreadChoiseResult.Location = new System.Drawing.Point(188, 222);
            this.labelThreadChoiseResult.Name = "labelThreadChoiseResult";
            this.labelThreadChoiseResult.Size = new System.Drawing.Size(92, 31);
            this.labelThreadChoiseResult.TabIndex = 12;
            this.labelThreadChoiseResult.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Размер фаски (min)";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(162, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 141);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Threads.Properties.Resources.view_cr1;
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 196);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // aLabel4
            // 
            this.aLabel4.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel4.Location = new System.Drawing.Point(5, 385);
            this.aLabel4.Name = "aLabel4";
            this.aLabel4.Size = new System.Drawing.Size(150, 20);
            this.aLabel4.TabIndex = 10;
            this.aLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLabel3
            // 
            this.aLabel3.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel3.Location = new System.Drawing.Point(5, 340);
            this.aLabel3.Name = "aLabel3";
            this.aLabel3.Size = new System.Drawing.Size(150, 20);
            this.aLabel3.TabIndex = 10;
            this.aLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLabel2
            // 
            this.aLabel2.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel2.Location = new System.Drawing.Point(5, 293);
            this.aLabel2.Name = "aLabel2";
            this.aLabel2.Size = new System.Drawing.Size(150, 20);
            this.aLabel2.TabIndex = 5;
            this.aLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aLabel1
            // 
            this.aLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel1.Location = new System.Drawing.Point(5, 242);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(150, 20);
            this.aLabel1.TabIndex = 5;
            this.aLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aLabel1.Click += new System.EventHandler(this.aLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 411);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelThreadChoiseResult);
            this.Controls.Add(this.checkBoxShowForm2);
            this.Controls.Add(this.aLabel4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aLabel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aLabel2);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPitch);
            this.Controls.Add(this.listBoxThread);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thread solution";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxThread;
        private System.Windows.Forms.ListBox listBoxPitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private aLabel aLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private aLabel aLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBSPP;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.Label label5;
        private aLabel aLabel3;
        private System.Windows.Forms.CheckBox checkBoxShowForm2;
        private System.Windows.Forms.Label labelThreadChoiseResult;
        private System.Windows.Forms.Label label7;
        private aLabel aLabel4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

