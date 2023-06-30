using System;

namespace FactoryMethodExample
{
    public class PagoTarjetaDebito : IPago
    {
        public void RealizarPago()
        {
            Console.WriteLine("Pago con tarjeta de debito realizado");
        }
    }
}
