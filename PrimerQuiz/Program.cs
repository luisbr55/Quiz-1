using System;
using PrimerQuiz.ClasesBasicas;

namespace PrimerQuiz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Operaciones ope = new Operaciones();
            Persona persona = new Persona();
            Citas cita = new Citas();

            string respuesta;
            string correo;
            string nombre;
            string nombrePac;
            string apellido;
            string especialidad;
            int cedula;
            int hora;
            int celular;
            int id;


            try
            {
                do
                {
                    //Se muestra menu principal
                    Console.WriteLine("Menu: \n" +
                    "1. Registrar un usuario\n" +
                    "2. Crear una cita\n" +
                    "3. Eliminar una cita \n" +
                    "4. Mostrar lista completa\n" +
                    "5. Cerrar Programa");
                    //Se iguala respuesta para que entre al switch 
                    respuesta = Console.ReadLine();

                    switch (respuesta)
                    {
                        case "1":
                            do
                            {
                                //Se muestra submenu para escoger tipo de usuario
                                Console.WriteLine("Que desea registrar: \n" +
                                "1. Doctor\n" +
                                "2. Paciente\n" +
                                "3. Volver a menu principal");
                                //Se iguala respuesta para que entre al switch
                                respuesta = Console.ReadLine();
                                switch (respuesta)
                                {
                                    case "1":
                                        //Solicitando el id del doctor
                                        Console.WriteLine("Digite el id del doctor:");
                                        id = int.Parse(Console.ReadLine());
                                        //Solicitando el nombre del doctor
                                        Console.WriteLine("Digite el nombre del doctor: ");
                                        nombre = Console.ReadLine();
                                        //Solicitando el apellido del doctor
                                        Console.WriteLine("Digite el apellido: ");
                                        apellido = Console.ReadLine();
                                        //Solicitando la cedula del doctor
                                        Console.WriteLine("Digite la cedula del doctor:");
                                        cedula = int.Parse(Console.ReadLine());
                                        //Solicitando la especialidad del doctor
                                        Console.WriteLine("Digite la especialidad del doctor:");
                                        especialidad = Console.ReadLine();
                                        //Enviando los datos al metodo para crear doctor
                                        ope.crearDoctor(id, nombre, apellido, cedula, especialidad);
                                        break;
                                    case "2":
                                        //Solicitando el id del paciente
                                        Console.WriteLine("Digite el id del paciente:");
                                        id = int.Parse(Console.ReadLine());
                                        //Solicitando el nombre del paciente
                                        Console.WriteLine("Digite el nombre del paciente: ");
                                        nombre = Console.ReadLine();
                                        //Solicitando el apellido del paciente
                                        Console.WriteLine("Digite el apellido: ");
                                        apellido = Console.ReadLine();
                                        //Solicitando la cedula del paciente
                                        Console.WriteLine("Digite la cedula del paciente:");
                                        cedula = int.Parse(Console.ReadLine());
                                        //Solicitando el celular del paciente
                                        Console.WriteLine("Digite el celular:");
                                        celular = int.Parse(Console.ReadLine());
                                        //Solicitando el correo del paciente
                                        Console.WriteLine("Digite el correo del paciente");
                                        correo = Console.ReadLine();
                                        //Enviando los datos al metodo para crear paciente
                                        ope.crearPaciente(id, nombre, apellido, cedula, celular, correo);
                                        break;
                                    case "3":
                                        //Mensaje para volver al menu principal
                                        Console.WriteLine("Volviendo al menu principal");
                                        break;
                                    default:
                                        //Mensaje en caso de opcion invalida
                                        Console.WriteLine("Opcion digitada invalida!");
                                        break;
                                }
                            } while (respuesta != "3");
                            break;
                        case "2":
                            //Se solicita el nombre del doctor para la cita
                            Console.WriteLine("Digite el nombre del doctor de la cita: ");
                            nombre = Console.ReadLine();
                            //Se solicita el nombre del paciente para la cita
                            Console.WriteLine("Digite el nombre del paciente de la cita: ");
                            nombrePac = Console.ReadLine();
                            //Se solicita la hora para la cita
                            Console.WriteLine("Digite la hora de la cita:");
                            hora = int.Parse(Console.ReadLine());

                            if (hora > 8 || hora > 13)
                            {
                                ope.crearCita(nombre, nombrePac, hora);
                            }
                            else
                            {
                                Console.WriteLine("Hora seleccionada fuera de espacio laboral");
                            }
                            break;
                        case "3":
                            if (persona.listaDoctor.Count !=0 || persona.listaCliente.Count != 0)
                            {
                                //Se solicita el nombre del doctor
                                Console.WriteLine("Digite el doctor");
                                nombre = Console.ReadLine();
                                //Se solicita el nombre del paciente
                                Console.WriteLine("Digite el nombre del paciente:");
                                nombrePac = Console.ReadLine();

                                //Se pregunta la hora de la cita
                                Console.WriteLine("Digite la hora de la cita:");
                                hora = int.Parse(Console.ReadLine());
                                if (hora > 8 || hora > 13)
                                {
                                    ope.eliminarCita(nombre, nombrePac, hora);
                                }
                                else
                                {
                                    Console.WriteLine("La hora insertada no existe!");
                                }

                            }
                            else { Console.WriteLine("La lista doctores o clientes se encuentra vacia!"); }
                            break;
                        case "4":
                            do
                            {
                                //Se muestra submenu con las opciones para imprimir
                                Console.WriteLine("Que lista desea imprimir: \n" +
                                    "1. Doctores \n" +
                                    "2. Pacientes\n" +
                                    "3. Citas\n" +
                                    "4. Ninguno");
                                respuesta = Console.ReadLine();

                                switch (respuesta)
                                {

                                    case "1":
                                        //Se valida que la lista no este vacia
                                        if (persona.listaDoctor.Equals(null))
                                        {
                                            Console.WriteLine("No hay doctores registrados!");
                                        }
                                        else
                                        {
                                            ope.imprimirDoctor();
                                        }
                                        break;
                                    case "2":
                                        //Se llama al metodo para mostrar a los pacientes
                                        ope.imprimirPacientes();
                                        break;
                                    case "3":
                                        ope.imprimirCitas();
                                        break;
                                    case "4":
                                        //Mensaje para volver al menu principal
                                        Console.WriteLine("Volviendo al menu principal");
                                        break;
                                    default:
                                        //Mensaje en caso de opcion invalida
                                        Console.WriteLine("Opcion digitada invalida!");
                                        break;
                                }
                            } while (respuesta != "4");
                            break;

                        case "5":
                            //Mensaje para cuando se finalice el programa
                            Console.WriteLine("Programa Finalizado!");
                            break;
                        default:
                            //Mensaje en caso de opcion invalida
                            Console.WriteLine("Opcion digitada invalida!");
                            break;
                    }
                }
                //Fin del ciclo do while
                while (respuesta != "5");
            }
            catch (Exception ex)
            {
                //Mensaje en caso de error
                Console.WriteLine("Ocurrio un error" + ex.Message);
            }
        }
    }
}



