using System.Collections.Generic;

namespace WebApiNinjectIHttpControllerActivator.Models
{
    public interface IStatusQuery
    {
        IEnumerable<string> GetValues();
        string GetValueById(int id);
    }
}