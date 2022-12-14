using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ECAD_eApps_Interview
{
   public class CommandHandler : ICommand
   {
      public CommandHandler()
      {
      }

      public CommandHandler(Func<Task> commandAction, Func<bool> canExecuteFunc = null)
      {
         CommandAction = async () => await commandAction().ConfigureAwait(true);
         CanExecuteFunc = canExecuteFunc;
      }

      public CommandHandler(Action commandAction, Func<bool> canExecuteFunc = null)
      {
         CommandAction = commandAction;
         CanExecuteFunc = canExecuteFunc;
      }

      public CommandHandler(Action<object> commandActionParam, Func<object, bool> canExecuteFuncParam = null)
      {
         CommandActionParam = commandActionParam;
         CanExecuteFuncParam = canExecuteFuncParam;
      }

      public Action<object> CommandActionParam { get; set; }

      public Func<object, bool> CanExecuteFuncParam { get; set; }

      public Action CommandAction { get; set; }

      public Func<bool> CanExecuteFunc { get; set; }

      public void Execute(object parameter = null)
      {
         if (CommandActionParam != null)
         {
            CommandActionParam?.Invoke(parameter);
         }
         else if (CommandAction != null)
         {
            CommandAction?.Invoke();
         }
      }

      public bool CanExecute(object parameter = null)
      {
         if (CanExecuteFuncParam != null)
         {
            return CanExecuteFuncParam(parameter);
         }

         if (CanExecuteFunc != null)
         {
            return CanExecuteFunc();
         }

         return true;
      }

      public event EventHandler CanExecuteChanged
      {
         add { CommandManager.RequerySuggested += value; }
         remove { CommandManager.RequerySuggested -= value; }
      }
   }
}
