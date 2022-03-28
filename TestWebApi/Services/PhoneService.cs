using System.Collections.Generic;
using System.Linq;
using TestWebApi.Models;

namespace TestWebApi.Services
{
    public static class PhoneService
    {
        private static readonly List<Phone> _phones = new();
        public static List<Phone> GetAll => _phones;
        public static Phone Get(int id)=>_phones.FirstOrDefault(x => x.Id == id);
        public static Phone Get(string name)=>_phones.FirstOrDefault(x => x.Name == name);
        public static void Add(Phone phone)
        {
            _phones.Add(phone);
        }
        public static void Delete(int id)
        {
            Phone phone = Get(id);
            if (phone is null)
                return;
            _phones.Remove(phone);
        }
    }
}
