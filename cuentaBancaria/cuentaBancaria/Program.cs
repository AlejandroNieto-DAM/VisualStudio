using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria cuentaBancariaNormal = new CuentaBancaria();
            cuentaBancariaNormal.setNumCuenta(123456789);
            cuentaBancariaNormal.setNombreCuenta("Cuenta1");
            cuentaBancariaNormal.setSaldoCuenta(12000);
            cuentaBancariaNormal.setTipoInteres(5);

            CuentaAhorro cuentaBancariaAhorro = new CuentaAhorro();
            cuentaBancariaAhorro.setNumCuenta(987654321);
            cuentaBancariaAhorro.setNombreCuenta("CuentaAhorro1");
            cuentaBancariaAhorro.setSaldoCuenta(5000);
            cuentaBancariaAhorro.setTipoInteres(2);
            cuentaBancariaAhorro.setCuotaMantenimiento(100);


            cuentaBancariaNormal.estadoCuenta();
            
            cuentaBancariaAhorro.estadoCuenta();
            

            Console.ReadKey();
        }
    }

}
