using System;

namespace FactoryMethodExample
{
    public class PagoTarjetaCreditoFactory : PagoFactory
    {
        public override IPago ObtenerPago()
        {
            return new PagoTarjetaCredito();
        }
    }
}
