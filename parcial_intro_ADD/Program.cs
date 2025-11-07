// See https://aka.ms/new-console-template for more information

//datos que debe ingresar el usuario

int anio = 2022;

double[] tasasBancoNacion = new double[3];

double[] tasasBancoProvincia = new double[3];

double[] tasasBancoHipotecario = new double[3];

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


//calculos que se deben realizar con las datos ingresados por el usuario

// Punto 2): Calcular el promedio de las tasas anuales de cada banco
double tasaPromedioBancoNacion = (tasasBancoNacion[0] + tasasBancoNacion[1] + tasasBancoNacion[2]) / 3;
double tasaPromedioBancoProvincia = (tasasBancoProvincia[0] + tasasBancoProvincia[1] + tasasBancoProvincia[2]) / 3;
double tasaPromedioBancoHipotecario = (tasasBancoHipotecario[0] + tasasBancoHipotecario[1] + tasasBancoHipotecario[2]) / 3;

Console.Clear();
Console.WriteLine("Tasa promedio Banco Nación: " + tasaPromedioBancoNacion + "%");
Console.WriteLine("Tasa promedio Banco Provincia: " + tasaPromedioBancoProvincia + "%");
Console.WriteLine("Tasa promedio Banco Hipotecario: " + tasaPromedioBancoHipotecario + "%");


//resultados que se deben mostrar por pantalla
//comparar distintas opciones para elegir la mejor
