using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Solution
{
    public class dbRepository
    {
        private dbContext db = new dbContext();

        public List<string> FetchDataAsString()
        {
            return db.Testit.Select(t => t.Nimi).ToList();
        }

        public IQueryable<Testitaulu> FetchDataAsTableModel()
        {
            return db.Testit;
        }
    }
}
