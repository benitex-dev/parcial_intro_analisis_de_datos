// See https://aka.ms/new-console-template for more information

//datos que debe ingresar el usuario

using System.Runtime.CompilerServices;

//declaración de variables
int anio = 2022;
double[] tasasBancoNacion = new double[3];
double[] tasasBancoProvincia = new double[3];
double[] tasasBancoHipotecario = new double[3];
double mejorRendimiento = 0;
string mejorOpcion = "";
double capitalInicial = 850000;

//-----------------  Banco Nación  -------------------------

for (int i = 0; i < tasasBancoNacion.Length; i++)
{
    Console.WriteLine("Ingrese la tasa anual del año "+(anio)+" para el Banco Nación:");
    tasasBancoNacion[i] = double.Parse(Console.ReadLine());
    anio = anio + 1;
    Console.Clear();
}

anio = 2022;

for (int i = 0; i < tasasBancoNacion.Length; i++)
{
    Console.WriteLine("Tasa anual anio "+(anio)+ " del banco nación: "+tasasBancoNacion[i]);
    anio=anio + 1;
}
Console.WriteLine("\nPresione Enter para cargar las tasas del siguiente banco...");
Console.ReadLine();
Console.Clear();
//-----------------  Banco Provincia  -------------------------
anio = 2022;
for (int i = 0; i < tasasBancoProvincia.Length; i++)
{
    Console.WriteLine("Ingrese la tasa anual del año " + (anio) + " para el Banco Provincia:");
    tasasBancoProvincia[i] = double.Parse(Console.ReadLine());
    anio = anio + 1;
    Console.Clear();
}

anio = 2022;

for (int i = 0; i < tasasBancoProvincia.Length; i++)
{
    Console.WriteLine("Tasa anual anio " + (anio) + " del Banco Provincia: " + tasasBancoProvincia[i]);
    anio = anio + 1;
}
Console.WriteLine("\nPresione Enter para cargar las tasas del siguiente banco...");
Console.ReadLine();
Console.Clear();
//-----------------  Banco Hipotecario  -------------------------
anio = 2022;
for (int i = 0; i < tasasBancoHipotecario.Length; i++)
{
    Console.WriteLine("Ingrese la tasa anual del año " + (anio) + " para el Banco Hipotecario:");
    tasasBancoHipotecario[i] = double.Parse(Console.ReadLine());
    anio = anio + 1;
    Console.Clear();
}

anio = 2022;

for (int i = 0; i < tasasBancoHipotecario.Length; i++)
{
    Console.WriteLine("Tasa anual anio " + (anio) + " del Banco Hipotecario: " + tasasBancoHipotecario[i]);
    anio = anio + 1;
}
Console.WriteLine("\nPresione Enter para calcular los promedios de las tasas...");
Console.ReadLine();
Console.Clear();


//calculos que se deben realizar con las datos ingresados por el usuario

// Punto 2): Calcular el promedio de las tasas anuales de cada banco
double tasaPromedioBancoNacion = tasasBancoNacion.Average();
double tasaPromedioBancoProvincia = tasasBancoProvincia.Average();
double tasaPromedioBancoHipotecario = tasasBancoHipotecario.Average();

Console.Clear();
Console.WriteLine("--- PROMEDIOS DE TASAS ANUALES ---");
Console.WriteLine($"Tasa promedio Banco Nación: {tasaPromedioBancoNacion:F2} %");
Console.WriteLine($"Tasa promedio Banco Provincia: {tasaPromedioBancoProvincia:F2} %");
Console.WriteLine($"Tasa promedio Banco Hipotecario: {tasaPromedioBancoHipotecario:F2} %");
Console.WriteLine("\nPresione Enter para calcular los rendimientos...");
Console.ReadLine();
Console.Clear();

CalcularYMostrarRendimientos("Banco Nación", tasaPromedioBancoNacion, capitalInicial);
CalcularYMostrarRendimientos("Banco Provincia", tasaPromedioBancoProvincia, capitalInicial);
CalcularYMostrarRendimientos("Banco Hipotecario", tasaPromedioBancoHipotecario, capitalInicial);

Console.WriteLine("\nPresione Enter para calcular la mejor opcion...");
Console.ReadLine();
Console.Clear();

// Mostrar resultado final
Console.WriteLine("==============================================");
Console.WriteLine("           MEJOR OPCIÓN ENCONTRADA            ");
Console.WriteLine("==============================================");
Console.WriteLine($"La opción más rentable es: {mejorOpcion}");
Console.WriteLine($"Con un rendimiento total de: ${mejorRendimiento - capitalInicial:F2}");
Console.WriteLine("==============================================");
Console.ReadLine();

void CalcularYMostrarRendimientos(string nombreBanco, double tasaAnualPromedio, double capitalInicial)
{
    if (nombreBanco == "Banco Nación")
    {
        Console.WriteLine($"--- CÁLCULOS PARA: {nombreBanco} (Tasa promedio: {tasaAnualPromedio:F2}%) ---");

        double rendMensualNacion = tasaAnualPromedio / 12;
        double rendAnualNacion = tasaAnualPromedio;
        double rendTrimNacion = tasaAnualPromedio / 4;


        rendMensualNacion = rendMensualNacion / 100.0;
        rendAnualNacion = rendAnualNacion / 100.0;
        rendTrimNacion = rendTrimNacion / 100.0;


        for (int i = 0; i < 12; i++)
        {
            capitalInicial *= (1 + rendMensualNacion);
            //Console.WriteLine("Mes " + (i + 1) + ":"+ "    Rendimiento: " + capitalInicial);
            Console.WriteLine($"Mes  {(i + 1)} : Rendimiento : {capitalInicial:F2}");

        }
        double totalMensualNacion = capitalInicial;
        ActualizarMejorOpcion(totalMensualNacion, "Banco Nación", "Mensual");
       
        capitalInicial = 850000;

        //Mostrar por pantalla rendimiento anual
        double capitalAnualNacion = capitalInicial * (1 + rendAnualNacion);
        ActualizarMejorOpcion(capitalAnualNacion, "Banco Nación", "Anual");

        Console.WriteLine("\r");
        Console.WriteLine($"Rendimiento Anual= {capitalAnualNacion:F2}");
        Console.WriteLine("\r");
        for (int i = 0; i < 4; i++)
        {

            capitalInicial *= (1 + rendTrimNacion);


            //Console.WriteLine("Trimestre " + (i + 1) +  ":    Rendimiento= " + capitalInicial);
            Console.WriteLine($"Trimestre  {(i + 1)} : Rendimiento : {capitalInicial:F2}");


        }
        
        double totalTrimNacion = capitalInicial;
        ActualizarMejorOpcion(totalTrimNacion, "Banco Nación", "Trimestral");
        capitalInicial = 850000;

    }

    if (nombreBanco == "Banco Provincia")
    {
        Console.WriteLine($"\n\n--- CÁLCULOS PARA: {nombreBanco} (Tasa promedio: {tasaAnualPromedio:F2}%) ---");

        double rendMensualProvincia = tasaAnualPromedio /12;
        double rendAnualProvincia = tasaAnualPromedio;
        double rendTrimProvincia = tasaAnualPromedio /4;

        rendMensualProvincia = rendMensualProvincia / 100.0;
        rendAnualProvincia = rendAnualProvincia / 100.0;
        rendTrimProvincia = rendTrimProvincia / 100.0;

        for (int i = 0; i < 12; i++)
        {
            capitalInicial *= (1 + rendMensualProvincia);
            //Console.WriteLine("Mes " + (i + 1)+ ":    Rendimiento: " + capitalInicial);
            Console.WriteLine($"Mes  {(i + 1)} : Rendimiento : {capitalInicial:F2}");

        }
        
        double totalMensualPovincia = capitalInicial;
        ActualizarMejorOpcion(totalMensualPovincia, "Banco Provincia", "Mensual");
        capitalInicial = 850000;

        double capitalAnualProvincia = capitalInicial * (1 + rendAnualProvincia);
        ActualizarMejorOpcion(capitalAnualProvincia, "Banco Provincia", "Anual");
        Console.WriteLine("\r");
        Console.WriteLine($"Rendimiento Anual=  {capitalAnualProvincia:F2}");
        Console.WriteLine("\r");



        for (int i = 0; i < 4; i++)
        {
            capitalInicial *= (1 + rendTrimProvincia);
            //Console.WriteLine((i + 1) + "Trimestre    Rendimiento =" + capitalInicial);
            Console.WriteLine($"Trimestre  {(i + 1)} : Rendimiento : {capitalInicial:F2}");
        }
        
        double totalTrimestralPovincia = capitalInicial;
        ActualizarMejorOpcion(totalTrimestralPovincia, "Banco Provincia", "Trimestral");
        capitalInicial = 850000;

    }

    if (nombreBanco == "Banco Hipotecario")
    {
        Console.WriteLine($"\n\n--- CÁLCULOS PARA: {nombreBanco} (Tasa {tasaAnualPromedio:F2}%) ---");

        double rendMensualHipotecario = tasaAnualPromedio / 12;
        double rendAnualHipotecario = tasaAnualPromedio;
        double rendTrimHipotecario = tasaAnualPromedio / 4;

        rendMensualHipotecario = rendMensualHipotecario / 100.0;
        rendAnualHipotecario = rendAnualHipotecario / 100.0;
        rendTrimHipotecario = rendTrimHipotecario / 100.0;

        for (int i = 0; i < 12; i++)
        {
            capitalInicial *= (1 + rendMensualHipotecario);
            //Console.WriteLine("Mes: " + (i + 1) + "Rendimiento: " + capitalInicial);
            Console.WriteLine($"Mes  {(i + 1)} : Rendimiento : {capitalInicial:F2}");

        }
        

        double totalMensualHipotecario = capitalInicial;
        ActualizarMejorOpcion(totalMensualHipotecario, "Banco Hipotecario", "Mensual");

        capitalInicial = 850000;

        double capitalAnualHipotecario = capitalInicial * (1 + rendAnualHipotecario);
        ActualizarMejorOpcion(capitalAnualHipotecario, "Banco Hipotecario", "Anual");

        Console.WriteLine("\r");
        Console.WriteLine($"Rendimiento Anual = { capitalAnualHipotecario:F2}");
        Console.WriteLine("\r");



        for (int i = 0; i < 4; i++)
        {
            capitalInicial *= (1 + rendTrimHipotecario);
            //Console.WriteLine((i + 1) + "Trimestre    Rendimiento =" + capitalInicial);
            Console.WriteLine($"Trimestre  {(i + 1)} : Rendimiento : {capitalInicial:F2}");
        }
        
        double totalTrimestralHipotecario = capitalInicial;
        ActualizarMejorOpcion(totalTrimestralHipotecario, "Banco Hipotecario", "Trimestral");

        capitalInicial = 850000;
    }
}

void ActualizarMejorOpcion(double rendimientoNuevo, string nombreBanco, string modalidad)
{
    if (rendimientoNuevo > mejorRendimiento)
    {
        mejorRendimiento = rendimientoNuevo;
        mejorOpcion = $"{nombreBanco} - Modalidad: {modalidad}";
    }
}


