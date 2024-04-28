using Microsoft.AspNetCore.Mvc;
using tpmodul10_1302223050;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul10_1302220053.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswa : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Gabrielle Adsense Felime", "1302220053"),
            new Mahasiswa("Reinhard Efraim Situmeang", "13022220001"),
            new Mahasiswa("Muhammad Rizqi Fadilah", "1302220020"),
            new Mahasiswa("Rafli Ahmad Denistri" , "1302223153"),
            new Mahasiswa(" Rizky Kusuma Nugraha", "130222"),
            new Mahasiswa(" Shela Tappa", "130222")
        };
        // GET: api/<mahasiswa>
        [HttpGet]


        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
;
        }

        // GET api/<mahasiswa>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        // POST api/<mahasiswa>
        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

       

        // DELETE api/<mahasiswa>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}
