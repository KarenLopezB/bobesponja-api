 using System.Collections.Generic;
using bobesponja_api.Modules;
using Microsoft.AspNetCore.Mvc;

namespace bobesponja_api.Dependencies
{
    public interface ICharacter
    {
        List<Character> GetCharacterList();
        
        Character GetCharacter(int id);
    }
     
}