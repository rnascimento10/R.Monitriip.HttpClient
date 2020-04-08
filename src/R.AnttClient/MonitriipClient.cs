using antt.gov.br.monitriip.v1._0;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace R.Monitriip.HttpClient
{
    public class MonitriipClient : MonitriipBaseClient, IMonitriipClient
    {

        protected string URL_HOMOLOGACAO_BASE = "http://appservices.antt.gov.br:8000/antt/monitriip.validacao/rest/";


        public MonitriipClient(string token)
        {

            Timeout = TimeSpan.FromSeconds(3);
            
            BaseAddress = new Uri(URL_HOMOLOGACAO_BASE);
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        public MonitriipClient(string urlBase, string token)
        {

            Timeout = TimeSpan.FromSeconds(3);

            BaseAddress = new Uri(urlBase);
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
        }

        public MonitriipClient(int timeout, string urlBase, string token)
        {

            Timeout = (timeout > 0) ? new TimeSpan(0, 0, timeout) : new TimeSpan(0, 0, 3);
            BaseAddress = new Uri(urlBase);
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);                
        }


        public async Task<resultadoOperacao> InserirLogBilheteEmbarque(bilheteEmbarque bilheteEmbarque)
        { 
            var retval = await ExecuteRequestAsync("rest/InserirLogVendaPassagem", bilheteEmbarque);
            return await Task.FromResult(retval);   
        }

        public async Task<resultadoOperacao> InserirLogCancelarPassagem(cancelarPassagem cancelamentoPassagem)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogCancelarPassagem", cancelamentoPassagem);
            return await Task.FromResult(retval);            
        }

        public async Task<resultadoOperacao> InserirLogCartaoEmitidoRecargaEfetuada(cartaoEmitidoRecargaEfetuada cartaoEmitidoRecargaEfetuada)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogCartaoEmitidoRecargaEfetuada", cartaoEmitidoRecargaEfetuada);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogDetectorParada(detectorParada detectorParada)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogDetectorParada", detectorParada);
            return await Task.FromResult(retval); 
        }

        public async Task<resultadoOperacao> InserirLogInicioFimViagemFretado(inicioFimViagemFretado inicioFimViagemFretado)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogInicioFimViagemFretado", inicioFimViagemFretado);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogInicioFimViagemRegular(inicioFimViagemRegular inicioFimViagemRegular)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogInicioFimViagemRegular", inicioFimViagemRegular);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogJornadaTrabalhoMotorista(jornadaTrabalhoMotorista jornadaTrabalhoMotorista)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogJornadaTrabalhoMotorista", jornadaTrabalhoMotorista);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogLeitorCartaoRFID(leitorCartaoRFID cartaoRFID)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogLeitorCartaoRFID", cartaoRFID);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogRegistroOcorrenciaRodoviario(registroOcorrenciaRodoviario ocorrencia)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogRegistroOcorrenciaRodoviario", ocorrencia);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogRegistroOcorrenciaSemiUrbano(registroOcorrenciaSemiurbano ocorrencia)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogRegistroOcorrenciaSemiUrbano", ocorrencia);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogVelocidadeTempoLocalizacao(velocidadeTempoLocalizacao velocidadeTempoLocalizacao)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogVelocidadeTempoLocalizacao", velocidadeTempoLocalizacao);
            return await Task.FromResult(retval);
        }

        public async Task<resultadoOperacao> InserirLogVendaPassagem(vendaPassagem passagem)
        {
            var retval = await ExecuteRequestAsync("rest/InserirLogVendaPassagem", passagem);
            return await Task.FromResult(retval);
        }
    }
}
