using DevExpress.XtraBars;
using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using veXMAX.Desktop.Forms.Generics;
using veXMAX.Lib.Extension;
using veXMAX.Shared;
using veXMAX.Shared.Models.Primitives;
using veXMAX.Shared.Models.Transactions;

namespace veXMAX.Desktop
{
    public partial class MainView : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }



        void CreateListPrimitive(string sModelo) 
        { 

            Type ModelPrimitive = VXModelInteropHelper.GetModelPrimitiveByName(sModelo);

            if (ModelPrimitive.IsNull())
                return;

            var ListPrimitiveGenericType = typeof(ListPrimitiveGeneric<>);
            Type[] typeArgs = { ModelPrimitive };
            var VXDBPrimitiveMaker = ListPrimitiveGenericType.MakeGenericType(typeArgs);
            var ListPrimitive = Activator.CreateInstance(VXDBPrimitiveMaker, new object[] { });

            var accessor = TypeAccessor.Create(ListPrimitive.GetType());


            accessor[ListPrimitive, "Parent"] = pnlMain;
            accessor[ListPrimitive, "Name"] = "grid";
            accessor[ListPrimitive, "Dock"] = DockStyle.Fill;
            accessor[ListPrimitive, "TabIndex"] = 0;

            var method = ListPrimitive.GetType().GetMethod("BringToFront");

            method.Invoke(ListPrimitive, new object[] { });

        }

        void CreateListTransction(string sModelo)
        {

            Type ModelTransaction = VXModelInteropHelper.GetModelTransactionByName(sModelo);

            if (ModelTransaction.IsNull())
                return;

            var ListTransactionGenericType = typeof(ListTransactionGeneric<>);
            Type[] typeArgs = { ModelTransaction };
            var VXDBPrimitiveMaker = ListTransactionGenericType.MakeGenericType(typeArgs);

            var ListTransaction = Activator.CreateInstance(VXDBPrimitiveMaker, new object[] { });

            var accessor = TypeAccessor.Create(ListTransaction.GetType());

            accessor[ListTransaction, "Parent"] = pnlMain;
            accessor[ListTransaction, "Name"] = "grid";
            accessor[ListTransaction, "Dock"] = DockStyle.Fill;
            accessor[ListTransaction, "TabIndex"] = 0;

            var method = ListTransaction.GetType().GetMethod("BringToFront");

            method.Invoke(ListTransaction, new object[] { });

        }

        private void mnuSatProdServ_Click(object sender, EventArgs e)
        {
            CreateListTransction(nameof(ERSAT_PRODSERV));
        }

        private void mnuLineaProducto_Click(object sender, EventArgs e)
        {
            CreateListPrimitive(nameof(PRO_LINEA));
        }

        private void mnuDiseñadorLayOuts_Click(object sender, EventArgs e)
        {
            FormDesigner form = new FormDesigner();

            form.Name = "fmFormDesigner";
            form.Parent = pnlMain;
            form.Dock = DockStyle.Fill;
            form.TabIndex = 0;
            form.BringToFront();
        }

        private void mnuFormularioProductos_Click(object sender, EventArgs e)
        {
            CreateFormTransction("ERCAJ_BANCO");
        }

        void CreateFormTransction(string sModelo)
        {

            Type ModelTransaction = VXModelInteropHelper.GetModelTransactionByName(sModelo);

            if (ModelTransaction.IsNull())
                return;

            var FormTransactionGenericType = typeof(FormTransactionGeneric<>);
            Type[] typeArgs = { ModelTransaction };
            var VXDBPrimitiveMaker = FormTransactionGenericType.MakeGenericType(typeArgs);

            var ListTransaction = Activator.CreateInstance(VXDBPrimitiveMaker, new object[] { });

            var accessor = TypeAccessor.Create(ListTransaction.GetType());

            accessor[ListTransaction, "Parent"] = pnlMain;
            accessor[ListTransaction, "Name"] = "grid";
            accessor[ListTransaction, "Dock"] = DockStyle.Fill;
            accessor[ListTransaction, "TabIndex"] = 0;

            var method = ListTransaction.GetType().GetMethod("BringToFront");

            method.Invoke(ListTransaction, new object[] { });

        }

        private void mnuPruebas_Click(object sender, EventArgs e)
        {
            FormTransactionGenericTest<ERCAJ_BANCO> fmPrueba = new FormTransactionGenericTest<ERCAJ_BANCO>();

            fmPrueba.Parent = pnlMain;
            fmPrueba.Name = "grid";
            fmPrueba.Dock = DockStyle.Fill;
            fmPrueba.TabIndex = 0;
        }
    }
}


