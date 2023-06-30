using System;

namespace FactoryMethodExample
{
    public abstract class PagoFactory
    {
        public abstract IPago ObtenerPago();
    }
}
