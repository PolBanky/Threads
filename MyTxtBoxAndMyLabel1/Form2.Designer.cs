namespace Threads
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBoxMaterials = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_DataOfSteel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSbeg = new System.Windows.Forms.RadioButton();
            this.radioButtonKanavka = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDbl1 = new Threads.TxtBoxDbl();
            this.aLabel1 = new Threads.aLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonNoStandart = new System.Windows.Forms.RadioButton();
            this.radioButtonStBolt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMaterials
            // 
            this.listBoxMaterials.FormattingEnabled = true;
            this.listBoxMaterials.Location = new System.Drawing.Point(12, 68);
            this.listBoxMaterials.Name = "listBoxMaterials";
            this.listBoxMaterials.Size = new System.Drawing.Size(129, 69);
            this.listBoxMaterials.TabIndex = 13;
            this.listBoxMaterials.SelectedIndexChanged += new System.EventHandler(this.listBoxMaterials_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Марка стали";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 110);
            this.label1.TabIndex = 15;
            this.label1.Text = "Н - нормализация, У - улучшение";
            // 
            // label_DataOfSteel
            // 
            this.label_DataOfSteel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_DataOfSteel.Location = new System.Drawing.Point(146, 68);
            this.label_DataOfSteel.Name = "label_DataOfSteel";
            this.label_DataOfSteel.Size = new System.Drawing.Size(454, 68);
            this.label_DataOfSteel.TabIndex = 16;
            this.label_DataOfSteel.Text = "label_DataOfSteel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Расчет стержня на разрыв";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSbeg);
            this.groupBox1.Controls.Add(this.radioButtonKanavka);
            this.groupBox1.Location = new System.Drawing.Point(8, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выход резьбы";
            // 
            // radioButtonSbeg
            // 
            this.radioButtonSbeg.AutoSize = true;
            this.radioButtonSbeg.Checked = true;
            this.radioButtonSbeg.Location = new System.Drawing.Point(7, 44);
            this.radioButtonSbeg.Name = "radioButtonSbeg";
            this.radioButtonSbeg.Size = new System.Drawing.Size(49, 17);
            this.radioButtonSbeg.TabIndex = 1;
            this.radioButtonSbeg.TabStop = true;
            this.radioButtonSbeg.Text = "Сбег";
            this.radioButtonSbeg.UseVisualStyleBackColor = true;
            this.radioButtonSbeg.CheckedChanged += new System.EventHandler(this.radioButtonSbeg_CheckedChanged);
            // 
            // radioButtonKanavka
            // 
            this.radioButtonKanavka.AutoSize = true;
            this.radioButtonKanavka.Location = new System.Drawing.Point(7, 20);
            this.radioButtonKanavka.Name = "radioButtonKanavka";
            this.radioButtonKanavka.Size = new System.Drawing.Size(68, 17);
            this.radioButtonKanavka.TabIndex = 0;
            this.radioButtonKanavka.Text = "Канавка";
            this.radioButtonKanavka.UseVisualStyleBackColor = true;
            this.radioButtonKanavka.CheckedChanged += new System.EventHandler(this.radioButtonKanavka_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 52);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3\r\nlabel3\r\n\r\nlabel3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "Расчет резьбы на срез\r\nШирина гайки, мм -";
            // 
            // txtBoxDbl1
            // 
            this.txtBoxDbl1.Location = new System.Drawing.Point(436, 289);
            this.txtBoxDbl1.MaxLength = 8;
            this.txtBoxDbl1.Name = "txtBoxDbl1";
            this.txtBoxDbl1.Size = new System.Drawing.Size(98, 20);
            this.txtBoxDbl1.TabIndex = 22;
            this.txtBoxDbl1.TextChanged += new System.EventHandler(this.txtBoxDbl1_TextChanged);
            // 
            // aLabel1
            // 
            this.aLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.aLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aLabel1.Location = new System.Drawing.Point(115, 330);
            this.aLabel1.Name = "aLabel1";
            this.aLabel1.Size = new System.Drawing.Size(120, 17);
            this.aLabel1.TabIndex = 20;
            this.aLabel1.Text = "aLabel1";
            this.aLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonNoStandart);
            this.groupBox2.Controls.Add(this.radioButtonStBolt);
            this.groupBox2.Location = new System.Drawing.Point(283, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 44);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Что рассчитываем";
            // 
            // radioButtonNoStandart
            // 
            this.radioButtonNoStandart.AutoSize = true;
            this.radioButtonNoStandart.Location = new System.Drawing.Point(164, 19);
            this.radioButtonNoStandart.Name = "radioButtonNoStandart";
            this.radioButtonNoStandart.Size = new System.Drawing.Size(141, 17);
            this.radioButtonNoStandart.TabIndex = 1;
            this.radioButtonNoStandart.Text = "Нестандартная деталь";
            this.radioButtonNoStandart.UseVisualStyleBackColor = true;
            this.radioButtonNoStandart.CheckedChanged += new System.EventHandler(this.radioButtonNoStandart_CheckedChanged);
            // 
            // radioButtonStBolt
            // 
            this.radioButtonStBolt.AutoSize = true;
            this.radioButtonStBolt.Checked = true;
            this.radioButtonStBolt.Location = new System.Drawing.Point(6, 19);
            this.radioButtonStBolt.Name = "radioButtonStBolt";
            this.radioButtonStBolt.Size = new System.Drawing.Size(118, 17);
            this.radioButtonStBolt.TabIndex = 0;
            this.radioButtonStBolt.TabStop = true;
            this.radioButtonStBolt.Text = "Стандартный болт";
            this.radioButtonStBolt.UseVisualStyleBackColor = true;
            this.radioButtonStBolt.CheckedChanged += new System.EventHandler(this.radioButtonStBolt_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxDbl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_DataOfSteel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxMaterials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "strength of thread";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Deactivate += new System.EventHandler(this.Form2_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMaterials;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_DataOfSteel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSbeg;
        private System.Windows.Forms.RadioButton radioButtonKanavka;
        private System.Windows.Forms.Label label3;
        private aLabel aLabel1;
        private System.Windows.Forms.Label label4;
        private TxtBoxDbl txtBoxDbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonStBolt;
        private System.Windows.Forms.RadioButton radioButtonNoStandart;
    }
}