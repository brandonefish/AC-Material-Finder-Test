using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AC_Test.Classes
{
    public class Director
    {
        public List<Materials> FindMaterialsList()
        {
            List<Materials> materialsList;
            Controller con = new Controller();
            materialsList = con.GetMaterials();
            return materialsList;
        }
    }
}
