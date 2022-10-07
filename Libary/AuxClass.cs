using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Libary
{

    public class AuxClass
    {
        RegexExtrator regex = new RegexExtrator("s*[-+]?([0-9]{0,3}(,[0-9]{3})*(\\.[0-9]+)?)", "<div class=\"YMlKec fxKbKc\">", "</div>");
        public string GetDate()
        {
            return $"{DateTime.Now}";
        }
        public string GetFonte()
        {
            return $"Informações retiradas do site: https://www.google.com/finance/";
        }
        public async Task<double> GetCriptoValue(string url, CancellationToken ct)
        {
            try
            {
                var task = Task.Factory.StartNew(() =>
                {
                    var SharePriceBitcoin = new GetVariable(regex, url);
                    return SharePriceBitcoin.FindValue(Formats.Pt, ct);
                });
                return await task.Result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possivel conectar com o site, verifique a internet. Erro na conexão.{ex.Message}");
            }

        }
        public async Task<double> GetCripto(string url, CancellationToken ct)
        {
            var SharePriceBitcoin = new GetVariable(regex, url);
            return await SharePriceBitcoin.FindValue(Formats.Pt, ct);
        }
        public async Task<string[]> GetCriptoValues(IEnumerable<string> tabela, IProgress<string> reportadorDeProgresso, string url, CancellationToken ct)
        {
            var task = tabela.Select(cripto => Task.Factory.StartNew(async () =>
            {
                ct.ThrowIfCancellationRequested();
                var SharePrice = new GetVariable(regex, url + cripto);
                cripto = cripto.Replace("-BRL","");
                var resultadoConsolidacao = $"Valor {cripto}: R${await SharePrice.FindValue(Formats.Pt, ct)}\r\n";
                
                reportadorDeProgresso.Report(resultadoConsolidacao);
                ct.ThrowIfCancellationRequested();
                return resultadoConsolidacao;
                
            },ct));
            
            return await Task.WhenAll(await Task.WhenAll(task));
        }
        public async Task<double> getValor(string url, CancellationToken ct)
        {
            var SharePriceBitcoin = new GetVariable(regex, url);
            return await SharePriceBitcoin.FindValue(Formats.Pt, ct);
        }
    }
}
