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

double rendMensualProvincia = 0;
double rendAnualProvincia = 0;
double rendTrimProvincia= 0;

double rendMensualNacion = 0;
double rendAnualNacion = 0;
double rendTrimNacion = 0;

double rendMensualHipotecario = 0;
double rendAnualHipotecario = 0;
double rendTrimHipotecario = 0;

double capitalMensualProvincia = 0;
double capitalAnualProvincia = 0;
double capitalTrimProvincia = 0;

double capitalMensualNacion = 0;
double totalAnualNacion = 0;
double capitalTrimNacion=0;

double capitalMensualHipotecario = 0;
double capitalAnualHipotecario = 0;
double capitalTrimHipotecario = 0;

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
Console.WriteLine("Tasa promedio Banco Nación: " + tasaPromedioBancoNacion + "%");
Console.WriteLine("Tasa promedio Banco Provincia: " + tasaPromedioBancoProvincia + "%");
Console.WriteLine("Tasa promedio Banco Hipotecario: " + tasaPromedioBancoHipotecario + "%");
Console.WriteLine("\nPresione Enter para calcular los rendimientos...");
Console.ReadLine();
Console.Clear();

CalcularYMostrarRendimientos("Banco Nación", tasaPromedioBancoNacion, capitalInicial, tasasBancoNacion[2]);
CalcularYMostrarRendimientos("Banco Provincia", tasaPromedioBancoProvincia, capitalInicial, tasasBancoProvincia[2]);
CalcularYMostrarRendimientos("Banco Hipotecario", tasaPromedioBancoHipotecario, capitalInicial, tasasBancoHipotecario[2]);

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

void CalcularYMostrarRendimientos(string nombreBanco, double tasaAnualPromedio, double capitalInicial,double tasaActual)
{
    if (nombreBanco == "Banco Nación")
    {
        Console.WriteLine($"\n--- CÁLCULOS PARA: {nombreBanco} (Tasa promedio: {tasaAnualPromedio:F2}%) ---");

        rendMensualNacion = tasaAnualPromedio / 12;
        rendAnualNacion = tasaActual;
        rendTrimNacion = tasaAnualPromedio / 4;


        rendMensualNacion = rendMensualNacion / 100.0;
        rendAnualNacion = rendAnualNacion / 100.0;
        rendTrimNacion = rendTrimNacion / 100.0;

        

        for (int i = 0; i < 12; i++)
        {
            capitalInicial *= (1 + rendMensualNacion);
            Console.WriteLine("Mes " + (i + 1) + ":"+ "    Rendimiento: " + capitalInicial);

        }
        double totalMensualNacion = capitalInicial;
        ActualizarMejorOpcion(totalMensualNacion, "Banco Nación", "Mensual");
       
        capitalInicial = 850000;

        //Mostrar por pantalla rendimiento anual
        totalAnualNacion = capitalInicial * (1 + rendAnualNacion);
        ActualizarMejorOpcion(totalAnualNacion, "Banco Nación", "Anual");
        Console.WriteLine("Rendimiento Anual= " + totalAnualNacion);


        for (int i = 0; i < 4; i++)
        {

            capitalInicial *= (1 + rendTrimNacion);


            Console.WriteLine("Trimestre " + (i + 1) +  ":    Rendimiento= " + capitalInicial);


        }
        double totalTrimNacion = capitalInicial;
        ActualizarMejorOpcion(totalTrimNacion, "Banco Nación", "Trimestral");
        capitalInicial = 850000;

    }

    if (nombreBanco == "Banco Provincia")
    {
        Console.WriteLine($"\n--- CÁLCULOS PARA: {nombreBanco} (Tasa promedio: {tasaAnualPromedio:F2}%) ---");

        rendMensualProvincia = tasaAnualPromedio /12;
        rendAnualProvincia = tasaActual;
        rendTrimProvincia = tasaAnualPromedio /4;

        rendMensualProvincia = rendMensualProvincia / 100.0;
        rendAnualProvincia = rendAnualProvincia / 100.0;
        rendTrimProvincia = rendTrimProvincia / 100.0;

        for (int i = 0; i < 12; i++)
        {
            capitalInicial *= (1 + rendMensualProvincia);
            Console.WriteLine("Mes " + (i + 1)+ ":    Rendimiento: " + capitalInicial);

        }
        double totalMensualPovincia = capitalInicial;
        ActualizarMejorOpcion(totalMensualPovincia, "Banco Provincia", "Mensual");
        capitalInicial = 850000;

        capitalAnualProvincia = capitalInicial * (1 + rendAnualProvincia);
        ActualizarMejorOpcion(capitalAnualProvincia, "Banco Provincia", "Anual");
        Console.WriteLine("Rendimiento Anual= " + capitalAnualProvincia);


        for (int i = 0; i < 4; i++)
        {
            capitalInicial *= (1 + rendTrimProvincia);
            Console.WriteLine((i + 1) + "Trimestre    Rendimiento =" + capitalInicial);
        }
        double totalTrimestralPovincia = capitalInicial;
        ActualizarMejorOpcion(totalTrimestralPovincia, "Banco Provincia", "Trimestral");
        capitalInicial = 850000;

    }

    if (nombreBanco == "Banco Hipotecario")
    {
        Console.WriteLine($"\n--- CÁLCULOS PARA: {nombreBanco} (Tasa {tasaAnualPromedio:F2}%) ---");

        rendMensualHipotecario = tasaAnualPromedio / 12;
        rendAnualHipotecario = tasaActual;
        rendTrimHipotecario = tasaAnualPromedio / 4;

        rendMensualHipotecario = rendMensualHipotecario / 100.0;
        rendAnualHipotecario = rendAnualHipotecario / 100.0;
        rendTrimHipotecario = rendTrimHipotecario / 100.0;

        for (int i = 0; i < 12; i++)
        {
            capitalInicial *= (1 + rendMensualHipotecario);
            Console.WriteLine("Mes: " + (i + 1) + "Rendimiento: " + capitalInicial);
        }

        double totalMensualHipotecario = capitalInicial;
        ActualizarMejorOpcion(totalMensualHipotecario, "Banco Hipotecario", "Mensual");

        capitalInicial = 850000;

        capitalAnualHipotecario = capitalInicial * (1 + rendAnualHipotecario);
        ActualizarMejorOpcion(capitalAnualHipotecario, "Banco Hipotecario", "Anual");

        Console.WriteLine("Rendimiento Anual =" + capitalAnualHipotecario);


        for (int i = 0; i < 4; i++)
        {
            capitalInicial *= (1 + rendTrimHipotecario);
            Console.WriteLine((i + 1) + "Trimestre    Rendimiento =" + capitalInicial);
        }
        double totalTrimestralHipotecario = capitalInicial;
        ActualizarMejorOpcion(totalTrimestralHipotecario, "Banco Hipotecario", "Trimestral");

        capitalInicial = 850000;
         
        //BuscarMaximo (totalMensualNacion, totalTrimNacion, totalAnualNacion, totalMensualProvincia, totalTrimProvincia, totalAnualProvincia, totalMensualHipotecario, totalTrimestralHipotecario, capitalAnualHipotecario);
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


//resultados que se deben mostrar por pantalla



//comparar distintas opciones para elegir la mejor
//void BuscarMaximo(double totalMensualNacion, double totalTrimNacion, double totalAnualNacion, double totalMensualProvincia, double totalTrimProvincia, double totalAnualProvincia, double totalMensualHipotecario, double totalTrimHipotecario, double totalAnualHipotecario)
//{
//    double maximo = totalMensualNacion;
//    string opcion = "Banco Nación (Mensual)";

//    if (totalTrimNacion > maximo)
//    {
//        maximo = totalTrimNacion;
//        opcion = "Banco Nación (Trimestral)";
//    }
//    if (totalAnualNacion > maximo)
//    {
//        maximo = totalAnualNacion;
//        opcion = "Banco Nación (Anual)";
//    }
//    if (totalMensualProvincia > maximo)
//    {
//        maximo = totalMensualProvincia;
//        opcion = "Banco Provincia (Mensual)";
//    }
//    if (totalTrimProvincia > maximo)
//    {
//        maximo = totalTrimProvincia;
//        opcion = "Banco Provincia (Trimestral)";
//    }
//    if (totalAnualProvincia > maximo)
//    {
//        maximo = totalAnualProvincia;
//        opcion = "Banco Provincia (Anual)";
//    }
//    if (totalMensualHipotecario > maximo)
//    {
//        maximo = totalMensualHipotecario;
//        opcion = "Banco Hipotecario (Mensual)";
//    }
//    if (totalTrimHipotecario > maximo)
//    {
//        maximo = totalTrimHipotecario;
//        opcion = "Banco Hipotecario (Trimestral)";
//    }
//    if (totalAnualHipotecario > maximo)
//    {
//        maximo = totalAnualHipotecario;
//        opcion = "Banco Hipotecario (Anual)";
//    }

//    // Mostrar resultado final
//    Console.WriteLine("==============================================");
//    Console.WriteLine("           MEJOR OPCIÓN ENCONTRADA            ");
//    Console.WriteLine("==============================================");
//    Console.WriteLine($"La opción más rentable es: {opcion}");
//    Console.WriteLine($"Con un rendimiento total de: ${maximo:F2}");
//    Console.WriteLine("==============================================");

//}

