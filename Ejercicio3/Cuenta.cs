using System;

namespace Ejercicio3
{
    class Cuenta
    {   
        private double saldo;
        private long nCuenta;
        private string nombre;
        
        public Cuenta(string nombre, long nCuenta){
            this.nombre = nombre;
            this.nCuenta = nCuenta;
            this.saldo = 0;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public long getNCuenta()
        {
            return this.nCuenta;
        }

        public void setNCuenta(long nCuenta)
        {
            this.nCuenta = nCuenta;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void AjustSaldo(bool tr){
            Console.Write("\nSaldo: ");
            double saldo = double.Parse(Console.ReadLine());
            if(tr){
                if(this.getSaldo() > saldo){
                    saldo *= -1;
                    saldo += this.getSaldo();
                    this.setSaldo(saldo);
                    Console.WriteLine("\nRetiro satisfactorio....");
                }
                else{
                    saldo = 0;
                    Console.WriteLine("\nNo es posible retirar, saldo insuficiente...");
                }

                
            }
            else{
                saldo += this.getSaldo();
                this.setSaldo(saldo);
                Console.WriteLine("\nSaldo agregado...");
            }

            
        }
    }
}