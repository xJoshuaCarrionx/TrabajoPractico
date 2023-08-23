String[] Unidades =
{
    "",
    "Uno",
    "Dos",
    "tres",
    "cuatro",
    "Cinco",
    "Seis",    
    "Siete",
    "Ocho",
    "Nueve",

};

String[] Decenas = 
{ 
  "",
  "Diez",
  "Veinte",
  "Treinta",
  "Cuarenta",
  "Cincuenta",
  "Sesenta",
  "Setenta",
  "Ochenta",
  "Noventa",

};


String[] Especiales =
{
    "",
    "Once",
    "Doce",
    "Trece",
    "Catorce",
    "Quince",
    "Diesciseis",
    "Diesiciete",
    "Diesiocho",
    "Diesinueve"
};
String[] Centenas =
{
    "",
    "Cientos",
    "Doscientos",
    "Tresciento",
    "Cuatrocientos",
    "Quinientos",
    "Sesicientos",
    "Setencientos",
    "Ochocientos",
    "Novecientos",
};

int numero;
while (true)
{
    Console.WriteLine("Ingrese un numero entre 0 y 9999");
    if (int.TryParse(Console.ReadLine(), out numero))
    {
        if(numero >= 0 && numero <= 9999)
        {
            string numerosEnLetras = Convertirnumerosinletras(numero);
            Console.WriteLine($"El numero {numero} en letras es:  {numerosEnLetras}");
        }
        else
        {
            Console.WriteLine("El numero ingresado esta fuera del rango");
        }
    }
    else
    {
        Console.WriteLine("Entrada no valida. " +
          "Por favor ingrese un numero valido");

    } 
}

string Convertirnumerosinletras(int numero)
{ 
    if (numero == 0)
    {
        return "Cero";

    }
    string numeroEnLetras = "";


    //Procesar unidades de millar
    int unidadesDeMillar = numero / 1000;
    if (unidadesDeMillar > 0)
    {
        if (unidadesDeMillar == 1)
            numeroEnLetras = "Mil";
        else 
        numeroEnLetras += Unidades[unidadesDeMillar] + "Mil";
        numero %= 1000;

    }

    //Procesar las centenas
    int parteCentena = numero / 100;
    if (parteCentena > 0)
    {
        numeroEnLetras += Centenas[parteCentena] + " ";
        numero %= 100;
    }
    // Decenas y Unidades
    if (numero >= 11 && numero <= 19)
    {
        numeroEnLetras += Especiales[numero - 10] + " ";
    }
    else
    {
        int decena = numero / 10;
        if (decena > 0)
        {
            numeroEnLetras += Decenas[decena];
            if (numero % 10 > 0)
            {
                numeroEnLetras += " y " +
                    Unidades[numero % 10];
            }


        } else if (numero % 10 > 0) 
        {
            numeroEnLetras += Unidades[numero % 10];

        }
      
    }
    return numeroEnLetras;
}

