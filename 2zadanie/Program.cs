class Programm
{
    static int F(int x)  //Подключение метода
    {
        if (x%2==0) return x/2; //условный оператор
        return x=0; //возвращаемое значение
    }
    static void Main() //точка входа в программу
    {
        Console.Write("Введите а="); //Подсказка
        int a = int.Parse(Console.ReadLine());//Ввод
        Console.WriteLine(F(a));  //вызов метода F
    }
}
