using System;

namespace FactoryMethodExample
{
    public class PagoEfectivoFactory : PagoFactory
    {
        public override IPago ObtenerPago()
        {
            return new PagoEfectivo();
        }
    }
}
