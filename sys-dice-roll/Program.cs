using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();

    }

    static void Menu(){
        Console.WriteLine("==== Seja-Bem Vindo ao Roll Dice RPG ====");
        Console.WriteLine("  ==== Selecione o seu tipo de dado ====");
        Console.WriteLine("1 - D4");
        Console.WriteLine("2 - D6");
        Console.WriteLine("3 - D8");
        Console.WriteLine("4 - D10");
        Console.WriteLine("5 - D12");
        Console.WriteLine("6 - D20");
        Console.WriteLine("7 - Exit");
        Console.WriteLine("");
        Console.WriteLine("==== Digite a opcao desejada ====");

        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1 : rollD4();break;
            case 2 : rollD6();break;
            case 3 : rollD8();break;
            case 4 : rollD10();break;
            case 5 : rollD12();break;
            case 6 : rollD20();break;
            case 67 : System.Environment.Exit(0);;break;
        }

    }

    static void rollD4(){
        rollsDice(1,4);
    }
    static void rollD6(){
        rollsDice(1,6);
    }
    static void rollD8(){
        rollsDice(1,8);
    }
    static void rollD10(){
        rollsDice(1,10);
    }
    static void rollD12(){
        rollsDice(1,12);
    }
    static void rollD20(){
        rollsDice(1,20);
    }
    static void rollsDice(int num1, int num2){
        Console.Clear();
        Console.WriteLine("=== O numero foi: ===");

        Random aleatorio = new Random();
        int valor = aleatorio.Next(num1, num2);

        Console.WriteLine(valor);
        Console.ReadKey();
        Menu();

    }

}



