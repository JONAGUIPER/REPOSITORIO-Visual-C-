using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDataContext
    {
        DataTable GetCustomers();
        DataTable GetStores();
        DataTable GetSalesOrdersHeaders();

        Cliente GetCustomersByID(int ClienteID);
        DataTable GetPedidos(int ClienteID);
    }
}
