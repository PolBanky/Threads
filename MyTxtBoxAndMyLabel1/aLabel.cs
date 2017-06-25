using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace Threads
{
    class aLabel : System.Windows.Forms.Label
    {
        // Конструктор класса  aLabel : Label
        public aLabel()
        {
            this.AutoSize = false;
            this.Text = "";
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Size = new System.Drawing.Size(140, 20);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }      // Завершение Конструктора класса



        // setText() - СДЕЛАТЬ В СТРОКЕ ДВА ЗНАКА ПОСЛЕ ЗАПЯТОЙ ЕСЛИ ЧИСЛО < 100, ОДИН ЕСЛИ < 1000,
        //  НОЛЬ ЕСЛИ > 1000, И ДОБАВИТЬ ПЕРЕДАННУЮ СТРОКУ
        public void setText(double dbl, string str)
        {
            string stringForCut;
            int indexOfDivide, stringForCutLength, stringCuttedLength, howMany = 0;
            if (dbl < 100) howMany = 3;
            if ((dbl >= 100) && (dbl < 1000)) howMany = 2;

            stringForCut = dbl.ToString();
            stringForCutLength = stringForCut.Length;
            indexOfDivide = stringForCut.IndexOf(Program.divide_true);
            if (indexOfDivide != -1)
            {
                stringCuttedLength = indexOfDivide + howMany;
                if (stringForCutLength > stringCuttedLength)
                    stringForCut = stringForCut.Remove(stringCuttedLength);
            }
            this.Text = stringForCut + str;
        }   // завершение setText()


        
        // setText() - СДЕЛАТЬ В СТРОКЕ num ЗНАКОВ ПОСЛЕ ЗАПЯТОЙ И ДОБАВИТЬ ПЕРЕДАННУЮ СТРОКУ
        public void setText(double dbl, string str, int num)
        {
            string stringForCut;
            int indexOfDivide, stringForCutLength, stringCuttedLength;

            stringForCut = dbl.ToString();
            stringForCutLength = stringForCut.Length;
            indexOfDivide = stringForCut.IndexOf(Program.divide_true);
            if (indexOfDivide != -1)
            {
                stringCuttedLength = indexOfDivide + 1 + num;
                if (stringForCutLength > stringCuttedLength)
                    stringForCut = stringForCut.Remove(stringCuttedLength);
            }
            this.Text = stringForCut + str;
        }   // завершение setText()



        // setText() - СДЕЛАТЬ В СТРОКЕ num ЗНАКОВ ПОСЛЕ ЗАПЯТОЙ И ДОБАВИТЬ ПЕРЕДАННУЮ СТРОКУ
        // изменить исходный double для соответствия с выведенной строкой
        public void setText(ref double dbl, string str, int num)
        {
            string stringForCut;
            int indexOfDivide, stringForCutLength, stringCuttedLength;

            stringForCut = dbl.ToString();
            stringForCutLength = stringForCut.Length;
            indexOfDivide = stringForCut.IndexOf(Program.divide_true);
            if (indexOfDivide != -1)
            {
                stringCuttedLength = indexOfDivide + 1 + num;
                if (stringForCutLength > stringCuttedLength)
                    stringForCut = stringForCut.Remove(stringCuttedLength);
            }
            this.Text = stringForCut + str;
            dbl = Convert.ToDouble(stringForCut);
        }   // завершение setText()



        // setText() - СДЕЛАТЬ В СТРОКЕ ДВА ЗНАКА ПОСЛЕ ЗАПЯТОЙ И ДОБАВИТЬ ДВЕ ПЕРЕДАННЫЕ СТРОКИ
        public void setText(string str1, double dbl, string str2)
        {
            string stringForCut;
            int indexOfDivide, stringForCutLength, stringCuttedLength;

            stringForCut = dbl.ToString();
            stringForCutLength = stringForCut.Length;
            indexOfDivide = stringForCut.IndexOf(Program.divide_true);
            if (indexOfDivide != -1)
            {
                stringCuttedLength = indexOfDivide + 3;
                if (stringForCutLength > stringCuttedLength)
                    stringForCut = stringForCut.Remove(stringCuttedLength);
            }
            this.Text = str1 + stringForCut + str2;
        }   // завершение setText()



        // setText() - ПОКАЗАТЬ ПЕРЕДАННУЮ СТРОКУ (БЕЗ DOUBLE)
        public void setText(string str)
        {
            this.Text = str;
        }

    }   // завершение class aLabel : System.Windows.Forms.Label
}       // завершение namespace wf472
