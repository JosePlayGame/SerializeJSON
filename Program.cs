class Program
{
    /*
    Para serealizar un objeto de la clase Empleado, se tiene que tener en cuenta los siguientes puntos:
        1.- Creacion de la clase con sus propiedades , métodos y constructores
        2.- Creamos una lista de empleados para pasarlo a JSON. 
        3.- Añadimos la libreria NewtonSoft.Json con el comando "dotnet add package NewtonSoft.Json"
        4.- Serializamos el JSON para que lo cree
        5.- Deserializamos el JSON
        6.- Usamos el programa con GenerarAleatorio y ListarJSON para serializar y deserializar
        7.- Para que no te muestre un empleado se pone en Borrado = true y quitamos el metodo de GenerarAleatorio
    */
    static void Main(string[] args)
    {
        ListaEmpleado listaEmpleado= new ListaEmpleado();
        listaEmpleado.GenerarAleatorio(10); //serializador del json
        listaEmpleado.ListarJSON();    //Deserializador del JSON
        System.Console.WriteLine("Actualización del salario \n");
        listaEmpleado.ActualizarSueldoJSON(1,5000.50f);
        listaEmpleado.ListarJSON();
    }
}