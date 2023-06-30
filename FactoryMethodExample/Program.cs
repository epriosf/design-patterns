using System;
using System.Collections.Generic;

namespace FactoryMethodExample
{
    enum TipoDePago
    {
        Efectivo,
        TarjetaCredito,
        TarjetaDebito
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<TipoDePago, PagoFactory> pagos = new Dictionary<TipoDePago, PagoFactory>
            {
                {TipoDePago.Efectivo, new PagoEfectivoFactory() },
                {TipoDePago.TarjetaDebito, new PagoTarjetaDebitoFactory() },
                {TipoDePago.TarjetaCredito, new PagoTarjetaCreditoFactory() },
            };
            Console.WriteLine("*******************************");
            Console.WriteLine("Sistema para realizar Pagos");
            Console.WriteLine("*******************************");
            Console.WriteLine("Ingrese la opcion de pago: \n0) Efectivo \n1) Tarjeta De Credito\n2) Tarjeta de Debito");
            string metodo = Console.ReadLine();
            TipoDePago tipoDePago;
            if (Enum.TryParse(metodo, out tipoDePago) && pagos.TryGetValue(tipoDePago, out PagoFactory factory))
            {
                IPago pago = factory.ObtenerPago();
                pago.RealizarPago();
            }
            else
            {
                Console.WriteLine("Entrada invalida. Debe escoger un numero: 0, 1, 2");
            }
            Console.ReadKey();
        }
    }
}
