using Microsoft.AspNetCore.Mvc;

namespace Project001.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {

        public string Phone()
        {
            return "07891632506";
        }

        public string Address()
        {
            return "25 Mallard Way, Watford, UK";
        }
    }
}
