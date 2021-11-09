using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Vuelos;

namespace ReservarVuelo
{
    public partial class VentanaGeneral : Form
    {
        //creo 3 objetos List para cada una de las clases de los modelos de datos
        List<Aeropuerto> aero = new List<Aeropuerto>();
        List<Aerolinea> lineas = new List<Aerolinea>();
        List<Vuelo> vuelos = new List<Vuelo>();


        public VentanaGeneral()
        {
            InitializeComponent();
            //IMAGEN DE FONDO****************************************************************
            Bitmap img = new Bitmap(Application.StartupPath + @"\imagenes\cielo.jpg");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //accedo a los datos de los ficheros
            aero = Aeropuerto.importar("aeropuertos.dat");
            lineas = Aerolinea.importar("aerolineas.dat");
            vuelos = Vuelo.importar("vuelos.dat");

            //*************************************************
            //ORIGEN
            //accedo a los nombres de los aeropuertos sin filtro
            for (int i = 0; i < aero.Count; i++)
            {
                cbAeropuertoNombreOrigen.Items.Add(aero[i].Nombre);

            }
            cbAeropuertoNombreOrigen.Items.Insert(0, "nada");

        }

        //***************************************************************** 
        //DESTINOS CON FILTRO
        //evento sobre el comboBox origen
        //el comboBox de Destino cambia al seleccionar el origen 
        private void cbAeropuertoNombreOrigen_SelectedValueChanged(object sender, EventArgs e)
        {
            //si el usuario elige nada, se borra el combobox destino
            if (cbAeropuertoNombreOrigen.SelectedItem.Equals("nada"))
            {

                cbAeropuertoNombreDestino.Items.Clear();
            }
            //recupero la seleccion del usuario en la variable origen
            var origen = cbAeropuertoNombreOrigen.SelectedItem.ToString();

            //limpio el ComboDestino
            cbAeropuertoNombreDestino.Items.Clear();

            //muestro en una label el origen elegido por el usuario
            lbAeropuertoNombreOrigenElegido.Text = "ORIGEN: " + origen;

            //recorro el list vuelos
            for (int i = 0; i < vuelos.Count; i++)
            {

                //si la eleccion de origen del usuario es igual al elemento origen.nombre en la posicion i de la lista vuelos 
                if (origen.Equals((vuelos[i].Origen.Nombre).ToString()))
                {
                    //guardo el destino en una variable
                    var destino = (vuelos[i].Destino.Nombre).ToString();

                    //evito repetidos: devuelve -1 si no lo encuentra en la lista
                    if (cbAeropuertoNombreDestino.Items.IndexOf(destino) != -1) { }
                    else
                    {
                        //lleno el comboBox destino
                        cbAeropuertoNombreDestino.Items.Add(destino);
                    }


                }



            }


        }
        //**************************************************************
        //AEROLINEAS DISPONIBLES CON FILTRO
        //evento sobre el combobox destino
        //cuando el usuario elige un destino se llena el combobox de aerolineas con las disponibles 
        private void cbAeropuertoNombreDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            //recupero la seleccion del usuario en la variable 
            var destino = cbAeropuertoNombreDestino.SelectedItem.ToString();
            var origen = cbAeropuertoNombreOrigen.SelectedItem.ToString();

            // lleno el label destino
            lbAeropuertoNombreDestinoElegido.Text = "DESTINO: " + destino;

            //limpio el combo box aerolineas disponibles
            cbAerolineasDisponibles.Items.Clear();

            //recorro el list vuelos
            for (int i = 0; i < vuelos.Count; i++)
            {
                //si coincide origen en list vuelos
                if (origen.Equals(vuelos[i].Origen.Nombre.ToString()))
                {
                    //y si coincide destinos en list vuelos
                    if (destino.Equals(vuelos[i].Destino.Nombre.ToString()))
                    {
                        var aeroDisponible = vuelos[i].Aerolinea.Nombre.ToString();

                        //evito repetidos: devuelve -1 si no lo encuentra en la lista
                        if (cbAerolineasDisponibles.Items.IndexOf(aeroDisponible) != -1) { }
                        else
                        {
                            //lleno el comboBox con las aerolineas disponibles
                            cbAerolineasDisponibles.Items.Add(aeroDisponible);
                        }


                    }
                }


            }
        }
        //********************************************************
        //FECHAS DISPONIBLES CON FILTRO
        //evento sobre combo box aerolineas disponibles
        //muestra las fechas disponibles para viajar
        private void cbAerolineasDisponibles_SelectedValueChanged(object sender, EventArgs e)
        {
            //recupero la seleccion del usuario en las variables
            var destino = cbAeropuertoNombreDestino.SelectedItem.ToString();
            var origen = cbAeropuertoNombreOrigen.SelectedItem.ToString();
            var aerolinea = cbAerolineasDisponibles.SelectedItem.ToString();

            //lleno el label aerolinea elegida
            lbAerolineaDisponibleElegida.Text = "AEROLINEA: " + aerolinea;

            //limpio el combobox fechas
            cbFechasDisponibles.Items.Clear();

            //recorro el list vuelos
            for (int i = 0; i < vuelos.Count; i++)
            {
                //si coincide origen(eleccion del usuario) con origen en list vuelos
                if (origen.Equals(vuelos[i].Origen.Nombre.ToString()))
                {
                    //si coincide destinos
                    if (destino.Equals(vuelos[i].Destino.Nombre.ToString()))
                    {
                        //si coincide aerolinea
                        if (aerolinea.Equals(vuelos[i].Aerolinea.Nombre.ToString()))
                        {
                            //lleno el combo box con las fechas disponibles
                            var fechasDisponibles = vuelos[i].Fecha.ToString();

                            //evito repetidos: devuelve -1 si no lo encuentra en la lista
                            if (cbFechasDisponibles.Items.IndexOf(fechasDisponibles) != -1) { }
                            else
                            {
                                //lleno el comboBox con las fechas disponibles disponibles
                                cbFechasDisponibles.Items.Add(fechasDisponibles);
                            }
                        }




                    }

                }

            }
        }
        //**************************************************************
        //RESERVAR
        //evento sobre boton reservar
        private void btReservar_Click(object sender, EventArgs e)
        {
            Reserva miReserva = null;
            Vuelo miVuelo = null;
            var numeroVu="";
            Aeropuerto ori=null;
            Aeropuerto des=null;
            Aerolinea aero=null;
            DateTime fe= default(DateTime);
            int adultos = 1;
            int ninios = 0;
            bool extra = false;



            try
            { 
                
                //reseteo label reserva
                lbReservaElegida.Text = "RESERVA:\n\n";

                
                //recupero el origen y lo imprimo en label Reserva
                var origen = cbAeropuertoNombreOrigen.SelectedItem;
                if (origen != null)
                {
                    lbReservaElegida.Text += $"ORIGEN: {origen.ToString()}\n\n";
                    
                    
                }
                else
                {
                   
                    lbReservaElegida.Text += "DEBE ELEGIR UN ORIGEN ANTES DE RESERVAR!\n\n";
                }
                

                //recupero el destino y lo imprimo en label Reserva
                var destino = cbAeropuertoNombreDestino.SelectedItem;
                if (destino != null)
                {
                    lbReservaElegida.Text += $"DESTINO: {destino.ToString()}\n\n";
                    
                }else
                {
                    lbReservaElegida.Text += "DEBE ELEGIR UN DESTINO ANTES DE RESERVAR!\n\n";
                }

                //recupero la fecha y lo imprimo en label Reserva
                var fecha = cbFechasDisponibles.SelectedItem;
                if (fecha != null)
                {
                    lbReservaElegida.Text += $"FECHA: {fecha.ToString()}\n\n";
                   
                }
                else
                {
                    lbReservaElegida.Text += "DEBE ELEGIR UNA FECHA ANTES DE RESERVAR!\n\n";
                }

                 //recupero la aerolinea y lo imprimo en label Reserva
                var aerolinea = cbAerolineasDisponibles.SelectedItem;
                if (aerolinea != null)
                {
                    lbReservaElegida.Text += $"AEROLINEA: {aerolinea.ToString()}\n\n";
                    
                }
                else
                {
                    lbReservaElegida.Text += "DEBE ELEGIR UNA AEROLINEA ANTES DE RESERVAR!\n\n";
                }

                //recupero lo que el usuario elige en adultos y lo imprimo en label Reserva
                adultos = (int)nUdAdultos.Value;
                lbReservaElegida.Text += $"ADULTOS: {adultos.ToString()}\n\n ";
                

                //recupero lo que el usuario elige en ninios
                ninios = (int)nUdNinios.Value;
                lbReservaElegida.Text += $"NIÑOS: {ninios.ToString()} \n\n";
                

                if (cbEquipaje.Checked)
                {
                    lbReservaElegida.Text += "Usted eligio llevar equipaje extra\n\n";
                    
                }
               

                //recupero numero de vuelo buscandolo en el list vuelo: Numero string
                //recorro el list vuelos
                for (int i = 0; i < vuelos.Count; i++)
                {
                    //si coincide origen
                    if (origen!=null && origen.Equals(vuelos[i].Origen.Nombre.ToString()))
                    {
                        //si coincide destinos
                        if (destino!=null && destino.Equals(vuelos[i].Destino.Nombre.ToString()))
                        {
                            //si coincide aerolinea
                            if (aerolinea!=null && aerolinea.Equals(vuelos[i].Aerolinea.Nombre.ToString()))
                            {

                                //si coincide fecha
                                if (cbFechasDisponibles.SelectedItem!=null && cbFechasDisponibles.SelectedItem.Equals(vuelos[i].Fecha.ToString()))
                                {
                                    numeroVu = vuelos[i].Numero;
                                    if (numeroVu!=null && numeroVu != null)
                                    {
                                        lbReservaElegida.Text += $"NUMERO DE VUELO: {numeroVu}";
                                        
                                    }
                                    else
                                    {
                                        lbReservaElegida.Text += "DEBE ELEGIR TODAS LAS CASILLAS ANTES DE RESERVAR!!!";
                                    }

                                }
                             }
                        }
                    }

                }

                //recupero datos para instanciar el objeto vuelo



                for (int i = 0; i < vuelos.Count; i++)
                {
                    if (origen != null && origen.Equals(vuelos[i].Origen.Nombre.ToString()))
                    {
                        ori = vuelos[i].Origen;

                        if (destino != null && destino.Equals(vuelos[i].Destino.Nombre.ToString()))
                        {
                            des = vuelos[i].Destino;

                            if (aerolinea != null && aerolinea.Equals(vuelos[i].Aerolinea.Nombre.ToString()))
                            {
                                aero = vuelos[i].Aerolinea;

                                if (cbFechasDisponibles.SelectedItem != null && cbFechasDisponibles.SelectedItem.Equals(vuelos[i].Fecha.ToString()))
                                {
                                    fe = vuelos[i].Fecha;
                                    miVuelo = new Vuelo(numeroVu, ori, des, fe, aero);


                                    if (cbEquipaje.Checked)
                                    {
                                        extra = true;

                                    }

                                    miReserva = new Reserva(miVuelo, adultos, ninios, extra);
                                    miReserva.confirmar();
                                }
                            }
                        }

                    }

                }

             
              

               

            }
            catch(System.NullReferenceException e1)
            {
                lbReservaElegida.Text += "DEBE ELEGIR TODAS LAS CASILLAS ANTES DE RESERVAR!!!";
            }

         
            
        }
    }
}

