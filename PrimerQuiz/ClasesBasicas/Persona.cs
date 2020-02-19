using System;
using System.Collections.Generic;

namespace PrimerQuiz.ClasesBasicas
{
    public class Persona
    {
        #region atributos
        private int _id;
        private string _nombre;
        private string _apellidos;
        private int _cedula;
        //Lista de tipo objeto para poder almacenar diferentes tipos de variables.
        public List<object> listaDoctor = new List<object>();
        public List<object> listaCliente = new List<object>();


        #endregion

        /********/
        //Asignando Get y Set para cada atributo
        #region Propiedades
        public int ID { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public int Cedula { get => _cedula; set => _cedula = value; }
        #endregion

        /*********/
        #region Constructores
        public Persona() { }

        public Persona(int _valorID, string _valorNombre, string _valorApellidos, int _valorCedula)
        {
            this._id = _valorID;
            this._nombre = _valorNombre;
            this._apellidos = _valorApellidos;
            this._cedula = _valorCedula;
        }

        #endregion

        /*********/
        #region Metodos
        //Metodo para la creacion de una persona
        //Virtual para que se puede sobreescribir en otra clase
        public override string ToString()
        {
            return "ID" + ID + " " + "Nombre" + Nombre + " " + "Apellidos" + Apellidos;
        }


        #endregion



    }
}
