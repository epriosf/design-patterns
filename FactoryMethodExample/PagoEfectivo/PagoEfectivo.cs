using System;

namespace FactoryMethodExample
{
    public class PagoEfectivo : IPago
    {
        public void RealizarPago()
        {
            Console.WriteLine("Pago en efectivo realizado");
        }
    }
}
