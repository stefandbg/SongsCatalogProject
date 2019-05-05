using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogPesni
{
    public class LoadFromFIle
    {
        private string Filename;


        public LoadFromFIle(string FileName)
        {
            this.Filename = FileName;
        }

        public List<CatalogDataModel> GetModelFromFile()
        {
            List<CatalogDataModel> result = new List<CatalogDataModel>();
            string[] lines = File.ReadAllLines(Filename);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(';');
               
                int id = int.Parse(data[0]);
                double length = double.Parse(data[5]);
                
                int year = int.Parse(data[3]);
              
                var model = new CatalogDataModel()
                {
                    Id = id,
                    SongName = data[1],
                    Singer = data[2],
                    Year = year,
                    Genre = data[4],
                    Length = length,
                   

                };
                result.Add(model);
            }
            return result;
        }

    }
}
