using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EinKleinesMatheprogramm.ViewModels
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> executeMethode;
        private readonly Func<T, bool> canExecuteMethode;

        /// <summary>
        /// Eventhandler, der aufgerufen wird
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Konstruktor für ein Command, dass immer ausgeführt werden kann.
        /// </summary>
        /// <param name="execute"></param>
        public RelayCommand(Action<T> execute):this (execute, null) { }

        /// <summary>
        /// Konstruktor für ein neues Command.
        /// </summary>
        /// <param name="execute">Funktion, die ausgeführt werden soll</param>
        /// <param name="canExecute">Funktion, die überprüft, ob execute aus geführt
        /// werden kann</param>
        public RelayCommand(Action<T> execute, Func<T, bool> canExecute)
        {
            executeMethode = execute; ;
            canExecuteMethode = canExecute;
        }

        /// <summary>
        /// Überprüft, ob das Command ausgeführt werden kann
        /// </summary>
        /// <param name="parameter">Daten, welche vom Command benutzt werden kann</param>
        /// <returns>true, wenn Commannd ausgeführt werden kann, sonst false</returns>
        bool ICommand.CanExecute(object parameter)
        {
            if(canExecuteMethode != null)
            {
                T parm = (T)parameter;
                return canExecuteMethode(parm);
            }

            if(executeMethode != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Führt das Command aus
        /// </summary>
        /// <param name="parameter">Daten, die vom Command genutzt werden kann</param>
        void ICommand.Execute(object parameter)
        {
            executeMethode?.Invoke((T)parameter);
        }

        /// <summary>
        /// Methode löst das Event aus
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }


    }
}
