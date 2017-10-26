using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Login
    {

        public bool CheckData(String username, String password, int vartotojas)
        {
            bool exists = false;
            using (KnygosEntities2 contex = new KnygosEntities2())
            {
                Vartotojai vartotojass = contex.Vartotojais.FirstOrDefault(r => r.Userame == username
               && r.Password == password && r.Vartotojas == vartotojas);

                if (vartotojass != null)
                {
                    exists = true;
                }

            }
            return exists;
        }


        public void FillData(String username, String password, int vartotojas)
        {
            using (KnygosEntities2 contex = new KnygosEntities2())
            {
                Vartotojai vartotojass = new Vartotojai()
                {
                    Userame = username,
                    Password = password,
                    Vartotojas = vartotojas,

                };
                contex.Vartotojais.Add(vartotojass);
                contex.SaveChanges();
            }
        }

        public static int GetID(string username)
        {
            int id;
            using (KnygosEntities2 contex = new KnygosEntities2())
            {
                Vartotojai vartotojass = contex.Vartotojais.FirstOrDefault(r => r.Userame == username);
                    id = (int)vartotojass.Id;
            }
            return id;

        }



    }
}
