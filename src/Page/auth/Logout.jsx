import React, { useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import api from '../../utils/api';
import { toast } from 'react-hot-toast';

const Logout = () => {
  const navigate = useNavigate();

  useEffect(() => {
    const doLogout = () => {
      // Clear any client-side auth state/storage
      localStorage.clear();
      sessionStorage.clear();
      document.cookie = "access=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
      document.cookie = "refresh=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
      
      window.dispatchEvent(new Event("authChange"));
      toast.success("Đăng xuất thành công!");
      
      setTimeout(() => {
        navigate('/', { replace: true });
        window.location.reload(); // Hard reload to clear all states
      }, 500); // Đợi nửa giây cho mượt
    };
    doLogout();
  }, [navigate]);

  return <div />;
};

export default Logout;
