using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatalogPesni
{
    public class DatabaseController
    {
        

        public void WriteToDatabase(CatalogDataModel model)
        {
            using (var db = new Database())
            {
                db.Songs.Add(model);
                db.SaveChanges();
            }
        }

        public CatalogDataModel GetModelByName(string name)
        {
            using (var db = new Database())
            {
                return db.Songs.First(g => g.SongName == name);
            }
        }

        public List<string> GetSongNames()
        {
            var result = new List<string>();
            using (var db = new Database())
            {
                if(db.Songs.Count() > 0)
                {
                    foreach (var g in db.Songs)
                        result.Add(g.SongName);
                }
               
            }
            return result;
        }

        public List<string> GetSortedSongNames()
        {
            var result = new List<string>();
            using (var db = new Database())
            {
                if (db.Songs.Count() > 0)
                {
                    foreach (var g in db.Songs)
                        result.Add(g.SongName);

                    result.Sort(StringComparer.CurrentCulture);
                }
            }
            return result;
        }

        public List<string> GetSortedSingers()
        {
            var result = new List<string>();
            using (var db = new Database())
            {
                if (db.Songs.Count() > 0)
                {
                    foreach (var g in db.Songs)
                        result.Add(g.Singer);

                    result.Sort(StringComparer.CurrentCulture);
                }
            }
            return result;
        }


        public List<string> GetSortedYear()
        {
            var result = new List<string>();
            using (var db = new Database())
            {
                if (db.Songs.Count() > 0)
                {
                    foreach (var g in db.Songs)
                        result.Add(g.Year.ToString());

                    result.Sort(StringComparer.CurrentCulture);
                }
            }
            return result;
        }

        public List<string> GetSortedGenre()
        {
            var result = new List<string>();
            using (var db = new Database())
            {
                if (db.Songs.Count() > 0)
                {
                    foreach (var g in db.Songs)
                        result.Add(g.Genre);

                    result.Sort(StringComparer.CurrentCulture);
                }
            }
            return result;
        }

        public List<string> GetSortedLength()
        {
            var result = new List<string>();
            using (var db = new Database())
            {
                if (db.Songs.Count() > 0)
                {
                    foreach (var g in db.Songs)
                        result.Add(g.Length.ToString());

                    result.Sort(StringComparer.CurrentCulture);
                }
            }
            return result;
        }
    }
}
