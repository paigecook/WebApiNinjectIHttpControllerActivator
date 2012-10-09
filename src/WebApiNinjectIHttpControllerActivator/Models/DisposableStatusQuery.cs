using System;
using System.Collections.Generic;

namespace WebApiNinjectIHttpControllerActivator.Models
{
    public class DisposableStatusQuery : IDisposable, IStatusQuery
    {
        private readonly List<string> _values = new List<string>{ "value1", "value2"};  

        public void Dispose()
        {
            //do something to dispose of an expensive resource here.
        }

        public IEnumerable<string> GetValues()
        {
            return _values;
        }

        public string GetValueById(int id)
        {
            if(id >= _values.Count || id < 0)
            {
                return "Not Found";
            }

            return _values[id - 1];
        }
    }
}