using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatalogPesni
{
    public class Database : DbContext
    {
        public DbSet<CatalogDataModel> Songs { get; set; }

        public Database() : base("name=CatalogDatabase") { }

    }
}
