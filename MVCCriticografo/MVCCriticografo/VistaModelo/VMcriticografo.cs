using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVCCriticografo.VistaModelo
{
    public class VMcriticografo : BaseViewModel
    {
        #region VARIABLES
        string _Nombre;
        bool _Hembra;
        bool _Macho;
        bool _Alto;
        bool _Feo;
        bool _Listo;
        bool _Extravagante;
        bool _Raro;
        bool _Grande;
        string _Oracion;
        string _TextoConvertido;
        #endregion
        #region CONSTRUCTOR
        public VMcriticografo(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Nombre
        {
            get { return _Nombre; }
            set { SetValue(ref _Nombre, value); }
        }
        public string TextoConvertido
        {
            get { return _TextoConvertido; }
            set { SetValue(ref _TextoConvertido, value); }
        }
        public string Oracion
        {
            get { return _Oracion; }
            set { SetValue(ref _Oracion, value); }
        }

        public bool Hembra
        {
            get { return _Hembra; }
            set { SetValue(ref _Hembra, value); }
        }
        public bool Macho
        {
            get { return _Macho; }
            set { SetValue(ref _Macho, value); }
        }
        public bool Alto
        {
            get { return _Alto; }
            set { SetValue(ref _Alto, value); }
        }
        public bool Feo
        {
            get { return _Feo; }
            set { SetValue(ref _Feo, value); }
        }
        public bool Listo
        {
            get { return _Listo; }
            set { SetValue(ref _Listo, value); }
        }
        public bool Extravagante
        {
            get { return _Extravagante; }
            set { SetValue(ref _Extravagante, value); }
        }
        public bool Raro
        {
            get { return _Raro; }
            set { SetValue(ref _Raro, value); }
        }
        public bool Grande
        {
            get { return _Grande; }
            set { SetValue(ref _Grande, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {
            

        }

       
        public void Personalidad()
        {
            string texto = "";
            TextoConvertido = string.Empty;
            texto = string.Empty;

            if (Macho == true)
            {
                if (Alto)
                {
                    texto += "Alto";
                }
                if (Feo)
                {
                    texto += " Feo";
                }
                if (Listo)
                {
                    texto += " Listo";
                }
                if (Extravagante)
                {
                    texto += " Extravagante";
                }
                if (Raro)
                {
                    texto += " Raro";
                }
                if (Grande)
                {
                    texto += " Grande";
                }
            }
            else if (Hembra == true)
            {
                if (Alto)
                {
                    texto = "Alta";
                }
                if (Feo)
                {
                    texto += " Fea";
                }
                if (Listo)
                {
                    texto += " Lista";
                }
                if (Extravagante)
                {
                    texto += " Extravaganta";
                }
                if (Raro)
                {
                    texto += " Rara";
                }
                if (Grande)
                {
                    texto += " Granda";
                }
            }
            string[] resultadofinal = texto.Split(' ');
            if (Alto)
            {
                for (int i = 0; i < resultadofinal.Length - 1; i++)
                {
                    TextoConvertido += resultadofinal[i] + ",";
                }
            }
            else
            {
                for (int i = 1; i < resultadofinal.Length - 1; i++)
                {
                    TextoConvertido += resultadofinal[i] + ",";
                }

            }
            if (resultadofinal.Length > 1)
            {
                TextoConvertido = TextoConvertido.Substring(0, TextoConvertido.Length - 1) + " y " + resultadofinal[resultadofinal.Length - 1];
            }
        }
        public async void BTNMensaje()
        {
            Personalidad();

            //  Personalidad();
            Oracion =Nombre +" es "+ TextoConvertido;

        }
        public void procesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        public ICommand MostrarMensajeCommand => new Command(BTNMensaje);

        #endregion
    }
}
