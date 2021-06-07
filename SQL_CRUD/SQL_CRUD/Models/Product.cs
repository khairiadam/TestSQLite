using System;
using SQLite;

namespace TestSQLite.Models
{
    public class Product
    {
        [ PrimaryKey , AutoIncrement ] 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}