import { createRouter, createWebHistory } from 'vue-router'
import TasksView from '../views/TasksView.vue'

const routes = [
  {
    path: '/',
    name: 'tasks',
    component: TasksView,
  },
]

export default createRouter({
  history: createWebHistory(),
  routes,
})
