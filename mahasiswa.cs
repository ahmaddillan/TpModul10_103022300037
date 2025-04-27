using Microsoft.AspNetCore.Mvc;
namespace tpmodul10_103022300037
{
    [ApiController]
    [Route("api/[controller]")]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa1> dataMahasiswa = new List<Mahasiswa1>
        {
            new Mahasiswa1("LeBron James","1302000001"),
            new Mahasiswa1("Stephen Curry","1302000002")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa1> Get()
        {
            return dataMahasiswa;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa1 mahasiswa)
        {
            dataMahasiswa.Add(mahasiswa);
        }

        [HttpGet("{id}")]
        public Mahasiswa1 Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpDelete]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
