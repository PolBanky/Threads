﻿
namespace Threads
{
    // inside this region - определение структуры Bspp и структуры Steel
    #region Bspp & Steel & classBolt
    public struct Bspp
    {
        public string threadName;           // Обозначение резьбы
        public double ext_Diameter;        	// Наружный диаметр - d
        public double int_Diameter;        	// Внутренний диаметр - d1
        public double threadPitch;        	// Шаг резьбы - P
        public double numThreadPitch;       // Число шагов резьбы на дюйм - z

        // конструктор структуры
        public Bspp(string a1, double a2, double a3, double a4, double a5)
        {
            threadName = a1;
            ext_Diameter = a2;
            int_Diameter = a3;
            threadPitch = a4;
            numThreadPitch = a5;
        }   // end of - конструктор Bspp
    }       // end of - struct Bspp



    // определение структуры Steel
    public struct Steel
    {   // D A T A
        public string steelName;               	// Марка стали
        public char sortSteel;                  // углеродистая или легированая
        public double ultimate_Strength;        // Временное сопротивление
        public double yield_Strength;           // Предел текучести

        // конструктор структуры
        public Steel(string a1, char a2, double a3, double a4)
        {
            steelName = a1;             // Марка стали
            sortSteel = a2;             // углеродистая или легированая
            ultimate_Strength = a3;     // Временное сопротивление
            yield_Strength = a4;        // Предел текучести        
        }   // end of - конструктор Steel
    }       // end of - struct Steel


    // определение структуры classStrength
    public struct classBolt
    {   // D A T A
        public string classBoltName;    // Наименование класса прочности
        public char sortSteel;          // углеродистая или легированая
        public double ultimate_Strength;// Временное сопротивление
        public double yield_Strength;   // Предел текучести
        public string steelsName;       // Марки сталей

        // конструктор структуры
        public classBolt(string a1, char a2, double a3, double a4, string a5)
        {
            classBoltName = a1;     // Наименование класса прочности
            sortSteel = a2;             // углеродистая или легированая
            ultimate_Strength = a3;     // Временное сопротивление
            yield_Strength = a4;        // Предел текучести
            steelsName = a5;            // Марки сталей
        }   // end of - конструктор classBolt
    }       // end of - struct classBolt
    #endregion


        /********** class allTables **********/
    public class allTables
    {
        // DATA!!!
        public Bspp[] BsppThreadList = new[]  // массив структур
            {
            new Bspp("1/16\"",   7.723,  6.561, 0.907, 28),
            new Bspp("1/8\"",    9.728,  8.566, 0.907, 28),
            new Bspp("1/4\"",   13.157, 11.445, 1.337, 19),
            new Bspp("3/8\"",   16.662, 14.950, 1.337, 19),
            new Bspp("1/2\"",   20.955, 18.631, 1.814, 14),
            new Bspp("5/8\"",   22.911, 20.587, 1.814, 14),
            new Bspp("3/4\"",   26.441, 24.117, 1.814, 14),
            new Bspp("7/8\"",   30.201, 27.877, 1.814, 14),
            new Bspp("1\"",     33.249, 30.291, 2.309, 11),
            new Bspp("1 1/8\"", 37.897, 34.939, 2.309, 11),
            new Bspp("1 1/4\"", 41.910, 38.952, 2.309, 11),
            new Bspp("1 3/8\"", 44.323, 41.365, 2.309, 11),
            new Bspp("1 1/2\"", 47.803, 44.845, 2.309, 11),
            new Bspp("1 3/4\"", 53.746, 50.788, 2.309, 11),
            new Bspp("2\"",     59.614, 56.656, 2.309, 11),
            new Bspp("2 1/4\"", 65.710, 62.752, 2.309, 11),
            new Bspp("2 1/2\"", 75.184, 72.226, 2.309, 11),
            new Bspp("2 3/4\"", 81.534, 78.576, 2.309, 11),
            new Bspp("3\"",     87.884, 84.926, 2.309, 11),
			new Bspp("3 1/4\"", 93.980, 91.022, 2.309, 11),
            new Bspp("3 1/2\"",100.330, 97.372, 2.309, 11),
            new Bspp("3 3/4\"",106.680,103.722, 2.309, 11),
            new Bspp("4\"",    113.030,110.072, 2.309, 11),
			new Bspp("4 1/2\"",125.730,122.772, 2.309, 11),            
            new Bspp("5\"",    138.430,135.472, 2.309, 11)
            };

        // Метрическая

        public double[,] mThreadList =
        {
            // Первый столбец:  D - наружный диаметр резьбы
            // 2й - 7й столбцы:  шаги резьбы
            // 8й - 9й столбцы:
            // Sn - размеры под ключ норм ГОСТ 5915-70 и DIN 931
            // Su - уменьш ГОСТ 15521-70
            // A  - Размер на эскизе внизу
            // E  - Размер на эскизе внизу
            // 
            // D    /****** ш а г  р е з ь б ы ******/    Sn    Su      A     E
            { 4.0,  0.70, 0.50, 0.00, 0.00, 0.00, 0.00,   7.00,  0.00, 14.00, 6.00},
            { 4.5,  0.75, 0.50, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 5.0,  0.80, 0.50, 0.00, 0.00, 0.00, 0.00,   8.00,  0.00, 17.00, 7.00},
            { 5.5,  0.50, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 6.0,  1.00, 0.75, 0.50, 0.00, 0.00, 0.00,  10.00,  0.00, 20.00, 8.00},
            { 7.0,  1.00, 0.75, 0.50, 0.00, 0.00, 0.00,  11.00,  0.00, 22.00, 9.00},
            { 8.0,  1.25, 1.00, 0.75, 0.50, 0.00, 0.00,  13.00, 12.00, 26.00,10.00}, // уменьшенные начинаются с М8 ! и такого DIN нет
            { 9.0,  1.25, 1.00, 0.75, 0.50, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 10.0, 1.50, 1.25, 1.00, 0.75, 0.50, 0.00,  17.00, 14.00, 34.00,13.00},
            { 11.0, 1.50, 1.00, 0.75, 0.50, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 12.0, 1.75, 1.50, 1.25, 1.00, 0.75, 0.50,  19.00, 17.00, 36.00,14.00},
            { 14.0, 2.00, 1.50, 1.25, 1.00, 0.75, 0.50,  22.00, 19.00,  0.00, 0.00},
            { 15.0, 1.50, 1.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 16.0, 2.00, 1.50, 1.00, 0.75, 0.50, 0.00,  24.00, 22.00, 42.00,15.00},
            { 17.0, 1.50, 1.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 18.0, 2.50, 2.00, 1.50, 1.00, 0.75, 0.50,  27.00, 24.00, 52.00,19.00},
            { 20.0, 2.50, 2.00, 1.50, 1.00, 0.75, 0.50,  30.00, 27.00, 58.00,20.00},
            { 22.0, 2.50, 2.00, 1.50, 1.00, 0.75, 0.50,  32.00, 30.00, 62.00,22.00},
            { 24.0, 3.00, 2.00, 1.50, 1.00, 0.75, 0.00,  36.00, 32.00, 68.00,24.00},
            { 25.0, 2.00, 1.50, 1.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 26.0, 1.50, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 27.0, 3.00, 2.00, 1.50, 1.00, 0.75, 0.00,  41.00, 36.00, 80.00,26.00},
            { 28.0, 2.00, 1.50, 1.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 30.0, 3.50, 3.00, 2.00, 1.50, 1.00, 0.75,  46.00, 41.00, 90.00,30.00},
            { 32.0, 2.00, 1.50, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 33.0, 3.50, 3.00, 2.00, 1.50, 1.00, 0.75,  50.00,  0.00, 95.00,32.00},
            { 35.0, 1.50, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 36.0, 4.00, 3.00, 2.00, 1.50, 1.00, 0.00,  55.00, 50.00,105.00,36.00},
            { 38.0, 1.50, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 39.0, 4.00, 3.00, 2.00, 1.50, 1.00, 0.00,  60.00,  0.00,110.00,38.00},
            { 40.0, 3.00, 2.00, 1.50, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 42.0, 4.50, 4.00, 3.00, 2.00, 1.50, 1.00,  65.00, 60.00,120.00,42.00},
            { 45.0, 4.50, 4.00, 3.00, 2.00, 1.50, 1.00,  70.00,  0.00,130.00,45.00},
            { 48.0, 5.00, 4.00, 3.00, 2.00, 1.50, 1.00,  75.00, 70.00,140.00,48.00},
            { 50.0, 3.00, 2.00, 1.50, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 52.0, 5.00, 4.00, 3.00, 2.00, 1.50, 1.00,  80.00,  0.00,150.00,50.00},
            { 55.0, 4.00, 3.00, 2.00, 1.50, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 56.0, 5.50, 4.00, 3.00, 2.00, 1.50, 1.00,  85.00,  0.00,160.00,52.00},
            { 58.0, 4.00, 3.00, 2.00, 1.50, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 60.0, 5.50, 4.00, 3.00, 2.00, 1.50, 1.00,  90.00,  0.00,170.00,58.00},
            { 62.0, 4.00, 3.00, 2.00, 1.50, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 64.0, 6.00, 4.00, 3.00, 2.00, 1.50, 1.00,  95.00,  0.00,175.00,61.00},
            { 65.0, 4.00, 3.00, 2.00, 1.50, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 68.0, 6.00, 4.00, 3.00, 2.00, 1.50, 1.00, 100.00,  0.00,190.00,65.00},
            { 70.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 72.0, 6.00, 4.00, 3.00, 2.00, 1.50, 1.00, 105.00,  0.00,200.00,68.00},
            { 75.0, 4.00, 3.00, 2.00, 1.50, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 76.0, 6.00, 4.00, 3.00, 2.00, 1.50, 1.00, 110.00,  0.00,205.00,70.00},
            { 78.0, 2.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 80.0, 6.00, 4.00, 3.00, 2.00, 1.50, 1.00, 115.00,  0.00,215.00,72.00},
            { 82.0, 2.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 85.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            { 90.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00, 130.00,  0.00,245.00,80.00},
            { 95.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {100.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00, 145.00,  0.00,275.00,95.00},
            {105.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {110.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00, 155.00,  0.00,295.00,100.00},
            {115.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {120.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {125.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00, 180.00,  0.00,335.00,115.00},
            {130.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {135.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {140.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00, 200.00,  0.00,370.00,120.00},
            {145.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {150.0, 6.00, 4.00, 3.00, 2.00, 1.50, 0.00,   0.00,  0.00,  0.00, 0.00},
            {155.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00,  0.00, 0.00},
            {160.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00, 230.00,  0.00,430.00,145.00},
            {165.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {170.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {175.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {180.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {185.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {190.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {195.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {200.0, 6.00, 4.00, 3.00, 2.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {205.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {210.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {215.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {220.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {225.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {230.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {235.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {240.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {245.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {250.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {255.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {260.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {265.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {270.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {275.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {280.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {285.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {290.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {295.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {300.0, 6.00, 4.00, 3.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {310.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {320.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {330.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {340.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {350.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {360.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {370.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {380.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {390.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {400.0, 6.00, 4.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {410.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {420.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {430.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {440.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {450.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {460.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {470.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {480.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {490.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {500.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {510.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {520.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {530.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {540.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {550.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {560.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {570.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {580.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {590.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
            {600.0, 6.00, 0.00, 0.00, 0.00, 0.00, 0.00,   0.00,  0.00, 0.00, 0.00},
        };                                                           
    }                                                                
    /********** class allTables **********/                          
}   // namespace Threads                                             
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     