class Empleado
{
    //#region Sirve para crear regiones y hacer el codigo más visible para el programador
    #region Propiedades
    public int ID{get;set;}
    public string Apellidos { get; set; }
    public string Nombre { get; set;}
    public float Sueldo { get; set; }
    public bool Borrado{get; set;}
    #endregion

    #region Constructores
    public Empleado(int id,string nom, string ape, float sue) 
    { 
        ID=id;
        Apellidos = ape;
        Nombre = nom;
        Sueldo = sue;
    }
    #endregion

    #region Métodos
    public override string ToString()
    {
        return $"#{ID,-5}{Apellidos,-30}{Nombre,-20}{Sueldo,-7}€";
    }
    #endregion
}