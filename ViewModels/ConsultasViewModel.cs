using InformeProyectos.Commands;
using InformeProyectos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InformeProyectos.ViewModels
{
    class ConsultasViewModel : ViewModelBase
    {
        public UpdateViewCommand updateViewCommand { set; get; }
        public ICommand ReportsCommand {set;get;}
        public ICommand UpdateDptoCommand { set; get; }
        public ICommand UpdateProyectoCommand { set; get; }
        private DptoModel dpto;
        public DptoModel Dpto
        {
            set
            {
                dpto = value;
                OnPropertyChanged(nameof(Dpto));
            }
            get
            {
                return dpto;
            }
        }

        private ProyectoModel proyecto;
        public ProyectoModel Proyecto
        {
            set
            {
                proyecto = value;
                OnPropertyChanged(nameof(Proyecto));
            }
            get
            {
                return proyecto;
            }
        }


        public int IdDpto { set; get; }

        private ObservableCollection<DptoModel>  listaDptos;
        public ObservableCollection<DptoModel> ListaDptos
        {
            set
            {
                listaDptos = value;
                OnPropertyChanged(nameof(ListaDptos));
            }
            get
            {
                return listaDptos;
            }
        }
        private ObservableCollection<ProyectoModel> listaProyectos;
        public ObservableCollection<ProyectoModel> ListaProyectos
        {
            set
            {
                listaProyectos = value;
                OnPropertyChanged(nameof(ListaProyectos));
            }
            get
            {
                return listaProyectos;
            }
        }
        public DateTime Fecha1 { set; get; }
        public DateTime Fecha2 { set; get; }

        public ConsultasViewModel(UpdateViewCommand updateViewCommand)
        {
            this.updateViewCommand = updateViewCommand;

            ReportsCommand = new ReportsCommand(this);
            UpdateDptoCommand = new UpdateDptoCommand(this);
            UpdateProyectoCommand = new UpdateProyectoCommand(this);
            Fecha1 = DateTime.Today;
            Fecha2 = DateTime.Today;
        }
    }
}
