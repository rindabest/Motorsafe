import React, { useState } from 'react';
import { motion, AnimatePresence } from 'framer-motion';
import { Star, Loader } from 'lucide-react';
import { toast } from 'react-hot-toast';
import { useNavigate } from 'react-router-dom';
import api from '../utils/api';

const ACTIVE_JOB_STORAGE_KEY = 'activeJobData';
const FORM_STORAGE_KEY = 'punctureRequestFormData';

const getInitial = (name) => {
  if (!name) return '?';
  return name.trim().charAt(0).toUpperCase();
};

const InitialAvatar = ({ name, size = 'w-20 h-20 text-3xl' }) => {
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
    <div className={`${size} rounded-full bg-gradient-to-br ${gradient} flex items-center justify-center text-white font-bold shadow-md border-4 border-white select-none mx-auto mb-4`}>
      {getInitial(name)}
    </div>
  );
};

const ReviewModal = ({ isOpen, onClose, mechanicId, bookingId, mechanicName, onSubmitSuccess }) => {
  const navigate = useNavigate();

  const clearActiveJobData = () => {
    localStorage.removeItem(ACTIVE_JOB_STORAGE_KEY);
    localStorage.removeItem(FORM_STORAGE_KEY);
  };
  const [rating, setRating] = useState(0);
  const [hoverRating, setHoverRating] = useState(0);
  const [comment, setComment] = useState('');
  const [isSubmitting, setIsSubmitting] = useState(false);

  // --- Neumorphism Style Constants ---
  const baseBg = "bg-slate-200";
  const primaryTextColor = "text-slate-800";
  const secondaryTextColor = "text-slate-500";
  const neumorphicShadow = "shadow-[8px_8px_16px_#b8bec9,_-8px_-8px_16px_#ffffff]";
  const neumorphicInsetShadow = "shadow-[inset_6px_6px_12px_#b8bec9,_inset_-6px_-6px_12px_#ffffff]";
  const buttonActiveShadow = "active:shadow-[inset_4px_4px_8px_#b8bec9,_inset_-4px_-4px_8px_#ffffff]";

  if (!isOpen) return null;

  const handleSubmit = async () => {
    if (rating === 0) {
      toast.error('Vui lòng chọn số sao để đánh giá!');
      return;
    }

    const trimmedComment = comment.trim();
    
    // Nếu người dùng có gõ phím nhưng chỉ toàn khoảng trắng thì báo lỗi
    if (comment.length > 0 && trimmedComment === "") {
      toast.error('Vui lòng nhập nhận xét cụ thể hoặc để trống!');
      return;
    }

    setIsSubmitting(true);
    try {
      const response = await api.post('/reviews', {
        mechanicId: parseInt(mechanicId),
        bookingId: parseInt(bookingId),
        rating,
        comment: trimmedComment
      });

        if (response.data.success) {
        toast.success('Cảm ơn bạn đã đánh giá!');
        if (onSubmitSuccess) {
          onSubmitSuccess(response.data.mechanicAverageRating, response.data.totalReviews);
        }
        onClose();
        clearActiveJobData();
        navigate('/');
      }
    } catch (error) {
      console.error('Lỗi khi gửi đánh giá:', error);
      toast.error(error.response?.data?.message || 'Không thể gửi đánh giá, xin thử lại sau.');
    } finally {
      setIsSubmitting(false);
    }
  };

  return (
    <AnimatePresence>
      <div className="fixed inset-0 z-50 flex items-center justify-center p-4">
        {/* Backdrop */}
        <div 
          className="fixed inset-0 bg-slate-900/40 backdrop-blur-sm z-40"
        />

        {/* Modal body */}
        <motion.div
          initial={{ opacity: 0, scale: 0.9, y: 20 }}
          animate={{ opacity: 1, scale: 1, y: 0 }}
          exit={{ opacity: 0, scale: 0.9, y: 20 }}
          transition={{ type: 'spring', damping: 25, stiffness: 300 }}
          className={`relative z-50 ${baseBg} w-full max-w-sm p-8 rounded-[2.5rem] ${neumorphicShadow}`}
        >
          <InitialAvatar name={mechanicName} />

          <h2 className={`text-2xl font-black mb-1 text-center text-slate-800`}>Đánh giá Dịch vụ</h2>
          <p className={`${secondaryTextColor} text-sm text-center mb-8 px-2`}>
            Trải nghiệm của bạn với thợ <br/> <span className="font-bold text-blue-600">{mechanicName}</span> thế nào?
          </p>

          <div className="flex flex-col items-center justify-center space-y-4 mb-6">
            <div className="flex gap-2">
              {[1, 2, 3, 4, 5].map((star) => (
                <button
                  key={star}
                  type="button"
                  onMouseEnter={() => setHoverRating(star)}
                  onMouseLeave={() => setHoverRating(0)}
                  onClick={() => setRating(star)}
                  className={`p-3 rounded-full transition-all duration-200 
                    ${star <= (hoverRating || rating) 
                      ? `${neumorphicInsetShadow} text-amber-400 scale-110` 
                      : `${neumorphicShadow} text-slate-400`}
                  `}
                >
                  <Star size={28} fill={star <= (hoverRating || rating) ? 'currentColor' : 'none'} />
                </button>
              ))}
            </div>
            <p className="text-sm font-semibold text-amber-500 h-5 mt-2">
              {rating === 1 && 'Rất tệ'}
              {rating === 2 && 'Tệ'}
              {rating === 3 && 'Bình thường'}
              {rating === 4 && 'Tốt'}
              {rating === 5 && 'Tuyệt vời'}
            </p>
          </div>

          <div className="mb-6">
            <label className="block text-sm font-medium text-slate-600 mb-2">Nhận xét thêm (Không bắt buộc)</label>
            <textarea
              name="comment"
              value={comment}
              onChange={(e) => setComment(e.target.value)}
              placeholder="Thợ làm việc như thế nào, có đúng giờ không..."
              rows={3}
              className={`w-full ${baseBg} ${neumorphicInsetShadow} rounded-2xl p-4 text-slate-700 focus:outline-none focus:ring-2 focus:ring-blue-300 resize-none`}
            />
          </div>

          <div className="space-y-4">
            <button
              onClick={handleSubmit}
              disabled={isSubmitting || rating === 0}
              className={`w-full py-4 rounded-2xl font-bold flex justify-center items-center gap-2
                ${isSubmitting || rating === 0 
                  ? 'opacity-50 text-slate-400 cursor-not-allowed shadow-none' 
                  : `${neumorphicShadow} ${buttonActiveShadow} text-blue-600 bg-slate-200 hover:text-blue-700`}
                transition-all duration-200`}
            >
              {isSubmitting ? <Loader className="animate-spin" size={20} /> : 'Gửi Đánh Giá'}
            </button>

            <button
              onClick={() => {
                onClose();
                clearActiveJobData();
                navigate('/');
              }}
              disabled={isSubmitting}
              className={`w-full py-3 rounded-2xl font-bold text-slate-500 hover:text-slate-700 transition-all duration-200 ${neumorphicShadow} ${buttonActiveShadow}`}
            >
              Bỏ qua
            </button>
          </div>
        </motion.div>
      </div>
    </AnimatePresence>
  );
};

export default ReviewModal;
