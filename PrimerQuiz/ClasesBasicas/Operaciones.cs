using System;
using System.Collections.Generic;

namespace PrimerQuiz.ClasesBasicas
{
    public class Operaciones
    {
        Persona persona = new Persona();
        Citas cita = new Citas();

        #region Constructores
        public Operaciones()
        {


        }
        #endregion

        /********/
        #region Metodos
        //Metodo para crear un doctor
        public void crearDoctor(int id, string nombre, string apellido, int cedula, string especialidad)
        {
            try
            {
                //Agregando valores a lista de doctores
                persona.listaDoctor.Add(id);
                persona.listaDoctor.Add(nombre);
                persona.listaDoctor.Add(apellido);
                persona.listaDoctor.Add(cedula);
                persona.listaDoctor.Add(especialidad);

            }
            catch (Exception ex)
            {
                //Mensaje en caso de error creando un doctor
                Console.WriteLine("Error creando doctor" + ex.Message);
            }
        }
        //Metodo para crear un paciente
        public void crearPaciente(int id, string nombre, string apellido, int cedula, int celular, string correo)
        {
            try
            {
                //Agregando valores a la lista de clientes
                persona.listaCliente.Add(id);
                persona.listaCliente.Add(nombre);
                persona.listaCliente.Add(apellido);
                persona.listaCliente.Add(cedula);
                persona.listaCliente.Add(celular);
                persona.listaCliente.Add(correo);
            }
            catch (Exception ex)
            {
                //Mensaje en caso de error creando un paciente
                Console.WriteLine("Error creando paciente" + ex.Message);
            }
        }
        //Metodo para crear una cita
        public void crearCita(string nombreDoctor, string nombrePaciente, int horaCita)
        {
            try
            {
                cita.listaCitas.Add(nombreDoctor);
                cita.listaCitas.Add(nombrePaciente);
                if (horaCita >= 8 || horaCita <= 13)
                {
                    cita.listaCitas.Add(horaCita);
                }
                else
                {
                    Console.WriteLine("La hora esta fuera del espacio laboral!"); 
                }
            }
            catch (Exception ex)
            {
                //Mensaje en caso de error creando una cita
                Console.WriteLine("A ocurrido un error creando una cita" + ex.Message);
            }
        }
        //Metodo para eliminar una cita
        public void eliminarCita(string nombreDoctor, string nombrePaciente, int horaCita)
        {
            try
            {
                    cita.listaCitas.Remove(nombreDoctor);
                    cita.listaCitas.Remove(nombrePaciente);
                    cita.listaCitas.Remove(horaCita);
            }

            catch (Exception ex)
            {
                //Mensaje en caso de error eliminando una cita
                Console.WriteLine("A ocurrido un error eliminando una cita" + ex.Message);
            }
        }
        //Metodo para imrpimir a los doctores
        public void imprimirDoctor()
        {
            Console.WriteLine("Imprimiendo doctores");
            foreach (var dato in persona.listaDoctor)
            {

                Console.WriteLine(dato);
                Console.WriteLine("---------");
            }
           

        }
        //Metodo para imprimir a los pacientes
        public void imprimirPacientes()
        {
            Console.WriteLine("Imprimiendo Pacientes");
            foreach (var dato1 in persona.listaCliente)
            {

                Console.WriteLine(dato1);

            }

        }
        //Metodo para imprimir la lista de citas
        public void imprimirCitas()
        {
            Console.WriteLine("Imprimiendo lista de citas");
            foreach (var dato2 in cita.listaCitas)
            {

                Console.WriteLine(dato2);

            }
            #endregion
        }
    }
}
