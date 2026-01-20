<template>
  <div class="page">
    <div class="card">
      <h1>TaskFlow</h1>
      <p class="subtitle">Simple task manager</p>

      <form class="task-form" @submit.prevent="addTask">
        <input v-model="newTask" placeholder="What do you need to do?" />
        <button>Add</button>
      </form>

      <ul class="task-list">
        <li v-for="task in tasks" :key="task.id" :class="{ done: task.isCompleted }">
          <span @click="toggleTask(task.id)">
            {{ task.title }}
          </span>

          <button class="delete" @click="deleteTask(task.id)">✕</button>
        </li>
      </ul>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import taskService from './services/taskService'

const tasks = ref([])
const newTask = ref('')

async function loadTasks() {
  tasks.value = await taskService.getAll()
}

async function addTask() {
  if (!newTask.value.trim()) return
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
.page {
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  background: linear-gradient(135deg, #667eea, #764ba2);
  font-family: Inter, system-ui, sans-serif;
}

.card {
  width: 100%;
  max-width: 420px;
  background: white;
  padding: 32px;
  border-radius: 16px;
  box-shadow: 0 20px 40px rgba(0, 0, 0, 0.15);
}

h1 {
  margin: 0;
  text-align: center;
}

.subtitle {
  text-align: center;
  color: #666;
  margin-bottom: 24px;
}

.task-form {
  display: flex;
  gap: 8px;
  margin-bottom: 24px;
}

.task-form input {
  flex: 1;
  padding: 12px;
  border-radius: 8px;
  border: 1px solid #ddd;
  font-size: 14px;
}

.task-form input:focus {
  outline: none;
  border-color: #667eea;
}

.task-form button {
  padding: 12px 16px;
  border-radius: 8px;
  border: none;
  background: #667eea;
  color: white;
  font-weight: 600;
  cursor: pointer;
}

.task-form button:hover {
  background: #5a67d8;
}

.task-list {
  list-style: none;
  padding: 0;
  margin: 0;
}

.task-list li {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 12px;
  border-radius: 8px;
  margin-bottom: 8px;
  background: #f7f7f7;
  transition: background 0.2s;
}

.task-list li:hover {
  background: #eee;
}

.task-list span {
  cursor: pointer;
}

.task-list li.done span {
  text-decoration: line-through;
  color: #999;
}

.delete {
  border: none;
  background: transparent;
  font-size: 18px;
  cursor: pointer;
  color: #999;
}

.delete:hover {
  color: #e53e3e;
}
</style>
