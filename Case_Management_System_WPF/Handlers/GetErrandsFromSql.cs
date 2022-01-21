using Case_Management_System_WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Management_System_WPF.Handlers
{
    internal class GetErrandsFromSql
    {
        SqlService sql = new();

        public void Database(ErrandsList errandsList)
        {
            errandsList.ClearErrandsList();

            var _errandList = sql.GetErrands();

            foreach ( var errand in _errandList)
                errandsList.AddToErrandsList(errand);
        }
    }
}
