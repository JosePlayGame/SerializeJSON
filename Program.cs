class Program
{
    /*
    Para serealizar un objeto de la clase Empleado, se tiene que tener en cuenta los siguientes puntos:
        1.- Creacion de la clase con sus propiedades , métodos y constructores
        2.- Creamos una lista de empleados para pasarlo a JSON. 
        3.- Añadimos la libreria NewtonSoft.Json con el comando "dotnet add package NewtonSoft.Json"
        4.- Serializamos el JSON para que lo cree
        5.- Deserializamos el JSON
    
    
    */
    static void Main(string[] args)
    {
        ListaEmpleado listaEmpleado= new ListaEmpleado();
        listaEmpleado.GenerarAleatorio(30); //Serializador del JSON
        listaEmpleado.ListarJSON();    //Deserializador del JSON
    }
}