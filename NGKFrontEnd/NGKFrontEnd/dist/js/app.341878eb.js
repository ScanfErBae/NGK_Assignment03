(function(e){function t(t){for(var o,i,l=t[0],s=t[1],u=t[2],c=0,m=[];c<l.length;c++)i=l[c],Object.prototype.hasOwnProperty.call(a,i)&&a[i]&&m.push(a[i][0]),a[i]=0;for(o in s)Object.prototype.hasOwnProperty.call(s,o)&&(e[o]=s[o]);p&&p(t);while(m.length)m.shift()();return r.push.apply(r,u||[]),n()}function n(){for(var e,t=0;t<r.length;t++){for(var n=r[t],o=!0,l=1;l<n.length;l++){var s=n[l];0!==a[s]&&(o=!1)}o&&(r.splice(t--,1),e=i(i.s=n[0]))}return e}var o={},a={app:0},r=[];function i(t){if(o[t])return o[t].exports;var n=o[t]={i:t,l:!1,exports:{}};return e[t].call(n.exports,n,n.exports,i),n.l=!0,n.exports}i.m=e,i.c=o,i.d=function(e,t,n){i.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:n})},i.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},i.t=function(e,t){if(1&t&&(e=i(e)),8&t)return e;if(4&t&&"object"===typeof e&&e&&e.__esModule)return e;var n=Object.create(null);if(i.r(n),Object.defineProperty(n,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var o in e)i.d(n,o,function(t){return e[t]}.bind(null,o));return n},i.n=function(e){var t=e&&e.__esModule?function(){return e["default"]}:function(){return e};return i.d(t,"a",t),t},i.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},i.p="/";var l=window["webpackJsonp"]=window["webpackJsonp"]||[],s=l.push.bind(l);l.push=t,l=l.slice();for(var u=0;u<l.length;u++)t(l[u]);var p=s;r.push([0,"chunk-vendors"]),n()})({0:function(e,t,n){e.exports=n("56d7")},"54a8":function(e,t,n){},"56d7":function(e,t,n){"use strict";n.r(t);var o=n("2b0e"),a=function(){var e=this,t=e.$createElement,n=e._self._c||t;return n("div",{attrs:{id:"app"}},[n("Home",{attrs:{msg:"Hello world!"}})],1)},r=[],i=function(){var e=this,t=e.$createElement,n=e._self._c||t;return n("div",{staticClass:"home"},[n("input",{directives:[{name:"model",rawName:"v-model",value:e.name,expression:"name"}],attrs:{type:"text",placeholder:"Name"},domProps:{value:e.name},on:{input:function(t){t.target.composing||(e.name=t.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:e.email,expression:"email"}],attrs:{type:"text",placeholder:"Email"},domProps:{value:e.email},on:{input:function(t){t.target.composing||(e.email=t.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:e.password,expression:"password"}],attrs:{type:"password",placeholder:"Password"},domProps:{value:e.password},on:{input:function(t){t.target.composing||(e.password=t.target.value)}}}),n("br"),n("button",{staticClass:"get",on:{click:e.register}},[e._v("Register")]),n("br"),n("br"),n("br"),n("input",{directives:[{name:"model",rawName:"v-model",value:e.name1,expression:"name1"}],attrs:{type:"text",placeholder:"Name"},domProps:{value:e.name1},on:{input:function(t){t.target.composing||(e.name1=t.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:e.email1,expression:"email1"}],attrs:{type:"text",placeholder:"Email"},domProps:{value:e.email1},on:{input:function(t){t.target.composing||(e.email1=t.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:e.password1,expression:"password1"}],attrs:{type:"password",placeholder:"Password"},domProps:{value:e.password1},on:{input:function(t){t.target.composing||(e.password1=t.target.value)}}}),n("br"),n("button",{staticClass:"get",on:{click:e.login}},[e._v("Login")]),n("br"),n("br"),n("br"),n("input",{directives:[{name:"model",rawName:"v-model",value:e.name2,expression:"name2"}],attrs:{type:"text",placeholder:"Name"},domProps:{value:e.name2},on:{input:function(t){t.target.composing||(e.name2=t.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:e.lat,expression:"lat"}],attrs:{type:"text",placeholder:"Lat"},domProps:{value:e.lat},on:{input:function(t){t.target.composing||(e.lat=t.target.value)}}}),n("input",{directives:[{name:"model",rawName:"v-model",value:e.long,expression:"long"}],attrs:{type:"text",placeholder:"Long"},domProps:{value:e.long},on:{input:function(t){t.target.composing||(e.long=t.target.value)}}}),n("br"),n("button",{staticClass:"get",on:{click:e.postLocation}},[e._v("Post Location")]),n("br")])},l=[],s=(n("7f7f"),{name:"Home",data:function(){return{info:null,name:null,email:null,password:null,name1:null,name2:null,lat:null,long:null,email1:null,password1:null}},methods:{HandleErrors:function(e){if(!e.ok)throw Error(e.statusText);return e},register:function(){fetch("https://localhost:44384/api/Account/Register",{method:"POST",body:JSON.stringify({Email:this.email,Name:this.name,Password:this.password}),headers:new Headers({"Content-Type":"application/json"})}).then(this.HandleErrors).then(function(e){return console.log(e)}).catch(function(e){return console.log(e)})},login:function(){fetch("https://localhost:44384/api/Account/Login",{method:"POST",body:JSON.stringify({Email:this.email1,Name:this.name1,Password:this.password1}),headers:new Headers({"Content-Type":"application/json"})}).then(function(e){return e.json().then(function(t){localStorage.setItem("token",t),console.log(e)}).catch(function(e){return console.error("Error:",e)})})},postLocation:function(){var e="Bearer "+getSavedToken();fetch("https://localhost:44384/api/Account/Login",{method:"POST",withCredentials:!0,credentials:"include",body:JSON.stringify({Latitude:this.lat,Longitude:this.long,Name:this.name1}),headers:new Headers({Authorization:e,"Content-Type":"application/json"})}).then(function(e){JSON.parse(e._bodyInit)}).catch(function(e){return console.error("Error:",e)})}}}),u=s,p=(n("90aa"),n("2877")),c=Object(p["a"])(u,i,l,!1,null,"1104607c",null),m=c.exports,d={name:"app",components:{Home:m}},f=d,v=Object(p["a"])(f,a,r,!1,null,null,null),g=v.exports,h=n("bc3a"),w=n.n(h);o["a"].prototype.$http=w.a,o["a"].config.productionTip=!0,new o["a"]({render:function(e){return e(g)}}).$mount("#app")},"90aa":function(e,t,n){"use strict";var o=n("54a8"),a=n.n(o);a.a}});
//# sourceMappingURL=app.341878eb.js.map