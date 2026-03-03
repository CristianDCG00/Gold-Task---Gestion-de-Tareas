//// Creamos un objeto fuera de la Clase persona
//Persona cristian = new Persona();

//cristian.estatura = 1.73;

//Auto toyota = new Auto()
//{
//    modelo = "Tracker",
//    anio = 2018,
//    kilometraje = 0,
//    precio = 100.000m
//};

//Auto chevrolet = new Auto()
//{
//    modelo = "Renault",
//    anio = 2010,
//    kilometraje = 0,
//    precio = 5000000m
//};

//Console.WriteLine($"Información del vehículo: \n {chevrolet.GetInfo()}");
//Console.WriteLine($"Información del vehículo: \n {toyota.GetInfo()}");

////Clase tipo pública, que en este caso es "Persona"
//public class Persona
//{
//    //Propiedades de la clase, o sea, de "Persona" 
//    public string nombre { get; set; }
//    public string apellido { get; set; }
//    public int edad { get; set; }
//    public double estatura { get; set; }

//    //Si algo es public es porque luego se puede acceder a sus datos o sus propiedades, en el caso de una clase.
//}

//public class Auto
//{
//    public string modelo { get; set; }
//    public int anio { get; set; }
//    public decimal kilometraje { get; set; }
//    public decimal precio { get; set; }

//    public string GetInfo()
//    {
//        return $"\nModelo: {modelo}. \n Año: {anio}. \n Kilometraje: {kilometraje}. \n Precio: {precio}";
//    }
//}
//int contador = 0;
//string entrada = "";
//Calculadora calculadora = new Calculadora();

//while (true)
//{
//    int opcion = calculadora.Opcion();
//    if (opcion == 5)
//    {
//        Console.WriteLine("¿Seguro que desea salir? S/N");
//        entrada = Console.ReadLine()!;
//    }
//    if (entrada == "S" || entrada == "s") break;
//    var operadores = calculadora.Operadores();
//    double resultados = calculadora.Resultados(opcion, operadores.n1, operadores.n2);
//    contador++;
//    double historial = calculadora.Historial(resultados);
//    Console.WriteLine($"\nEl resultado es: {resultados}. Hizo {contador} operaciones. El historial es {historial}");

//}

//public class Calculadora
//{
//    //Propiedades

//    //Métodos

//    //Opción
//    public int Opcion()
//    {
//        int opcion;

//        while (true)
//        {
//            Console.WriteLine("\nEija una opción");
//            Console.WriteLine("\n1. Sumar | 2. Restar | 3. Multiplicar | 4. Dividir | 5. Salir");

//            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
//            {
//                Console.WriteLine("\nError. Elija una opción válida.");
//                continue;
//            }

//            break;
//        }

//        return opcion;
//    }

//    //Operadores
//    public (double n1, double n2) Operadores()
//    {
//        double n1;
//        double n2;

//        while (true)
//        {
//            Console.WriteLine("Ingrese el primer número.");
//            if (!double.TryParse(Console.ReadLine(), out n1))
//            {
//                Console.WriteLine("\nError. Ingrese un número válido");
//                continue;
//            }

//            Console.WriteLine("Ingrese el segundo número.");
//            if (!double.TryParse(Console.ReadLine(), out n2))
//            {
//                Console.WriteLine("\nError. Ingrese un número válido");
//                continue;
//            }

//            break;
//        }

//        return (n1, n2);
//    }

//    //Switch
//    public double Resultados(int opcion, double n1, double n2)
//    {
//        double resultado = 0;

//        switch (opcion)
//        {
//            case 1:
//                return resultado = n1 + n2;

//            case 2:
//                return resultado = n1 - n2;

//            case 3:
//                return resultado = n1 * n2;

//            case 4:
//                if (n2 == 0)
//                {
//                    Console.WriteLine("\nNo se puede dividir por cero.");
//                    return 0;
//                }

//                return resultado = n1 / n2;

//            default:
//                return 0;
//        }
//    }

//    List<double> historial = new List<double>();

//    public double Historial(double resultado)
//    {


//        historial.Add(resultado);

//        foreach(var cosa  in historial)
//        {
//            return cosa;
//        }

//        return 0;
//    }

//}

//Pide números hasta que escriba "fin"

//Guárdalos en una lista

//Al final muéstralos todos

//ALGORITMO

//1 Crear un método que pida valores y los valide; los debe guardar en una lista.
//3. Crear un método que enseñe la lista una vez que el usuario escriba fin. Debe retornar la lista impresa.

//List<double> lista = LlenarLista();
//MostrarLista(lista);

//List<double> LlenarLista()
//{
//    double numero;
//    List<double> numeros = new List<double>();

//    while (true)
//    {
//        Console.WriteLine("Por favor, ingrese un número. Si desea salir presione 0");
//        if(!double.TryParse(Console.ReadLine(), out numero))
//        {
//            Console.WriteLine("Por favor, ingrese un número válido.");
//            continue;
//        }

//        if (numero == 0)
//        {
//            Console.WriteLine("Ha salido correctamente.");
//            break;
//        }

//        numeros.Add(numero);
//    }

//    return numeros;
//}

//void MostrarLista(List<double> lista)
//{
//    Console.WriteLine("Ha salido con éxito del programa, su lista de números es:");

//    foreach (double n in lista)
//    {
//        Console.Write($"{n} | ");
//    }
//}

Estudiante estudiante1 = new Estudiante() {

    nombres = "Sebastian Marín",
    apellidos = "Delgado",
    grado = "11-A"

};

Console.WriteLine($"Nombres del estudiante 1: {estudiante1.nombres}");
//estudiante1.Calificaciones();



public class Estudiante
{
    public string nombres { get; set; }
    public string apellidos { get; set; }
    public string grado { get; set; }

    public void Calificaciones()
    {
        int[] notas = {10, 7, 8, 9, 10};

        Console.WriteLine("El estudiante ha aprobado el 100% de las tareas en Sociales.");
        Console.WriteLine("Sus notas en sociales son:");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write(notas[i] + "|");
        }
    }
}