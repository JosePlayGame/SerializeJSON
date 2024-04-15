using Newtonsoft.Json;

public class ListaEmpleado
{
    #region Propiedades
    
    #endregion
    #region Campos Privados
    List<Empleado> _plantilla;
    string rutaficheo="empleados.json";
    #endregion
    #region Constructores
    public ListaEmpleado(){
        _plantilla = new List<Empleado>();
    }
    #endregion
    #region Metodos
    private void GenerarJSON(){
        string json = JsonConvert.SerializeObject(_plantilla,Formatting.Indented);
        File.WriteAllText(rutaficheo,json);
    }
    public void ListarJSON(){
        if (!File.Exists(rutaficheo))
        {
            System.Console.WriteLine("No existe el fichero con el JSON");
            return;
        }
        var plantilla = new List<Empleado>();
        using(StreamReader sr = File.OpenText(rutaficheo)){
            plantilla = JsonConvert.DeserializeObject<List<Empleado>>(sr.ReadToEnd());
        }
        if (plantilla!= null)
        {
            foreach (var item in plantilla)
            {
                if (!item.Borrado)
                {
                    System.Console.WriteLine(item);
                }
            }
        }
    }
    //para generar numeros aleatorios se usa  la resta entre los extremos mas el minimo
    public void GenerarAleatorio(int cuantos){
        string[]nombres={"Juan","Pedro","Maria","Alberto","Jesús","Enrique","Aitor"};
        string[]apellidos = {"Perez","Gonzalez","Lopez","Martinez","Garcia","Ruiz","Sanchez"};
        Random rnd = new Random();
        for (int i = 0; i < cuantos; i++)
        {
            _plantilla.Add(new Empleado(apellidos[rnd.Next(0,apellidos.Length-1)],nombres[rnd.Next(0,nombres.Length-1)],(float)Math.Round(rnd.NextDouble()*(4000-1400)+1400)));
        }
        GenerarJSON();
    }
    public override string ToString()
    {
        return String.Join("\n",_plantilla);
    }
    #endregion
}