using System;
using System.Collections.Generic;

namespace PrimerQuiz.ClasesBasicas
{
    public class Citas
    {
        #region Atributos
        private int _idCita;
        private string _nombreDoctor;
        private string _nombrePaciente;
        private int _horaCita;
        public List<object> listaCitas = new List<object>();
        #endregion

        /********/
        //Asigando los get y set para cada atributo
        #region Propiedades
        public int IdCita { get => _idCita; set => _idCita = value; }
        public string NombreDoctor { get => _nombreDoctor; set => _nombreDoctor = value; }
        public string NombrePaciente { get => _nombrePaciente; set => _nombrePaciente = value; }
        public int HoraCita { get => _horaCita; set => _horaCita = value; }
        #endregion

        /********/
        #region Constructores
        public Citas()
        {

        }
        #endregion

        /********/
        #region Metodos


        #endregion
    }
}
