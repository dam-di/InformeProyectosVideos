using InformeProyectos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InformeProyectos.Commands
{
    class ReportsCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is string)
            {
                string consulta = (string)parameter;

                if (consulta.Equals("idDpto")){
                    consultasViewModel.updateViewCommand.reportViewModel.GenerarInformeDpto(consultasViewModel.Dpto.idDpto);
                    consultasViewModel.updateViewCommand.Execute("informe");
                }
                else if (consulta.Equals("fechas"))
                {
                    consultasViewModel.updateViewCommand.reportViewModel.GenerarInformeFechas(consultasViewModel.Fecha1, consultasViewModel.Fecha2);
                    consultasViewModel.updateViewCommand.Execute("informe");
                }else if (consulta.Equals("proyecto"))
                {
                    consultasViewModel.updateViewCommand.reportViewModel.GenerarInformeIdProyecto(consultasViewModel.Proyecto.idProyecto);
                    consultasViewModel.updateViewCommand.Execute("informe");
                }else if (consulta.Equals("proyectoDpto"))
                {
                    consultasViewModel.updateViewCommand.reportViewModel.GenerarInformeProyectoDpto(consultasViewModel.Proyecto.idProyecto, consultasViewModel.Dpto.idDpto);
                    consultasViewModel.updateViewCommand.Execute("informe");
                }
            }
        }

        public ConsultasViewModel consultasViewModel { set; get; }
        public ReportsCommand(ConsultasViewModel consultasViewModel)
        {
            this.consultasViewModel = consultasViewModel;
        }
    }
}
