using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Clases
{
    [Serializable]
    public class PersonaDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }
    }
}
