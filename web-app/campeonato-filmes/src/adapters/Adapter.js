import axios from 'axios';

const api = axios.create(
    {
        baseURL: 'http://localhost:7654/api'
    },
);

export default api;