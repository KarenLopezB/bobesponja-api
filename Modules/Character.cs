using System;


namespace bobesponja_api.Modules
{

    public class Character
    {
    Int64 id;
    string nombre;
    string apellido;
    string genero;
    string color;
    string especie;
    string ocupacion;
    string descripcion;

    public Character(){}
    
    public Character ( Int64 id,string nombre, string apellido, string genero, string color, string especie, string ocupacion, string descripcion )
    {
        this.id = id;
        this.nombre = nombre;
        this.apellido = apellido;
        this.genero = genero;
        this.color = color;
        this.especie = especie;
        this.ocupacion = ocupacion;
        this.descripcion = descripcion;   
    }
    
     

      public string Nombre { get => nombre; set => nombre = value; }
      public string Apellido { get => apellido; set => apellido = value; }
      public string Genero { get => genero; set => genero = value; }
      public string Color { get => color; set => color = value; }  
      public string Especie { get => especie; set => especie = value; }
      public string Ocupacion { get => ocupacion; set => ocupacion = value; }   
      public string Descripcion { get => descripcion; set => descripcion = value; }  
      public Int64 Id {get => id; set => id = value; }

    }
}