using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * CLASE METODOSMENU
 **/
namespace Olor_a_Libro
{
    public static class MetodosMenu
    {

        /**
         * TODOS LOS METODOS NOS ABREN PARA REUTILIZAR CODIGO SU RESPECTIVO FORMULARIO
         **/ 
        public static void Inicio()
        {
            FormPrincipal fPrincipal = new FormPrincipal();
            fPrincipal.ShowDialog();
           
        }

        public static void VerLibrerias()
        {
            FormListaLibrerias fListaLibreria = new FormListaLibrerias();
            fListaLibreria.ShowDialog();
        }

        public static void AnyadirLibreria()
        {
            FormLibreria fLibreria = new FormLibreria();
            fLibreria.ShowDialog();
        }
        
        public static void VerActividades()
        {
            FormListaActividades fListaAct = new FormListaActividades();
            fListaAct.ShowDialog();
        }

        public static void AnyadirAct()
        {
            FormActividad fActividad = new FormActividad();
            fActividad.ShowDialog();
        }

        public static void VerActividadLibreria()
        {
            FormActividadesLibreria fActLibreria = new FormActividadesLibreria();
            fActLibreria.ShowDialog();
        }

        public static void verUsuarios()
        {
            FormUsuarios fUsuarios = new FormUsuarios();
            fUsuarios.ShowDialog();
        }
        public static void AnyadirUsuarios()
        {
            FormVerUsuario fUsuarios = new FormVerUsuario();
            fUsuarios.ShowDialog();
        }

        public static void Estadisticas()
        {
            FormEstadisticas fEstadisticas = new FormEstadisticas();
            fEstadisticas.ShowDialog();
        }

        public static void PuntosAdmin()
        {
            FormPuntuacionAdmin fPuntoAdmin = new FormPuntuacionAdmin();
            fPuntoAdmin.ShowDialog();
        }
    }
}
