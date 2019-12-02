import Vue from 'vue';
import App from './App.vue';
import axios from 'axios';

//import socketio from 'socket.io-client';
//import VueSocketIO from 'vue-socket.io';

//export const SocketInstance = socketio('http://localhost:1337');

//Vue.use(VueSocketIO, SocketInstance);

Vue.prototype.$http = axios;
Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
