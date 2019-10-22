﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuentaBancaria
{
    class CuentaAhorro : CuentaBancaria
    {
        private Double cuotaMantenimiento;

        public CuentaAhorro()
        {
            cuotaMantenimiento = 0.0;
        }

        public void setCuotaMantenimiento(Double cuota)
        {
            this.cuotaMantenimiento = cuota;
        }

        public Double getCuotaMantenimiento()
        {
            return this.cuotaMantenimiento;
        }

            
        public void estadoCuenta()
        {
            base.estadoCuenta();
            Console.WriteLine("Cuota mantenimiento --> " + this.cuotaMantenimiento);
        }
    }
}
