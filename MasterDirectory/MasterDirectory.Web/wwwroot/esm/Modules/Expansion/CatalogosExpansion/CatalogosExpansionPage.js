import{a as g,b as c,c as p,d as i}from"../../../_chunks/chunk-CS7SSEFC.js";import{a as E}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as n,d as s,f,g as m}from"../../../_chunks/chunk-FEDAVPE7.js";var x=n(f(),1);var u=n(m(),1);var a=n(m(),1);var t=class extends a.EntityDialog{constructor(){super(...arguments);this.form=new c(this.idPrefix)}getFormKey(){return c.formKey}getRowDefinition(){return p}getService(){return i.baseUrl}};o(t,"CatalogosExpansionDialog"),t=s([a.Decorators.registerClass("MasterDirectory.Expansion.CatalogosExpansionDialog")],t);var l=n(E(),1);var e=class extends u.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return t}getRowDefinition(){return p}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(l.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(l.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(e,"CatalogosExpansionGrid"),e=s([u.Decorators.registerClass("MasterDirectory.Expansion.CatalogosExpansionGrid")],e);function w(){(0,x.initFullHeightGridPage)(new e($("#GridDiv")).element)}o(w,"pageInit");export{w as default};
//# sourceMappingURL=CatalogosExpansionPage.js.map
