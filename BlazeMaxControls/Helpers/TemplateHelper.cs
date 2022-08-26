using BlazeMaxControls.Components;
using DevExpress.Entity.Model;
using FastMember;
using Microsoft.AspNetCore.Components;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using veXMAX.Shared.Attributes;
using veXMAX.Shared.Models;
using veXMAX.Shared.Models.Transactions;
using veXMAX.Resources;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using veXMAX.Resources;
using System.Reflection;
using veXMAX.Shared;

namespace BlazeMaxControls.Helpers
{
    public class TemplateHelper
    {
        public ERCAJ_BANCO Model { get; set; } = new ERCAJ_BANCO();
        //public VXModelPrimitive Data { get; set; }
        public LocalizedString this[string name, params object[] arguments] => throw new NotImplementedException();

        public LocalizedString this[string name] => throw new NotImplementedException();

        TypeAccessor TransAccessor;
        public ObjectAccessor MasterAccessor { get; set; }
        //public ObjectAccessor MasterAccessor = null;
        object Master = null;
        public string MasterAccessorStr { get; set; }
        public bool dataGrid { get; set; } = false;

        //private string Caption
        //{
        //    get => Field != null ? L[MetaColumnAttributes.Description] : LayoutFieldAttribute.Field;
        //}

        public TemplateHelper()
        {

            TransAccessor = TypeAccessor.Create(typeof(ERCAJ_BANCO));

            foreach (Member TMember in TransAccessor.GetMembers())
            {
                if (TMember.GetAttribute(typeof(NotMappedAttribute), false) != null)
                    continue;

                if (TMember.GetAttribute(typeof(VXTransactionMasterAttribute), false) != null)
                {
                    Master = TransAccessor[Model, TMember.Name];
                    MasterAccessor = ObjectAccessor.Create(TransAccessor[Model, TMember.Name]);
                }
            }

        }
        public VXModelPrimitive BuildData(LayoutItem Item)
        {
            VXModelPrimitive Data = null;

            if (Item.LeafContent.Any())
            {
                foreach (var item in Item.LeafContent)
                {
                    Data = ((VXModelPrimitive)TransAccessor[Model, Item.LeafContent[0].Primitive]);
                }
            }
            return Data;
        }

        public string BuildItem(LayoutItem Item, bool FirstIteration = false)
        {
            var component = string.Empty;

            if (Item.LeafContent.Any())
            {
                //if (MasterAccessor.Target.GetType().Name == Item.LeafContent[0].Primitive)
                //{

                foreach (var item in Item.LeafContent)
                {

                    //Componente 
                    //component += $"\r\n<DxLabel>{item.Field}</DxLabel>";
                    //Definición de controles

                    if (MasterAccessor.Target.GetType().Name == Item.LeafContent[0].Primitive)
                    {
                        var Turip = MasterAccessor.Target.GetType().GetProperty(item.Field);
                        VXMetaColumnAttributes MetaAttr = (VXMetaColumnAttributes)Attribute.GetCustomAttribute(Turip, typeof(VXMetaColumnAttributes));
                        string Var = Convert.ToString(Model.GetType().Name + "." + MasterAccessor.Target.GetType().Name + "." + item.Field);
                        //component += $"\r\n<VXFormComponent @bind-Field=\"@_{Var}\" @bind-Model=\"@_{Model.GetType().Name}.{Master.GetType().Name}\" />";
                        //component += $"\r\n<VXFormComponent2 @bind-Field=\"@_" + Var + "\" colspan=" + Convert.ToString(item.ColSpan) + " beginrow=" + item.BeginRow.ToString().ToLower() + " control=" + MetaAttr.Control + " description =" + MetaAttr.Description + " />";
                        string Data = (Model.GetType().Name + "." + MasterAccessor.Target.GetType().Name);
                        var Control = RenderComponent(MetaAttr.Control.ToString(), Var, MetaAttr, item, Turip, Data);
                        component += Control;

                    }
                    else
                    {
                        if (!dataGrid)
                        {
                            MasterAccessorStr = MasterAccessor.Target.GetType().Name;
                            component += $"\r\n<VxSlaveGridCreator2 Data=\"@_{(Model.GetType().Name + "." + Item.LeafContent[0].Primitive)}\" FieldAttributes=\"@_LayoutL\"/>";
                            dataGrid = true;
                        }



                    }
                }
            }
            if (Item.GroupContent.Any())
            {
                //foreach (var item in Item.GroupContent)
                //{
                //    component += $"\r\n<div class=\"m-2\" style=\"border: 1px solid #000;\">{BuildItem(item)}\r\n</div>";
                //}
                switch (Item.GroupAttribute.ContainerType)
                {
                    case VXLayOutGroupEnum.ControlContainer:
                        foreach (LayoutItem GroupItem in Item.GroupContent)
                        {
                            component += $"\r\n <DxFormLayoutGroup Caption=\"@{GroupItem.GroupAttribute.Description}\" ColSpanXl=\"{GroupItem.GroupAttribute.ColSpan}\" BeginRow={(GroupItem.GroupAttribute.BeginRow ? "true" : "false")} ColSpanXl=\"{GroupItem.GroupAttribute.ColSpan}>\r\n{BuildItem(GroupItem)}\r\n</DxFormLayoutGroup>";
                        }
                        break;
                    case VXLayOutGroupEnum.GroupContainer:

                        if (Item.GroupAttribute.IsTab)
                        {
                            foreach (LayoutItem GroupItem in Item.GroupContent)
                            {
                                component += $"\r\n <DxFormLayoutTabPages Caption=\"{Item.GroupAttribute.Description}\" ColSpanXl=\"{Item.GroupAttribute.ColSpan}\" >\r\n{BuildTabGroups(Item)}\r\n</DxFormLayoutTabPages>";
                            }

                        }
                        else
                        {
                            foreach (LayoutItem GroupItem in Item.GroupContent)
                            {
                                if (FirstIteration)
                                {
                                    component += $"\r\n  <DxFormLayoutGroup Caption=\"{Item.GroupAttribute.Description}\" ColSpanXl=\"{GroupItem.GroupAttribute.ColSpan}\" BeginRow={(GroupItem.GroupAttribute.BeginRow ? "true" : "false")}>\r\n{BuildItem(GroupItem)}\r\n</DxFormLayoutGroup>";
                                }
                                else
                                {
                                    component += $"\r\n <DxFormLayoutGroup Caption=\"{GroupItem.GroupAttribute.Description}\" ColSpanLg=\"{GroupItem.GroupAttribute.ColSpan}\" BeginRow={(GroupItem.GroupAttribute.BeginRow ? "true" : "false")}> \r\n{BuildItem(GroupItem)}\r\n</DxFormLayoutGroup>";
                                }
                            }
                        }
                        break;
                    case VXLayOutGroupEnum.GridContainerInPlace:
                        break;
                    case VXLayOutGroupEnum.GridContainerEditForm:
                        break;
                    case VXLayOutGroupEnum.GridContainerFormInPlace:
                        break;
                }
            }

            return component;

        }
        public string BuildTabGroups(LayoutItem Item)
        {
            string Component = string.Empty;
            if (Item.GroupContent.Any())
            {
                foreach (LayoutItem Tab in Item.GroupContent)
                {

                    Component += $"<DxFormLayoutTabPage Caption = \"{Tab.GroupAttribute.Description}\" ColSpanLg = \"{Tab.GroupAttribute.ColSpan}\" >\r\n{BuildItem(Tab)}\r\n</DxFormLayoutTabPage>";

                }
            }
            return Component;
        }
        private string RenderComponent(string control, string Field, VXMetaColumnAttributes MetaAttr, VXLayOutFieldAttribute FieldAttr, PropertyInfo _Turip, string _Model)
        {
            //string _component = $"\r\n<DxFormLayoutItem>";
            string _component = "";

            switch (MetaAttr.Control)
            {
                case VXColumnControl.TextEdit:
                    //_component += $"\r\n<VXFormComponent2 @bind-Field=\"_{Field}\" _control=\"{MetaAttr.Control}\" description=\"{MetaAttr.Description}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} Colspan={FieldAttr.ColSpan} />";

                    if (MetaAttr.Description == string.Empty)
                    {

                        _component += $"\r\n<DxFormLayoutItem Field = \"_{Field}\" Caption = \"_{Field}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd={FieldAttr.ColSpan} >";

                        _component += $"\r\n<DxTextBox @bind-Text =\"_{Field}\"/>";

                        _component += $"\r\n</DxFormLayoutItem>";

                    }
                    else
                    {

                        _component += $"\r\n<DxFormLayoutItem Field = \"_{Field}\" Caption =@L[\"{MetaAttr.Description}\"] BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd ={FieldAttr.ColSpan} >";

                        _component += $"\r\n<DxTextBox @bind-Text = \"_{Field}\" />";

                        _component += $"\r\n</DxFormLayoutItem >";
                    }
                    break;
                case VXColumnControl.SpinEdit:
                    //_component += $"\r\n<VXFormComponent2 IntValue=_{Field} _control=\"{MetaAttr.Control}\" description=\"{MetaAttr.Description}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} Colspan={FieldAttr.ColSpan}  />";
                    if (Field == string.Empty)
                    {

                        _component += $"\r\n<DxFormLayoutItem Field = \"_{Field}\" Caption = \"_{Field}\" BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd ={FieldAttr.ColSpan} >";

                        _component += $"\r\n <DxSpinEdit @bind-Value = \"_{Field}\" />";

                        _component += $"\r\n</DxFormLayoutItem >";

                    }
                    else
                    {

                        _component += $"\r\n<DxFormLayoutItem Field =\"_{Field}\" Caption =@L[\"{MetaAttr.Description}\"] BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd ={FieldAttr.ColSpan} >";

                        _component += $"\r\n<DxSpinEdit @bind-Value =\"_{Field}\" />";

                        _component += $"\r\n</DxFormLayoutItem >";


                    }
                    break;
                case VXColumnControl.DateEdit:
                    //_component += $"\r\n<VXFormComponent2 DateTimeValue=_{Field} _control=\"{MetaAttr.Control}\" description=\"{MetaAttr.Description}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} Colspan={FieldAttr.ColSpan}  />";
                    if (Field == string.Empty)
                    {

                        _component += $"\r\n<DxFormLayoutItem Field =\"_{Field}\" Caption =\"_{Field}\" BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd ={FieldAttr.ColSpan} >";

                        _component += $"\r\n<DxDateEdit @bind-Date =\"_{Field}\" />";

                        _component += $"\r\n</DxFormLayoutItem >";

                    }
                    else
                    {

                        _component += $"\r\n<DxFormLayoutItem Field =\"_{Field}\" Caption =@L[\"{MetaAttr.Description}\"] BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd={FieldAttr.ColSpan} >";

                        _component += $"\r\n<DxDateEdit @bind-Date =\"_{Field}\" />";

                        _component += $"\r\n</DxFormLayoutItem >";


                    }
                    break;
                case VXColumnControl.MemoEdit:
                    //_component += $"\r\n<VXFormComponent2 @bind-Field=\"_{Field}\" _control=\"{MetaAttr.Control}\" description=\"{MetaAttr.Description}\" AttributeField=\"{FieldAttr.Field}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} Colspan={FieldAttr.ColSpan} />";

					_component += $"\r\n<DxFormLayoutItem Caption =@L[\"{MetaAttr.Description}\"] BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd =12 CssClass=\"@({FieldAttr.ColSpan} > 0 ? $\"col-xxl-{FieldAttr.ColSpan}\" : string.Empty)\" >";
					_component += $"\r\n<DxMemo @bind-Text =\"@_{Field}\" Rows =\"5\" ResizeMode = \"MemoResizeMode.Vertical\"/> ";
					_component += $"\r\n</DxFormLayoutItem >";

					break;
                case VXColumnControl.ComboEnumEdit:
                    //_component += $"\r\n<VXFormComponent2 Field=_{Field} FieldAttrib=_{Field} _control=\"{MetaAttr.Control}\" description=\"{MetaAttr.Description}\" AttributeField=\"{FieldAttr.Field}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} Colspan={FieldAttr.ColSpan} />";
                    if (Field == string.Empty)
                    {

                        _component += $"\r\n<DxFormLayoutItem Field =\"_{Field}\" Caption =\"_{Field}\" BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd ={FieldAttr.ColSpan} >";

                        _component += $"\r\n<Template> />";
                        _component += $"\r\n<div class=\"d - flex\"> />";
                        _component += $"\r\n<div class=\"me-1 flex-grow-1 flex-shrink-1\">";
                        //_component += $"\r\n<DxComboBox Data = "@EnumOptionsList"";
                        //< DxComboBox Data = "@EnumOptionsList"

                        //    TextFieldName = "@nameof(ComboEnumWrapper.DisplayText)"

                        //    ValueFieldName = "@nameof(ComboEnumWrapper.Type)"

                        //    @bind - Value = "@Field" />

                        _component += $"\r\n</div> />";
                        _component += $"\r\n</div> />";
                        _component += $"\r\n</Template> />";

                        _component += $"\r\n</DxFormLayoutItem >";

                    }
                    else
                    {

                        _component += $"\r\n<DxFormLayoutItem Field =\"_{Field}\" Caption =@L[\"{MetaAttr.Description}\"] BeginRow ={FieldAttr.BeginRow.ToString().ToLower()} ColSpanMd={FieldAttr.ColSpan} >";

                        _component += $"\r\n<DxDateEdit @bind-Date =\"_{Field}\" />";

                        _component += $"\r\n</DxFormLayoutItem >";


                    }
                    break;
                case VXColumnControl.LookUpEdit:

                    _component += $"\r\n<VXFormComponent2 Field=_{Field} FieldAttrib=_{Field} _control=\"{MetaAttr.Control}\" description=\"{MetaAttr.Description}\" AttributeField=\"{FieldAttr.Field}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} Colspan={FieldAttr.ColSpan} LookUpPrimitive=\"{MetaAttr.LookUpPrimitive}\" TFields=\"{_Turip.PropertyType.Name}\" Model=\"@_{_Model}\"/>";
                    break;





                    //    //case VXColumnControl.LookUpEditDialog:
                    //    //    var TLookupd = MetaColumnAttributes.LookUpPrimitive != string.Empty ?
                    //    //            AppDomain.CurrentDomain
                    //    //                .GetAssemblies()
                    //    //                .SelectMany(t => t.GetTypes())
                    //    //                .Where(t => String.Equals(t.Name, MetaColumnAttributes.LookUpPrimitive, StringComparison.Ordinal))
                    //    //                .First()
                    //    //                : null;
                    //    //    var TFieldD = typeof(VxLookupEditDialog<,>).MakeGenericType(new Type[] { TLookupd, typeof(TField) });
                    //    //    __builder.OpenComponent(0, TFieldD);
                    //    //    //__builder.OpenComponent(0, typeof(VxLookupEdit<,>).MakeGenericType(new Type[] { TLookup, FieldType }));
                    //    //    //__builder.OpenComponent<VxLookupEdit>(0);
                    //    //    __builder.AddAttribute(1, "Field", Field);
                    //    //    __builder.AddAttribute(2, "LayoutFieldAttribute", LayoutFieldAttribute);
                    //    //    __builder.AddAttribute(2, "MetaColumnAttributes", MetaColumnAttributes);
                    //    //    __builder.CloseComponent();

                    //    //    //<VxLookupEditDialog @bind-Field="@Field" 
                    //    //    //					LayoutFieldAttribute="@LayoutFieldAttribute" 
                    //    //    //					MetaColumnAttributes="@MetaColumnAttributes" />
                    //    //    break;
                    //    //case VXColumnControl.None:
                    //    //    break;
                    //default:
                    //    //_component += $"\r\n<div>{Field}</div>";
                    //    _component += $"\r\n<VXFormComponent2 Field=_{Field} FieldAttrib=_{Field} _control=\"default\" description=\"{MetaAttr.Description}\" AttributeField=\"{FieldAttr.Field}\" BeginRow={FieldAttr.BeginRow.ToString().ToLower()} Colspan={FieldAttr.ColSpan} LookUpPrimitive=\"{MetaAttr.LookUpPrimitive}\" TFields=\"{_Turip.PropertyType.Name}\"/>";
                    //    break;
            }
            //_component += $"\r\n</DxFormLayoutItem>";
            return _component;
        }

        //public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
