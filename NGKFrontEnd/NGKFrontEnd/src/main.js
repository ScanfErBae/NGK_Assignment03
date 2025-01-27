import Vue from 'vue';
import App from './App.vue';
import axios from 'axios';
//import socketio from 'socket.io';

Vue.prototype.$http = axios;
Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
