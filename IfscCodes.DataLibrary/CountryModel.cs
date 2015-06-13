using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfscCodes.DataLibrary
{
   public class CountryModel
    {
       public int Create(Country item)
       {
           using (IfscEntities context = new IfscEntities())
           {
               context.Countries.Add(item);
               context.SaveChanges();
               return item.CountryId;
           }
       }

       public int Update(Country item)
       {
           using (IfscEntities context = new IfscEntities())
           {
               Country itemToUpdate = GetCountry(item.CountryId);
               itemToUpdate.CountryName = item.CountryName;
               itemToUpdate.CountryCode = item.CountryCode;
               itemToUpdate.Active = item.Active;
               context.SaveChanges();
               return item.CountryId;
           }
       }
       public List<Country> GetCountries()
       {
           using (IfscEntities context = new IfscEntities())
           {
               List<Country> list = context.Countries.Where(c => c.Active == true).ToList<Country>();
               return list;
           }
       }

       public Country GetCountry(int Id)
       {
           using (IfscEntities context = new IfscEntities())
           {
               Country item = context.Countries.Where(c => c.Active == true && c.CountryId == Id).FirstOrDefault();
               return item;
           }
       }
    }
}
