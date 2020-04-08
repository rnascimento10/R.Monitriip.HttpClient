using antt.gov.br.monitriip.v1._0;
using System.Threading.Tasks;

namespace R.Monitriip.HttpClient
{
    public interface IMonitriipClient
    {
        Task<resultadoOperacao> InserirLogVendaPassagem(vendaPassagem passagem);
        Task<resultadoOperacao> InserirLogRegistroOcorrenciaRodoviario(registroOcorrenciaRodoviario ocorrencia);
        Task<resultadoOperacao> InserirLogCartaoEmitidoRecargaEfetuada(cartaoEmitidoRecargaEfetuada cartaoEmitidoRecargaEfetuada);
        Task<resultadoOperacao> InserirLogRegistroOcorrenciaSemiUrbano(registroOcorrenciaSemiurbano ocorrencia);
        Task<resultadoOperacao> InserirLogVelocidadeTempoLocalizacao(velocidadeTempoLocalizacao velocidadeTempoLocalizacao);
        Task<resultadoOperacao> InserirLogJornadaTrabalhoMotorista(jornadaTrabalhoMotorista jornadaTrabalhoMotorista);
        Task<resultadoOperacao> InserirLogDetectorParada(detectorParada detectorParada);
        Task<resultadoOperacao> InserirLogInicioFimViagemRegular(inicioFimViagemRegular inicioFimViagemRegular);
        Task<resultadoOperacao> InserirLogInicioFimViagemFretado(inicioFimViagemFretado inicioFimViagemFretado);
        Task<resultadoOperacao> InserirLogBilheteEmbarque(bilheteEmbarque bilheteEmbarque);
        Task<resultadoOperacao> InserirLogLeitorCartaoRFID(leitorCartaoRFID cartaoRFID);
        Task<resultadoOperacao> InserirLogCancelarPassagem(cancelarPassagem cancelamentoPassagem);
       
    }
}