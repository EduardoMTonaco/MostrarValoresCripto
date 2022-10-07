using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Libary
{
    public class GetVariable
    {
        private IRegexExtrator RegexTools { get; set; }
        private string Url { get; set; }
        public GetVariable(IRegexExtrator regexTools, string url)
        {
            RegexTools = regexTools;
            Url = url;
        }
        public async Task<string> DownloadWebPageString()
        {
            try
            {
                var httpUrl = new HttpClient();
                return await httpUrl.GetStringAsync(Url);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("no internet connection or invalid url. Error: " + ex.Message);
            }
        }
        public async Task<string> FindString()
        {
            var texto = await DownloadWebPageString();
            return texto;
        }
        public async Task<string> FindString(CancellationToken ct)
        {
            var task = Task.Run(() =>
            {
                var texto = DownloadWebPageString();
                return texto;
            }, ct);
            return await task;
        }
        public async Task<double> FindValue(Formats format)
        {
            var texto = await DownloadWebPageString();
            if (format == Formats.Standart)
            {
                return Convert.ToDouble(RegexTools.GetRegex(texto).Replace(",", ""));
            }
            return Convert.ToDouble(RegexTools.GetRegex(texto).Replace(",", "").Replace(".", ","));
        }
        public async Task<double> FindValue(Formats format, CancellationToken ct)
        {
            var texto = await DownloadWebPageString();

            var task = Task.Run(() =>
            {
                if (format == Formats.Standart)
                {
                    return Convert.ToDouble(RegexTools.GetRegex(texto).Replace(",", ""));
                }

                return Convert.ToDouble(RegexTools.GetRegex(texto).Replace(",", "").Replace(".", ",")); ;
            }, ct);
            return await task;
        }
        public async Task<int> FindInt()
        {
            var texto = await DownloadWebPageString();
            return Convert.ToInt32(RegexTools.GetRegex(texto).Replace(",", "").Replace(".", "")); ;
        }
        public async Task<int> FindInt(CancellationToken ct)
        {
            var texto = await DownloadWebPageString();

            var task = Task.Run(() =>
            {
                int inteiro = Convert.ToInt32(RegexTools.GetRegex(texto).Replace(",", "").Replace(".", ""));
                return inteiro;
            }, ct);
            return await task;
        }
    }
}
