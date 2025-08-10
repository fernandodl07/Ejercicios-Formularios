using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Formularios
{
    internal class Operation
    {
        public bool IsNumeric(string num) {

			try
			{
				double x = Convert.ToInt32(num);
				return true;
			}
			catch (Exception)
			{
				return false;
			}

        }

		public double suma (double a, double b)
		{
			return a + b;
		}

		public double resta(double a, double b)
		{
			return a - b;
		}

		public double multi(double a, double b)
		{
			return a * b;
		}

		public double divi(double a, double b)
		{
			return a / b;
		}
    }
}
