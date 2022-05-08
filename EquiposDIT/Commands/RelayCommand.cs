using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EquiposDIT.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action DoWork;

        //Le paso por constructor un metodo a ejecutar
        public RelayCommand(Action work)
        {
            DoWork = work;
        }

        //Aca se puede poner una validacion, si valida ok se ejecuta Execute, no se que tipo de
        //validacion se puede implementar aca ni como hacerlo, asi que ahora hardcodeo true
        public bool CanExecute(object parameter)
        {
            return true;
        }


        //Ejecuto el metodo que haya pasado por constructor.
        public void Execute(object parameter)
        {
            DoWork();
        }
    }
}
