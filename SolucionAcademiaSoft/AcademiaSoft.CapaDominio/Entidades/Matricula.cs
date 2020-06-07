﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Matricula
    {
        private Secretario secretario;
        private Alumno alumno;
        private CicloAcademico cicloAcademico;
        private List<Examen> listaDeExamenes;
        private List<Clase> listaDeClases;

        private int codigo;
        private DateTime fecha;
        private double precio;//lo que cuesta
        private double pago;//el monto descontado, lo que pagas

        public Matricula() { }
        public Matricula(int codigo, DateTime fecha, double pago)
        {
            this.Codigo = codigo;
            this.Fecha = fecha;
            this.Pago = pago;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Secretario Secretario { get => secretario; set => secretario = value; }
        public Alumno Alumno { get => alumno; set => alumno = value; }
        public List<Examen> ListaDeExamenes { get => listaDeExamenes; set => listaDeExamenes = value; }
        public CicloAcademico CicloAcademico { get => cicloAcademico; set => cicloAcademico = value; }
        public List<Clase> ListaDeClases { get => listaDeClases; set => listaDeClases = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Pago { get => pago; set => pago = value; }

        //Regla de negocio para el pago
        //Si el alumno se matricula a los 3 primeros dias, entonces se le hará un descuento del 15% del costo de matricula
        public void calcularDescuento()
        {
            DateTime fechaActual = new DateTime();
            if (fechaActual >= cicloAcademico.FechaInicioMatricula && fechaActual <= cicloAcademico.FechaInicioMatricula.AddDays(3))
                Pago = precio - (precio * 0.15);
        }

    }

}
