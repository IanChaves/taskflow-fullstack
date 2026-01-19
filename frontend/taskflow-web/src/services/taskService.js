import axios from 'axios'

const api = axios.create({
  baseURL: 'https://localhost:7125/api/tasks',
})

export default {
  async getAll() {
    const res = await api.get('/')
    return res.data
  },

  async create(title) {
    await api.post('/', { title })
  },

  async toggle(id) {
    await api.put(`/${id}/toggle`)
  },

  async remove(id) {
    await api.delete(`/${id}`)
  },
}
