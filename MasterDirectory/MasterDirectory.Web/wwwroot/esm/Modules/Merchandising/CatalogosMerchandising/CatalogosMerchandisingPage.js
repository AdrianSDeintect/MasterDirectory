import{a as g,b as u,c,d as i}from"../../../_chunks/chunk-7AMZQNXU.js";import{a as x}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as s,d as a,f as h,g as m}from"../../../_chunks/chunk-FEDAVPE7.js";var d=s(h(),1);var p=s(m(),1);var e=class extends p.EntityDialog{constructor(){super(...arguments);this.form=new u(this.idPrefix)}getFormKey(){return u.formKey}getRowDefinition(){return c}getService(){return i.baseUrl}};o(e,"CatalogosMerchandisingDialog"),e=a([p.Decorators.registerClass("MasterDirectory.Merchandising.CatalogosMerchandisingDialog")],e);var n=s(m(),1),l=s(x(),1);var t=class extends n.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return e}getRowDefinition(){return c}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(l.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(l.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(t,"CatalogosMerchandisingGrid"),t=a([n.Decorators.filterable(),n.Decorators.registerClass("MasterDirectory.Merchandising.CatalogosMerchandisingGrid")],t);function w(){(0,d.initFullHeightGridPage)(new t($("#GridDiv")).element)}o(w,"pageInit");export{w as default};
//# sourceMappingURL=CatalogosMerchandisingPage.js.map
