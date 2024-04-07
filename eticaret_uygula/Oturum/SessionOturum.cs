using Newtonsoft.Json;

namespace eticaret_uygula.Oturum
{
    public static class SessionOturum
    {
        public static void SetJson(this ISession session,string key,object value)//Session kullanıcı verilerini belirli bir süre ile durum bilgisini tutan, key-value şeklinde veri saklayan bir mekanizmadır.
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T GetJson<T>(this ISession session,string key)
        {
            var sessionData = session.GetString(key);
            return sessionData == null ? default(T) : JsonConvert.DeserializeObject<T>(sessionData);
        }
    }
}
