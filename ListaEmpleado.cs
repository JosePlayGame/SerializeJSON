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
        string json = JsonConvert.SerializeObject(_plantilla,Formatting.None);
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
        float sueldo = 0f;
        for (int i = 0; i < cuantos; i++)
        {
            sueldo= (float)Math.Round(rnd.NextDouble()*(4000-1400)+1400);
            _plantilla.Add(new Empleado(i,apellidos[rnd.Next(0,apellidos.Length-1)],nombres[rnd.Next(0,nombres.Length-1)],sueldo));
        }
        GenerarJSON();
    }
    public override string ToString()
    {
        return String.Join("\n",_plantilla);
    }
    public bool ActualizarSueldoJSON(int id,float nuevoSueldo){
        if(File.Exists(rutaficheo)){
            string json = File.ReadAllText(rutaficheo);
            if (json.Contains(id.ToString()))
            {
                dynamic? arrayempleados = JsonConvert.DeserializeObject(json);
                arrayempleados![id]["Sueldo"]=nuevoSueldo;
                string datosASalvar = JsonConvert.SerializeObject(arrayempleados,Formatting.Indented);
                File.WriteAllText(rutaficheo,datosASalvar);
                return true;
            }
        }
        return false;
    }
    #endregion
}