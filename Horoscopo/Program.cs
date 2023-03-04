internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("BIENVENIDO");
        Console.WriteLine("¿EN QUE MES NACISTE??");
        Console.WriteLine("");
        Console.WriteLine("1.ENERO");
        Console.WriteLine("2.FEBRERO");
        Console.WriteLine("3.MARZO");
        Console.WriteLine("4.ABRIL");
        Console.WriteLine("5.MAYO");
        Console.WriteLine("6.JUNIO");
        Console.WriteLine("7.JULIO");
        Console.WriteLine("8.AGOSTO");
        Console.WriteLine("9.SEPTIEMBRE");
        Console.WriteLine("10.OCTUBRE");
        Console.WriteLine("11.NOVIEMBRE");
        Console.WriteLine("12.DICIEMRE");

        int mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("CAPRICORNIO");
                break;

            case 2:
                Console.WriteLine("ACUARIO");
                break;
            case 3:
                Console.WriteLine("PSICIS");
                break;
            case 4:
                Console.WriteLine("ARIES");
                break;
            case 5:
                Console.WriteLine("TAURO");
                break;
            case 6:
                Console.WriteLine("GEMINIS");
                break;
            case 7:
                Console.WriteLine("CANCER");
                break;
            case 8:
                Console.WriteLine("LEO");
                break;
            case 9:
                Console.WriteLine("VIRGO");
                break;
            case 10:
                Console.WriteLine("LIBRA");
                break;
            case 11:
                Console.WriteLine("SCORPIO");
                break;
            case 12:
                Console.WriteLine("SAGITARIO");
                break;
        }
    }
}