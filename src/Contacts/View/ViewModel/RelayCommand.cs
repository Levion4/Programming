using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <inheritdoc/>
    public class RelayCommand: ICommand
    {
        /// <summary>
        /// Делегат, выполняющийся при вызове метода <see cref="Execute(object)"/>.
        /// </summary>
        private Action<object> _execute;

        /// <summary>
        /// Делегат, выполняющий проверку
        /// может ли команда выполнится в текущий момент.
        /// </summary>
        private Func<object, bool> _canExecute;

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged
        {
            add 
            {
                CommandManager.RequerySuggested += value; 
            }
            remove 
            {
                CommandManager.RequerySuggested -= value; 
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="RelayCommand"/>.
        /// </summary>
        /// <param name="execute">Команда на выполнение.</param>
        /// <param name="canExecute">Делегат проверки
        /// возможности выполнения команды.</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        /// <summary>
        /// Определяет, может ли команда выполняться.
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            this._execute(parameter);
        }
    }
}
