import{a as g,b as c,c as a,d as i}from"../../../_chunks/chunk-EYKCN7UV.js";import{a as w}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as n,d as s,f as x,g as m}from"../../../_chunks/chunk-FEDAVPE7.js";var d=n(x(),1);var u=n(m(),1);var p=n(m(),1);var t=class extends p.EntityDialog{constructor(){super(...arguments);this.form=new c(this.idPrefix)}getFormKey(){return c.formKey}getRowDefinition(){return a}getService(){return i.baseUrl}};o(t,"CatalogosFinanzasDialog"),t=s([p.Decorators.registerClass("MasterDirectory.Finanzas.CatalogosFinanzasDialog")],t);var l=n(w(),1);var e=class extends u.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return t}getRowDefinition(){return a}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(l.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(l.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(e,"CatalogosFinanzasGrid"),e=s([u.Decorators.registerClass("MasterDirectory.Finanzas.CatalogosFinanzasGrid")],e);function y(){(0,d.initFullHeightGridPage)(new e($("#GridDiv")).element)}o(y,"pageInit");export{y as default};
//# sourceMappingURL=CatalogosFinanzasPage.js.map
