using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosCap4
{
    internal class Cuenta
    {
        private decimal _saldo; // variable de instancia que almacena el saldo
        
        // constructor
        public Cuenta(decimal saldoInicial)
        {
            Saldo = saldoInicial; 
        } 

        // acredita (suma) un monto a la cuenta
        public void Acredita(decimal monto)
        {
            Saldo = Saldo + monto; 
        } 

        // una propiedad para obtener (get) y establecer (set) el saldo de una cuenta
        public decimal Saldo
        {
            get
            {
                return _saldo;
            } 
            set
            {

                if (value >= 0)
                    _saldo = value;
            } 
        } 
    }
}
