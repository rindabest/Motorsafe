import React, { useState, useEffect, useRef } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { motion, AnimatePresence } from 'framer-motion';
import { Car, Bike, Clock, Loader, Phone, Wifi, WifiOff, X, MapPin, Wrench, NotebookPen, Star, Route, ChevronLeft, ShieldCheck } from 'lucide-react';
import toast from 'react-hot-toast';
import api from '../utils/api';
import { useWebSocket } from '../context/WebSocketContext';
import OrderDetailsCard from '../components/OrderDetailsCard';
import maplibregl from 'maplibre-gl';
import 'maplibre-gl/dist/maplibre-gl.css';

export default function FindingMechanic() {
  const { request_id } = useParams();
  const navigate = useNavigate();

  const [searchTime, setSearchTime] = useState(0);
  const [isCancelModalOpen, setCancelModalOpen] = useState(false);
  const [selectedReason, setSelectedReason] = useState('');
  const [username, setUsername] = useState('User');
  const [userLocation, setUserLocation] = useState(null);
  const [foundMechanics, setFoundMechanics] = useState([]);
  const [selectedMechanic, setSelectedMechanic] = useState(null);
  const [sortBy, setSortBy] = useState('distance'); // 'distance' | 'price'
  const hasFetchedMechanics = useRef(false);

  // Ad Modal State
  const [showAdModal, setShowAdModal] = useState(false);
  const [selectedAdTitle, setSelectedAdTitle] = useState('');

  const mapContainerRef = useRef(null);
  const mapInstanceRef = useRef(null);
  const userMarkerRef = useRef(null);
  const adMarkersRef = useRef([]);

  const timerRef = useRef(null);
  const ConnectionStatus = () => {
    const { connectionStatus } = useWebSocket();
    const neumorphicShadow = "shadow-[5px_5px_10px_#b8bec9,_-5px_-5px_10px_#ffffff]";

    let statusContent;
    switch (connectionStatus) {
      case 'connected':
        statusContent = <div className="flex items-center text-green-600"><Wifi size={16} className="mr-2" /><span>Đã kết nối</span></div>;
        break;
      case 'connecting':
        statusContent = <div className="flex items-center text-yellow-600"><Clock size={16} className="mr-2 animate-spin" /><span>Đang kết nối...</span></div>;
        break;
      default:
        statusContent = <div className="flex items-center text-red-600"><WifiOff size={16} className="mr-2" /><span>Mất kết nối</span></div>;
    }

    return (
      <div className={`fixed bottom-4 right-4 bg-slate-200 px-4 py-2 rounded-full text-sm font-semibold z-20 ${neumorphicShadow}`}>
        {statusContent}
      </div>
    );
  };
  // Timer effect
  useEffect(() => {
    timerRef.current = setInterval(() => {
      setSearchTime(prev => prev + 1);
    }, 1000);
    return () => clearInterval(timerRef.current);
  }, []);

  // Get user location from local storage
  useEffect(() => {
    try {
      const saved = localStorage.getItem('punctureRequestFormData');
      if (saved) {
        const data = JSON.parse(saved);
        if (data.latitude && data.longitude) {
          setUserLocation({ lat: data.latitude, lng: data.longitude });
        }
      }
    } catch (err) {
      console.error("Error loading job request data", err);
    }
  }, []);

  // Initialize Map
  useEffect(() => {
    if (!mapContainerRef.current || !userLocation) return;
    if (mapInstanceRef.current) return;

    const map = new maplibregl.Map({
      container: mapContainerRef.current,
      center: [userLocation.lng, userLocation.lat],
      zoom: 14,
      style: `https://api.maptiler.com/maps/019b64a4-ef96-7e83-9a23-dde0df92b2ba/style.json?key=wf1HtIzvVsvPfvNrhwPz`,
      attributionControl: false,
    });
    mapInstanceRef.current = map;

    map.on('load', () => {
      // User marker
      const el = document.createElement('div');
      el.innerHTML = `<div style="width: 20px; height: 20px; background: #3b82f6; border-radius: 50%; border: 3px solid white; box-shadow: 0 0 10px rgba(0,0,0,0.3); animation: pulse 2s infinite;"></div>`;
      userMarkerRef.current = new maplibregl.Marker({ element: el })
        .setLngLat([userLocation.lng, userLocation.lat])
        .addTo(map);

      // Ad Placeholders
      const adPlaceholders = [
        { businessName: "Quảng cáo của bạn", longitude: 0.005, latitude: 0.005, color: "#f59e0b" },
        { businessName: "Doanh nghiệp trên bản đồ", longitude: -0.005, latitude: 0.005, color: "#ec4899" },
        { businessName: "Quảng cáo", longitude: 0.008, latitude: -0.005, color: "#8b5cf6" },
        { businessName: "Quảng cáo ngay", longitude: -0.008, latitude: -0.008, color: "#ef4444" }
      ];

      adPlaceholders.forEach(ad => {
        const adEl = document.createElement('div');
        adEl.style.cssText = `
          background: ${ad.color};
          color: white;
          padding: 6px 10px;
          border-radius: 10px;
          font-size: 10px;
          font-weight: 900;
          box-shadow: 0 4px 10px rgba(0,0,0,0.2);
          border: 2px solid white;
          white-space: nowrap;
          text-align: center;
          animation: pulse 2s infinite ease-in-out;
        `;
        adEl.innerHTML = `<div style="font-size: 6px; opacity: 0.8;">QUẢNG CÁO</div><div>${ad.businessName}</div>`;

        new maplibregl.Marker({ element: adEl })
          .setLngLat([userLocation.lng + ad.longitude, userLocation.lat + ad.latitude])
          .addTo(map);
      });
    });
  }, [userLocation]);

  // HTTP Polling
  useEffect(() => {
    let intervalId;
    const pollBookingStatus = async () => {
      try {
        const { data: response } = await api.get(`/bookings/${request_id}`);
        const booking = response.booking;

        if (booking && (booking.status === 'Moving' || booking.status === 'Arrived')) {
          // Mechanic assigned!
          try {
            const mechanicData = {
              job_id: booking.id,
              mechanic_details: {
                id: booking.mechanicId,
                first_name: booking.mechanicName || "Mechanic",
                last_name: "",
                phone_number: booking.mechanicPhone || "",
                Mechanic_profile_pic: null, // mock
                current_latitude: booking.mechanicLat,
                current_longitude: booking.mechanicLng
              },
              request_id,
              estimated_arrival_time: null,
              timestamp: new Date().toISOString()
            };

            localStorage.setItem('activeJobData', JSON.stringify(mechanicData));

            toast.success(`Đã tìm thấy thợ! Thợ đang đến 🚗`);
          } catch (error) {
            console.error('❌ Error saving mechanic data to localStorage:', error);
          }

          // Stop polling
          clearInterval(intervalId);

          // Navigate to MechanicFound page
          navigate(`/mechanic-found/${request_id}/`, {
            state: {
              mechanic: {
                id: booking.mechanicId,
                first_name: booking.mechanicName || "Mechanic",
                last_name: "",
                phone_number: booking.mechanicPhone || "",
                current_latitude: booking.mechanicLat,
                current_longitude: booking.mechanicLng,
                final_price: booking.finalPrice
              },
              estimatedTime: null,
              requestId: request_id
            }
          });
        }
      } catch (error) {
        console.error("Failed to poll booking status", error);
      }
    };

    // Initial poll
    pollBookingStatus();
    // Poll every 3 seconds
    intervalId = setInterval(pollBookingStatus, 3000);

    return () => clearInterval(intervalId);
  }, [navigate, request_id]);

  // Fetch nearest mechanics after 15 seconds
  useEffect(() => {
    if (searchTime >= 15 && !hasFetchedMechanics.current && userLocation) {
      hasFetchedMechanics.current = true;
      // Stop the search timer
      if (timerRef.current) {
        clearInterval(timerRef.current);
        timerRef.current = null;
      }

      const fetchMechanics = async () => {
        try {
          // Get issue type from saved form data
          const savedForm = localStorage.getItem('punctureRequestFormData');
          const issueType = savedForm ? JSON.parse(savedForm)?.problem || '' : '';

          const { data } = await api.get('/bookings/nearest', {
            params: {
              lat: userLocation.lat,
              lng: userLocation.lng,
              issueType: issueType
            }
          });
          setFoundMechanics(data?.mechanics || []);
        } catch (error) {
          console.error('Failed to fetch nearest mechanics:', error);
          toast.error('Không thể tìm thợ gần bạn.');
        }
      };
      fetchMechanics();
    }
  }, [searchTime, userLocation]);

  const handleSelectMechanic = async (mechanic) => {
    try {
      await api.put(`/bookings/${request_id}/assign-mechanic`, {
        mechanicId: mechanic.id,
        finalPrice: mechanic.estimatedPrice
      });

      toast.success(`Đã chọn thợ ${mechanic.name}! Giá: ${mechanic.estimatedPrice?.toLocaleString()}đ`);

      // Navigate to MechanicFound page
      navigate(`/mechanic-found/${request_id}/`, {
        state: {
          mechanic: {
            id: mechanic.id,
            first_name: mechanic.name,
            last_name: '',
            phone_number: mechanic.phone,
            current_latitude: mechanic.locationLat,
            current_longitude: mechanic.locationLng,
            final_price: mechanic.estimatedPrice
          },
          estimatedTime: null,
          requestId: request_id
        }
      });
    } catch (error) {
      console.error('Failed to assign mechanic:', error);
      const msg = error?.response?.data?.message || 'Có lỗi khi chọn thợ.';
      toast.error(msg);

      // Thợ đã bị chọn bởi người khác → refresh danh sách
      if (error?.response?.status === 400 || error?.response?.status === 409) {
        toast('Đang cập nhật danh sách thợ...', { icon: '🔄' });
        try {
          const savedForm = localStorage.getItem('punctureRequestFormData');
          const issueType = savedForm ? JSON.parse(savedForm)?.problem || '' : '';
          const { data } = await api.get('/bookings/nearest', {
            params: { lat: userLocation.lat, lng: userLocation.lng, issueType }
          });
          setFoundMechanics(data?.mechanics || []);
          setSelectedMechanic(null);
        } catch (refreshError) {
          console.error('Failed to refresh mechanics:', refreshError);
        }
      }
    }
  };

  const handleCancel = () => {
    setCancelModalOpen(true);
  };

  const handleCancelConfirm = async () => {
    if (!selectedReason) {
      toast.error("Vui lòng chọn lý do hủy.");
      return;
    }
    try {
      // Update backend status to Cancelled
      await api.put(`/bookings/${request_id}/simulate-status`, { status: 'Cancelled' });

      // Clear localStorage to prevent redirect loop
      localStorage.removeItem('activeJobData');
      localStorage.removeItem('punctureRequestFormData');

      toast.success("Đã hủy yêu cầu sửa chữa.");
      navigate('/');
    } catch (error) {
      console.error("Failed to cancel service request:", error);
      const errorMessage = error.response?.data?.message || "Cancellation failed. Please try again.";
      toast.error(errorMessage);
    } finally {
      setCancelModalOpen(false);
    }
  };

  const formatTime = (seconds) => {
    const mins = Math.floor(seconds / 60);
    const secs = seconds % 60;
    return `${mins.toString().padStart(2, '0')}:${secs.toString().padStart(2, '0')}`;
  };

  // Neumorphism shadow convention: A light top-left shadow and a dark bottom-right shadow.
  // We use Tailwind's arbitrary values for this: `shadow-[light_shadow,dark_shadow]`.
  // For the "pressed" or "inset" effect, we use `shadow-[inset_...]`.
  const neumorphicShadow = "shadow-[8px_8px_16px_#d1d5db,_-8px_-8px_16px_#ffffff]";
  const neumorphicInsetShadow = "shadow-[inset_5px_5px_10px_#d1d5db,_inset_-5px_-5px_10px_#ffffff]";
  const buttonShadow = "shadow-[5px_5px_10px_#d1d5db,_-5px_-5px_10px_#ffffff]";
  const buttonActiveShadow = "active:shadow-[inset_5px_5px_10px_#d1d5db,_inset_-5px_-5px_10px_#ffffff]";

  const sortedMechanics = [...foundMechanics].sort((a, b) => {
    if (sortBy === 'price') return a.estimatedPrice - b.estimatedPrice;
    return a.distanceKm - b.distanceKm;
  });

  return (
    <div className="min-h-screen bg-gray-100 text-gray-700 flex flex-col items-center justify-center p-4 font-sans">
      <ConnectionStatus />
      <div className="w-full max-w-md">
        <motion.div
          initial={{ opacity: 0, scale: 0.95 }}
          animate={{ opacity: 1, scale: 1 }}
          transition={{ duration: 0.3 }}
          className={`bg-gray-100 rounded-3xl p-6 md:p-8 ${neumorphicShadow}`}
        >
          {foundMechanics.length === 0 ? (
            <>
              <div className="text-center mb-8">
                <div className="flex justify-center mb-4">
                  <div className={`p-4 rounded-full bg-gray-100 ${neumorphicInsetShadow}`}>
                    <Loader className="animate-spin text-blue-500" size={32} />
                  </div>
                </div>
                <h1 className="text-2xl font-bold text-gray-800 mb-2">Đang tìm thợ sửa xe</h1>
                <p className="text-gray-500">Chúng tôi đang tìm thợ gần nhất cho bạn...</p>
              </div>

              <div className="mb-6 rounded-2xl overflow-hidden h-40 border-2 border-white shadow-inner relative">
                <div ref={mapContainerRef} className="w-full h-full" />
                <div className="absolute inset-0 pointer-events-none bg-gradient-to-b from-transparent to-black/5" />
              </div>

              <div className="space-y-4 mb-8">
                <div className={`flex justify-between items-center p-4 rounded-xl bg-gray-100 ${neumorphicInsetShadow}`}>
                  <div className="flex items-center gap-3">
                    <Clock className="text-blue-500" size={20} />
                    <span className="font-semibold">Thời gian tìm kiếm</span>
                  </div>
                  <span className="font-mono text-lg font-bold text-gray-800">{formatTime(searchTime)}</span>
                </div>
                <div className="text-center text-gray-400 text-sm">
                  <p>Request ID: #{request_id}</p>
                </div>
                <OrderDetailsCard />
              </div>

              <div className="flex gap-4">
                <button
                  onClick={handleCancel}
                  className={`flex-1 py-3 px-4 bg-gray-100 rounded-lg font-semibold text-red-500 transition-all duration-200
                            ${buttonShadow} ${buttonActiveShadow}`}
                >
                  <X size={18} className="inline-block mr-2" />
                  Hủy yêu cầu
                </button>
              </div>
            </>
          ) : selectedMechanic ? (
            <motion.div
              initial={{ opacity: 0, scale: 0.95, y: 10 }}
              animate={{ opacity: 1, scale: 1, y: 0 }}
              transition={{ duration: 0.3 }}
              className="space-y-6"
            >
              {/* Header with Back Button */}
              <div className="flex items-center gap-4">
                <button 
                  onClick={() => setSelectedMechanic(null)}
                  className={`p-3 rounded-xl bg-gray-100 ${buttonShadow} ${buttonActiveShadow} hover:text-blue-600 transition-colors shrink-0`}
                >
                  <ChevronLeft size={20} />
                </button>
                <h2 className="text-xl font-bold text-gray-800 flex-1 text-center pr-12">Chi tiết thợ</h2>
              </div>

              {/* Mechanic Profile Info */}
              <div className={`bg-gray-100 rounded-3xl p-6 ${neumorphicInsetShadow}`}>
                <div className="flex items-center gap-4 mb-5">
                  <div className="w-16 h-16 rounded-full bg-blue-100 text-blue-600 flex items-center justify-center text-2xl font-black shadow-inner border border-white shrink-0">
                    {selectedMechanic.name.charAt(0)}
                  </div>
                  <div>
                    <h3 className="text-xl font-bold text-gray-800">{selectedMechanic.name}</h3>
                    <p className="text-sm text-gray-500 font-medium">{selectedMechanic.shopName}</p>
                    <div className="flex items-center gap-3 mt-2">
                      <span className="flex items-center text-xs font-bold text-gray-700 bg-white/60 px-2.5 py-1 rounded-full shadow-sm">
                        <Star size={12} className="text-yellow-500 fill-yellow-500 mr-1" />
                        {selectedMechanic.rating}
                      </span>
                      <span className="flex items-center text-xs font-semibold text-green-700 bg-green-100 px-2.5 py-1 rounded-full shadow-sm">
                        <ShieldCheck size={12} className="mr-1" /> Xác thực
                      </span>
                    </div>
                  </div>
                </div>
                
                <div className="space-y-4 text-sm text-gray-600">
                  <div className="flex items-start gap-3">
                    <MapPin size={18} className="text-blue-500 shrink-0 mt-0.5" />
                    <p className="leading-snug">
                      <span className="block font-bold text-gray-800 mb-0.5">Khoảng cách: {selectedMechanic.distanceKm} km</span>
                      <span className="text-gray-500">{selectedMechanic.address}</span>
                    </p>
                  </div>
                  <div className="flex items-start gap-3">
                    <Phone size={18} className="text-green-500 shrink-0 mt-0.5" />
                    <p className="font-bold text-gray-800 leading-snug">{selectedMechanic.phone}</p>
                  </div>

                </div>
              </div>

              {/* Price Quote */}
              <div className={`bg-gray-100 rounded-3xl p-6 ${buttonShadow}`}>
                <h4 className="font-bold text-gray-800 mb-4 flex items-center gap-2 text-base">
                  <NotebookPen size={18} className="text-blue-500" /> Chi tiết báo giá dự kiến
                </h4>
                <div className="space-y-3 text-sm">
                  <div className="flex justify-between items-center text-gray-600">
                    <span>Phí dịch vụ cơ bản</span>
                    <span className="font-semibold text-gray-800">{selectedMechanic.baseServicePrice?.toLocaleString()}đ</span>
                  </div>
                  <div className="flex justify-between items-center text-gray-600">
                    <span>Phí di chuyển ({selectedMechanic.distanceKm} km)</span>
                    <span className="font-semibold text-gray-800">{selectedMechanic.travelFee?.toLocaleString()}đ</span>
                  </div>
                  <div className="flex justify-between items-center text-gray-600">
                    <span>Công thợ (tuỳ tình trạng)</span>
                    <span className="font-semibold text-gray-800">{selectedMechanic.laborCost?.toLocaleString()}đ</span>
                  </div>
                  <div className="h-px bg-gray-200 my-4 shadow-[0_1px_1px_rgba(255,255,255,1)]"></div>
                  <div className="flex justify-between items-center text-lg">
                    <span className="font-black text-gray-800">Tổng cộng</span>
                    <span className="font-black text-green-600 text-xl">{selectedMechanic.estimatedPrice?.toLocaleString()}đ</span>
                  </div>
                </div>
              </div>

              {/* Action Buttons */}
              <div className="flex gap-4 pt-2">
                <button
                  onClick={() => handleSelectMechanic(selectedMechanic)}
                  className={`flex-1 py-4 px-4 bg-blue-500 rounded-2xl font-bold text-white transition-all duration-200 shadow-[5px_5px_15px_rgba(59,130,246,0.3),-5px_-5px_15px_rgba(255,255,255,0.8)] hover:bg-blue-600 active:shadow-[inset_2px_2px_5px_rgba(0,0,0,0.2)] flex items-center justify-center gap-2 text-base`}
                >
                  Xác nhận gọi thợ này
                </button>
              </div>
            </motion.div>
          ) : (
            <motion.div
              initial={{ opacity: 0, y: 30 }}
              animate={{ opacity: 1, y: 0 }}
              transition={{ duration: 0.4 }}
              className="space-y-4"
            >
              <div className="text-center mb-6">
                <h2 className="text-2xl font-bold text-gray-800">Đã tìm thấy {foundMechanics.length} thợ!</h2>
                <p className="text-gray-500 text-sm mt-1">Chọn thợ phù hợp nhất với bạn</p>
              </div>

              {/* Sorting Filters */}
              <div className="flex gap-3 mb-6 justify-center">
                <button
                  onClick={() => setSortBy('distance')}
                  className={`px-4 py-2 rounded-xl text-sm font-semibold transition-all flex items-center gap-2 ${
                    sortBy === 'distance' 
                      ? `bg-blue-500 text-white ${buttonShadow}` 
                      : `bg-gray-100 text-gray-600 ${neumorphicInsetShadow}`
                  }`}
                >
                  <Route size={16} /> Gần nhất
                </button>
                <button
                  onClick={() => setSortBy('price')}
                  className={`px-4 py-2 rounded-xl text-sm font-semibold transition-all flex items-center gap-2 ${
                    sortBy === 'price' 
                      ? `bg-blue-500 text-white ${buttonShadow}` 
                      : `bg-gray-100 text-gray-600 ${neumorphicInsetShadow}`
                  }`}
                >
                  <Star size={16} /> Giá rẻ nhất
                </button>
              </div>

              {sortedMechanics.map((mechanic, index) => (
                <motion.div
                  key={mechanic.id}
                  initial={{ opacity: 0, x: -20 }}
                  animate={{ opacity: 1, x: 0 }}
                  transition={{ delay: index * 0.1 }}
                  className={`bg-gray-100 rounded-2xl p-4 cursor-pointer group transition-all duration-200 ${buttonShadow} hover:${neumorphicInsetShadow}`}
                  onClick={() => setSelectedMechanic(mechanic)}
                >
                  <div className="flex items-start justify-between">
                    <div className="flex-1">
                      <div className="flex items-center gap-2 mb-1">
                        <span className="bg-blue-500 text-white text-xs font-bold w-6 h-6 rounded-full flex items-center justify-center">
                          {index + 1}
                        </span>
                        <h3 className="font-bold text-gray-800">{mechanic.name}</h3>
                      </div>
                      <p className="text-sm text-gray-500 ml-8">{mechanic.shopName}</p>
                      <div className="flex items-center gap-3 mt-2 ml-8 text-sm text-gray-600">
                        <span className="flex items-center gap-1">
                          <Star size={14} className="text-yellow-500 fill-yellow-500" />
                          {mechanic.rating}
                        </span>
                        <span className="flex items-center gap-1">
                          <Route size={14} className="text-blue-500" />
                          {mechanic.distanceKm} km
                        </span>
                        <span className="flex items-center gap-1">
                          <Phone size={14} className="text-green-500" />
                          {mechanic.phone}
                        </span>
                      </div>
                      <p className="text-xs text-gray-400 ml-8 mt-1">
                        <MapPin size={12} className="inline mr-1" />{mechanic.address}
                      </p>

                    </div>
                    <div className="text-right min-w-[90px]">
                      <p className="text-lg font-bold text-green-600">
                        {mechanic.estimatedPrice?.toLocaleString()}đ
                      </p>
                      <div className="text-[10px] text-gray-400 mt-1 space-y-0.5">
                        <p>Dịch vụ: {mechanic.baseServicePrice?.toLocaleString()}đ</p>
                        <p>Di chuyển: {mechanic.travelFee?.toLocaleString()}đ</p>
                        <p>Công thợ: {mechanic.laborCost?.toLocaleString()}đ</p>
                      </div>
                    </div>
                  </div>
                  <div className="mt-2 flex justify-end">
                    <span className="text-sm font-semibold text-blue-500 group-hover:text-blue-700 transition-colors">
                      Xem chi tiết →
                    </span>
                  </div>
                </motion.div>
              ))}
            </motion.div>
          )}
        </motion.div>
      </div>

      {/* Ad Modal */}
      <AnimatePresence>
        {showAdModal && (
          <div className="fixed inset-0 z-[100] flex items-center justify-center p-4 bg-black/60 backdrop-blur-sm text-gray-800">
            <motion.div
              initial={{ opacity: 0, scale: 0.9, y: 20 }}
              animate={{ opacity: 1, scale: 1, y: 0 }}
              exit={{ opacity: 0, scale: 0.9, y: 20 }}
              className="bg-white w-full max-w-md rounded-[2.5rem] p-8 shadow-2xl overflow-hidden relative"
            >
              <button
                onClick={() => setShowAdModal(false)}
                className="absolute top-6 right-6 p-2 text-gray-400 hover:bg-gray-100 rounded-xl transition-colors"
              >
                <X size={20} />
              </button>

              <div className="text-center mb-8">
                <div className="w-16 h-16 bg-blue-50 text-blue-600 rounded-2xl flex items-center justify-center mx-auto mb-4">
                  <Wrench size={32} />
                </div>
                <h3 className="text-2xl font-black text-gray-900">{selectedAdTitle}</h3>
                <p className="text-gray-500 text-sm">Phát triển kinh doanh bằng cách quảng cáo với MotorSafe.</p>
              </div>

              <form onSubmit={(e) => { e.preventDefault(); toast.success('Interest registered!'); setShowAdModal(false); }}>
                <div className="space-y-4 mb-6 text-left">
                  <div>
                    <label className="block text-xs font-bold text-gray-400 uppercase tracking-widest mb-2 ml-1">Tên doanh nghiệp</label>
                    <input
                      type="text"
                      placeholder="Doanh nghiệp của bạn"
                      className="w-full px-6 py-4 bg-gray-50 border-2 border-gray-100 rounded-2xl focus:border-blue-500 outline-none font-bold"
                      required
                    />
                  </div>
                  <div>
                    <label className="block text-xs font-bold text-gray-400 uppercase tracking-widest mb-2 ml-1">Số điện thoại liên hệ</label>
                    <input
                      type="tel"
                      placeholder="09xx xxx xxx"
                      className="w-full px-6 py-4 bg-gray-50 border-2 border-gray-100 rounded-2xl focus:border-blue-500 outline-none font-bold"
                      required
                    />
                  </div>
                </div>

                <button
                  type="submit"
                  className="w-full py-4 bg-blue-600 hover:bg-blue-700 text-white rounded-2xl font-bold text-lg shadow-lg shadow-blue-200 transition-all active:scale-95 flex items-center justify-center gap-2"
                >
                  Nhận báo giá & thông tin
                </button>
              </form>
            </motion.div>
          </div>
        )}
      </AnimatePresence>

      {/* Cancellation Modal */}
      {isCancelModalOpen && (
        <div className="fixed inset-0 bg-opacity-25 z-50 flex items-center justify-center p-4">
          <motion.div
            initial={{ opacity: 0, scale: 0.9 }}
            animate={{ opacity: 1, scale: 1 }}
            className={`bg-gray-100 w-full max-w-md mx-4 p-6 rounded-2xl text-gray-800 ${neumorphicShadow}`}
          >
            <h2 className="text-lg font-bold mb-4">Tại sao bạn muốn hủy?</h2>
            <div className="space-y-3">
              {['Thợ đến muộn', 'Tôi đã đổi ý', 'Đã tìm được hỗ trợ khác', 'Lý do khác'].map((reason) => (
                <div
                  key={reason}
                  onClick={() => setSelectedReason(reason)}
                  className={`w-full px-4 py-3 rounded-lg cursor-pointer transition-all duration-200
                             ${selectedReason === reason
                      ? `text-red-600 font-semibold ${neumorphicInsetShadow}`
                      : `text-gray-700 hover:text-blue-600 ${buttonShadow} active:shadow-none`
                    }`}
                >
                  {reason}
                </div>
              ))}
            </div>
            <div className="mt-6 flex justify-end gap-4">
              <button
                onClick={() => setCancelModalOpen(false)}
                className={`px-5 py-2 bg-gray-100 rounded-lg text-sm font-semibold transition-all duration-200
                           ${buttonShadow} ${buttonActiveShadow}`}
              >
                Quay lại
              </button>
              <button
                disabled={!selectedReason}
                onClick={handleCancelConfirm}
                className={`px-5 py-2 bg-gray-100 text-red-500 rounded-lg text-sm font-semibold transition-all duration-200
                           ${buttonShadow} ${buttonActiveShadow}
                           disabled:opacity-60 disabled:text-gray-400 disabled:cursor-not-allowed disabled:shadow-none`}
              >
                Xác nhận hủy
              </button>
            </div>
          </motion.div>
        </div>
      )}
    </div>
  );
}
