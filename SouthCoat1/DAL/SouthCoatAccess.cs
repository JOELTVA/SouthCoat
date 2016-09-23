using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SouthCoat1.DAL
{
    public class SouthCoatAccess
    {
        private SouthCoatEntities sce = new SouthCoatEntities();


        //Fungerar
        public List<Product> FindAllProductsTest()
        {
            string s = "orange";
            try
            {
                List<Product> listMembers = (from u in sce.Product where u.ProductId == s select u).ToList();
                return listMembers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}