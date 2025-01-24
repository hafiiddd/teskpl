using Microsoft.AspNetCore.Mvc;

namespace tesKPL.Controllers
{
    [Route("api/[controller]")]
    public class tokoController : Controller

    {
        public static List<tokoOnline> dataToko = new List<tokoOnline>
        {
            new tokoOnline("hafid","musang",1,20000,"01-january-2023","bogor",Shipping_Type.delivered),
            new tokoOnline("eddy","musang",1,20000,"01-january-2023","bogor",Shipping_Type.delivered)

        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(dataToko);
        }
        [HttpPost]
        public IActionResult Post([FromBody] tokoOnline value)
        {
            dataToko.Add(value);
            return CreatedAtAction(nameof(Post), value);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] tokoOnline value)
        {
            tokoOnline findPesanan = dataToko.ElementAt(id);
            findPesanan.Customer_name = value.Customer_name;
            findPesanan.total_price = value.total_price;
            findPesanan.product_name = value.product_name;
            findPesanan.shipping_address = value.shipping_address;
            findPesanan.quantity = value.quantity;
            findPesanan.order_date = value.order_date;
            return Ok(findPesanan);
        }
        [HttpGet("{id}")]
        public tokoOnline Get(int id)
        {
            return dataToko[id];
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataToko.RemoveAt(id);
        }
    }
}
