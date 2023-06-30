using System;

namespace FactoryMethodExample
{
    public class PagoTarjetaDebitoFactory : PagoFactory
    {
        public override IPago ObtenerPago()
        {
            return new PagoTarjetaDebito();
        }
    }
}
