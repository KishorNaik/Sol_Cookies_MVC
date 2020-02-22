using CookieManager;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Persistence
{
    public static class Data
    {
        public static async Task<CookiesModel> DataPersitanceAsync(ICookieManager cookieManager)
        {
            return await Task.Run(() =>
            {
                return cookieManager.GetOrSet<CookiesModel>("mymodel", () =>
               {
                   //write fucntion to store  output in cookie
                   return new CookiesModel()
                   {
                       Id = Guid.NewGuid().ToString(),
                       Indentifier = "valueasgrsdgdf66514sdfgsd51d65s31g5dsg1rs5dg",
                       Date = DateTime.Now
                   };
               }, 60);
            });
        }
    }
}