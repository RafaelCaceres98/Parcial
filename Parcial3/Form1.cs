using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace Parcial3
{
    public partial class Form1 : Form
    {
        public LacteosService LacteosService;
        public Form1()
        {
            InitializeComponent();
            LacteosService = new LacteosService(ConfigConection.Connection);
            DtgConsulta.DataSource = LacteosService.ConsultasBD();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            var ruta = openFile.FileName;
            MessageBox.Show(ruta);
            LacteosService = new LacteosService(ConfigConection.Connection);
            IList<Lacteos> LacteosMalos = new List<Lacteos>();
            IList<Lacteos> LacteosBuenos = new List<Lacteos>();
            foreach (var item in LacteosService.CargarArchivo(ruta))
            {
                if (item.CalcularPago() != item.TotalPago)
                {
                    LacteosMalos.Add(item);
                }
                else
                {
                    LacteosBuenos.Add(item);
                }
            }

            MessageBox.Show(LacteosService.GuardarLacteos(LacteosBuenos, LacteosMalos.Count));
        }

        private void CmbSede1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LacteosService = new LacteosService(ConfigConection.Connection);
            decimal total = 0, salario = 0, bonificacion = 0, descuento = 0;
            if (CmbSede1.Text.Equals("Valledupar"))
            {
                DtgConsulta.DataSource = null;
                DtgConsulta.DataSource = LacteosService.FiltroSede(1);
                total = LacteosService.FiltroSede(1).Sum(L => L.TotalPago);
                salario = LacteosService.FiltroSede(1).Sum(L => L.Salario);
                bonificacion = LacteosService.FiltroSede(1).Sum(L => L.Bonificaciones);
                descuento = LacteosService.FiltroSede(1).Sum(L => L.Descuentos);
            }
            if (CmbSede1.Text.Equals("Barranquilla"))
            {
                DtgConsulta.DataSource = null;
                DtgConsulta.DataSource = LacteosService.FiltroSede(2);
                total = LacteosService.FiltroSede(2).Sum(L => L.TotalPago);
                salario = LacteosService.FiltroSede(2).Sum(L => L.Salario);
                bonificacion = LacteosService.FiltroSede(2).Sum(L => L.Bonificaciones);
                descuento = LacteosService.FiltroSede(2).Sum(L => L.Descuentos);
            }
            if (CmbSede1.Text.Equals("Cartagena"))
            {
                DtgConsulta.DataSource = null;
                DtgConsulta.DataSource = LacteosService.FiltroSede(3);
                total = LacteosService.FiltroSede(3).Sum(L => L.TotalPago);
                salario = LacteosService.FiltroSede(3).Sum(L => L.Salario);
                bonificacion = LacteosService.FiltroSede(3).Sum(L => L.Bonificaciones);
                descuento = LacteosService.FiltroSede(3).Sum(L => L.Descuentos);
            }
            TxtSalario.Text = salario.ToString();
            TxtBonificaciones.Text = bonificacion.ToString();
            TxtDescuento.Text = descuento.ToString();
            TxtTotal.Text = total.ToString();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {
            decimal total = 0, salario = 0, bonificacion = 0, descuento = 0;
            if (CmbSede2.Text.Equals(""))
            {
                MessageBox.Show("Combo Vacio. ");
            }
            else
            {
                DateTime fecha = DtpFecha.Value;
                int opcion=0;

                if (CmbSede2.Text.Equals("Valledupar"))
                {
                    opcion = 1;
                    total = LacteosService.Filtro(opcion, fecha).Sum(L => L.TotalPago);
                    salario = LacteosService.Filtro(opcion, fecha).Sum(L => L.Salario);
                    bonificacion = LacteosService.Filtro(opcion, fecha).Sum(L => L.Bonificaciones);
                    descuento = LacteosService.Filtro(opcion, fecha).Sum(L => L.Descuentos);
                }
                if (CmbSede2.Text.Equals("Barranquilla"))
                {
                    opcion = 2;
                    total = LacteosService.Filtro(opcion, fecha).Sum(L => L.TotalPago);
                    salario = LacteosService.Filtro(opcion, fecha).Sum(L => L.Salario);
                    bonificacion = LacteosService.Filtro(opcion, fecha).Sum(L => L.Bonificaciones);
                    descuento = LacteosService.Filtro(opcion, fecha).Sum(L => L.Descuentos);
                }
                if (CmbSede2.Text.Equals("Cartagena"))
                {
                    opcion = 3;
                    total = LacteosService.Filtro(opcion, fecha).Sum(L => L.TotalPago);
                    salario = LacteosService.Filtro(opcion, fecha).Sum(L => L.Salario);
                    bonificacion = LacteosService.Filtro(opcion, fecha).Sum(L => L.Bonificaciones);
                    descuento = LacteosService.Filtro(opcion, fecha).Sum(L => L.Descuentos);
                }

                DtgConsulta.DataSource = null;
                DtgConsulta.DataSource = LacteosService.Filtro(opcion,fecha);
                TxtSalario.Text = salario.ToString();
                TxtBonificaciones.Text = bonificacion.ToString();
                TxtDescuento.Text = descuento.ToString();
                TxtTotal.Text = total.ToString();
            }
        }
    }
}
