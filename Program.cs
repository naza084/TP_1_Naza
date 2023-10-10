//Variables
string text = "hola gente magenta";
string textTraducido = "";



//Primero sacamos los espacios
string[] palabras = text.Split(' ');




//Recorremos cada palabra en el texto y aplicamos reglas
foreach (string palabra in palabras)
{

    //Aplicamos regla 1
    string palabraTraducida = TraducirRegla1(palabra);


    //Minusculizamos la frase
    palabraTraducida = palabraTraducida.ToLower();


    //Aplicamos regla 3
    palabraTraducida = TraducirRegla3(palabraTraducida);


    //Aplicamos regla 4
    palabraTraducida = TraducirRegla4(palabraTraducida);


    //Agregamos la palabra traducida al texto traducido
    textTraducido += palabraTraducida + " ";
}



//Mostramos el texto traducido
Console.WriteLine("Texto original: " + text);
Console.WriteLine("Texto traducido: " + textTraducido.Trim());




//Metodos:



//Regla 1
static string TraducirRegla1(string palabra)
{


    //Modificamos la palabra original con insert
    if (EsVocal(palabra[0]) && !EsVocal(palabra[1])) palabra = palabra.Insert(1, palabra[0].ToString());


    return palabra;
}


   

//Regla 3
static string TraducirRegla3(string palabra)
{


    //agregamos an al principio si cumple la regla
    if (palabra.Length > 6) palabra = palabra.Insert(0, "an");


    return palabra;
}




//Regla 4
static string TraducirRegla4(string palabra)
{

    char ultimaLetra = palabra[palabra.Length - 1];


    //Verificamos la ultima letra y aplicamos la regla 
    if (EsVocalMenosO(ultimaLetra) || ultimaLetra == 'n' || ultimaLetra == 's') palabra += "sten";
    else if (ultimaLetra == 'o' || ultimaLetra == 'O') palabra += "so";


    return palabra;
}





//Metodo auxiliar para verificar vocal
static bool EsVocal(char letra)
{

    string vocales = "aeiouAEIOU";

    //Verificamos si la letra está en las vocales
    return vocales.Contains(letra);

}


//Metodo auxiliar para la regla 4
static bool EsVocalMenosO(char letra)
{

    string vocales = "aeiu";

    //Verificamos si la letra esta en las vocales menos la O
    return vocales.Contains(letra);

}




Console.ReadKey();