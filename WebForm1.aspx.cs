using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenR_JAGS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public class Perrito
        {
            public string status { get; set; }
            public string message { get; set; }
        }

        protected async void Generar(object sender, EventArgs e)
        {
            await GenerarPerrito();
        }


        public async  Task GenerarPerrito()
        {
            string url = "https://dog.ceo/api/breeds/image/random";
            using (HttpClient  client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);
                Perrito perrito = JsonConvert.DeserializeObject<Perrito>(json);

                imagen.ImageUrl = perrito.message;
                imagen.Visible = true;
            }
        }


    }
}