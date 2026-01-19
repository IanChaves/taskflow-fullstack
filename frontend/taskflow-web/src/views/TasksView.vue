<template>
  <div class="container">
    <h1>TaskFlow</h1>

    <form @submit.prevent="addTask">
      <input v-model="newTask" placeholder="Nova tarefa..." />
      <button>Adicionar</button>
    </form>

    <ul>
      <li v-for="task in tasks" :key="task.id">
        <span :class="{ done: task.isCompleted }">
          {{ task.title }}
        </span>

        <button @click="toggleTask(task.id)">✔</button>
        <button @click="deleteTask(task.id)">🗑</button>
      </li>
    </ul>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import taskService from '../services/taskService'

const tasks = ref([])
const newTask = ref('')

async function loadTasks() {
  tasks.value = await taskService.getAll()
}

async function addTask() {
  if (!newTask.value) return
  await taskService.create(newTask.value)
  newTask.value = ''
  loadTasks()
}

async function toggleTask(id) {
  await taskService.toggle(id)
  loadTasks()
}

async function deleteTask(id) {
  await taskService.remove(id)
  loadTasks()
}

onMounted(loadTasks)
</script>

<style scoped>
.container {
  max-width: 500px;
  margin: 40px auto;
  background: white;
  padding: 20px;
  border-radius: 8px;
}

.done {
  text-decoration: line-through;
  color: #999;
}

li {
  display: flex;
  justify-content: space-between;
  margin: 10px 0;
}
</style>
