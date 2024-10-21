using Entities;
using MAUI_UD8_EJ5_DAL;
using System.Collections.ObjectModel;

namespace MAUI_UD8_EJ5_UI
{
    public partial class MainPage : ContentPage
    {

        /// <summary>
        /// 
        /// </summary>
        List<ClsPersona> Personas { get; set; }

        public String nombre;



        public MainPage()
        {
            InitializeComponent();


            Personas= ClsListados.ListadoPersonas();

            foreach(ClsPersona persona in Personas)
            {
                nombre =persona.Nombre;
            }


            VistaPersonas.ItemsSource = Personas;

        }






    }

}
