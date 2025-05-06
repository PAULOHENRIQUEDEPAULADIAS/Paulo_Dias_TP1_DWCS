

namespace Paulo_Dias_TP1
{
    class ECommerce
    {
        public delegate decimal CalculateDiscount(decimal precoOriginal);

        public static decimal aplicarDescontoDezPorCento(decimal precoOriginal)
        {
            return precoOriginal * 0.90m;
        }


    }
}
