using InformeProyectos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InformeProyectos.Commands
{
    class UpdateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public ReportViewModel reportViewModel { set; get; }
        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is string)
            {
                string viewName = (string)parameter;

                if (viewName.Equals("home"))
                {
                    mainViewModel.SelectedViewModel = new HomeViewModel();
                }else if (viewName.Equals("resumen"))
                {
                    mainViewModel.SelectedViewModel = new ResumenViewModel();
                }else if (viewName.Equals("informe"))
                {
                    mainViewModel.SelectedViewModel = reportViewModel;
                }else if (viewName.Equals("consultas"))
                {
                    mainViewModel.SelectedViewModel = new ConsultasViewModel(this);
                }
            }
        }

        public MainViewModel mainViewModel { get; set; }
        public UpdateViewCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            this.mainViewModel.SelectedViewModel = new HomeViewModel();
            reportViewModel = new ReportViewModel();
        }
    }
}
