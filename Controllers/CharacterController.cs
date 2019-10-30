using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using bobesponja_api.Modules;
using bobesponja_api.Dependencies;
using System.Data.SqlClient; 


namespace bobesponja_api.Controller

{
  [Route("bobesponja/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    
    public class CharacterController: ICharacter
    {
       List<Character> listOfCharacters => new List<Character>
        {
             new Character
            {
                Nombre = "Bob Esponja",
                Apellido = "Pantalones Cuadrados",
                Genero = "Masculino",
                Color = "Amarillo",
                Especie = "Esponja de Mar",
                Ocupacion = "Trabaja como cocinero en el Crustáceo Cascarudo, junto con su vecino, Calamardo Tentáculos.",
                Descripcion = "Vive en una piña en la ciudad de Fondo de Bikini, con su caracol Gary. Bob es el mejor amigo de Patricio Estrella, y le encanta pescar medusas y soplar burbujas.",
            },

            new Character
            {
                Nombre = "Patricio",
                Apellido = "Estrella",
                Genero = "Masculino",
                Color = "Rosado",
                Especie = "Estrella de mar",
                Ocupacion = "Patricio tiene el premio por no hacer nada durante más tiempo que nadie y busca seguir invicto en ese título.",
                Descripcion = "Vive debajo de una roca en la ciudad submarina de Fondo de Bikini, siendo vecino de Bob Esponja y Calamardo.",
            },
            
            new Character
            {
                Nombre = "Calamardo",
                Apellido = "Tentáculos",
                Genero = "Masculino",
                Color = "Turquesa",
                Especie = "Pulpo",
                Ocupacion = "Es compañero de trabajo de Bob, en el Crustáceo Cascarudo, restaurante de comida rápida, donde trabaja como cajero.",
                Descripcion = "Es amargado y de un carácter pesimista. Aunque está amargado, a veces suele comportarse de manera muy despreciable.",
            },

            new Character
            {
                Nombre = "Don Eugenio",
                Apellido = "Cangrejo",
                Genero = "Masculino",
                Color = "Rojo",
                Especie = "Cangrejo Rojo",
                Ocupacion = "Es el jefe de Bob Esponja y el dueño del restaurante El Crustáceo Cascarudo",
                Descripcion = "Persona madura, que tiene su futuro resuelto por poseer el restaurante más exitoso del Fondo de Bikini, le encanta el dinero; frecuentemente suma billetes.",
            },

            new Character
            {
                Nombre = "Sheldon",
                Apellido = "Plankton",
                Genero = "Masculino",
                Color = "Verde",
                Especie = "Copépodo",
                Ocupacion = "Dueño de un repugnante restaurante llamado el Chum Bucket, donde la comida está hecha de Carnada, el restaurante queda en frente del Crustáceo Cascarudo.",
                Descripcion = "Él y su computadora consciente, Karen, siempre planean robar la receta de la Cangreburger de Don Cangrejo.",
            },
         };


              [HttpGet("{id}")]
        public Character GetCharacterList(int id)
        {
             return characterList[id];

        }

        [HttpGet]
        public List<Character> GetCharacterList()
        {
           return characterList;
        }
         }
    


}