import{e as g,f as l,g as p,h as i}from"../../../_chunks/chunk-EYKCN7UV.js";import{a as y}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as a,d as s,f as w,g as m}from"../../../_chunks/chunk-FEDAVPE7.js";var d=a(w(),1);var u=a(m(),1);var n=a(m(),1);var e=class extends n.EntityDialog{constructor(){super();this.form=new l(this.idPrefix)}dialogOpen(x){super.dialogOpen(x)}getFormKey(){return l.formKey}getRowDefinition(){return p}getService(){return i.baseUrl}};o(e,"CategoriaFinanzasDialog"),e=s([n.Decorators.registerClass("MasterDirectory.Finanzas.CategoriaFinanzasDialog"),n.Decorators.panel()],e);var c=a(y(),1);var t=class extends u.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return e}getRowDefinition(){return p}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(c.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(c.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(t,"CategoriaFinanzasGrid"),t=s([u.Decorators.registerClass("MasterDirectory.Finanzas.CategoriaFinanzasGrid")],t);function b(){(0,d.initFullHeightGridPage)(new t($("#GridDiv")).element)}o(b,"pageInit");export{b as default};
//# sourceMappingURL=CategoriaFinanzasPage.js.map
