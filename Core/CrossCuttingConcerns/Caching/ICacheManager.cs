using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key); // cacheden data getirmek için,
        object Get(string key); // yukarıdakinin non generic hali.
        void Add(string key, object value, int duration); // cache eklemek için
        bool IsAdd(string key); // cache de varmı bakmak için
        void Remove(string key);// cacheden silmek için
        void RemoveByPattern(string pattern); // bir regex pattern'ine göre cacheden silmek için,(pattern bir regex pattern'i)
    }
}
