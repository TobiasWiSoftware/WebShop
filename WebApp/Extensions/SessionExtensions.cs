using System.Text.Json;
using Microsoft.AspNetCore.Http;
using ShopBase.Model;

namespace WebApp

{
    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        { 
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetObject<T>(this ISession session, string key) 
        {
            var value = session.GetString(key);

            if(value == null)
            {
                Statistic.WebsiteVisit();
            }

            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
    }
}
