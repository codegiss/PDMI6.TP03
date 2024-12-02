using PDMI6_TP03.Models;
using PDMI6_TP03.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PDMI6_TP03.ViewModels
{
    internal class ViewModel
    {
        public ICommand DetalhesCommand { get; }
        public List<Pacote> listaPacotes;
        public Pacote selecionado = new Pacote();

        public ViewModel(INavigation navigation)
        {
            listaPacotes = new List<Pacote>
            {
                new Pacote("ABC", "enviado", DateTime.Today.AddDays(-4), DateTime.Today),
                new Pacote("QWE2", "recebido", DateTime.Today.AddDays(-5), DateTime.Today),
                new Pacote("ASD", "cancelado", DateTime.Today.AddDays(-10), DateTime.Today.AddDays(-2))
            };

            int a = listaPacotes.FindIndex(p => p.CodRastreio == "ABC");
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-4), "pedido registrado"));
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-3), "pedido enviado"));
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-1), "pedido a caminho"));

            a = listaPacotes.FindIndex(p => p.CodRastreio == "QWE2");
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-5), "pedido registrado"));
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-3), "pedido enviado"));
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-1), "pedido a caminho"));
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today, "pedido recebido"));

            a = listaPacotes.FindIndex(p => p.CodRastreio == "ASD");
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-10), "pedido registrado"));
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-8), "pedido enviado"));
            listaPacotes[a].HistoricoEventos.Add(new Evento(DateTime.Today.AddDays(-5), "pedido cancelado"));
        }
        public async Task<bool> VerDetalhes(string cod, INavigation nav)
        {
            string codigo = cod.ToUpper();
            foreach(Pacote p in listaPacotes)
            {
                if (p.CodRastreio == codigo)
                {
                    var paginaDetalhes = new Detalhes(p);
                    await nav.PushAsync(paginaDetalhes);
                    return true;
                }
            }
            return false;
        }
    }
}
