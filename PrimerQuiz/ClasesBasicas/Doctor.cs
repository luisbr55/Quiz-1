using System;
using System.Collections.Generic;

namespace PrimerQuiz.ClasesBasicas
{
    public class Doctor : Persona
    {
        #region Atributos
        private string _especialidad;
        #endregion

        #region Propiedades
        public string Especialidad { get => _especialidad; set => _especialidad = value; }
        #endregion

        /********/
        #region constructores
        public Doctor()
        {
        }
        #endregion

        /********/
        #region Metodos
        //Metodo sobreescrito para la creacion de una persona
        public override string ToString()
        {
            return "ID" + ID + " " + "Nombre" + Nombre + " " + "Apellidos" + Apellidos + " " + "Especialidad" + Especialidad;
        }
        #endregion
    }
}
