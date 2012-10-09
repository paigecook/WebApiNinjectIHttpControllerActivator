using System.Collections.Generic;
using System.Web.Http;
using WebApiNinjectIHttpControllerActivator.Models;

namespace WebApiNinjectIHttpControllerActivator.Controllers
{
    public class RootController : ApiController
    {
        private readonly IStatusQuery _statusQuery;

        public RootController(IStatusQuery statusQuery)
        {
            _statusQuery = statusQuery;
        }

        // GET api/root
        public IEnumerable<string> Get()
        {
            return _statusQuery.GetValues();
        }

        // GET api/root/5
        public string Get(int id)
        {
            return _statusQuery.GetValueById(id);
        }
    }
}
