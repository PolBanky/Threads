using System;
using System.Windows.Forms;

namespace Threads
{

    public partial class Form2 : Form
    {
        //
        // DATA!!
        //
        // inside this region - инициализация массива  Steel[] steels и classStrength[] classStrengths
        #region classBolt[] classBolts & Steel[] steels & string[] txtLabels
        //Класс прочности болтов обозначен двумя числами.
//Первое число, умноженное на 100, определяет минимальное значение [сигма]временное, МПа;
//Второе число, умноженное на 10, отношение [сигма]текучести/[сигма]временное,%
//т.е. произведение чисел, умноженное на 10 - определяет величину предела текучести в МПа.

        classBolt[] classBolts = new[]
        {
            new classBolt(" 3.6", 'U',  300,  180, "Сталь 3кп, Сталь 3сп, 10, 10кп"),
            new classBolt(" 4.6", 'U',  400,  240, "20"),
            new classBolt(" 4.8", 'U',  400,  240, "10, 10кп"),
            new classBolt(" 5.6", 'U',  500,  300, "30, 35"),
            new classBolt(" 5.8", 'U',  500,  400, "20, 20кп"),
            new classBolt(" 6.6", 'U',  600,  360, "35, 45, 40Г"),
            new classBolt(" 6.8", 'U',  600,  480, "20, 20кп"),
            new classBolt(" 6.9", 'U',  600,  540, "20, 20кп"),
            new classBolt(" 8.8", 'L',  800,  640, "35Х, 38ХА, 45Г"),
            new classBolt("10.9", 'L', 1000,  900, "35Х, 38ХА, 45Г"),
            new classBolt("12.9", 'L', 1200, 1080, "30ХГСА"),
            new classBolt("14.9", 'L', 1400, 1260, "40Н2МА")
        };


        Steel[] steels = new[]  // массив структур
        {
            new Steel("сталь 3          ", 'U', 370, 245),
            new Steel("сталь 08 (Н)     ", 'U', 330, 200),
            new Steel("сталь 10 (Н)     ", 'U', 340, 210),
            new Steel("сталь 15 (Н)     ", 'U', 380, 230),
            new Steel("сталь 20 (Н)     ", 'U', 420, 250),
            new Steel("сталь 25 (Н)     ", 'U', 460, 280),
            new Steel("сталь 30 (Н)     ", 'U', 500, 300),
            new Steel("сталь 30 (У)     ", 'U', 600, 350),
            new Steel("сталь 35 (Н)     ", 'U', 540, 320),
            new Steel("сталь 35 (У)     ", 'U', 650, 380),
            new Steel("сталь 40 (Н)     ", 'U', 580, 340),
            new Steel("сталь 40 (У)     ", 'U', 700, 400),
            new Steel("сталь 45 (Н)     ", 'U', 610, 360),
            new Steel("сталь 45 (У)     ", 'U', 750, 450),
            new Steel("сталь 09Г2С (-)  ", 'L', 500, 350),
            new Steel("сталь 10ХСНД (-) ", 'L', 540, 400),
            new Steel("сталь 20Х (Н)    ", 'L', 600, 300),
            new Steel("сталь 20Х (У)    ", 'L', 700, 500),
            new Steel("сталь 40Х (Н)    ", 'L', 630, 330),
            new Steel("сталь 40Х (У)    ", 'L', 800, 650)
        };

        string[] txtLabels = { "Класс прочности болтов обозначен двумя числами.\nПервое число, умноженное на 100, равно минимальному значению для [сигма]временное, МПа.\nВторое число, умноженное на 10 - это отношение [сигма]текучести / [сигма]временное, %\nт.е. произведение первого и второго чисел, умноженное на 10 - равно пределу текучести, МПа.\n", "Принимаем допустимое напряжение на разрыв\nдля углеродистой стали [sigma]p = 0,4 * [sigma]текучести. Для болта < М16: [sigma]p = 0,25 * [sigma]текучести\nдля легированой стали  [sigma]p = 0,3 * [sigma]текучести. Для болта < М16: [sigma]p = 0,20 * [sigma]текучести" };

        #endregion  classBolt[] classBolts & Steel[] steels & string[] txtLabels

        
        public enum what { standart, nostandart};// что рассчитываем, стандарт или нет
        what whatsolution = what.standart;       // что рассчитываем, стандарт или нет
        int selectedClassBolts = 0;     // выбранный класс прочности
        int selectedSteel = 0;          // выбранная марка стали
        double actual_Stress_Max = 0;   // Допускаемое напряжение для выбранной стали или класса прочности
        double diaStretch = 0;          // диаметр для расчета стержня на разрыв
        double areaStretch = 0;         // площадь сечения стержня для расчета стержня на разрыв
        double forceMax = 0;            // максимально допустимое усилие, N
        double nutWidth = 0;            // ширина гайки для расчета на срез
        public Form1 form1;             // ссылка на объект Form1 form1 
        // в конструкторе Form1 присваивание ссылке form2.form1 адреса самой создаваемой формы класса Form1 ( = this );
        public CheckBox cb = new CheckBox();
        double koeff = 0.4;             // для расчета actual_Stress_Max
        double sizeM = 10;              // sizeM = form1.tbl.mThread[form1.selectedThread_M, 0];
        // завершение DATA

        //
        // КОНСТРУКТОР of - CLASS  FORM2 : FORM  !!!
        //
        public Form2()
        {
            InitializeComponent();            
            foreach ( classBolt a in classBolts)
                listBoxMaterials.Items.Add(a.classBoltName);
            // выделяем первую строку в listBox3, а значит просходит событие listBox3_SelectedIndexChanged()
            listBoxMaterials.SelectedIndex = 0;
            showLabels();            
        }       // завершение КОНСТРУКТОР of - CLASS  FORM2 : FORM  !!!
        

        
        //
        // Form2_FormClosing - СКРЫТЬ ВТОРУЮ ФОРМУ ( вместо ее закрытия ) И АКТИВИРОВАТЬ ПЕРВУЮ
        //
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                cb.Checked = false;
                form1.Activate();
            }
        }   // завершение Form2_FormClosing



        //
        // listBoxMaterials_SelectedIndexChanged()  -  ВЫБРАН ДРУГОЙ МАТЕРИАЛ!!! (СТАЛЬ ИЛИ КЛАСС ПРОЧНОСТИ)
        //
        private void listBoxMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDataSelectedMaterial(); // ПОКАЗАТЬ ДАННЫЕ ВЫБРАННОГО МАТЕРИАЛА
        }   // завершение listBox3_SelectedIndexChanged

        //
        // showDataSelectedMaterial() - ПОКАЗАТЬ ДАННЫЕ ВЫБРАННОГО МАТЕРИАЛА (СТАЛИ ИЛИ КЛАССА ПРОЧНОСТИ)
        //
        void showDataSelectedMaterial()
        {
            switch (whatsolution)
            {
                case what.standart:     // СТАНДАРТНЫЙ БОЛТ
                    selectedClassBolts = listBoxMaterials.SelectedIndex;
                    if (sizeM <= 16)
                    {
                        if (classBolts[selectedClassBolts].sortSteel == 'U') koeff = 0.25;
                        if (classBolts[selectedClassBolts].sortSteel == 'L') koeff = 0.2;
                    }
                    else // sizeM > 16
                    {
                        if (classBolts[selectedClassBolts].sortSteel == 'U') koeff = 0.4;
                        if (classBolts[selectedClassBolts].sortSteel == 'L') koeff = 0.3;
                    }                    
                    actual_Stress_Max = classBolts[selectedClassBolts].yield_Strength * koeff;                    
                    label_DataOfSteel.Text = "Класс прочности - " + classBolts[selectedClassBolts].classBoltName
+ "\nВременное сопротивление - " + Convert.ToString(classBolts[selectedClassBolts].ultimate_Strength) + "  МПа"
+ "\nПредел текучести - " + Convert.ToString(classBolts[selectedClassBolts].yield_Strength) + "  МПа"
+ "\nДля статической нагрузки при растяжении"
+ "\nдопустимое напряжение  -  " + Convert.ToString(actual_Stress_Max) + " МПа  ( k = " + koeff.ToString() + " )";
                    break;  // case what.standart:

                case what.nostandart:    // НЕСТАНДАРТНАЯ ДЕТАЛЬ
                    selectedSteel = listBoxMaterials.SelectedIndex;
                    if (sizeM <= 16)
                    {
                        if (steels[selectedSteel].sortSteel == 'U') koeff = 0.25;
                        if (steels[selectedSteel].sortSteel == 'L') koeff = 0.2; //else koeff = 0.2;
                    }
                    else // sizeM > 16
                    {
                        if (steels[selectedSteel].sortSteel == 'U') koeff = 0.4;
                        if (steels[selectedSteel].sortSteel == 'L') koeff = 0.3; //else koeff = 0.3;
                    }
                    actual_Stress_Max = steels[selectedSteel].yield_Strength * koeff;                    
                    label_DataOfSteel.Text = "Марка стали - " + steels[selectedSteel].steelName
+ "\nВременное сопротивление - " + Convert.ToString(steels[selectedSteel].ultimate_Strength) + "  МПа"
+ "\nПредел текучести - " + Convert.ToString(steels[selectedSteel].yield_Strength) + "  МПа"
+ "\nДля статической нагрузки при растяжении"
+ "\nдопустимое напряжение  -  " + Convert.ToString(actual_Stress_Max) + "  МПа  ( k = " + koeff.ToString() + " )";                  
                    break;  // case what.nostandart:

                default:
                    break;
            }   // switch (whatsol)
            CalcAndShow_forceMax();
        }

        private void CalcAndShow_forceMax()
        {
            // НАПРЯЖЕНИЕ (МПа) = СИЛА (Н) / ПЛОЩАДЬ (мм.кв.)
            // СИЛА (Н) = НАПРЯЖЕНИЕ (МПа) * ПЛОЩАДЬ (мм.кв.)
            forceMax = actual_Stress_Max * areaStretch; // in N
            aLabel1.setText(forceMax / 10, " kg");      // show forceMax in kg
        }

        //
        /***** Form2_Activated - ФОРМА 2 АТИВИРОВАНА!!! *****/
        //
        private void Form2_Activated(object sender, EventArgs e)
        {
            sizeM = form1.tbl.mThreadList[form1.indexSelectedThread_M, 0];            
            label5.Text = "М"
+ Convert.ToString(sizeM) + " x "
+ Convert.ToString(form1.tbl.mThreadList[form1.indexSelectedThread_M, form1.selectedThreadPitch]);
            showDataSelectedMaterial();
            if (radioButtonKanavka.Checked == true)  // КАНАВКА
            {
                show_forceMax_WithGroove();
            }
            else    // СБЕГ
            {
                showSbegStress();
            }
        }   // завершение Form2_Activated
                                /***** завершение ФОРМА 2 АТИВИРОВАНА!!! *****/


        //
        // show_forceMax_WithGroove - ЕС
        //
        void show_forceMax_WithGroove()
        {
            diaStretch = form1.dk;  // diaStretch - чтобы не было ошибки времени исполнения
            // т.к. form1.dk рассчитывается при работе проги в другом объекте
            label3.Text = "Производим расчет на разрыв по канавке. \nДиаметр канавки, мм - "
                + diaStretch.ToString()
                + "\n\nДопустимое усилие растяжения, kg -";
            // Расчет площади сечения стержня  S = (PI * d^2)/4
            areaStretch = ( Math.PI * Math.Pow(diaStretch, 2)) / 4;
            CalcAndShow_forceMax();
        }



        void showSbegStress()
        {
            // расчет диаметра -   dr = d - 0.938 * P
            diaStretch = form1.tbl.mThreadList[form1.indexSelectedThread_M, 0] -
                0.938 * form1.tbl.mThreadList[form1.indexSelectedThread_M, form1.selectedThreadPitch];
            label3.Text = "Расчет на разрыв по стержню dr = d - 0.938 * P\nРасчетный диаметр, мм - "
                + diaStretch.ToString("F2")
                + "\n\nДопустимое усилие растяжения, kg -";
            // Расчет площади сечения стержня    S = (PI * d^2)/4
            areaStretch = (Math.PI * Math.Pow(diaStretch, 2)) / 4;
            CalcAndShow_forceMax();
        }


        //
        /*********** ВЫБОР ВИДА ВЫХОДА РЕЗЬБЫ (radioButtonKanavka / radioButtonSbeg) ***********/
        //
        private void radioButtonKanavka_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKanavka.Checked == true)  // КАНАВКА
            {
                show_forceMax_WithGroove();
            }
        }

        private void radioButtonSbeg_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSbeg.Checked == true)  // СБЕГ
            {
                showSbegStress();
            }
        }
        /*********** завершение ВЫБОР ВИДА ВЫХОДА РЕЗЬБЫ (radioButton1 radioButton2) ***********/



        /*********** ВЫБОР СТАНДАРТ БОЛТ/НЕСТАНДАРТ ДЕТАЛЬ (radioButtonStBolt / radioButtonNoStandart) ***********/

        private void radioButtonStBolt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonStBolt.Checked == true)
            {
                whatsolution = what.standart;                
                listBoxMaterials.Items.Clear();
                foreach (classBolt a in classBolts)
                    listBoxMaterials.Items.Add(a.classBoltName);
                //int selectedClassBolts;     // выбранный класс прочности                
                // выделяем строку в listBox3, а значит просходит событие listBox3_SelectedIndexChanged()
                listBoxMaterials.SelectedIndex = selectedClassBolts;
                showLabels();
            }
        }

        private void radioButtonNoStandart_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNoStandart.Checked == true)
            {
                whatsolution = what.nostandart;                
                listBoxMaterials.Items.Clear();
                foreach (Steel b in steels)
                    listBoxMaterials.Items.Add(b.steelName);                
                //int selectedSteel;          // выбранная марка стали
                // выделяем строку в listBox3, а значит просходит событие listBox3_SelectedIndexChanged()
                listBoxMaterials.SelectedIndex = selectedSteel;
                showLabels();
            }
        }
        /********* end ВЫБОР СТАНДАРТ БОЛТ/НЕСТАНДАРТ ДЕТАЛЬ (radioButtonStBolt/radioButtonNoStandart) *********/



        void showLabels()
        {
            switch (whatsolution)
            {
                case what.standart:
                    label6.Text = "Класс прочности болта";
                    label1.Text = txtLabels[0] + txtLabels[1];
                    break;
                case what.nostandart:
                    label6.Text = "Марка стали";
                    label1.Text = txtLabels[1];
                    break;
            }   // switch (whatsol)
        }


        // txtBoxDbl1_TextChanged   -   ВВОД ШИРИНЫ ГАЙКИ!!!
        private void txtBoxDbl1_TextChanged(object sender, EventArgs e)
        {
            txtBoxDbl1.strToDbl(out nutWidth);     //MessageBox.Show(nutWidth.ToString());
            // РАСЧЕТ РЕЗЬБЫ НА СРЕЗ (Детали машин. Добровольский стр. 135)


        }   // завершение txtBoxDbl1_TextChanged   -   ВВОД ШИРИНЫ ГАЙКИ!!!



        /**************************************still not use*******************************************/
        // still not use
        private void Form2_Shown(object sender, EventArgs e)
        {
            //label3.Text = "Производим расчет на разрыв по канавке. \nРасчетный диаметр, мм -";
            //aLabel1.setText(form1.dk, " мм", 1);
        }
        
        private void Form2_Deactivate(object sender, EventArgs e)
        {
            /*form1.Show();  form1.Activate();*/
            //form1.Activate();
        /**************************************still not use*******************************************/
        }

        


    }       // завершение class Form2 : Form
}           // завершение namespace Threads
