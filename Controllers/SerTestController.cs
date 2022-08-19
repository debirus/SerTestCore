using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SerTestCore.Models;
using SerTestCore.Logic;

namespace SerTestCore.Controllers{

    [ApiController]
    [Route("[controller]")]
    public class SerTestController : ControllerBase
    {
        private readonly ILogger<SerTestController> _logger;
        private readonly SerTestLogic logic;

        public AppDb Db { get; }

        public SerTestController(ILogger<SerTestController> logger, AppDb db)
        {
            _logger = logger;
            Db = db;
            logic=new SerTestLogic(db);
        }

        [HttpGet(Name = "GetSerTestTable")]
        public List<SerTestObj> GetTable()
        {
            return logic.GetTable();
        }
    }
}
