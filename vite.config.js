import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';
import tailwindcss from '@tailwindcss/vite';
import path from 'path';
import { fileURLToPath } from 'url';

const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

export default defineConfig({
  plugins: [react(), tailwindcss()],
  resolve: {
    alias: {
      '@': path.resolve(__dirname, 'src'),
    },
  },
  server: {
    allowedHosts: true,
    proxy: {

      '/api': {
        // target: 'https://mechanic-setu-backend.vercel.app', // <-- Bản gốc (Cloud)
        target: 'http://localhost:5275', // <-- Bản test Local / Ngrok
        changeOrigin: true,
        // secure: true,
        secure: false, // Local dùng http không chứng chỉ nên phải disable secure
      },
      
      '/ws': {
        // target: 'wss://mechanic-setu.onrender.com', // <-- Bản gốc (Cloud)
        target: 'ws://localhost:5275', // <-- Bản test Local / Ngrok
        ws: true,
        changeOrigin: true,
        // secure: true,
        secure: false,
      },
    },
  },
});
