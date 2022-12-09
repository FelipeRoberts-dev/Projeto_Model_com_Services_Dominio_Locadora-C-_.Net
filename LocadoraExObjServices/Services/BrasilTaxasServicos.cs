namespace LocadoraExObjServices.Services
{
    class BrasilTaxasServicos : ITaxaServico
    {
        public double Taxa(double quantia)
        {
            if (quantia <= 100.0)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }
    }
}
