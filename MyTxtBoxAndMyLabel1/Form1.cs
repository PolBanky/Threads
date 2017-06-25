// Контролы (кроме lblOnPic) установлены на форму из панели элементов в режиме конструктора

using System;
using System.Windows.Forms;

namespace Threads
{
    public partial class Form1 : Form
    {
        //
        // DATA!!!
        //
        //indexSelectedThread_M и indexSelectedThread_Bspp - public, т.к. должны быть видны в другом классе
        public int indexSelectedThread_M = 0;   // выбранная резьба метрическая (индекс) 
        public int indexSelectedThread_Bspp = 0;// выбранная резьба BSPP (индекс) 
        public int selectedThreadPitch = 0;     // выбранный шаг метрической резьбы
        double d1 = 0;                          // внутренний диаметр гайки
        double d3 = 0;                          // диаметр болта по дну впадины 
        public double dk = 0;                   // Диаметр канавки болта (max) 
        int mThreadList_Length = 0;             // длина массива метрической резьбы в классе allTables 
        public enum threadChoice { M, BSPP };               // Метрическая или BSPP
        threadChoice whatThread_M_or_BSPP = threadChoice.M; // Метрическая или BSPP
        Form2 form2;                    // ссылка на объект Form2 form2 (создание объекта - в конструкторе)
        public allTables tbl = new allTables();             // создание объекта класса allTables

        // Здесь lblOnPic собственный а не из ВинЛиба !!!
        lblOnPic onPic_A =  new lblOnPic(  95, 113);
        lblOnPic onPic_E =  new lblOnPic( 225,  73);
        lblOnPic onPic_S =  new lblOnPic( 101,  45);
        lblOnPic onPic_S1 = new lblOnPic(  95,  61, 35, 13, 2);

        ToolTip Tip1;
        
        HelpProvider hlP1;  // Вызов справки по нажатию F1, в данном случае - файла *.txt 
        string hlpFile = null;
        // завершение DATA

        
        //
        // КОНСТРУКТОР of - CLASS  FORM1 : FORM  !!! 
        //
        public Form1()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;  - это уже есть в InitializeComponent() 
            form2 = new Form2();        // создание второй формы
            form2.form1 = this;
            form2.cb = checkBoxShowForm2;
            mThreadList_Length = tbl.mThreadList.GetLength(0); // т.к. не получается foreach с двухмерным массивом 
            int i = 0;                  // подсчет циклов
            // инициализация listBoxThread 
            while (i < mThreadList_Length)                   
            {
                listBoxThread.Items.Add(tbl.mThreadList[i++,0]);
            }
            listBoxThread.SelectedIndex = 0; // выделяем первую строку в listBoxThread 
            // 
            // Добавление лебелов lblOnPic на пикчебокс формы !!!
            // 
            this.pictureBox2.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.onPic_A, this.onPic_E, this.onPic_S, this.onPic_S1 }
                );
            //
            // Tip1
            //
            Tip1 = new ToolTip();
            Tip1.InitialDelay = 600;
            Tip1.ToolTipIcon = ToolTipIcon.Info;
            Tip1.ToolTipTitle = "Just Do It !";
            Tip1.SetToolTip(this.aLabel1, "Click LEFT button to copy\ndiameter into The Clipboard.");
            Tip1.IsBalloon = true;
            // инициализация listBoxPitch происходит в listBoxPitch_SelectedIndexChanged() 
            //
            // HelpProvider
            //
            hlP1 = new HelpProvider();
            hlP1.SetShowHelp(this, true);
            hlpFile = this.Text + ".txt";
            hlP1.HelpNamespace = hlpFile; // "Thread solution.txt" 
                // this.hlP1.SetShowHelp(this.checkBoxShowForm2, true); 
                // this.hlP1.SetHelpString(this.checkBoxShowForm2, "Press for stress solution"); 
        }   // завершение КОНСТРУКТОР of - CLASS  FORM1 : FORM  !!! 


        //
        // listBoxThread_SelectedIndexChanged() - ВЫБРАНА ДРУГАЯ РЕЗЬБА 
        //
        private void listBoxThread_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("listBoxThread_SelectedIndexChanged");
            switch (whatThread_M_or_BSPP)       // Метрическая или BSPP
            {
                case threadChoice.M:            //  Метрическая
                    indexSelectedThread_M = listBoxThread.SelectedIndex;
                    // инициализация listBox2  
                    listBoxPitch.Items.Clear();
                    for (int y = 1; y <= 6; y++)
                    {
                        if (tbl.mThreadList[indexSelectedThread_M, y] > 0)
                        {
                            listBoxPitch.Items.Add(tbl.mThreadList[indexSelectedThread_M, y]);
                        }
                    }
                    listBoxPitch.SelectedIndex = 0; // выделяем первую строку в listBoxPitch
                    if (tbl.mThreadList[indexSelectedThread_M, 7] != 0)
                    {
                        onPic_S.Text = tbl.mThreadList[indexSelectedThread_M, 7].ToString(); // Размер под ключ нормальный 
                    }
                    else
                    {   
                        onPic_S.Text = "S";
                    }
                        if (tbl.mThreadList[indexSelectedThread_M, 8] != 0)
                        {
                            onPic_S1.Text = "(" + tbl.mThreadList[indexSelectedThread_M, 8].ToString() + ")"; // Размер под ключ уменьшенный 
                        }
                        else
                        {
                            onPic_S1.Text = "(S1)";
                        }

                        if (tbl.mThreadList[indexSelectedThread_M, 9] != 0)
                        {
                            onPic_A.Text = tbl.mThreadList[indexSelectedThread_M, 9].ToString(); // Размер между осями болтов - A 
                        }
                        else
                        {
                            onPic_A.Text = "A";
                        }

                        if (tbl.mThreadList[indexSelectedThread_M, 10] != 0)
                        {
                            onPic_E.Text = tbl.mThreadList[indexSelectedThread_M, 10].ToString(); // Размер от оси болта до стенки -E 
                        }
                        else
                        {
                            onPic_E.Text = "E";
                        }
                    break;

                case threadChoice.BSPP:         // BSPP
                    indexSelectedThread_Bspp = listBoxThread.SelectedIndex;
                    // инициализация listBoxPitch
                    listBoxPitch.Items.Clear();
                    listBoxPitch.Items.Add(tbl.BsppThreadList[indexSelectedThread_Bspp].threadPitch + " мм");
                    listBoxPitch.Items.Add("( " + tbl.BsppThreadList[indexSelectedThread_Bspp].numThreadPitch + " pitch/inch )");
                    aLabel1.setText(tbl.BsppThreadList[indexSelectedThread_Bspp].ext_Diameter, " мм", 3);
                    aLabel2.setText(tbl.BsppThreadList[indexSelectedThread_Bspp].int_Diameter, " мм", 3);
                    dk = tbl.BsppThreadList[indexSelectedThread_Bspp].int_Diameter - 0.2;
                    aLabel3.setText(dk, " мм", 1);
                    double lf = (tbl.BsppThreadList[indexSelectedThread_Bspp].ext_Diameter - dk) / 2;
                    aLabel4.Text = lf.ToString("F1") + " x 45";
                    labelThreadChoiseResult.Text = "G" + tbl.BsppThreadList[indexSelectedThread_Bspp].threadName;
                    break;
                default:                    
                    break;
            }       // завершение switch 
        }           // завершение listBox1_SelectedIndexChanged() 


        //
        // listBoxPitch_SelectedIndexChanged - ВЫБРАН ДРУГОЙ ШАГ 
        //
        private void listBoxPitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (whatThread_M_or_BSPP)   // Метрическая (1) или BSPP (2) 
            {
                case threadChoice.M: // метрическая 
                    selectedThreadPitch = listBoxPitch.SelectedIndex + 1;
                    d1 = tbl.mThreadList[indexSelectedThread_M, 0] - 1.082531755 *
                         tbl.mThreadList[indexSelectedThread_M, selectedThreadPitch];
                    aLabel1.Text = d1.ToString("F3") + " мм   (R=" + (d1/2).ToString("F5") + ")";
                    //aLabel1.setText(d1, " мм", 3); 
                    d3 = tbl.mThreadList[indexSelectedThread_M, 0] - 1.226869322 *
                         tbl.mThreadList[indexSelectedThread_M, selectedThreadPitch];
                    aLabel2.setText(d3, " мм", 3);
                    dk = d3 - 0.2;
                    aLabel3.setText(ref dk, " мм", 1);  // ref - чтоб можно было изменить dk из aLabel3 
                    double lf = (tbl.mThreadList[indexSelectedThread_M, 0] - dk) / 2;
                    aLabel4.Text = lf.ToString("F1") + " x 45";
                    labelThreadChoiseResult.Text = "M" + Convert.ToString(tbl.mThreadList[indexSelectedThread_M, 0]) + " x "
                                      + Convert.ToString(tbl.mThreadList[indexSelectedThread_M, selectedThreadPitch]);
                    break;
                case threadChoice.BSPP: // BSPP 
                    break;
                default:
                    break;
            }       // завершение switch
        }   // завершение listBox2_SelectedIndexChanged() 

        
        //
        /*********** ВЫБОР ВИДА РЕЗЬБЫ (radioButtonM & radioButtonBSPP) ***********/
        //
        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonM.Checked == true)   // МЕТРИЧЕСКАЯ 
            {
                pictureBox1.Size = new System.Drawing.Size(365, 196);
                pictureBox1.Image = Threads.Properties.Resources.view_cr1;
                labelThreadChoiseResult.Top = pictureBox1.Bottom + 5;
                pictureBox2.Visible = true;
                checkBoxShowForm2.Visible = true;
                int i = 0;                      // подсчет циклов 
                // инициализация listBoxThread 
                whatThread_M_or_BSPP = threadChoice.M;
                listBoxThread.Items.Clear();
                while (i < mThreadList_Length)
                {
                    listBoxThread.Items.Add(tbl.mThreadList[i++, 0]);                    
                }
                listBoxThread.SelectedIndex = indexSelectedThread_M;     // выделяем выбранную ранее строку в listBox1 
                label1.Text = "Номинальный диаметр резьбы d";                
                label3.Text = "Внутренний диаметр гайки d1";
                label4.Text = "Диаметр по дну впадины d3";
            }   // завершение if 
        }       // завершение radioButton1_CheckedChanged() 
        

        private void radioButtonBSPP_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBSPP.Checked == true)  // BSPP 
            {
                pictureBox1.Size = new System.Drawing.Size(289, 221);
                pictureBox1.Image = Threads.Properties.Resources.BSPP___cr1;
                pictureBox2.Visible = false;
                labelThreadChoiseResult.Top = pictureBox1.Bottom + 5;
                checkBoxShowForm2.Visible = false;                
                // инициализация listBox1 
                whatThread_M_or_BSPP = threadChoice.BSPP;                
                listBoxThread.Items.Clear();
                foreach (Bspp c in tbl.BsppThreadList)
                    listBoxThread.Items.Add(c.threadName);
                listBoxThread.SelectedIndex = indexSelectedThread_Bspp;     // выделяем выбранную ранее строку в listBox1 
                label1.Text = "Обозначение резьбы";
                label3.Text = "Наружный диаметр болта d";
                label4.Text = "Внутренний диаметр гайки d1";
            }   // завершение if 
        }       // завершение radioButton2_CheckedChanged() 

        /*********** завершение ВЫБОР ВИДА РЕЗЬБЫ (radioButtonM & radioButtonBSPP) ***********/


        //
        // checkBoxShowForm2_CheckedChanged - ПОКАЗАТЬ ФОРМУ2 
        //
        private void checkBoxShowForm2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowForm2.Checked == true)
            {
                this.Hide();
                form2.Show();                                           
            }
            else
            {
                form2.Hide();
                this.Show();
            }
        }   // завершение checkBox1_CheckedChanged 


        //
        //  кнопка "Exit" 
        //
        private void button1_Click(object sender, EventArgs e)
        {
                Application.Exit();     // закрываем главную форму 1 
        }   // end of - button1_Click 


        // Запись значения диаметра в клипборд 
        private void aLabel1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(d1.ToString());
            MessageBox.Show("Значение внутреннего диаметра\nгайки d1 скопировано в ClipBoard", "Готово",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   // end of - aLabel1_Click 


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {if (MessageBox.Show("Чета не понял - ВЫХОДИМ ???", "Хрена-се...",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)   // MessageBoxButtons.YesNo
            {
                form2.Close();      // закрываем дочернюю форму 2     
                e.Cancel = false;   // продолжение закрытия программы 
            }
            else
                e.Cancel = true;    // отмена закрытия программы 
        } // end of - Form1_FormClosing 

    }   // завершение class Form1 : Form()          
}       // завершение namespace MyTxtBoxAndMyLabel1 