using System;
using System.Globalization;
namespace FirstProject {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiq;

        public double SalarioLiquido() {
             SalarioLiq = SalarioBruto - Imposto;
            return SalarioLiq;
        }

        public double AumentarSalario(double porcentagem) {
            SalarioLiq = (porcentagem * SalarioBruto) + SalarioLiq;
            return SalarioLiq;
        }

        override public string ToString() {
            return Nome + ", $ " + SalarioLiq.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
