using System;

namespace ACT5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador=0;
;            string [] meses={"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            int [] dias={31,29,31,30,31,30,31,31,30,31,30,31};
            Console.WriteLine("Contador de dias para fin de año...");
            Console.WriteLine("Por favor ingrese el numero de mes entre 1 y 12");
            int dia=Convert.ToInt32(Console.ReadLine());
            dia=dia-1;
            Console.WriteLine("Por favor ingrese el numero de dia del mes de {0} para saber cuantos dias faltan para terminar el año",meses[dia]);
            int dia_mes=Convert.ToInt32(Console.ReadLine());

            for (int i=dia;i<12;i++){
                contador=contador+dias[i] ;
            };

            Console.WriteLine("Eligio el {0} de {1} este mes cuenta con {2} dias y para finalizar el año faltan {3} dias",dia_mes,meses[dia],dias[dia],contador-dia_mes);
        }
    }
}
