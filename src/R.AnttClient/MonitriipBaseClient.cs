using antt.gov.br.monitriip.v1._0;
using System.Net.Http;
using System.Threading.Tasks;

namespace R.Monitriip.HttpClient
{
    public class MonitriipBaseClient : System.Net.Http.HttpClient
    {
        protected async Task<resultadoOperacao> ExecuteRequestAsync<T>(string url, T @object)
        {
           
            var response = await this.PostAsXmlAsync(url, @object);
            var ret = response.Content.ReadAsAsync<resultadoOperacao>().Result;

            return await Task.FromResult(ret);

        }

    }
}
