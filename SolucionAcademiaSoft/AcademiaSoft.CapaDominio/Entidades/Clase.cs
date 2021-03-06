﻿using System;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Clase
    {
        private Docente docente;
        private Horario horario;
        private Curso curso;

        private String codigo;

        public Clase()
        {
            this.docente = new Docente();
            this.Horario = new Horario();
            this.curso = new Curso();
        }

        public String Codigo { get => codigo; set => codigo = value; }
        public Docente Docente { get => docente; set => docente = value; }
        public Horario Horario { get => horario; set => horario = value; }
        public Curso Curso { get => curso; set => curso = value; }
    }
}
