using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogPesni
{
    public class CatalogDataModel
    {
        public int Id { get; set; }
        public string SongName { get; set; }
        public string Singer { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public double Length { get; set; }
        
    }
}
