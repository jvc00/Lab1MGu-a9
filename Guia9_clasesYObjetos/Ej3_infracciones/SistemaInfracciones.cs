using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3_infracciones
{
    class SistemaInfracciones
    {
        #region nomenclador de infracciones
        int CODIGO_1_INFRACCION = 1;
        string DESC_1_INFRACCION = "Sin luces bajas, ley 25….";
        int UD_1_INFRACCION = 25;
        //
        int CODIGO_2_INFRACCION = 2;
        string DESC_2_INFRACCION = "alta de Matafuego, ley 2…";
        int UD_2_INFRACCION = 30;
        #endregion

        #region atributos generales de sistema
        public double BaseMonetaria { get; private set; }

        public double Recaudacion { get; private set; }

        /*
        double recaudacion;
        public double Recaudacion
        {
            get {
                    ...
                return recaudacion;
            }
            set
            {
                recaudacion = value;
            }
        }
        */

        /*
        double recaudacion;
        public double GetRecaudacion()
        {
            return recaudacion;
        }
        public void SetRecaudacion(double Value)
        {
            recaudacion = Value;
        }
        */
        #endregion

        #region atributos por cada acta
        public int DniActa { get; private set; }
        public string NombreActa { get; private set; }
        public double TotalActaAPagar { get; private set; }
        #endregion

        #region atributos por cada infraccion
        public int CodigoInfraccion { get; private set; }
        public string DescripcionInfraccion { get; private set; }
        public double MontoInfraccion { get; private set; }
        #endregion

        #region método del sistema
        public void IniciarSistema(double montoBase)
        {
            this.BaseMonetaria = montoBase;
            this.Recaudacion = 0;
        }
        #endregion

        #region métodos por acta
        public void IniciarActa(int dni, string nombre)
        {
            this.DniActa = dni;
            this.NombreActa = nombre;
            TotalActaAPagar = 0;
        }

        public double RegistrarInfraccion(int codigo)
        {
            switch (codigo)
            {
                case 1:
                    {
                        MontoInfraccion = UD_1_INFRACCION * BaseMonetaria;
                    }
                    break;
                case 2:
                    {
                        MontoInfraccion = UD_2_INFRACCION * BaseMonetaria;
                    }
                    break;
            }
            TotalActaAPagar += MontoInfraccion;
            return MontoInfraccion;
        }

        public void FinalizarActa(bool pagaEnElLugar)
        {
            Recaudacion += TotalActaAPagar;
        }
        #endregion

    }
}
