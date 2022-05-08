using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Sector : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public int Id { get; set; }
        
        private string nombre;
        public string Nombre 
        {
            get { return nombre; } 
            set { nombre = value; OnPropertyChanged("Nombre"); } 
        }

        private bool activo;
        public bool Activo
        {
            get { return activo; }
            set { activo = value; OnPropertyChanged("Activo"); }
        }        
    }
}
