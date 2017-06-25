//1.TxtBoxDbl - принимает ввод только цифр, десятичного разделителя и BackSpace
//2.Методы класса
//2.1 strToDbl(out double b) - конвертирует Text объекта класса в число double, которое дано по указателю (out) 
//2.2 setText(double dbl) - присваивает свойству Text объекта класса преобразованное в строку значение double

using System;
using System.Windows.Forms;

namespace Threads
{
    /*****TxtBoxDbl*****TxtBoxDbl*****TxtBoxDbl*****TxtBoxDbl*****TxtBoxDbl*****/

    class TxtBoxDbl : TextBox
    {
        // Конструктор класса txtBoxDbl : TextBox
        public TxtBoxDbl()
        {
            this.MouseClick += new MouseEventHandler(TxtBoxDbl_MouseClick);
            this.KeyDown += new KeyEventHandler(txtBoxDbl_KeyDown);
            this.KeyPress += new KeyPressEventHandler(TxtBoxDbl_KeyPress);
            this.Size = new System.Drawing.Size(140, 20);
            this.MaxLength = 8;
        }   // Завершение Конструктора класса        



        // txtBoxDbl_MouseClick
        void TxtBoxDbl_MouseClick(object sender, MouseEventArgs e)
        {
            this.Select(this.Text.Length, 0);
        }   // завершение txtBoxDbl_MouseClick    



        // txtBoxDbl_KeyDown - отключить управляющие и перемещения клавиши 
        void txtBoxDbl_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Home) || (e.KeyCode == Keys.End) || (e.KeyCode == Keys.Delete) || (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Down))
                e.Handled = true;
        }   // завершение txtBoxDbl_KeyDown



        // txtBoxDbl_KeyPress -  принимать если цифра или BackSpace
        void TxtBoxDbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // если неправильный десятичный разделитель - ставим правильный вместо неправильного
            if (e.KeyChar == Program.divide_false)
                e.KeyChar = Program.divide_true;
            // если правильный десятичный разделитель            
            if (e.KeyChar == Program.divide_true)
            { // нельзя больше 1 разделителя
                if (this.Text.IndexOf(Program.divide_true) != -1)
                {
                    e.Handled = true;
                    return;
                }
                // десятичный разделитель не может быть первым символом - добавляем ноль впереди
                if (this.Text.Length == 0)// e.KeyChar = '0';
                {
                    e.Handled = true;
                    this.Text = "0" + Program.divide_true;
                    this.Select(this.Text.Length, 0);
                }
                return;
            } // завершение if (e.KeyChar == divide_true)
            // если BackSpace
            if (e.KeyChar == 8) return;
            // если цифра
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if ((this.Text.Length == 0) && (e.KeyChar == '0'))
                {   // если первый ноль - сразу добавляем десятичный разделитель 
                    e.Handled = true;
                    this.Text = "0" + Program.divide_true;
                    this.Select(this.Text.Length, 0);
                }
                return;
            }   // завершение if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            // если все другие символы  //MessageBox.Show("Цифирку надо!");
            e.Handled = true;
        }   // завершение TxtBoxDbl_KeyPress



        // Конвертировать Text данного объекта в число double, которое дано по указателю (out) 
        public void strToDbl(out double b)
        {
            if (this.Text.Length == 0) b = 0;
            else
            {
                try { b = Convert.ToDouble(this.Text); }
                catch
                {
                    MessageBox.Show("Недопустимый ввод", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Text = "";
                    b = 0;
                }   // завершение try...catch
            }       // завершение if...else
            // курсор в конец текста
            this.Select(this.Text.Length, 0);
        }          // завершение strToDbl()



        // setText() - СДЕЛАТЬ В СТРОКЕ ДВА ЗНАКА ПОСЛЕ ЗАПЯТОЙ
        public void setText(double dbl)
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
            this.Text = stringForCut;
        }   // завершение setText()

    }       // завершение TxtBoxDbl : TextBox

    /*****TxtBoxDbl*****TxtBoxDbl*****TxtBoxDbl*****TxtBoxDbl*****TxtBoxDbl*****/


    /*****TxtBoxInt*****TxtBoxInt*****TxtBoxInt*****TxtBoxInt*****TxtBoxInt*****/

    class TxtBoxInt : TextBox
    {
        // Конструктор класса TxtBoxNumNoComma : TextBox
        public TxtBoxInt()
        {
            this.KeyPress += new KeyPressEventHandler(TxtBoxInt_KeyPress);
            this.Size = new System.Drawing.Size(140, 20);
            this.MaxLength = 14;
        }   // Завершение Конструктора класса

        //
        // Обработчики событий
        //
        // TxtBoxInt_KeyPress - принимать если цифра или BackSpace
        void TxtBoxInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }   // завершение TxtBoxInt_KeyPress



        // Конвертировать Text данного объекта в число int, которое дано по указателю (out) 
        public void strToInt(out int b)
        {
            if (this.Text.Length == 0) b = 0;
            else
            {
                try { b = Convert.ToInt32(this.Text); }
                catch
                {
                    MessageBox.Show("Недопустимый ввод", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Text = "";
                    b = 0;
                }   // завершение try...catch
            }       // завершение if...else
            // курсор в конец текста
            this.Select(this.Text.Length, 0);
        }          // завершение strToInt()



        // Конвертировать Text данного объекта в число double, которое дано по указателю (out) 
        public void strToDbl(out double b)
        {
            if (this.Text.Length == 0) b = 0;
            else
            {
                try { b = Convert.ToDouble(this.Text); }
                catch
                {
                    MessageBox.Show("Недопустимый ввод", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Text = "";
                    b = 0;
                }   // завершение try...catch
            }       // завершение if...else            
        }          // завершение strToDbl()

    }       // завершение TxtBoxInt : TextBox

    /*****TxtBoxInt*****TxtBoxInt*****TxtBoxInt*****TxtBoxInt*****TxtBoxInt*****/

}       // завершение namespace wf472