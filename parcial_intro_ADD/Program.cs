// See https://aka.ms/new-console-template for more information

//datos que debe ingresar el usuario

int anio = 2022;

string[] tasasBancoNacion = new string[3];

string[] tasasBancoProvincia = new string[3];

string[] tasasBancoHipotecario = new string[3];

//-----------------  Banco Nación  -------------------------

for (int i = 0; i < tasasBancoNacion.Length; i++)
{
    Console.WriteLine("Ingrese la tasa anual del año "+(anio)+" para el Banco Nación:");
    tasasBancoNacion[i] = Console.ReadLine();
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
    tasasBancoProvincia[i] = Console.ReadLine();
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
    tasasBancoHipotecario[i] = Console.ReadLine();
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
//resultados que se deben mostrar por pantalla
//comparar distintas opciones para elegir la mejor
