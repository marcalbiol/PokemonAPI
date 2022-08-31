using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_BD.Repository.Entity
{
    public class Pagination
    {
        const int maxSize = 50;
        public int Pagina { get; set; } = 1;

        private int _pageSize = 10;

        public int TamañoPagina
        {
            get { return _pageSize; }
            set { _pageSize = (value > maxSize) ? maxSize : value; }
        }

    }
}
