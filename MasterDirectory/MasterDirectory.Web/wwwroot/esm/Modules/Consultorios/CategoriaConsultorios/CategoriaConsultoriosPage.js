import{e as g,f as c,g as p,h as i}from"../../../_chunks/chunk-44FX4MTB.js";import{a as w}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as n,d as u,f as x,g as m}from"../../../_chunks/chunk-FEDAVPE7.js";var d=n(x(),1);var l=n(m(),1);var s=n(m(),1);var t=class extends s.EntityDialog{constructor(){super();this.form=new c(this.idPrefix)}dialogOpen(C){super.dialogOpen(C)}getFormKey(){return c.formKey}getRowDefinition(){return p}getService(){return i.baseUrl}};o(t,"CategoriaConsultoriosDialog"),t=u([s.Decorators.registerClass("MasterDirectory.Consultorios.CategoriaConsultoriosDialog"),s.Decorators.panel()],t);var a=n(w(),1);var e=class extends l.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return t}getRowDefinition(){return p}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(a.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(a.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(e,"CategoriaConsultoriosGrid"),e=u([l.Decorators.registerClass("MasterDirectory.Consultorios.CategoriaConsultoriosGrid")],e);function y(){(0,d.initFullHeightGridPage)(new e($("#GridDiv")).element)}o(y,"pageInit");export{y as default};
//# sourceMappingURL=CategoriaConsultoriosPage.js.map
