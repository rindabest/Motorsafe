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
        target: 'https://mechanic-setu-backend.vercel.app',
        changeOrigin: true,
        secure: true,
      },
      
      '/ws': {
        target: 'wss://mechanic-setu.onrender.com',
        ws: true,
        changeOrigin: true,
        secure: true,
      },
    },
  },
});
