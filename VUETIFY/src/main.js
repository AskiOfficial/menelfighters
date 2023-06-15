import { createApp } from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import './plugins/vuetify.js'

import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'

const vuetify = createVuetify({
    components,
    directives,
})

/* eslint-disable */
console.log('Ignore me'); // eslint-disable-line no-console
createApp(App).use(router).use(vuetify).mount('#app')
