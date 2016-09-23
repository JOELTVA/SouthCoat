using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SouthCoat.DAL
{
    public class SouthCoatAccess
    {

        private SouthCoatEntities db = new SouthCoatEntities();

        //Products

        public List<Product> FindAllProducts()
        {
            try
            {
                List<Product> listProducts = (from p in db.Product where p.ProductName != "Orange" select p).ToList();
                return listProducts;
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

    }
}