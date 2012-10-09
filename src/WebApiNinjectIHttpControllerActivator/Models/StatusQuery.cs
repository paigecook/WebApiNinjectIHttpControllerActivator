using System.Collections.Generic;

namespace WebApiNinjectIHttpControllerActivator.Models
{
    public class StatusQuery : IStatusQuery
    {
        private readonly List<string> _statuses = new List<string> { "New", "Modified", "Added", "Delete" };  

        public IEnumerable<string> GetValues()
        {
            return _statuses;
        }

        public string GetValueById(int id)
        {
            if (id >= _statuses.Count || id < 0)
            {
                return "Not Found";
            }

            return _statuses[id - 1];
        }
    }
}