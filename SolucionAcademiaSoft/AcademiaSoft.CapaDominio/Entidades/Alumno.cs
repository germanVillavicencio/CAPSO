using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaSoft.CapaDominio.Entidades
{
    public class Alumno : Persona
    {
        private int idCard;
        private Matricula matricula;

        public Alumno() { }

        public int IdCard { get => idCard; set => idCard = value; }
        public Matricula Matricula { get => matricula; set => matricula = value; }
    }
}
