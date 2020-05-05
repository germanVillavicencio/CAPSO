﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Docente : Persona
    {
        private List<Clase> listaDeClases;

        private int horasTrabajadas;
        private double pagoPorHora;
        private String especialidad;

        public Docente(int horasTrabajadas, double pagoPorHora, string especialidad, String nombre, int dni, DateTime fechaNac, String apellidoP, String apellidoM, int telefono, String correo, String direccion)
        {
            this.horasTrabajadas = horasTrabajadas;
            this.pagoPorHora = pagoPorHora;
            this.especialidad = especialidad;
            Nombre = nombre;
            Dni = dni;
            FechaDeNacimiento = fechaNac;
            ApellidoPaterno = apellidoP;
            ApellidoPaterno = apellidoM;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }

        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public double PagoPorHora { get => pagoPorHora; set => pagoPorHora = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        internal List<Clase> ListaDeClases { get => listaDeClases; set => listaDeClases = value; }

        public double calcularSueldo()
        {
            return HorasTrabajadas * PagoPorHora;
        }

        public void registrarNotas()
        {

        }
    }
}