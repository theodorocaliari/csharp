using System;

namespace problema1061Uri
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio,
                diaTermino,
                diaEmSegundo,
                horaEmSegundo,
                minutoEmSegundo,
                horaInicio,
                minutoInicio,
                segundoInicio,
                horaTermino,
                minutoTermino,
                segundoTermino,
                tempoTotalInicioEmSegundos,
                tempoTotalTerminoEmSegundos,
                duracaoDoEvento, 
                duracaoDoEventoDia,
                duracaoDoEventoHora,
                duracaoDoEventoMinuto,
                duracaoDoEventoSegundo,
                resto;

            string[] tempoInicioEvento, tempoTerminoEvento;

            diaEmSegundo = 86400;
            horaEmSegundo = 3600;
            minutoEmSegundo = 60;

            Console.Write("Dia ");
            diaInicio = int.Parse(Console.ReadLine());
            tempoInicioEvento = Console.ReadLine().Split(":");
            Console.Write("Dia ");
            diaTermino = int.Parse(Console.ReadLine());
            tempoTerminoEvento = Console.ReadLine().Split(":");

            horaInicio = int.Parse(tempoInicioEvento[0]);
            minutoInicio = int.Parse(tempoInicioEvento[1]);
            segundoInicio = int.Parse(tempoInicioEvento[2]);

            horaTermino = int.Parse(tempoTerminoEvento[0]);
            minutoTermino = int.Parse(tempoTerminoEvento[1]);
            segundoTermino = int.Parse(tempoTerminoEvento[2]);

            //transformar dia para segundo
            diaInicio = diaInicio * diaEmSegundo;

            //transformar hora em segundo
            horaInicio = horaInicio * horaEmSegundo;

            //transformar minuto em segundo
            minutoInicio = minutoInicio * minutoEmSegundo;

            diaTermino = diaTermino * diaEmSegundo;
            horaTermino = horaTermino * horaEmSegundo;
            minutoTermino = minutoTermino * minutoEmSegundo;

            tempoTotalInicioEmSegundos = diaInicio + horaInicio + minutoInicio + segundoInicio;
            tempoTotalTerminoEmSegundos = diaTermino + horaTermino + minutoTermino + segundoTermino;

            duracaoDoEvento = tempoTotalTerminoEmSegundos - tempoTotalInicioEmSegundos;

            //Console.WriteLine("duracao: " + duracaoDoEvento);

            duracaoDoEventoDia = duracaoDoEvento / diaEmSegundo; //dias
            resto = duracaoDoEvento % diaEmSegundo; //resto dias
            //Console.WriteLine("Resto dias:" + resto);
            duracaoDoEventoHora = resto / horaEmSegundo; //hora
            resto = resto % horaEmSegundo; //resto horas
            //Console.WriteLine("Resto horas:" + resto);
            duracaoDoEventoMinuto = resto / minutoEmSegundo;//minuto
            resto = resto % minutoEmSegundo; //resto minuto
            //Console.WriteLine("Resto minuto:" + resto);
            duracaoDoEventoSegundo = resto / 60;

            Console.WriteLine((int)duracaoDoEventoDia + " dia(s)");
            Console.WriteLine((int)duracaoDoEventoHora + " hora(s)");
            Console.WriteLine((int)duracaoDoEventoMinuto + " minuto(s)");
            Console.WriteLine((int)duracaoDoEventoSegundo + " segundo(s)");

        }
    }
}
