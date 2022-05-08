using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Domain;
using Business;
using EquiposDIT.Commands;
using System.Windows.Input;

namespace EquiposDIT.ViewModels
{
    public class SitioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        SitioBusiness SitioService;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public SitioViewModel()
        {
            SitioService = new SitioBusiness();
            CargarGrilla();
            SitioActual = new Sitio();
            saveCommand = new RelayCommand(Save);            
        }

        #region guardar

        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }

        }

        public void Save()
        {
            try
            {
                if (Valido())
                {                    
                    if(SitioActual.Id != 0)
                    {
                        var isSaved = SitioService.UpdateSitio(SitioActual);
                        if (isSaved != 0)
                        {
                            Mensaje = "Sitio Actualizado Correctamente";
                        }
                        else
                        {
                            Mensaje = "Error al Actualizar Sitio";
                        }
                    }
                    else
                    {
                        var isSaved = SitioService.SaveSitio(SitioActual);
                        if (isSaved != 0)
                        {
                            Mensaje = "Sitio Guardado Correctamente";
                        }
                        else
                        {
                            Mensaje = "Error al guardar Sitio";
                        }
                    }
                    CargarGrilla();
                }
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion

        #region Listar

        private void CargarGrilla()
        {
            ListaSitios = new ObservableCollection<Sitio>(SitioService.GetSitios());
        }

        private ObservableCollection<Sitio> listaSitios;
        public ObservableCollection<Sitio> ListaSitios
        {
            get { return listaSitios; }
            set { listaSitios = value; OnPropertyChanged("ListaSitios"); }
        }

        private Sitio sitioActual;

        public Sitio SitioActual
        {
            get { return sitioActual; }
            set { sitioActual = value; OnPropertyChanged("SitioActual"); }
        }

        #endregion

        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; OnPropertyChanged("Mensaje"); }
        }

        public bool Valido()
        {
            bool valido = true;
            if(SitioActual != null)
            {
                if (!String.IsNullOrEmpty(SitioActual.Descripcion))
                {
                    if (String.IsNullOrEmpty(SitioActual.Descripcion.Trim()))
                    {
                        Mensaje = "Error, el campo Descripcion no puede estar vacio";
                        valido = false;
                    }
                }
                else
                {
                    Mensaje = "Error, el campo Descripcion no puede estar vacio";
                    valido = false;
                }
            }
           
           

            return valido;
        }
    }
}
