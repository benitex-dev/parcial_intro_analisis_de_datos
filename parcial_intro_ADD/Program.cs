// See https://aka.ms/new-console-template for more information

//datos que debe ingresar el usuario

using System.Runtime.CompilerServices;

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
Console.WriteLine("Tasa promedio Banco Nación: " + tasaPromedioBancoNacion + "%");
Console.WriteLine("Tasa promedio Banco Provincia: " + tasaPromedioBancoProvincia + "%");
Console.WriteLine("Tasa promedio Banco Hipotecario: " + tasaPromedioBancoHipotecario + "%");
Console.WriteLine("\nPresione Enter para calcular los rendimientos...");
Console.ReadLine();
Console.Clear();

CalcularYMostrarRendimientos("Banco Nación", tasaPromedioBancoNacion);
CalcularYMostrarRendimientos("Banco Provincia", tasaPromedioBancoProvincia);
CalcularYMostrarRendimientos("Banco Hipotecario", tasaPromedioBancoHipotecario);
Console.WriteLine("\nPresione Enter para calcular la mejor opcion...");
Console.ReadLine();
Console.Clear();

Console.WriteLine("==============================================");
Console.WriteLine("           MEJOR OPCIÓN ENCONTRADA            ");
Console.WriteLine("==============================================");
Console.WriteLine($"La opción más rentable es: {mejorOpcion}");
Console.WriteLine($"Con un rendimiento total de: ${mejorRendimiento:F2}");
Console.WriteLine("==============================================");

//resultados que se deben mostrar por pantalla

//comparar distintas opciones para elegir la mejor


void CalcularYMostrarRendimientos(string nombreBanco, double tasaAnualPromedio)
{
    Console.WriteLine($"\n--- CÁLCULOS PARA: {nombreBanco} (Tasa {tasaAnualPromedio:F2}%) ---");
    double tasaDecimal = tasaAnualPromedio / 100.0;

    // Inversión por un año completo
    double rendimientoAnual = capitalInicial * tasaDecimal;
    Console.WriteLine($"Modalidad Anual:     Rendimiento = ${rendimientoAnual:F2}");
    ActualizarMejorOpcion(rendimientoAnual, nombreBanco, "Anual");
}

    void ActualizarMejorOpcion(double rendimientoNuevo, string nombreBanco, string modalidad)
{
    if (rendimientoNuevo > mejorRendimiento)
    {
        mejorRendimiento = rendimientoNuevo;
        mejorOpcion = $"{nombreBanco} - Modalidad: {modalidad}";
    }
}
