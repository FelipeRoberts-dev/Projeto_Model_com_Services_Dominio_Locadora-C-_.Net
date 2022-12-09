using LocadoraExObjServices.Entidades;
namespace LocadoraExObjServices.Services
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ITaxaServico _taxaservico;

        public ServicoAluguel(double precohora, double precodia, ITaxaServico taxaServico)
        {
            PrecoHora = precohora;
            PrecoDia = precodia;
            _taxaservico = taxaServico;

        }

        public void ProcessarFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.Fim.Subtract(aluguelCarro.Inicio);

            double pagamentobasico = 0.0;
            if (duracao.TotalHours <= 12.0)
            {
                pagamentobasico = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentobasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double taxa = _taxaservico.Taxa(pagamentobasico);


            aluguelCarro.Fatura = new Fatura(pagamentobasico, taxa);

        }
    }
}
