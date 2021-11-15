//расчет кошелька, прибыли
//w= Расклад; a = Начальная сумма  ; c= финальная сумма ; h= дни; b= процент в день
//max = a; sol - считает сколько раз вывел; d- 1 действие; e = второе дейсвие; t = выражение за 1 день
//i  =возвожный процент
//
Console.WriteLine ("Расчитать дни: 1 " ); 
Console.WriteLine ("Расчитать проценты: 2 " ); 
Console.Write ("Введите значение:  " ); 
double w = Convert.ToDouble(Console.ReadLine());
{
    if(w==1)
    {
        Console.Write ("Начальная сумма: " ); 
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write ("Какую сумму надо: " ); 
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write ("Процент в день: " ); 
        double b = Convert.ToDouble(Console.ReadLine());
        double max = a; 
        int sol = 0;// считает количество циклов - тоесть дней
        {
            while  (max < c) 
            {
                double d = (max/100);
                double e = (d*b);
                double t = (e+max);
                max = t; 
                sol = sol +  1;
            }
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("Дни: " + sol);
            return;
        }
    }
    if(w==2)
    {
        Console.Write ("Начальная сумма: " ); 
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write ("Какую сумму надо: " ); 
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write ("За сколько дней: " ); 
        double h = Convert.ToDouble(Console.ReadLine());
        double max = a; 
        double q  = 1;
        double i = 0;
        double y = h + 1;
        while (max<c)//сумма должн абыть выше конечной
            {
                if (q>2)// обнуление второго цикла
                {
                    i = i + 0.1;//прибавляет процент
                    q = 1;
                    max = a;
                    Console.WriteLine("   НОВЫЙ ПРОЦЕНТ     ");//вывод дял нового дня   
                }
                while (q<y)// второй цикл считает
                {
                double d = (max/100);
                double e = (d*i);
                double t = (e+max);
                max = t;
                q = q + 1;//дни в цикле 
                Console.WriteLine(max + "        ");// показывает проценты в день
                }
        Console.WriteLine(" ");//вывод
        Console.WriteLine(i);

            }   
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            Console.WriteLine("Процент в день: " + i  );
            return;      
    }
    else
    {
        Console.Write("ERROR");
        return;
    }
}
