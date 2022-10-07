using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libary;

namespace MostrarValoresCripto
{
    public partial class Frm_MostrarValoresCripto : Form
    {
        AuxClass aux = new AuxClass();
        string site = "https://www.google.com/finance/quote/";
        CancellationTokenSource _cts;

        List<string> listaMoedas = new List<string>()
        {
            "BTC-BRL",
            "ETH-BRL",
            "ADA-BRL",
            "XRP-BRL",
            "USD-BRL",
            "EUR-BRL",
            "JPY-BRL",
            "AUD-BRL",
            ".DJI:INDEXDJX",
            ".INX:INDEXSP",
            ".IXIC:INDEXNASDAQ",
            "RUT:INDEXRUSSELL"
        };
        public Frm_MostrarValoresCripto()
        {
            InitializeComponent();
            Btn_Cancel.Text = "Cancelar";
            Btn_Cancel.Enabled = false;
            Btn_CheckCripto.Text = "Checar valor Cripto";
            Lbl_Tempo.Text = "";
            this.Text = "Checar Cotação Cripto";
        }
        private async void Btn_CheckCripto_Click(object sender, EventArgs e)
        {
            Pgs_Progresso.Maximum = listaMoedas.Count;
            Pgs_Progresso.Value = 0;
            var inicio = DateTime.Now;
            _cts = new CancellationTokenSource();
            Btn_Cancel.Enabled = Enabled;
            try
            {
                string texto = "";
                Btn_CheckCripto.Enabled = false;
                Txb_MostrarCripto.Text = texto;
                Lbl_Tempo.Text = texto;
                var progress = new Progress<string>(str => Pgs_Progresso.Value++);
                //var progressAux = new ProgressAction<string>(str => Pgs_Progresso.Value++);
                var resultado = await aux.GetCriptoValues(listaMoedas, progress, site, _cts.Token);
                AtualizarView(resultado);
               //texto = await UtilizandoForeach();
               //Txb_MostrarCripto.Text = texto; 
            }
            catch(OperationCanceledException ex)
            {
                MessageBox.Show(ex.Message, "Operacao Cancelada pelo usuário.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro de conexão",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }finally
            {
                Btn_CheckCripto.Enabled = true;
                var fim = DateTime.Now;
                var tempo = fim - inicio;
                Lbl_Tempo.Text = $"Tempo de Processamento:{tempo.Seconds}.{tempo.Milliseconds} segundos";
                Btn_Cancel.Enabled = false;
            }
        }

        private async Task<string> UtilizandoForeach(CancellationToken ct)
        {
            string texto = "";
            foreach (string cripto in listaMoedas)
            {
                var valor = await aux.GetCriptoValue(site + cripto, ct);
                texto += $"Valor {cripto}: R${valor}\r\n";
                Pgs_Progresso.Value++;
            }
            return texto;
        }

        private void AtualizarView(IEnumerable<string> lista)
        {
            Txb_MostrarCripto.Text = "";
            foreach (string texto in lista)
            {
                Txb_MostrarCripto.Text += texto;
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Btn_Cancel.Enabled = false;
            _cts.Cancel();
        }
    }
}
