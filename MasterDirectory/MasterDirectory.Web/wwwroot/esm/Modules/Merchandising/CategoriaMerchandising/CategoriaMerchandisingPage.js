import{e as m,f as l,g as p,h as i}from"../../../_chunks/chunk-KNOLGFNP.js";import{a as w}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as s,d as a,f as x,g}from"../../../_chunks/chunk-FEDAVPE7.js";var d=s(x(),1);var c=s(g(),1);var n=s(g(),1);var e=class extends n.EntityDialog{constructor(){super();this.form=new l(this.idPrefix)}dialogOpen(h){super.dialogOpen(h)}getFormKey(){return l.formKey}getRowDefinition(){return p}getService(){return i.baseUrl}};o(e,"CategoriaMerchandisingDialog"),e=a([n.Decorators.registerClass("MasterDirectory.Merchandising.CategoriaMerchandisingDialog"),n.Decorators.panel()],e);var u=s(w(),1);var t=class extends c.EntityGrid{getColumnsKey(){return m.columnsKey}getDialogType(){return e}getRowDefinition(){return p}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(u.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(u.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(t,"CategoriaMerchandisingGrid"),t=a([c.Decorators.registerClass("MasterDirectory.Merchandising.CategoriaMerchandisingGrid")],t);function y(){(0,d.initFullHeightGridPage)(new t($("#GridDiv")).element)}o(y,"pageInit");export{y as default};
//# sourceMappingURL=CategoriaMerchandisingPage.js.map