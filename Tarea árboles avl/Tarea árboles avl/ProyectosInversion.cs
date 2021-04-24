using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_árboles_avl
{
    class ProyectosInversion : Comparador
    {
		public Decimal Prioridad;
		public string Departamento;
		public string Nombre;
		public string Monto;

		public ProyectosInversion(Decimal pPrioridad, string pDepartamento, string pNombre, string pMonto)
		{
			Prioridad = pPrioridad;
			Departamento = pDepartamento;
			Nombre = pNombre;
			Monto = pMonto;
		}

		public bool Equals(String pPrioridad)
		{
			return this.Prioridad == Convert.ToDecimal(pPrioridad);
		}

		public override bool Equals(object obj)
		{

			if (obj == null)
			{
				return false;
			}
			return Equals((String)obj);
		}

        bool Comparador.igualQue(object q)
        {
            ProyectosInversion Aux = (ProyectosInversion)q;
            return (Prioridad == Aux.Prioridad);
        }

        bool Comparador.mayorIgualQue(object q)
        {
            ProyectosInversion Aux = (ProyectosInversion)q;
            bool bandera = false;
            ProyectosInversion p2 = (ProyectosInversion)q;
            if (Prioridad >= p2.Prioridad)
            {
                if (Departamento == "Chiquimula" || Departamento == "Baja Verapaz" || Departamento == "Alta Verapaz" || Departamento == "Zacapa" || Departamento == "El Progreso" || Departamento == "Guatemala")
                {
                    if (Departamento.CompareTo(p2.Departamento) > 0 || Departamento.CompareTo(p2.Departamento) > 0)
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                    }
                }
                else
                {
                    bandera = false;
                }
            }
            else
            {
                bandera = false;
            }

            return bandera;
        }

        bool Comparador.mayorQue(object q)
        {
            ProyectosInversion Aux = (ProyectosInversion)q;
            return (Prioridad > Aux.Prioridad);
        }

        bool Comparador.menorIgualQue(object q)
        {
            ProyectosInversion Aux = (ProyectosInversion)q;
            bool bandera = false;
            ProyectosInversion p2 = (ProyectosInversion)q;
            if (Prioridad <= p2.Prioridad)
            {
                if (Departamento == "Chiquimula" || Departamento == "Baja Verapaz" || Departamento == "Alta Verapaz" || Departamento == "Zacapa" || Departamento == "El Progreso" || Departamento == "Guatemala")
                {
                    if (Departamento.CompareTo(p2.Departamento) < 0 || Departamento.CompareTo(p2.Departamento) > 0)
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                    }
                }
                else
                {
                    bandera = false;
                }
            }
            else
            {
                bandera = false;
            }

            return bandera;
        }

        bool Comparador.menorQue(object q)
        {
            ProyectosInversion Aux = (ProyectosInversion)q;
            return (Prioridad < Aux.Prioridad);
        }

        public override string ToString()
        {
            return "(" + Prioridad + " - " + Departamento + " - " + Nombre + " - " + Monto + ")";
        }
    }
}
