import{i as d,j as m,k as p,l as c}from"../../../_chunks/chunk-KNOLGFNP.js";import{a as w}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as n,d as s,f as x,g as l}from"../../../_chunks/chunk-FEDAVPE7.js";var g=n(x(),1);var a=n(l(),1);var i=n(l(),1);var e=class extends i.EntityDialog{constructor(){super();this.form=new m(this.idPrefix);this.form.LocalSap.element.css("height","50px"),this.form.LocalSap.element.css("font-size","medium"),this.form.TipoSucursal.element.css("font-size","medium"),this.form.TipoSucursal.element.css("height","50px")}dialogOpen(h){super.dialogOpen(h)}getFormKey(){return m.formKey}getRowDefinition(){return p}getService(){return c.baseUrl}};o(e,"CatMerchandisingDialog"),e=s([i.Decorators.registerClass("MasterDirectory.Merchandising.CatMerchandisingDialog"),i.Decorators.panel()],e);var u=n(w(),1);var t=class extends a.EntityGrid{getColumnsKey(){return d.columnsKey}getDialogType(){return e}getRowDefinition(){return p}getService(){return c.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(u.ExcelExportHelper.createToolButton({grid:this,onViewSubmit:()=>this.onViewSubmit(),service:"/ListExcel",title:"Exportar Excel",separator:!0})),r.push(u.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(t,"CatMerchandisingGrid"),t=s([a.Decorators.registerClass("MasterDirectory.Merchandising.CatMerchandisingGrid")],t);function y(){(0,g.initFullHeightGridPage)(new t($("#GridDiv")).element)}o(y,"pageInit");export{y as default};
//# sourceMappingURL=CatMerchandisingPage.js.map