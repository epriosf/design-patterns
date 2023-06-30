using System;

namespace FactoryMethodExample
{
    public class PagoTarjetaCredito : IPago
    {
        public void RealizarPago()
        {
            Console.WriteLine("Pago con tarjeta de credito realizado");
        }
    }
}
