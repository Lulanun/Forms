using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public class Helper
    {
        Banco banco = Banco.GetInstancia();

        public void CargarListas()
        {

            banco.AltaDeUsuario("123", "Fer", "Ord", "fer@ord.com", "123");
            banco.AltaDeUsuario("456", "Mel", "Mon", "mel@mon.com", "123");
            banco.AltaDeUsuario("789", "Lou", "Nun", "lou@nun.com", "123");
            banco.AltaDeUsuario("987", "Luc", "Bel", "luc@bel.com", "123");
            banco.AltaDeUsuario("654", "Gas", "Sam", "gas@sam.com", "123");
            banco.AltaDeUsuario("321", "Lau", "Tom", "lau@tom.com", "123");
            banco.AltaDeUsuario("132", "Car", "Dun", "car@dun.com", "123");
            banco.AltaDeUsuario("465", "Ana", "Con", "ana@con.com", "123");

            banco.AltaCajaAhorro();
            banco.AltaCajaAhorro();
            banco.AltaCajaAhorro();
            banco.AltaCajaAhorro();
            banco.AltaCajaAhorro();
            banco.AltaCajaAhorro();

            banco.AltaPlazoFijo("123", 10, new DateTime(2021, 10, 25), new DateTime(2022, 10, 25), 50);
            banco.AltaPlazoFijo("123", 10, new DateTime(2021, 10, 25), new DateTime(2022, 10, 25), 50);
            banco.AltaPlazoFijo("456", 10, new DateTime(2022, 02, 25), new DateTime(2022, 02, 25), 50);
            banco.AltaPlazoFijo("456", 10, new DateTime(2022, 02, 25), new DateTime(2022, 02, 25), 50);
            banco.AltaPlazoFijo("789", 10, new DateTime(2022, 03, 25), new DateTime(2022, 03, 25), 50);
            banco.AltaPlazoFijo("789", 10, new DateTime(2022, 03, 25), new DateTime(2022, 03, 25), 50);
            banco.AltaPlazoFijo("987", 10, new DateTime(2021, 09, 25), new DateTime(2022, 09, 25), 50);
            banco.AltaPlazoFijo("987", 10, new DateTime(2021, 09, 25), new DateTime(2022, 09, 25), 50);
            banco.AltaPlazoFijo("654", 10, new DateTime(2021, 09, 01), new DateTime(2022, 09, 01), 50);
            banco.AltaPlazoFijo("654", 10, new DateTime(2021, 09, 01), new DateTime(2022, 09, 01), 50);
            banco.AltaPlazoFijo("321", 10, new DateTime(2021, 10, 08), new DateTime(2022, 10, 08), 50);
            banco.AltaPlazoFijo("321", 10, new DateTime(2021, 10, 08), new DateTime(2022, 10, 08), 50);
            banco.AltaPlazoFijo("132", 10, new DateTime(2022, 05, 05), new DateTime(2023, 05, 05), 50);
            banco.AltaPlazoFijo("132", 10, new DateTime(2022, 05, 05), new DateTime(2023, 05, 05), 50);
            banco.AltaPlazoFijo("465", 10, new DateTime(2021, 08, 23), new DateTime(2022, 08, 23), 50);
            banco.AltaPlazoFijo("465", 10, new DateTime(2021, 08, 23), new DateTime(2022, 08, 23), 50);

            banco.AltaTarjetaCredito("123", 123, 123, 123, 123);
            banco.AltaTarjetaCredito("123", 456, 456, 123, 123);
            banco.AltaTarjetaCredito("456", 789, 789, 123, 123);
            banco.AltaTarjetaCredito("456", 987, 987, 123, 123);
            banco.AltaTarjetaCredito("789", 654, 654, 123, 123);
            banco.AltaTarjetaCredito("789", 321, 321, 123, 123);
            banco.AltaTarjetaCredito("987", 1234, 1234, 123, 123);
            banco.AltaTarjetaCredito("987", 5678, 5678, 123, 123);
            banco.AltaTarjetaCredito("654", 9123, 9123, 123, 123);
            banco.AltaTarjetaCredito("654", 4567, 4567, 123, 123);
            banco.AltaTarjetaCredito("321", 8912, 8912, 123, 123);
            banco.AltaTarjetaCredito("321", 3456, 3456, 123, 123);
            banco.AltaTarjetaCredito("132", 7891, 7891, 123, 123);
            banco.AltaTarjetaCredito("132", 2345, 2345, 123, 123);
            banco.AltaTarjetaCredito("465", 6789, 6789, 123, 123);
            banco.AltaTarjetaCredito("465", 1243, 1243, 123, 123);

            banco.AltaPago("123", "nombre", 100.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("123", "nombre", 200.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("123", "nombre", 300.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("123", "nombre", 400.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("456", "nombre", 500.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("456", "nombre", 600.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("456", "nombre", 700.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("456", "nombre", 800.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("789", "nombre", 900.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("789", "nombre", 110.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("789", "nombre", 210.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("789", "nombre", 310.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("987", "nombre", 410.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("987", "nombre", 510.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("987", "nombre", 610.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("987", "nombre", 710.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("654", "nombre", 810.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("654", "nombre", 910.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("654", "nombre", 111.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("654", "nombre", 211.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("321", "nombre", 311.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("321", "nombre", 411.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("321", "nombre", 511.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("321", "nombre", 611.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("132", "nombre", 711.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("132", "nombre", 811.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("132", "nombre", 911.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("132", "nombre", 101.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("465", "nombre", 201.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("465", "nombre", 301.0f, Pago.TipoDePago.EFECTIVO);
            banco.AltaPago("465", "nombre", 401.0f, Pago.TipoDePago.CREDITO);
            banco.AltaPago("465", "nombre", 501.0f, Pago.TipoDePago.CREDITO);

            banco.AltaMovimiento("123", "detalle", 10.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("123", "detalle", 20.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("123", "detalle", 30.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("123", "detalle", 40.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("456", "detalle", 50.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("456", "detalle", 60.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("456", "detalle", 70.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("456", "detalle", 80.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("789", "detalle", 90.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("789", "detalle", 11.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("789", "detalle", 21.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("789", "detalle", 31.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("987", "detalle", 41.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("987", "detalle", 51.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("987", "detalle", 61.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("987", "detalle", 71.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("654", "detalle", 81.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("654", "detalle", 91.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("654", "detalle", 12.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("654", "detalle", 22.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("321", "detalle", 32.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("321", "detalle", 42.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("321", "detalle", 52.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("321", "detalle", 62.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("132", "detalle", 72.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("132", "detalle", 82.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("132", "detalle", 92.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("132", "detalle", 13.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("465", "detalle", 23.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("465", "detalle", 33.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("465", "detalle", 43.0f, new DateTime(2022, 10, 25));
            banco.AltaMovimiento("465", "detalle", 53.0f, new DateTime(2022, 10, 25));
        }
    }
}
