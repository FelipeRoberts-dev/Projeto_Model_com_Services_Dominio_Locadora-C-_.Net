using System.Globalization;
namespace LocadoraExObjServices.Entidades
{
     class Fatura
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }


        public Fatura(double pagamentobasico, double taxa)
        {
            PagamentoBasico = pagamentobasico;
            Taxa = taxa;
        }

        public double TotalPagamento //Propriedade Calculada.
        {
            get
            {
                return PagamentoBasico + Taxa;
            }
        }

        public override string ToString()
        {
            return "Pagamento Basico: " + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTaxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal Pagamento: " + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
