import{b as i}from"../../../../_chunks/chunk-DZEAZ5MW.js";import{a as e}from"../../../../_chunks/chunk-76FW2MMC.js";import{a as o,c as s,f as c,g as u}from"../../../../_chunks/chunk-FEDAVPE7.js";var m=s(u(),1),t=s(c(),1);$(function(){new r($("#ForgotPasswordPanel"))});var r=class extends m.PropertyPanel{getFormKey(){return i.formKey}constructor(n){super(n),this.byId("SubmitButton").click(a=>{if(a.preventDefault(),!!this.validateForm()){var l=this.getSaveEntity();(0,t.serviceCall)({url:(0,t.resolveUrl)("~/Account/ForgotPassword"),request:l,onSuccess:d=>{(0,t.information)(e.Forms.Membership.ForgotPassword.SuccessMessage,()=>{window.location.href=(0,t.resolveUrl)("~/")})}})}})}getTemplate(){return`<h2 class="text-center p-4">
    <img src="${(0,t.resolveUrl)("~/Content/site/images/DM_Admin.png")}"
      class="p-1" style="width: -webkit-fill-available; height: -webkit-fill-available /> 
</h2>

<div class="s-Panel p-4">
    <h5 class="text-center mb-4">${(0,t.htmlEncode)(e.Forms.Membership.ForgotPassword.FormTitle)}</h5>
    <p class="text-center">${(0,t.htmlEncode)(e.Forms.Membership.ForgotPassword.FormInfo)}</p>
    <form id="~_Form" action="">
        <div id="~_PropertyGrid"></div>
        <button id="~_SubmitButton" type="submit" class="btn btn-primary mx-8 w-100">
            ${(0,t.htmlEncode)(e.Forms.Membership.ForgotPassword.SubmitButton)}
        </button>
    </form>
</div>`}};o(r,"ForgotPasswordPanel");export{r as ForgotPasswordPanel};
//# sourceMappingURL=ForgotPasswordPage.js.map
