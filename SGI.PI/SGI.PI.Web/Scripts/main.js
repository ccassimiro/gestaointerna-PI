import Vue from 'vue'
import App from '../src/App.vue'
import { Layout} from 'bootstrap-vue/es/components';
import {Nav, Navbar} from 'bootstrap-vue/es/components';
import router from '../src/components/router/index.js';
import store from '../src/store.js';
import { BButton } from 'bootstrap-vue';
import { library } from '@fortawesome/fontawesome-svg-core';
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome';
import { fas, faPlusCircle } from '@fortawesome/free-solid-svg-icons'
import { findIconDefinition, icon } from '@fortawesome/fontawesome-svg-core'
import { faCamera } from '@fortawesome/free-solid-svg-icons'


Vue.component('b-button', BButton)
Vue.use(Layout);
Vue.use(Nav);
Vue.use(Navbar);
Vue.component('font-awesome-icon', FontAwesomeIcon)

library.add(faPlusCircle)



new Vue({
  el: '#app',
  render: h => h(App),
  router: router,
  store: store,
})


export {
    App, router, store,
}