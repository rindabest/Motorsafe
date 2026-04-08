import axios from "axios";

// Đọc VITE_API_URL từ biến môi trường trên Vercel, hoặc fallback về "/api"
const apiVercel = axios.create({
    baseURL: import.meta.env.VITE_API_URL || "/api",
    withCredentials: true,
});

export default apiVercel;
