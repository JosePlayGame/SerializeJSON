class Empleado
{
    //#region Sirve para crear regiones y hacer el codigo más visible para el programador
    #region Propiedades
    public string Apellidos { get; set; }
    public string Nombre { get; set;}
    public float Sueldo { get; set; }
    public bool Borrado{get; set;}
    #endregion

    #region Constructores
    public Empleado(string nom, string ape, float sue) 
    { 
        Apellidos = ape;
        Nombre = nom;
        Sueldo = sue;
    }
    #endregion

    #region Métodos
    public override string ToString()
    {
        return $"{Apellidos,-30}{Nombre,-20}{Sueldo,9}€";
    }
    #endregion
}