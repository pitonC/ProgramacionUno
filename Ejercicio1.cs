Console.WriteLine("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█\r\n█░░╦─╦╔╗╦─╔╗╔╗╔╦╗╔╗░░█\r\n█░░║║║╠─║─║─║║║║║╠─░░█\r\n█░░╚╩╝╚╝╚╝╚╝╚╝╩─╩╚╝░░█\r\n█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█\r\n");//se crea dibujo
Console.ForegroundColor = ConsoleColor.Cyan;    // cambia color de la fuente a cyan
Console.WriteLine("Ejercicio 1");               //se describe el numero el programa
Console.ForegroundColor = ConsoleColor.Yellow;  // cambia color de la fuente a amariilo
Console.WriteLine("Calcular la velocidad de un automóvil en base a distancia y el tiempo en recorrer dicha distancia.");//se describe la problematica a resolver
double d, t, v = 0;                             // se declaran variables
Console.BackgroundColor = ConsoleColor.Magenta; //// cambia el color de fondo a magenta
Console.WriteLine("Dame distancia en km");      //se toma el valor de entrada
d = Convert.ToDouble(Console.ReadLine());       //se convierte el valor capturado
Console.WriteLine("dame tiempo en horas");      //se toma el valor de entrada
t = Convert.ToDouble(Console.ReadLine());       //se convierte el valor capturado
v = d/t;                                        //se calcula el dato
Console.WriteLine("su velocidad es de: " + v);  //se imprime el valor
Console.ReadLine();                             //pausa la ejecucion del programa
