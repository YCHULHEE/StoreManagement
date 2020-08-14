using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement
{
    public class TableInfo
    {
        public string tableName { get; set; }
        public int tableNumber { get; set; }
        public int price { get; set; }
        public int kidNumber { get; set; }
        public int adultNumber { get; set; }
        public DateTime inTime { get; set; }
        public DateTime outTime { get; set; }
        public int check { get; set; }

        public TableInfo()
        {
            this.check = 0;
        }


        
    }
}
