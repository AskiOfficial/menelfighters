import { createRouter, createWebHashHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import AboutView from '../views/AboutView'
import DownloadView from "@/views/DownloadView";
import MariuszView from "@/views/postacie/MariuszView";

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/about',
    name: 'about',
    component: AboutView
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.

  },
  {
    path: '/download',
    name: 'download',
    component: DownloadView
  },
  {
    path: '/about/mariusz',
    name: 'mariusz',
    component: MariuszView
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
