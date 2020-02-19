using System;
using System.Collections.Generic;

namespace PrimerQuiz.ClasesBasicas
{
    public class Cliente : Persona
    {
        #region Atributos
        private int _telefono;
        private string _correo;
        #endregion

        /********/
        //Asignando los get y set para cada atributo
        #region Propiedades
        public int Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _correo; set => _correo = value; }
        #endregion

        /********/
        #region Constructores
        public Cliente()
        {
        }
        #endregion

        /********/
        #region Metodos
        public override string ToString()
        {
            return "ID" + ID + " " + "Nombre" + Nombre + " " + "Apellidos" + Apellidos;
        }
        #endregion
    }
}
