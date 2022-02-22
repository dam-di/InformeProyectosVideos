using InformeProyectos.Models;
using InformeProyectos.Services.DataSet.ProyectoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformeProyectos.Services.DataSet
{
    class DataSetHandler
    {
        private static InformeTableAdapter adapter = new InformeTableAdapter();
        private static departamentoTableAdapter dptoAdapter = new departamentoTableAdapter();
        private static proyectoTableAdapter proyectoAdapter = new proyectoTableAdapter();

        public static DataTable GetDataByProyectoDpto(int idProyecto, int idDpto)
        {
            return adapter.GetDataByProyectoDpto(idProyecto, idDpto);
        }

        public static DataTable GetDataByIdProyecto(int idProyecto)
        {
            return adapter.GetDataByIdProyecto(idProyecto);
        }

        public static DataTable GetDataByIdDpto(int idDpto)
        {
            return adapter.GetDataByIdDpto(idDpto);
        }

        public static DataTable GetDataByFechas(DateTime fecha1, DateTime fecha2)
        {
            return adapter.GetDataByFechas(fecha1.ToString(), fecha2.ToString());
        }

        public static ObservableCollection<DptoModel> GetDptos()
        {
            ObservableCollection<DptoModel> ListaDptos = new ObservableCollection<DptoModel>();

            DataTable listaDptosDT = dptoAdapter.GetData();

            foreach(DataRow dptoRow in listaDptosDT.Rows)
            {
                DptoModel dpto = new DptoModel();
                dpto.idDpto = (int)dptoRow["idDpto"];
                dpto.nombreDpto = dptoRow["nombreDpto"].ToString();
                ListaDptos.Add(dpto);
            }

            return ListaDptos;
        }

        public static ObservableCollection<ProyectoModel> GetProyectos()
        {
            ObservableCollection<ProyectoModel> ListaProyectos = new ObservableCollection<ProyectoModel>();

            DataTable listaProyectosDT = proyectoAdapter.GetData();

            foreach (DataRow proyectoRow in listaProyectosDT.Rows)
            {
                ProyectoModel proyecto = new ProyectoModel();
                proyecto.idProyecto = (int)proyectoRow["idProyecto"];
                proyecto.NombreProyecto = (string)proyectoRow["nombreProyecto"];
                proyecto.TipoProyecto = (string)proyectoRow["tipoProyecto"];
                proyecto.CiudadProyecto = (string)proyectoRow["ciudadProyecto"];
                proyecto.FechaInicio = (DateTime)proyectoRow["fechaInicio"];
                proyecto.FechaFin = (DateTime)proyectoRow["fechaFin"];
                
                ListaProyectos.Add(proyecto);
            }

            return ListaProyectos;
        }
    }
}
