import { useEffect, useRef, useState } from 'react';
import {
  Rocket,
  Zap
} from 'lucide-react';
import PropTypes from 'prop-types';
import { Link, Outlet, Route, Routes, useLocation, useNavigate } from 'react-router-dom';
import { Toaster, toast } from 'react-hot-toast';
import './App.css';

import MainPage from './Page/MainPage';
import NewLogin from './Page/auth/NewLogin';
import NewRegister from './Page/auth/NewRegister';
import OTP from './Page/auth/OTP';
import Logout from './Page/auth/Logout';
import ProcessForm from './Page/auth/ProcessForm';
import PunctureRequestForm from './Page/PunctureRequestForm';
import ProfilePage from './Page/ProfilePage';
import MechanicFound from './Page/MechanicFound';
import RequestLayout from './Page/RequestLayout';
import FindingMechanic from './Page/FindingMechanic';
import NearbyMechanicsPage from './Page/NearbyMechanics';
import MechanicRegistration from './Page/MechanicRegistration';
import MechanicList from './Page/MechanicList';
import MechanicDetail from './Page/MechanicDetail';
import RCInfo from './Page/RCInfo';
import VehicleDashboard from './Page/Dashboard/VehicleDashboard';
import VehicleDetails from './Page/Dashboard/VehicleDetails';
import VehicleAdmin from './Page/Dashboard/VehicleAdmin';
import VehicleAdminDetail from './Page/Dashboard/VehicleAdminDetail';
import NotFound from './Page/NotFound';
import Protected from './ProtectedRoute';
import NavbarLanding from './components/NavbarLanding';
import { WebSocketProvider, useWebSocket } from './context/WebSocketContext';
import api from './utils/api';
import TermsAndConditions from './Page/TermsAndConditions';
import PrivacyPolicy from './Page/PrivacyPolicy';
import BrandGuidelines from './Page/BrandGuidelines';

const LANDING_ISSUES = ['Thủng lốp', 'Xe không nổ máy', 'Sự cố động cơ', 'Cứu hộ kéo xe'];
const LANDING_LOCATIONS = [
  'Hai Chau',
  'Thanh Khe',
  'Son Tra',
  'Ngu Hanh Son',
  'Lien Chieu',
  'Cam Le',
  'Hoa Vang',
  'Dragon Bridge',
  'Han River'
];
const LANDING_FAQS = [
  {
    q: 'Xe bị thủng lốp ở cầu Rồng hay cầu Sông Hàn?',
    a: 'Đừng lo! MotorSafe cung cấp dịch vụ sửa khóa và vá lốp tận nơi nhanh nhất tại Hải Châu, Sơn Trà và Thanh Khê.'
  },
  {
    q: 'Các bạn có cứu hộ nhanh ở Ngũ Hành Sơn không?',
    a: 'Có! Chúng tôi chuyên xử lý khẩn cấp như vá lốp và kích bình điện. Đội ngũ thợ của chúng tôi thông thuộc mọi ngõ ngách Đà Nẵng.'
  }
];

function LandingHero({ error = '', loading, issues, onBookMechanic, onDetectLocation }) {
  return (
    <section className="relative min-h-[80vh] sm:min-h-[90vh] flex flex-col justify-center items-center bg-gradient-to-b from-blue-50 to-white px-4 sm:px-6 overflow-hidden">
      <div className="absolute top-0 left-0 w-full h-full overflow-hidden z-0 pointer-events-none">
        <div className="absolute top-[-10%] left-[-10%] w-72 h-72 sm:w-96 sm:h-96 bg-blue-400 rounded-full mix-blend-multiply filter blur-3xl opacity-20 animate-blob" />
        <div className="absolute top-[-10%] right-[-10%] w-72 h-72 sm:w-96 sm:h-96 bg-purple-400 rounded-full mix-blend-multiply filter blur-3xl opacity-20 animate-blob animation-delay-2000" />
        <div className="absolute bottom-[-20%] left-[20%] w-72 h-72 sm:w-96 sm:h-96 bg-pink-400 rounded-full mix-blend-multiply filter blur-3xl opacity-20 animate-blob animation-delay-4000" />
      </div>

      <div className="relative z-10 max-w-4xl w-full text-center">
        <div className="inline-block mb-4 px-4 py-1.5 rounded-full bg-gray-100 text-violet-600 text-sm font-medium">
          <span className="flex mx-2">
            <Rocket className="w-4 mx-1 text-violet-600" />
            #1 Cứu hộ giao thông tại Đà Nẵng
          </span>
        </div>
        <h1 className="text-4xl sm:text-5xl md:text-7xl font-bold mb-6 text-slate-900 tracking-tight leading-tight">
          Xe gặp sự cố giữa đường? <br />
          <span className="text-transparent bg-clip-text bg-gradient-to-r from-blue-600 to-violet-600">
            Có thợ sửa xe trong{' '}
            <span className="inline-block rounded-2xl border border-zinc-200 bg-white/30 px-3 py-1 rotate-[-12deg] -translate-y-2 shadow-[0_12px_28px_rgba(0,0,0,0.22)]">
              <span className="font-black text-transparent bg-clip-text bg-gradient-to-r from-blue-600 to-violet-600 -my-12">
                Tích tắc
              </span>
            </span>.
          </span>

        </h1>
        <p className="text-base sm:text-xl text-slate-600 mb-10 max-w-2xl mx-auto">
          Ứng dụng cứu hộ khẩn cấp cho sự cố xe máy của bạn.
        </p>

        {error && (
          <div className="mb-6 p-3 bg-red-50 text-red-600 rounded-lg text-sm border border-red-100">
            {error}
          </div>
        )}

        <div className="flex flex-col sm:flex-row gap-4 justify-center mb-12">
          <button
            type="button"
            onClick={onBookMechanic}
            className="w-full sm:w-auto flex items-center justify-center px-6 sm:px-8 py-3.5 sm:py-4 text-base sm:text-lg font-bold text-white bg-blue-600 rounded-xl hover:bg-blue-700 transition-all shadow-lg hover:shadow-blue-500/30"
          >
            <Zap className="w-5 h-5 mr-2" />
            Đặt thợ sửa xe
          </button>


        </div>

        <div className="flex flex-wrap justify-center gap-3">
          {issues.map((issue) => (
            <span
              key={issue}
              className="px-3 sm:px-4 py-1.5 sm:py-2 bg-white/80 backdrop-blur-sm border border-slate-200 rounded-full text-xs sm:text-sm text-slate-600 shadow-sm"
            >
              {issue}
            </span>
          ))}
        </div>
      </div>
    </section>
  );
}

LandingHero.propTypes = {
  error: PropTypes.string,
  loading: PropTypes.bool.isRequired,
  issues: PropTypes.arrayOf(PropTypes.string).isRequired,
  onBookMechanic: PropTypes.func.isRequired,
  onDetectLocation: PropTypes.func.isRequired
};


function LandingPage() {
  const navigate = useNavigate();
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState('');

  useEffect(() => {
    let isMounted = true;

    const checkAuthAndRedirect = async () => {
      try {
        await api.get('core/me/', { skipAuthRedirect: true });
        if (isMounted) navigate('/home', { replace: true });
      } catch {
        // Keep showing the public landing page when unauthenticated.
      }
    };

    checkAuthAndRedirect();
    return () => {
      isMounted = false;
    };
  }, [navigate]);

  const handleDetectLocation = () => {
    setLoading(true);
    setError('');

    if (!navigator.geolocation) {
      setError('Trình duyệt không hỗ trợ định vị');
      setLoading(false);
      return;
    }

    navigator.geolocation.getCurrentPosition(
      () => {
        navigate('/nearby-mechanics');
        setLoading(false);
      },
      () => {
        setError('Không thể lấy vị trí. Vui lòng bật GPS.');
        setLoading(false);
      }
    );
  };

  return (
    <main id="top" className="bg-white min-h-screen pt-16 md:pt-0 lg:pt-16 sm:pt-20">
      <NavbarLanding />
      <LandingHero
        error={error}
        loading={loading}
        issues={LANDING_ISSUES}
        onBookMechanic={() => navigate('/login')}
        onDetectLocation={handleDetectLocation}
      />
      <footer className="py-8 bg-white border-t border-slate-100">
        <div className="max-w-[1280px] mx-auto px-4 text-center">
          <p className="text-slate-500 text-sm">
            &copy; 2026 MotorSafe. Bảo lưu mọi quyền.
          </p>
        </div>
      </footer>
    </main>
  );
}

const GlobalSocketHandler = () => {
  const { lastMessage } = useWebSocket();
  const navigate = useNavigate();
  const location = useLocation();

  useEffect(() => {
    if (!lastMessage) return;

    const jobFinished =
      lastMessage.type === 'job_completed' ||
      lastMessage.type === 'job_cancelled' ||
      lastMessage.type === 'job_cancelled_notification';
    const noMechanicFound = lastMessage.type === 'no_mechanic_found';

    if (jobFinished || noMechanicFound) {
      console.log(`GLOBAL HANDLER: Job event type "${lastMessage.type}". Clearing active job from localStorage.`);

      localStorage.removeItem('activeJobData');
      localStorage.removeItem('punctureRequestFormData');

      if (noMechanicFound) {
        toast.error(lastMessage.message || 'Không tìm thấy thợ sửa xe. Đang hiển thị các lựa chọn gần đây.');
      } else {
        toast.success(lastMessage.message || 'Yêu cầu của bạn đã được hoàn thành.');
      }

      const isOnJobRelatedPage =
        location.pathname.startsWith('/finding/') || location.pathname.startsWith('/mechanic-found/');

      if (noMechanicFound) {
        navigate('/nearby-mechanics');
      } else if (location.pathname === '/' || isOnJobRelatedPage) {
        const timerId = setTimeout(() => {
          if (location.pathname === '/') {
            window.location.reload();
          } else {
            navigate('/');
          }
        }, 2000);
        return () => clearTimeout(timerId);
      }
    }
  }, [lastMessage, navigate, location.pathname]);

  return null;
};

const ProtectedShell = () => (
  <Protected>
    <WebSocketProvider>
      <GlobalSocketHandler />
      <Outlet />
    </WebSocketProvider>
  </Protected>
);

function getActiveJob() {
  const rawValue = localStorage.getItem('activeJobData');
  if (!rawValue) return null;

  try {
    return JSON.parse(rawValue);
  } catch {
    return null;
  }
}

export default function App() {
  const activeJob = getActiveJob();
  const location = useLocation();

  return (
    <div className="App transition-all duration-500 ease-in-out bg-white">
      <Toaster position="top-right" reverseOrder={false} />

      {activeJob?.request_id && !location.pathname.startsWith('/finding') && !location.pathname.startsWith('/mechanic-found') && (
        <div
          className="bg-blue-600 text-white font-bold min-w-screen w-full p-3 cursor-pointer text-center"
          onClick={() => {
            // Basic heuristic: if mechanic details are in localstorage, it implies mechanic is found
            if (activeJob.mechanic_details) {
              window.location.href = `/mechanic-found/${activeJob.request_id}`;
            } else {
              window.location.href = `/finding/${activeJob.request_id}`;
            }
          }}
        >
          Đơn hàng đang hoạt động #{activeJob.request_id} (Nhấn để xem)
        </div>
      )}

      <Routes>
        <Route path="/" element={<LandingPage />} />
        <Route path="/login" element={<NewLogin />} />
        <Route path="/register" element={<NewRegister />} />
        <Route path="/verify" element={<OTP />} />
        <Route path="/logout" element={<Logout />} />
        <Route path="/nearby-mechanics" element={<NearbyMechanicsPage />} />
        <Route path="/vehicle-rc" element={<RCInfo />} />


        <Route path="/PrivacyPolicy" element={<PrivacyPolicy />} />
        <Route path="/TermsAndConditions" element={<TermsAndConditions />} />
        <Route path="/BrandGuidelines" element={<BrandGuidelines />} />



        <Route element={<ProtectedShell />}>
          <Route path="/home" element={<MainPage />} />
          <Route path="/profile" element={<ProfilePage />} />
          <Route path="/form" element={<ProcessForm />} />
          <Route path="/request" element={<PunctureRequestForm />} />
          <Route path="/ms" element={<MechanicRegistration />} />
          <Route path="/ms/list" element={<MechanicList />} />
          <Route path="/ms/view/:id" element={<MechanicDetail />} />
          <Route path="/ms/edit/:id" element={<MechanicRegistration />} />
          <Route path="/vehicle-rc" element={<RCInfo />} />
          <Route path="/admin/vehicles" element={<VehicleAdmin />} />
          <Route path="/admin/vehicles/:id" element={<VehicleAdminDetail />} />
          <Route path="/dashboard/vehicles" element={<VehicleDashboard />} />
          <Route path="/dashboard/vehicles/:id" element={<VehicleDetails />} />

          <Route element={<RequestLayout />}>
            <Route path="/finding/:request_id" element={<FindingMechanic />} />
            <Route path="/mechanic-found/:request_id" element={<MechanicFound />} />
          </Route>
        </Route>

        <Route path="*" element={<NotFound />} />
      </Routes>
    </div>
  );
}
