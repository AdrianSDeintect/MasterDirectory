import{a as g,b as u,c as s,d as i}from"../../../_chunks/chunk-PKJXX6LC.js";import{a as x}from"../../../_chunks/chunk-HHAWTOGR.js";import{a as o,c as n,d as a,f as b,g as c}from"../../../_chunks/chunk-FEDAVPE7.js";var d=n(b(),1);var p=n(c(),1);var l=n(c(),1);var t=class extends l.EntityDialog{constructor(){super(...arguments);this.form=new u(this.idPrefix)}getFormKey(){return u.formKey}getRowDefinition(){return s}getService(){return i.baseUrl}};o(t,"CatalogosInmobiliariaDialog"),t=a([l.Decorators.registerClass("MasterDirectory.Inmobiliaria.CatalogosInmobiliariaDialog")],t);var m=n(x(),1);var e=class extends p.EntityGrid{getColumnsKey(){return g.columnsKey}getDialogType(){return t}getRowDefinition(){return s}getService(){return i.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push(m.ExcelExportHelper.createToolButton({grid:this,service:i.baseUrl+"/ListExcel",onViewSubmit:()=>this.onViewSubmit(),title:"Exportar Excel",separator:!0})),r.push(m.PdfExportHelper.createToolButton({grid:this,title:"Exportar PDF",onViewSubmit:()=>this.onViewSubmit()})),r}};o(e,"CatalogosInmobiliariaGrid"),e=a([p.Decorators.registerClass("MasterDirectory.Inmobiliaria.CatalogosInmobiliariaGrid")],e);function w(){(0,d.initFullHeightGridPage)(new e($("#GridDiv")).element)}o(w,"pageInit");export{w as default};
//# sourceMappingURL=CatalogosInmobiliariaPage.js.map