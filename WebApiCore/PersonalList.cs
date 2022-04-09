using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Model;

namespace WebApiCore
{
    public class PersonalList
    {
        public static List<Personal> pers = new List<Personal>
        {
          new  Personal
          {
            id=1000,
            name="Farid",
            surname="Hasanov",
            birth_place="Goranboy",
            age=20,
            salary=180
          },
          new  Personal
          {
            id=1001,
            name="Kanan",
            surname="Hasanov",
            birth_place="Goycay",
            age=20,
            salary=200
          },
          new  Personal
          {
            id=1002,
            name="Ibrahim",
            surname="Seyfullayev",
            birth_place="Salyan",
            age=20,
            salary=220
          }
        }; 
    }
}
