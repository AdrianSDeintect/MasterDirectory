import{a as g,b as l,c as p,d as i}from"../../../_chunks/chunk-XLCSKWNS.js";import{a as w}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as s,d as n,f as x,g as m}from"../../../_chunks/chunk-FEDAVPE7.js";var d=s(x(),1);var c=s(m(),1);var a=s(m(),1);var e=class extends a.EntityDialog{constructor(){super(...arguments);this.form=new l(this.idPrefix)}getFormKey(){return l.formKey}getRowDefinition(){return p}getService(){return i.baseUrl}};o(e,"CatalogosOperacionesDialog"),e=n([a.Decorators.registerClass("MasterDirectory.Operaciones.CatalogosOperacionesDialog")],e);var u=s(w(),1);var t=class extends c.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return e}getRowDefinition(){return p}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(u.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(u.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(t,"CatalogosOperacionesGrid"),t=n([c.Decorators.registerClass("MasterDirectory.Operaciones.CatalogosOperacionesGrid")],t);function y(){(0,d.initFullHeightGridPage)(new t($("#GridDiv")).element)}o(y,"pageInit");export{y as default};
//# sourceMappingURL=CatalogosOperacionesPage.js.map
