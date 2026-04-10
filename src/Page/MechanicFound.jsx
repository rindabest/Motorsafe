import React, { useState, useEffect, useRef } from 'react';
import { useLocation, useNavigate, useParams } from 'react-router-dom';
import { Car, Clock, Phone, Wifi, WifiOff, X, MapPin, Wrench, CheckCircle, MessageCircle, Send, Home, Star } from 'lucide-react';
import api from '../utils/api';
import { useWebSocket } from '../context/WebSocketContext';
import { toast } from 'react-hot-toast';
import OrderDetailsCard from '../components/OrderDetailsCard';
import ReviewModal from '../components/ReviewModal';
import { motion, AnimatePresence } from 'framer-motion';

const ACTIVE_JOB_STORAGE_KEY = 'activeJobData';
const FORM_STORAGE_KEY = 'punctureRequestFormData';

// --- 4 trạng thái ---
const STATUSES = [
  { key: 'preparing', label: 'Chuẩn bị', desc: 'Thợ đang chuẩn bị dụng cụ', icon: Wrench, color: 'blue' },
  { key: 'moving', label: 'Đang di chuyển', desc: 'Thợ đang trên đường đến', icon: Car, color: 'orange' },
  { key: 'arrived', label: 'Đã đến nơi', desc: 'Thợ đã đến vị trí của bạn', icon: MapPin, color: 'green' },
  { key: 'completed', label: 'Hoàn thành', desc: 'Dịch vụ đã hoàn tất', icon: CheckCircle, color: 'emerald' },
];

const STEP_DURATION = 20; // giây

// --- Cho phần chat với thợ: Keywords & Responses ---
const KEYWORD_RESPONSES = {
  time: {
    keywords: ['bao lâu', 'khi nào', 'chậm', 'lâu', 'mấy phút', 'bao giờ'],
    responses: [
      'Dạ em đang đi rồi ạ, đường hơi đông nên anh/chị đợi em thêm chừng 5 phút nhé.',
      'Dạ em sắp tới rồi ạ, khoảng 3-5 phút nữa thôi, anh/chị thông cảm nhé!',
      'Dạ em đang cố gắng đi nhanh nhất có thể rồi ạ, chắc tầm 5 phút nữa em tới.',
    ],
  },
  location: {
    keywords: ['ở đâu', 'vị trí', 'đâu rồi', 'tới đâu', 'gần chưa'],
    responses: [
      'Dạ em đang ở cách anh/chị khoảng 1km, sắp tới rồi ạ.',
      'Dạ em đang đi qua đoạn gần chỗ anh/chị rồi, sắp tới nơi ạ!',
      'Dạ em thấy trên bản đồ còn khoảng 800m nữa thôi ạ.',
    ],
  },
  price: {
    keywords: ['giá', 'bao nhiêu', 'phí', 'tiền', 'chi phí', 'thanh toán'],
    responses: [
      'Dạ giá dịch vụ sẽ theo báo giá trên app ạ, anh/chị yên tâm không phát sinh thêm nhé.',
      'Dạ chi phí sẽ đúng như trên đơn ạ, anh/chị khỏi lo nhé!',
      'Dạ em sẽ làm đúng giá trên app, không phụ thu gì thêm đâu ạ.',
    ],
  },
  thanks: {
    keywords: ['cảm ơn', 'thank', 'tks', 'cám ơn'],
    responses: [
      'Dạ không có gì ạ, em rất vui được hỗ trợ anh/chị!',
      'Dạ anh/chị quá khen, em cảm ơn anh/chị đã tin tưởng ạ!',
      'Dạ cảm ơn anh/chị, có gì cần cứ nhắn em nhé!',
    ],
  },
  greeting: {
    keywords: ['hello', 'xin chào', 'hi', 'chào', 'alo'],
    responses: [
      'Dạ chào anh/chị, em đang trên đường tới, có gì anh/chị cứ nhắn em nhé!',
      'Dạ chào anh/chị! Em sẽ có mặt sớm nhất có thể ạ.',
      'Dạ hi anh/chị, em đã nhận đơn và đang di chuyển rồi ạ!',
    ],
  },
  weather: {
    keywords: ['mưa', 'thời tiết', 'nắng', 'trời'],
    responses: [
      'Dạ em vẫn đến bình thường ạ, anh/chị yên tâm nhé.',
      'Dạ thời tiết không ảnh hưởng gì đâu ạ, em đang trên đường rồi!',
      'Dạ em vẫn di chuyển được ạ, anh/chị đợi em chút nhé!',
    ],
  },
  tools: {
    keywords: ['dụng cụ', 'đồ nghề', 'chuẩn bị', 'sẵn sàng'],
    responses: [
      'Dạ em đã chuẩn bị đầy đủ dụng cụ rồi ạ, anh/chị yên tâm.',
      'Dạ đồ nghề em mang theo đầy đủ hết rồi ạ!',
      'Dạ em luôn sẵn sàng dụng cụ trước khi đi ạ, anh/chị khỏi lo.',
    ],
  },
  vehicle: {
    keywords: ['xe', 'lốp', 'bánh', 'vá', 'thủng', 'xịt'],
    responses: [
      'Dạ em sẽ kiểm tra kỹ tình trạng xe cho anh/chị khi tới nơi nhé.',
      'Dạ anh/chị mô tả thêm tình trạng xe giúp em để em chuẩn bị nhé!',
      'Dạ em sẽ xem xét và xử lý nhanh nhất có thể khi tới nơi ạ.',
    ],
  },
  urgent: {
    keywords: ['nhanh', 'gấp', 'khẩn', 'vội'],
    responses: [
      'Dạ em đang cố gắng di chuyển nhanh nhất có thể rồi ạ!',
      'Dạ em hiểu ạ, em đang đi rất nhanh rồi, anh/chị đợi em chút nhé!',
      'Dạ em ưu tiên đơn anh/chị rồi ạ, sẽ tới sớm nhất có thể!',
    ],
  },
};

const FALLBACK_RESPONSES = [
  'Anh/chị vui lòng mô tả rõ hơn giúp em ạ.',
];

// --- Helper: get first character of name ---
const getInitial = (name) => {
  if (!name) return '?';
  return name.charAt(0).toUpperCase();
};

// --- Avatar with initial letter ---
const InitialAvatar = ({ name, size = 'w-16 h-16 text-2xl' }) => {
  const colors = [
    'from-blue-500 to-blue-600',
    'from-emerald-500 to-emerald-600',
    'from-orange-500 to-orange-600',
    'from-purple-500 to-purple-600',
    'from-pink-500 to-pink-600',
    'from-teal-500 to-teal-600',
  ];
  const colorIndex = (name || '').charCodeAt(0) % colors.length;
  const gradient = colors[colorIndex] || colors[0];

  return (
    <div className={`${size} rounded-full bg-gradient-to-br ${gradient} flex items-center justify-center text-white font-bold shadow-md border-4 border-slate-200 select-none`}>
      {getInitial(name)}
    </div>
  );
};

// --- ChatBox Component ---
const ChatBox = ({ isOpen, onClose, mechanicName, currentStep }) => {
  const [messages, setMessages] = useState([
    { sender: 'mechanic', text: `Xin chào! Tôi là ${mechanicName}. Bạn cần hỗ trợ gì ạ?`, time: new Date() },
  ]);
  const [inputText, setInputText] = useState('');
  const [isTyping, setIsTyping] = useState(false);
  const messagesEndRef = useRef(null);
  const inputRef = useRef(null);
  const usedResponsesRef = useRef(new Set()); // track các câu đã trả lời

  const isCompleted = currentStep >= 3;

  const scrollToBottom = () => {
    messagesEndRef.current?.scrollIntoView({ behavior: 'smooth' });
  };

  useEffect(() => {
    scrollToBottom();
  }, [messages, isTyping]);

  useEffect(() => {
    if (isOpen && !isCompleted) {
      setTimeout(() => inputRef.current?.focus(), 300);
    }
  }, [isOpen, isCompleted]);

  const sendMessage = () => {
    const text = inputText.trim();
    if (!text || isCompleted) return;

    const customerMsg = { sender: 'customer', text, time: new Date() };
    setMessages(prev => [...prev, customerMsg]);
    setInputText('');

    // Auto-responder with random delay 2-3s
    setIsTyping(true);
    const delay = 2000 + Math.random() * 1000;
    setTimeout(() => {
      const getResponseByKeyword = (userMessage) => {
        const lowerMsg = userMessage.toLowerCase();
        
        let possibleResponses = [];
        let matchedGroup = null;

        // Tìm nhóm khớp từ khóa
        for (const group of Object.values(KEYWORD_RESPONSES)) {
          if (group.keywords.some(kw => lowerMsg.includes(kw))) {
            matchedGroup = group;
            possibleResponses = group.responses.filter(r => !usedResponsesRef.current.has(r));
            break;
          }
        }

        // Nếu nhóm khớp hết câu trả lời HOẶC không khớp từ khóa nào -> dùng fallback
        if (possibleResponses.length === 0) {
          possibleResponses = FALLBACK_RESPONSES.filter(r => !usedResponsesRef.current.has(r));
        }

        // Nếu hết cả fallback -> reset history
        if (possibleResponses.length === 0) {
          usedResponsesRef.current.clear();
          if (matchedGroup) {
            possibleResponses = matchedGroup.responses;
          } else {
            possibleResponses = FALLBACK_RESPONSES;
          }
        }
        
        const chosen = possibleResponses[Math.floor(Math.random() * possibleResponses.length)];
        usedResponsesRef.current.add(chosen);
        return chosen;
      };

      const randomResponse = getResponseByKeyword(text);
      const botMsg = { sender: 'mechanic', text: randomResponse, time: new Date() };
      setMessages(prev => [...prev, botMsg]);
      setIsTyping(false);
    }, delay);
  };

  const handleKeyDown = (e) => {
    if (e.key === 'Enter' && !e.shiftKey) {
      e.preventDefault();
      sendMessage();
    }
  };

  const formatTime = (date) => {
    return new Date(date).toLocaleTimeString('vi-VN', { hour: '2-digit', minute: '2-digit' });
  };

  if (!isOpen) return null;

  return (
    <motion.div
      initial={{ opacity: 0 }}
      animate={{ opacity: 1 }}
      exit={{ opacity: 0 }}
      className="fixed inset-0 h-[100dvh] w-full z-[100] flex flex-col bg-slate-200"
    >
      {/* Chat Header */}
      <div className="bg-slate-200 shadow-[0_4px_10px_#b8bec9] px-4 py-3 flex items-center gap-3 z-10">
        <button
          onClick={onClose}
          className="p-2 rounded-full shadow-[4px_4px_8px_#b8bec9,_-4px_-4px_8px_#ffffff] active:shadow-[inset_3px_3px_6px_#b8bec9,_inset_-3px_-3px_6px_#ffffff] transition-all"
        >
          <X size={18} className="text-slate-600" />
        </button>
        <InitialAvatar name={mechanicName} size="w-10 h-10 text-lg" />
        <div className="flex-grow">
          <h3 className="font-bold text-slate-800 text-sm">{mechanicName}</h3>
          <p className="text-xs text-slate-500">
            {isCompleted ? 'Đơn hàng đã hoàn thành' : isTyping ? 'Đang nhập...' : 'Trực tuyến'}
          </p>
        </div>
        {isCompleted && (
          <span className="text-xs bg-emerald-100 text-emerald-700 px-3 py-1 rounded-full font-semibold">
            Chỉ đọc
          </span>
        )}
      </div>

      {/* Messages Area */}
      <div className="flex-grow overflow-y-auto px-4 py-3 space-y-3">
        {messages.map((msg, index) => (
          <motion.div
            key={index}
            initial={{ opacity: 0, y: 10 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.2 }}
            className={`flex ${msg.sender === 'customer' ? 'justify-end' : 'justify-start'}`}
          >
            <div className={`flex items-end gap-2 max-w-[80%] ${msg.sender === 'customer' ? 'flex-row-reverse' : 'flex-row'
              }`}>
              {msg.sender === 'mechanic' && (
                <InitialAvatar name={mechanicName} size="w-7 h-7 text-xs" />
              )}
              <div>
                <div className={`px-4 py-2.5 rounded-2xl text-sm leading-relaxed ${msg.sender === 'customer'
                    ? 'bg-blue-500 text-white rounded-br-md shadow-[3px_3px_6px_#b8bec9]'
                    : 'bg-white text-slate-800 rounded-bl-md shadow-[3px_3px_6px_#b8bec9,_-3px_-3px_6px_#ffffff]'
                  }`}>
                  {msg.text}
                </div>
                <p className={`text-[10px] mt-1 text-slate-400 ${msg.sender === 'customer' ? 'text-right' : 'text-left'
                  }`}>
                  {formatTime(msg.time)}
                </p>
              </div>
            </div>
          </motion.div>
        ))}

        {/* Typing indicator */}
        {isTyping && (
          <motion.div
            initial={{ opacity: 0, y: 10 }}
            animate={{ opacity: 1, y: 0 }}
            className="flex justify-start"
          >
            <div className="flex items-end gap-2">
              <InitialAvatar name={mechanicName} size="w-7 h-7 text-xs" />
              <div className="bg-white px-4 py-3 rounded-2xl rounded-bl-md shadow-[3px_3px_6px_#b8bec9,_-3px_-3px_6px_#ffffff]">
                <div className="flex gap-1">
                  <span className="w-2 h-2 bg-slate-400 rounded-full animate-bounce" style={{ animationDelay: '0ms' }} />
                  <span className="w-2 h-2 bg-slate-400 rounded-full animate-bounce" style={{ animationDelay: '150ms' }} />
                  <span className="w-2 h-2 bg-slate-400 rounded-full animate-bounce" style={{ animationDelay: '300ms' }} />
                </div>
              </div>
            </div>
          </motion.div>
        )}
        <div ref={messagesEndRef} />
      </div>

      {/* Input Area */}
      <div className="bg-slate-200 px-4 py-3 shadow-[0_-4px_10px_#b8bec9]">
        {isCompleted ? (
          <div className="text-center py-3 text-sm text-slate-500 font-medium bg-slate-100 rounded-xl">
            Đơn hàng đã hoàn thành — Không thể gửi tin nhắn mới
          </div>
        ) : (
          <div className="flex items-center gap-2">
            <input
              ref={inputRef}
              type="text"
              value={inputText}
              onChange={(e) => setInputText(e.target.value)}
              onKeyDown={handleKeyDown}
              placeholder="Nhập tin nhắn..."
              className="flex-grow bg-white rounded-xl px-4 py-3 text-[16px] md:text-sm text-slate-800 placeholder-slate-400 shadow-[inset_4px_4px_8px_#b8bec9,_inset_-4px_-4px_8px_#ffffff] outline-none focus:ring-2 focus:ring-blue-300 transition-all"
            />
            <button
              onClick={sendMessage}
              disabled={!inputText.trim()}
              className="p-3 rounded-xl bg-blue-500 text-white shadow-[4px_4px_8px_#b8bec9,_-4px_-4px_8px_#ffffff] active:shadow-[inset_3px_3px_6px_#3b82f6] transition-all disabled:opacity-40 disabled:shadow-none"
            >
              <Send size={18} />
            </button>
          </div>
        )}
      </div>
    </motion.div>
  );
};

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

// --- Status Timeline Component ---
const StatusTimeline = ({ currentStep }) => {
  const activeColor = STATUSES[currentStep]?.color || 'blue';
  const bgColorMap = {
    blue: '#3b82f6',
    orange: '#f97316',
    green: '#22c55e',
    emerald: '#10b981',
  };
  const fillColor = bgColorMap[activeColor] || bgColorMap.blue;

  // Progress percentage: each completed step = 1/(n-1) of the line
  const totalSegments = STATUSES.length - 1;
  const progressPercent = Math.min((currentStep / totalSegments) * 100, 100);

  return (
    <div className="w-full px-4">
      {/* Container for the timeline */}
      <div className="relative flex items-start justify-between">

        {/* Background track line (gray) — aligned from center of first circle to center of last circle */}
        <div
          className="absolute top-[18px] flex items-center"
          style={{ zIndex: 0, left: 'calc(100% / 8)', right: 'calc(100% / 8)' }}
        >
          <div className="w-full h-[3px] bg-slate-200 rounded-full relative overflow-hidden">
            {/* Filled progress line */}
            <motion.div
              className="absolute top-0 left-0 h-full rounded-full"
              style={{ backgroundColor: fillColor }}
              initial={{ width: '0%' }}
              animate={{ width: `${progressPercent}%` }}
              transition={{ duration: 0.8, ease: 'easeInOut' }}
            />
          </div>
        </div>

        {/* Step circles + labels */}
        {STATUSES.map((step, index) => {
          const isCompleted = index < currentStep;
          const isActive = index === currentStep;
          const isFuture = index > currentStep;
          const Icon = step.icon;

          const colorMap = {
            blue: { bg: 'bg-blue-500', ring: 'ring-blue-200', text: 'text-blue-600' },
            orange: { bg: 'bg-orange-500', ring: 'ring-orange-200', text: 'text-orange-600' },
            green: { bg: 'bg-green-500', ring: 'ring-green-200', text: 'text-green-600' },
            emerald: { bg: 'bg-emerald-500', ring: 'ring-emerald-200', text: 'text-emerald-600' },
          };
          const stepColor = colorMap[step.color] || colorMap.blue;

          return (
            <div key={step.key} className="flex flex-col items-center relative" style={{ flex: 1, zIndex: 1 }}>
              {/* Icon circle */}
              <motion.div
                initial={false}
                animate={{ scale: isActive ? 1.15 : 1 }}
                transition={{ type: 'spring', stiffness: 300, damping: 20 }}
                className={`w-10 h-10 rounded-full flex items-center justify-center transition-all duration-500 border-[3px]
                  ${isCompleted ? `${stepColor.bg} text-white shadow-lg border-white` : ''}
                  ${isActive ? `${stepColor.bg} text-white shadow-lg ring-4 ${stepColor.ring} border-white` : ''}
                  ${isFuture ? 'bg-white text-slate-400 border-slate-200' : ''}
                `}
              >
                {isCompleted ? (
                  <CheckCircle size={20} />
                ) : (
                  <Icon size={18} className={isActive ? 'animate-pulse' : ''} />
                )}
              </motion.div>

              {/* Label */}
              <p className={`mt-2 text-[11px] font-bold text-center leading-tight transition-colors duration-300
                ${isCompleted ? stepColor.text : ''}
                ${isActive ? stepColor.text : ''}
                ${isFuture ? 'text-slate-400' : ''}
              `}>
                {step.label}
              </p>
            </div>
          );
        })}
      </div>
    </div>
  );
};

const mapStatusToStep = (status) => {
  switch (status) {
    case 'Pending': return 0;
    case 'Moving': return 1;
    case 'Arrived': return 2;
    case 'Completed': return 3;
    case 'Cancelled': return -1;
    default: return 0;
  }
};

export default function MechanicFound() {
  const navigate = useNavigate();
  const location = useLocation();
  const { request_id: paramRequestId } = useParams();

  // --- Neumorphism Style Constants ---
  const baseBg = "bg-slate-200";
  const primaryTextColor = "text-slate-700";
  const secondaryTextColor = "text-slate-500";
  const neumorphicShadow = "shadow-[8px_8px_16px_#b8bec9,_-8px_-8px_16px_#ffffff]";
  const neumorphicInsetShadow = "shadow-[inset_6px_6px_12px_#b8bec9,_inset_-6px_-6px_12px_#ffffff]";
  const buttonActiveShadow = "active:shadow-[inset_4px_4px_8px_#b8bec9,_inset_-4px_-4px_8px_#ffffff]";

  // --- Initial State Loader ---
  const getInitialState = () => {
    if (location.state) {
      if (location.state.mechanic) {
        const data = {
          mechanic: location.state.mechanic,
          jobDetails: null,
          request_id: location.state.requestId || paramRequestId,
        };
        localStorage.setItem(ACTIVE_JOB_STORAGE_KEY, JSON.stringify(data));
        return data;
      }
      if (location.state.jobDetails) {
        const data = {
          mechanic: location.state.jobDetails.assigned_mechanic,
          jobDetails: location.state.jobDetails,
          request_id: location.state.requestId || paramRequestId,
        };
        localStorage.setItem(ACTIVE_JOB_STORAGE_KEY, JSON.stringify(data));
        return data;
      }
    }

    try {
      const saved = JSON.parse(localStorage.getItem(ACTIVE_JOB_STORAGE_KEY));
      if (saved && (saved.request_id === paramRequestId || !saved.request_id)) {
        return saved;
      }
    } catch (err) {
      console.error("Failed to parse localStorage mechanic data:", err);
    }

    return { mechanic: null, jobDetails: null, request_id: paramRequestId };
  };

  // --- State ---
  const [initialState] = useState(getInitialState());
  const [mechanic, setMechanic] = useState(initialState.mechanic);
  const [jobDetails] = useState(initialState.jobDetails);
  const [jobRequestDetails, setJobRequestDetails] = useState(null);
  const [mechanicArrived, setMechanicArrived] = useState(false);
  const [isCancelModalOpen, setCancelModalOpen] = useState(false);
  const [selectedReason, setSelectedReason] = useState('');
  const [isChatOpen, setIsChatOpen] = useState(false);
  const [isReviewModalOpen, setIsReviewModalOpen] = useState(false);
  const [mechanicRating, setMechanicRating] = useState(0);
  const [isReviewed, setIsReviewed] = useState(false);
  const [isPhoneModalOpen, setIsPhoneModalOpen] = useState(false);

  // --- Timeline State ---
  const [currentStep, setCurrentStep] = useState(0);
  const shownToastsRef = useRef(new Set());

  // --- Helpers ---
  const clearActiveJobData = () => {
    localStorage.removeItem(ACTIVE_JOB_STORAGE_KEY);
    localStorage.removeItem(FORM_STORAGE_KEY);
  };

  // Persist mechanic to storage
  useEffect(() => {
    if (mechanic && paramRequestId) {
      const data = { mechanic, jobDetails, request_id: paramRequestId };
      localStorage.setItem(ACTIVE_JOB_STORAGE_KEY, JSON.stringify(data));
    }
  }, [mechanic, jobDetails, paramRequestId]);

  // Load user form data (from localStorage)
  useEffect(() => {
    try {
      const saved = localStorage.getItem(FORM_STORAGE_KEY);
      if (saved) {
        const data = JSON.parse(saved);
        setJobRequestDetails(data);
      } else {
        toast.error("Không thể tải chi tiết công việc.");
      }
    } catch (err) {
      console.error("Error loading job request data", err);
      toast.error("Lỗi khi đọc chi tiết công việc.");
    }
  }, []);

  // --- Auto-advance timeline every 15 seconds ---
  useEffect(() => {
    if (currentStep >= STATUSES.length - 1) return; // Đã hoàn thành → dừng

    const timer = setInterval(async () => {
      const nextStep = currentStep + 1;
      const statusMap = ['Pending', 'Moving', 'Arrived', 'Completed'];
      if (nextStep < statusMap.length) {
        try {
          await api.put(`/bookings/${paramRequestId}/simulate-status`, { status: statusMap[nextStep] });
        } catch (err) {
          console.error('Failed to update status:', err);
        }
      }
      setCurrentStep(nextStep);
    }, STEP_DURATION * 1000);

    return () => clearInterval(timer);
  }, [currentStep, paramRequestId]);

  // --- Handle step transitions ---
  useEffect(() => {
    if (shownToastsRef.current.has(currentStep)) return;
    shownToastsRef.current.add(currentStep);

    if (currentStep === 1) {
      toast.success("Thợ đang trên đường đến!", { icon: '🚗' });
    }

    if (currentStep === 2) {
      toast.success("Thợ đã đến!", { icon: '📍' });
      setMechanicArrived(true);
    }

    if (currentStep === 3) {
      toast.success("Yêu cầu đã được hoàn tất.", { icon: '✅' });
      if (!isReviewed) {
        setTimeout(() => {
          setIsReviewModalOpen(true);
        }, 1500);
      }
    }
  }, [currentStep, isReviewed]);

  // HTTP Polling (keep for real-time backend sync)
  useEffect(() => {
    let intervalId;
    const pollBookingStatus = async () => {
      try {
        const { data: response } = await api.get(`/bookings/${paramRequestId}`);
        const booking = response.booking;

        if (booking) {
          // Fallback to get mechanicId if it wasn't passed via state/localStorage
          if (!mechanic?.id && booking.mechanicId) {
            setMechanic(prev => ({ ...prev, id: booking.mechanicId }));
          }

          if (booking.status === 'Cancelled') {
            toast.success("Yêu cầu đã được hủy.");
            clearActiveJobData();
            navigate('/');
            return;
          }

          const backendStep = mapStatusToStep(booking.status);
          const backendIsReviewed = booking.isReviewed;
          
          setIsReviewed(backendIsReviewed);

          setCurrentStep(prev => {
            if (backendStep > prev) {
              if (backendStep >= 2) setMechanicArrived(true);
              // Only open modal if it's the first time reaching step 3 AND not reviewed
              if (backendStep === 3 && !backendIsReviewed) {
                setIsReviewModalOpen(true);
              }
              return backendStep;
            }
            return prev;
          });
        }
      } catch (error) {
        console.error("Failed to poll booking status", error);
      }
    };

    pollBookingStatus();
    intervalId = setInterval(pollBookingStatus, 5000);

    return () => clearInterval(intervalId);
  }, [navigate, paramRequestId, mechanic?.id]);

  useEffect(() => {
    const timer = setTimeout(() => {
      if (!mechanic) {
        toast.error("Không tìm thấy chi tiết công việc.");
        clearActiveJobData();
        navigate('/');
      }
    }, 1000);
    return () => clearTimeout(timer);
  }, [mechanic, navigate]);

  const handleCallMechanic = () => {
    setIsPhoneModalOpen(true);
  };

  const handleCancelConfirm = async () => {
    if (!selectedReason) {
      toast.error("Vui lòng chọn lý do hủy.");
      return;
    }
    try {
      await api.put(`/bookings/${paramRequestId}/simulate-status`, { status: 'Cancelled' });
      clearActiveJobData();
      toast.success("Yêu cầu sửa chữa đã được hủy.");
      navigate('/');
    } catch (error) {
      toast.error(error.response?.data?.message || "Cancellation failed.");
    } finally {
      setCancelModalOpen(false);
    }
  };

  if (!mechanic) {
    return <div className={`min-h-screen ${baseBg} flex items-center justify-center ${primaryTextColor}`}>Đang tải chi tiết công việc...</div>;
  }

  const currentStatus = STATUSES[currentStep];

  return (
    <>
      {/* <ConnectionStatus /> */}
      <div className={`min-h-screen ${baseBg} ${primaryTextColor} pt-28 font-sans`}>
        {/* Header */}
        <div className="fixed top-0 left-0 right-0 z-10">
          <div className={`${baseBg} rounded-b-3xl p-5 ${neumorphicShadow}`}>
            <div className="flex items-center justify-between mb-4">
              <div>
                <h1 className="text-xl font-bold text-slate-800">
                  {currentStatus.label}
                </h1>
                <p className={`${secondaryTextColor} text-sm`}>
                  {currentStatus.desc}
                </p>
              </div>
              <div className="flex items-center gap-3">
                {currentStep === 3 ? (
                  <button
                    onClick={() => {
                        clearActiveJobData();
                        navigate('/');
                    }}
                    className={`${baseBg} px-4 py-2 sm:px-6 sm:py-3 rounded-xl font-bold text-emerald-700 transition-all duration-200 ${neumorphicShadow} ${buttonActiveShadow} flex items-center justify-center gap-2`}
                  >
                    <Home size={18} />
                    <span>Về trang chủ</span>
                  </button>
                ) : null}
              </div>
            </div>

            {/* Status Timeline */}
            <StatusTimeline currentStep={currentStep} />
          </div>
        </div>

        {/* Content */}
        <div className="flex flex-col p-3 gap-5 mt-8">
          {/* Mechanic Info */}
          <div className={`${baseBg} rounded-3xl ${neumorphicShadow} p-5 flex items-center gap-4`}>
            <InitialAvatar name={mechanic.first_name || mechanic.name || mechanic.Name} />
            <div className="flex-grow">
              <h3 className="text-lg font-bold text-slate-800">
                {(mechanic.first_name || mechanic.name || mechanic.Name || "Thợ")} {mechanic.last_name || ""}
              </h3>
              <p className={`text-sm ${secondaryTextColor}`}>Thợ đã xác minh</p>
              {mechanicRating > 0 && (
                <div className="flex items-center gap-1 mt-1 text-sm font-semibold text-amber-500">
                  <Star size={14} fill="currentColor" />
                  <span>{mechanicRating.toFixed(1)} / 5</span>
                </div>
              )}
            </div>
            <div className="flex items-center gap-2">
              <button
                onClick={() => setIsChatOpen(true)}
                disabled={currentStep >= 3}
                className={`${baseBg} p-3 rounded-full transition-all duration-200 
                  ${currentStep >= 3 
                    ? 'opacity-40 cursor-not-allowed shadow-none' 
                    : `${neumorphicShadow} ${buttonActiveShadow}`} 
                  relative`}
              >
                <MessageCircle size={20} className="text-blue-600" />
              </button>
              <button
                onClick={handleCallMechanic}
                className={`${baseBg} p-3 rounded-full transition-all duration-200 ${neumorphicShadow} ${buttonActiveShadow}`}
              >
                <Phone size={20} className="text-green-600" />
              </button>
            </div>
          </div>

          {/* Arrival UI when mechanic has arrived */}
          <AnimatePresence>
            {mechanicArrived && currentStep < 3 && (
              <motion.div
                initial={{ opacity: 0, y: 20 }}
                animate={{ opacity: 1, y: 0 }}
                exit={{ opacity: 0, y: -20 }}
                className={`rounded-3xl p-6 ${neumorphicShadow} bg-green-50 flex flex-col items-center justify-center text-center`}
              >
                <div className="p-4 bg-green-100 rounded-full mb-4 animate-pulse">
                  <Wrench size={48} className="text-green-600" />
                </div>
                <h2 className="text-xl font-bold text-green-800 mb-2">Thợ sửa xe đã đến</h2>
                <p className="text-green-600">Vui lòng di chuyển đến gặp thợ tại vị trí của bạn.</p>
              </motion.div>
            )}
          </AnimatePresence>

          {/* Completion UI */}
          <AnimatePresence>
            {currentStep === 3 && (
              <motion.div
                initial={{ opacity: 0, scale: 0.9 }}
                animate={{ opacity: 1, scale: 1 }}
                className={`rounded-3xl p-6 ${neumorphicShadow} bg-emerald-50 flex flex-col items-center justify-center text-center`}
              >
                <div className="p-4 bg-emerald-100 rounded-full mb-4">
                  <CheckCircle size={48} className="text-emerald-600" />
                </div>
                <h2 className="text-xl font-bold text-emerald-800 mb-2">Dịch vụ hoàn tất!</h2>
                <p className="text-emerald-600">Cảm ơn bạn đã sử dụng MotorSafe.</p>
              </motion.div>
            )}
          </AnimatePresence>

          {/* Job Details */}
          {jobRequestDetails && (
            <div className={`${baseBg} rounded-3xl ${neumorphicShadow} p-3`}>
              <OrderDetailsCard details={jobRequestDetails} price={mechanic?.final_price || jobDetails?.finalPrice} />
            </div>
          )}



          {/* Cancel */}
          {currentStep < 1 && (
            <div className="flex flex-col mb-32 gap-4 mt-2">
              <button
                onClick={() => setCancelModalOpen(true)}
                className={`${baseBg} w-full py-4 rounded-xl font-semibold text-red-600 transition-all duration-200 ${neumorphicShadow} ${buttonActiveShadow} flex items-center justify-center gap-2`}
              >
                <X size={20} />
                Hủy yêu cầu
              </button>
            </div>
          )}
        </div>
      </div>

      {/* Cancel Modal */}
      {isCancelModalOpen && (
        <div className="fixed inset-0 bg-slate-200 bg-opacity-25 z-50 flex items-center justify-center p-4">
          <div className={`${baseBg} w-full max-w-md p-6 rounded-3xl ${neumorphicShadow}`}>
            <h2 className="text-lg font-bold mb-5 text-slate-800">Tại sao bạn muốn hủy?</h2>
            <div className="space-y-3">
              {['Thợ đến muộn', 'Tôi đã đổi ý', 'Đã tìm được hỗ trợ khác', 'Lý do khác'].map((reason) => (
                <div
                  key={reason}
                  onClick={() => setSelectedReason(reason)}
                  className={`w-full px-4 py-3 rounded-lg cursor-pointer transition-all duration-200 font-medium ${selectedReason === reason
                    ? `text-red-600 ${neumorphicInsetShadow}`
                    : `${neumorphicShadow} hover:text-blue-600`
                    }`}
                >
                  {reason}
                </div>
              ))}
            </div>
            <div className="mt-6 flex justify-end gap-3">
              <button
                onClick={() => setCancelModalOpen(false)}
                className={`${baseBg} px-5 py-2 rounded-lg font-semibold transition-all duration-200 ${neumorphicShadow} ${buttonActiveShadow}`}
              >
                Quay lại
              </button>
              <button
                disabled={!selectedReason}
                onClick={handleCancelConfirm}
                className={`${baseBg} px-5 py-2 text-red-600 rounded-lg font-semibold transition-all duration-200 ${neumorphicShadow} ${buttonActiveShadow} disabled:opacity-50 disabled:text-slate-400 disabled:shadow-none`}
              >
                Xác nhận
              </button>
            </div>
          </div>
        </div>
      )}

      {/* Chat Box */}
      <AnimatePresence>
        <ChatBox
          isOpen={isChatOpen}
          onClose={() => setIsChatOpen(false)}
          mechanicName={`${mechanic.first_name} ${mechanic.last_name}`}
          currentStep={currentStep}
        />
      </AnimatePresence>

      <ReviewModal
        isOpen={isReviewModalOpen}
        onClose={() => setIsReviewModalOpen(false)}
        mechanicId={mechanic.id || mechanic.Id}
        bookingId={paramRequestId}
        mechanicName={`${mechanic.first_name || mechanic.name || mechanic.Name || "Thợ"} ${mechanic.last_name || ""}`.trim()}
        onSubmitSuccess={(avgRating) => {
          setMechanicRating(avgRating);
          setIsReviewed(true);
        }}
      />

      {/* Phone Number Modal */}
      <AnimatePresence>
        {isPhoneModalOpen && (
          <div className="fixed inset-0 z-50 flex items-center justify-center p-4">
            <motion.div
              initial={{ opacity: 0 }}
              animate={{ opacity: 1 }}
              exit={{ opacity: 0 }}
              onClick={() => setIsPhoneModalOpen(false)}
              className="fixed inset-0 bg-slate-900/40 backdrop-blur-sm"
            />
            <motion.div
              initial={{ opacity: 0, scale: 0.9, y: 20 }}
              animate={{ opacity: 1, scale: 1, y: 0 }}
              exit={{ opacity: 0, scale: 0.9, y: 20 }}
              className={`relative z-50 ${baseBg} w-full max-w-sm p-6 rounded-[2rem] ${neumorphicShadow}`}
            >
              <div className="text-center mb-6">
                <div className={`w-16 h-16 rounded-full ${neumorphicInsetShadow} flex items-center justify-center mx-auto mb-4`}>
                  <Phone size={28} className="text-green-600" />
                </div>
                <h3 className="text-xl font-bold text-slate-800">Số điện thoại của thợ</h3>
                <p className="text-slate-500 text-sm mt-1">{(mechanic.first_name || mechanic.name || "Thợ")}</p>
              </div>

              <div className={`py-4 px-6 rounded-2xl ${neumorphicInsetShadow} mb-2 text-center`}>
                <span className="text-2xl font-black tracking-wider text-slate-800">
                  {mechanic.phone_number || mechanic.Phone || "Không có số"}
                </span>
              </div>
              
              <button
                onClick={() => setIsPhoneModalOpen(false)}
                className="w-full mt-6 py-2 text-slate-400 font-medium hover:text-slate-600 transition-colors"
              >
                Đóng
              </button>
            </motion.div>
          </div>
        )}
      </AnimatePresence>
    </>
  );
}
