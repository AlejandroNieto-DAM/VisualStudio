using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentaBancaria
{
    class CuentaBancaria
    {
        protected int nNumCuenta;
        protected String strNombre;
        protected Double dblSaldo;
        protected float fltTipoInteres;

        public CuentaBancaria()
        {
            nNumCuenta = 0;
            strNombre = "";
            dblSaldo = 0.0;
            fltTipoInteres = 0;
        }

        public void setNumCuenta(int num)
        {
            this.nNumCuenta = num;
        }

        public void setNombreCuenta(String nombre)
        {
            this.strNombre = nombre;
        }

        public void setSaldoCuenta(Double saldo)
        {
            this.dblSaldo = saldo;
        }

        public void setTipoInteres(float interes)
        {
            this.fltTipoInteres = interes;
        }

        public int getNumCuenta()
        {
            return this.nNumCuenta;
        }

        public String getNombreCuenta()
        {
            return this.strNombre;
        }

        public Double getSaldoCuenta()
        {
            return this.dblSaldo;
        }

        public float getTipoInteres()
        {
            return this.fltTipoInteres;
        }

        public virtual void estadoCuenta()
        {
            Console.WriteLine("\nNumero de cuenta --> " + this.getNumCuenta() +
                                "\nNombre de cuenta --> " + this.getNombreCuenta() +
                                "\nSaldo cuenta --> " + this.getSaldoCuenta() +
                                "\nTipo Interes --> " + this.getTipoInteres());
        }
    }
}
