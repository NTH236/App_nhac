CREATE DATABASE music
GO
USE music
GO
CREATE TABLE albumcasi (
  id_album int PRIMARY KEY,
  id_casi int DEFAULT NULL,
  linkAnh nvarchar(500) DEFAULT NULL
);
GO
INSERT INTO albumcasi (id_album, id_casi, linkAnh) VALUES
(1, 1, 'albumCaSi\SonTungMTP.jpg'),
(2, 1, 'albumCaSi\SonTungMTP2.jpg'),
(3, 1, 'albumCaSi\SonTungMTP3.jpg'),
(4, 2, 'albumCaSi\DuongDomic1.jpg'),
(5, 2, 'albumCaSi\DuongDomic2.jpg'),
(6, 2, 'albumCaSi\DuongDomic3.jpg'),
(7, 3, 'albumCaSi\buitruonglinh1.jpg'),
(8, 3, 'albumCaSi\buitruonglinh2.jpg'),
(9, 3, 'albumCaSi\buitruonglinh3.jpg'),
(10, 4, 'albumCaSi\kha1.jpg'),
(11, 4, 'albumCaSi\kha2.jpg'),
(12, 4, 'albumCaSi\kha3.jpg'),
(13, 5, 'albumCaSi\jack1.jpg'),
(14, 5, 'albumCaSi\jack2.jpg'),
(15, 5, 'albumCaSi\jack3.jpg'),
(16, 6, 'albumCaSi\tungduong1.jpg'),
(17, 6, 'albumCaSi\tungduong2.jpg'),
(18, 6, 'albumCaSi\tungduong3.jpg'),
(19, 7, 'albumCaSi\hth1.jpg'),
(20, 7, 'albumCaSi\hth2.jpg'),
(21, 7, 'albumCaSi\hth3.jpg'),
(22, 8, 'albumCaSi\qh1.jpg'),
(23, 8, 'albumCaSi\qh2.jpg'),
(24, 8, 'albumCaSi\qh2.jpg'),
(25, 9, 'albumCaSi\hoamz1.jpg'),
(26, 9, 'albumCaSi\hoamz2.jpg'),
(27, 9, 'albumCaSi\hoamz3.jpg'),
(28, 10, 'albumCaSi\nganngan1.jpg'),
(29, 10, 'albumCaSi\nganngan2.jpg'),
(30, 10, 'albumCaSi\nganngan3.jpg'),
(31, 21, 'albumCaSi\bray1.jpg'),
(32, 21, 'albumCaSi\bray2.jpg'),
(33, 21, 'albumCaSi\bray3.jpg'),
(34, 22, 'albumCaSi\hades1.jpg'),
(35, 22, 'albumCaSi\hades2.jpg'),
(36, 22, 'albumCaSi\hades3.jpg'),
(37, 23, 'albumCaSi\puppy1.jpg'),
(38, 23, 'albumCaSi\puppy2.jpg'),
(39, 23, 'albumCaSi\puppy3.jpg'),
(40, 24, 'albumCaSi\rb1.jpg'),
(41, 24, 'albumCaSi\rb2.jpg'),
(42, 24, 'albumCaSi\rb3.jpg'),
(43, 25, 'albumCaSi\phao1.jpg'),
(44, 25, 'albumCaSi\phao2.jpg'),
(45, 25, 'albumCaSi\phao3.jpg'),
(46, 26, 'albumCaSi\denvau1.jpg'),
(47, 26, 'albumCaSi\denvau2.jpg'),
(48, 26, 'albumCaSi\denvau3.jpg'),
(49, 27, 'albumCaSi\mck1.jpg'),
(50, 27, 'albumCaSi\mck2.jpg'),
(51, 27, 'albumCaSi\mck3.jpg'),
(52, 28, 'albumCaSi\pk1.jpg'),
(53, 28, 'albumCaSi\pk2.jpg'),
(54, 28, 'albumCaSi\pk3.jpg'),
(55, 29, 'albumCaSi\obito1.jpg'),
(56, 29, 'albumCaSi\obito2.jpg'),
(57, 29, 'albumCaSi\obito3.jpg'),
(58, 30, 'albumCaSi\dangrangto1.jpg'),
(59, 30, 'albumCaSi\dangrangto2.jpg'),
(60, 30, 'albumCaSi\dangrangto3.jpg'),
(61, 11, 'albumCaSi\nguyenthuhang_1.jpg'),
(62, 11, 'albumCaSi\nguyenthuhang_2.jpg'),
(63, 11, 'albumCaSi\nguyenthuhang_3.jpg'),
(64, 11, 'albumCaSi\nguyenthuhang_4.jpg'),
(65, 12, 'albumCaSi\Yennhien1.jpg'),
(66, 12, 'albumCaSi\Yennhien2.jpg'),
(67, 12, 'albumCaSi\Yennhien3.jpg'),
(68, 13, 'albumCaSi\dothanhdanh1.jpg'),
(69, 13, 'albumCaSi\dothanhdanh2.jpg'),
(70, 13, 'albumCaSi\dothanhdanh3.jpg'),
(71, 14, 'albumCaSi\quangha1.jpg'),
(72, 14, 'albumCaSi\quangha2.jpg'),
(73, 14, 'albumCaSi\quangha3.jpg'),
(74, 15, 'albumCaSi\hoangminhthang1.jpg'),
(75, 15, 'albumCaSi\hoangminhthang2.jpg'),
(76, 15, 'albumCaSi\hoangminhthang3.jpg'),
(77, 16, 'albumCaSi\thanhhoa1.jpg'),
(78, 16, 'albumCaSi\thanhhoa2.jpg'),
(79, 16, 'albumCaSi\thanhhoa3.jpg'),
(80, 17, 'albumCaSi\khuonghung1.jpg'),
(81, 17, 'albumCaSi\khuonghung2.jpg'),
(82, 17, 'albumCaSi\khuonghung3.jpg'),
(83, 18, 'albumCaSi\huonggiang1.jpg'),
(84, 18, 'albumCaSi\huonggiang2.jpg'),
(85, 18, 'albumCaSi\huonggiang3.jpg'),
(86, 19, 'albumCaSi\taminhtam1.jpg'),
(87, 19, 'albumCaSi\taminhtam2.jpg'),
(88, 19, 'albumCaSi\taminhtam3.jpg'),
(89, 20, 'albumCaSi\quangthien1.jpg'),
(90, 20, 'albumCaSi\quangthien2.jpg'),
(91, 20, 'albumCaSi\quangthien3.jpg'),
(92, 20, 'albumCaSi\quangthien4.jpg'),
(93, 20, 'albumCaSi\quangthien5.jpg'),
(151, 31, 'albumCaSi\31_Rihanna_1.jpg'),
(152, 31, 'albumCaSi\31_Rihanna_2.jpg'),
(153, 31, 'albumCaSi\31_Rihanna_3.jpg'),
(154, 31, 'albumCaSi\31_Rihanna_4.jpg'),
(155, 31, 'albumCaSi\31_Rihanna_5.jpg'),
(156, 32, 'albumCaSi\32_ImagineDragons_1.jpg'),
(157, 32, 'albumCaSi\32_ImagineDragons_2.jpg'),
(158, 32, 'albumCaSi\32_ImagineDragons_3.jpg'),
(159, 32, 'albumCaSi\32_ImagineDragons_4.jpg'),
(160, 32, 'albumCaSi\32_ImagineDragons_5.jpg'),
(161, 33, 'albumCaSi\33_TokyoSquare_1.jpg'),
(162, 33, 'albumCaSi\33_TokyoSquare_2.jpg'),
(163, 33, 'albumCaSi\33_TokyoSquare_3.jpg'),
(164, 33, 'albumCaSi\33_TokyoSquare_4.jpg'),
(165, 34, 'albumCaSi\34_DianaRoss_1.jpg'),
(166, 34, 'albumCaSi\34_DianaRoss_2.jpg'),
(167, 34, 'albumCaSi\34_DianaRoss_3.jpg'),
(168, 34, 'albumCaSi\34_DianaRoss_4.jpg'),
(169, 34, 'albumCaSi\34_DianaRoss_5.jpg'),
(170, 35, 'albumCaSI\35_Vengaboys_1.jpg'),
(171, 35, 'albumCaSI\35_Vengaboys_2.jpg'),
(172, 35, 'albumCaSI\35_Vengaboys_3.jpg'),
(173, 35, 'albumCaSI\35_Vengaboys_4.jpg'),
(174, 35, 'albumCaSI\35_Vengaboys_5.jpg'),
(175, 36, 'albumCaSi\36_Aqua_1.jpg'),
(176, 36, 'albumCaSi\36_Aqua_2.jpg'),
(177, 36, 'albumCaSi\36_Aqua_3.jpg'),
(178, 36, 'albumCaSi\36_Aqua_4.jpg'),
(179, 36, 'albumCaSi\36_Aqua_5.jpg'),
(180, 37, 'albumCaSi\37_Cher_1.jpg'),
(181, 37, 'albumCaSi\37_Cher_2.jpg'),
(182, 37, 'albumCaSi\37_Cher_3.jpg'),
(183, 37, 'albumCaSi\37_Cher_4.jpg'),
(184, 37, 'albumCaSi\37_Cher_5.jpg'),
(185, 38, 'albumCaSi\38_Boyzone_1.jpg'),
(186, 38, 'albumCaSi\38_Boyzone_2.jpg'),
(187, 38, 'albumCaSi\38_Boyzone_3.jpg'),
(188, 38, 'albumCaSi\38_Boyzone_4.jpg'),
(189, 38, 'albumCaSi\38_Boyzone_5.jpg'),
(190, 39, 'albumCaSi\39_RichardMarx_1.jpg'),
(191, 39, 'albumCaSi\39_RichardMarx_2.jpg'),
(192, 39, 'albumCaSi\39_RichardMarx_3.jpg'),
(193, 39, 'albumCaSi\39_RichardMarx_4.jpg'),
(194, 39, 'albumCaSi\39_RichardMarx_5.jpg'),
(195, 40, 'albumCaSi\40_MichaelJackSon_1.jpg'),
(196, 40, 'albumCaSi\40_MichaelJackSon_2.jpg'),
(197, 40, 'albumCaSi\40_MichaelJackSon_3.jpg'),
(198, 40, 'albumCaSi\40_MichaelJackSon_4.jpg'),
(199, 40, 'albumCaSi\40_MichaelJackSon_5.jpg');
GO

CREATE TABLE baihat (
  id_baihat int PRIMARY KEY,
  id_casi int DEFAULT NULL,
  tenbaihat nvarchar(100) DEFAULT NULL,
  theloai nvarchar(50) DEFAULT NULL,
  luotnghe int DEFAULT NULL,
  album nvarchar(255) DEFAULT NULL,
  linknhac nvarchar(255) DEFAULT NULL
)

--
-- Dumping data for table baihat
--

INSERT INTO baihat (id_baihat, id_casi, tenbaihat, theloai, luotnghe, album, linknhac) VALUES
(1, 1, N'Âm thầm bên em', N'Nhạc trẻ', 0, 'album\Amthambenem.jpg', 'audio\nhactre1.mp3'),
(2, 1, N'Anh sai rồi', N'Nhạc trẻ', 0, 'album\AnhSaiRoi.jpg', 'audio\nhactre2.mp3'),
(3, 1, N'Chắc ai đó sẽ về ', N'Nhạc trẻ', 0, 'album\chacaidoseve.jpg', 'audio\nhactre3.mp3'),
(4, 2, N'Chập chờn', N'Nhạc trẻ', 0, 'album\chapchon.jpg', 'audio\nhactre8.mp3'),
(5, 2, N'Pin dự phòng', N'Nhạc trẻ', 0, 'album\pinduphong.jpg', 'audio\nhactre9.mp3'),
(6, 2, N'Tràn bộ nhớ', N'Nhạc trẻ', 0, 'album\tranbonho.jpg', 'audio\nhactre10.mp3'),
(7, 3, N'Anh đứng đây từ giờ tới mai', N'Nhạc trẻ', 0, 'album\anhdungdaytugiotoimai.jpg', 'audio\nhactre4.mp3'),
(8, 3, N'Chân đất', N'Nhạc trẻ', 0, 'album\chandat.jpg', 'audio\nhactre5.mp3'),
(9, 3, N'Dại', N'Nhạc trẻ', 0, 'album\dai.jpg', 'audio\nhactre6.mp3'),
(10, 3, N'Em à', N'Nhạc trẻ', 0, 'album\ema.jpg', 'audio\nhactre7.mp3'),
(11, 4, N'Em có nghe', N'Nhạc trẻ', 0, 'album\emconghe.jpg', 'audio\nhactre20.mp3'),
(12, 4, N'Lời yêu ngây dại', N'Nhạc trẻ', 0, 'album\loiyeungaydai.jpg', 'audio\nhactre21.mp3'),
(13, 5, N'Hoa hải đường', N'Nhạc trẻ', 0, 'album\jack1.jpg', 'audio\nhactre28.mp3'),
(14, 5, N'Ngôi sao cô đơn', N'Nhạc trẻ', 0, 'album\jack1.jpg', 'audio\nhactre29.mp3'),
(15, 5, N'Đom đóm', N'Nhạc trẻ', 0, 'album\jack1.jpg', 'audio\nhactre30.mp3'),
(16, 6, N'Áo mùa đông', N'Nhạc trẻ', 0, 'album\aomuadong.jpg', 'audio\nhactre19.mp3'),
(17, 6, N'Bài ca hi vọng', N'Nhạc trẻ', 0, 'album\baicahivong.jpg', 'audio\nhactre17.mp3'),
(18, 6, N'Mẹ (album lời tặng mẹ)', N'Nhạc trẻ', 0, 'album\me.jpg', 'audio\nhactre18.mp3'),
(19, 7, N'Giờ thì ai cười', N'Nhạc trẻ', 0, 'album\giothiaicuoi.jpg', 'audio\nhactre13.mp3'),
(20, 7, N'Không phải gu', N'Nhạc trẻ', 0, 'album\khongphaigu.jpg', 'audio\nhactre11.mp3'),
(21, 7, N'Siêu sao', N'Nhạc trẻ', 0, 'album\sieusao.jpg', 'audio\nhactre12.mp3'),
(22, 8, N'Đã có anh', N'Nhạc trẻ', 0, 'album\dacoanh.jpg', 'audio\nhactre27.mp3'),
(23, 8, N'Dễ đến dễ đi', N'Nhạc trẻ', 0, 'album\dedendedi.jpg', 'audio\nhactre25.mp3'),
(24, 8, N'Đừng vì anh mà khóc', N'Nhạc trẻ', 0, 'album\dungvianhmakhoc.jpg', 'audio\nhactre26.mp3'),
(25, 9, N'Nếu mai này xa nhau', N'Nhạc trẻ', 0, 'album\neumainayxanhau.jpg', 'audio\nhactre14.mp3'),
(26, 9, N'Người đến sau thay em', N'Nhạc trẻ', 0, 'album\nguoidensauthayem.jpg', 'audio\nhactre15.mp3'),
(27, 9, N'Thị Mầu', N'Nhạc trẻ', 0, 'album\thimau.jpg', 'audio\nhactre16.mp3'),
(28, 11, N'Lậy mẹ quang âm', N'Nhạc trẻ', 0, 'album\laymequangam.jpg', 'audio\nhactre22.mp3'),
(29, 11, N'Lậy phật con về', N'Nhạc trẻ', 0, 'album\nth.jpg', 'audio\nhactre23.mp3'),
(30, 11, N'Mẹ từ bi', N'Nhạc trẻ', 0, 'album\nth.jpg', 'audio\nhactre24.mp3'),
(31, 11, N'Ơn Bác Hồ Với Người Tây Nguyên', N'Nhạc Đỏ', 5800, 'album\31_OBHVNTN.jpg', 'audio\31_OBHVNTN.mp3'),
(32, 11, N'Đêm Nghe Đò Đưa Nhớ Bác', N'Nhạc Đỏ', 3600, 'album\32_ĐNĐĐNB.jpg', 'audio\32_ĐNĐĐNB.mp3'),
(33, 11, N'Đất Nước', N'Nhạc Đỏ', 3100, 'album\33_ĐN.jpg', 'audio\33_ĐN.mp3'),
(34, 12, N'Bài Ca Thống Nhất', N'Nhạc Đỏ', 2500, 'album\34_BCTN.jpg', 'audio\34_BCTN.mp3'),
(35, 12, N'Hành Khúc Ngày Và Đêm', N'Nhạc Đỏ', 3682, 'album\35_HKNVĐ.jpg', 'audio\35_HKNVĐ.mp3'),
(36, 12, N'Đường Trường Sơn Xe Anh Qua', N'Nhạc Đỏ', 1065, 'album\36_ĐTSXAQ.jpg', 'audio\36_ĐTSXAQ.mp3'),
(37, 13, N'Chào Anh Giải Phóng Quân', N'Nhạc Đỏ', 1654, 'album\37_CAGPQ.jpg', 'audio\37_CAGPQ.mp3'),
(38, 13, N'Tổ Quốc Tôi Chưa Đẹp Thế Bao Giờ', N'Nhạc Đỏ', 887, 'album\38_TQTCĐNTBG.jpg', 'audio\38_TQTCĐTBG.mp3'),
(39, 13, N'Mãi Mãi Niềm Tin Theo Đảng', N'Nhạc Đỏ', 986, 'album\39_MMNTTĐ.jpg', 'audio\39_MMNTTĐ.mp3'),
(40, 14, N'Bài Ca Hồ Chí Minh', N'Nhạc Đỏ', 5000, 'album\40_BCHCM.jpg', 'audio\40_BCHCM.mp3'),
(41, 14, N'Giai Điệu Tổ Quốc', N'Nhạc Đỏ', 4540, 'album\41_GĐTQ.jpg', 'audio\41_GDTQ.mp3'),
(42, 14, N'Mùa Xuân Bên Cửa Sổ ', N'Nhạc Đỏ', 1100, 'album\42_MXBCS.jpg', 'audio\42_MXBCS.mp3'),
(43, 15, N'Như Có Bác Hồ Trong Ngày Vui Đại Thắng', N'Nhạc Đỏ', 8990, 'album\43_NCBHTNVĐT.jpg', 'audio\43_NCBHTNVĐT.mp3'),
(44, 15, N'Cô Gái Mở Đường', N'Nhạc Đỏ', 7576, 'album\44_CGMĐ.jpg', 'audio\44_CGMĐ.mp3'),
(45, 16, N'Cùng Hành Quân Giữa Mùa Xuân', N'Nhạc Đỏ', 4505, 'album\45_CHQGMX.jpg', 'audio\45_CHQGMX.mp3'),
(46, 16, N'Bác Hồ Một Tình Yêu Bao La', N'Nhạc Đỏ', 1251, 'album\46_BHMTYBL.jpg', 'audio\46_BHMTYBL.mp3'),
(47, 16, N'Con Kênh  Ta Đào', N'Nhạc Đỏ', 4524, 'album\47_CKTĐ.jpg', 'audio\47_CKTĐ.mp3'),
(48, 16, N'Tàu Anh Qua Núi', N'Nhạc Đỏ', 7372, 'album\48_TAQN.jpg', 'audio\48_TAQN.mp3'),
(49, 17, N'Lời Bác Dạy Từ Mùa Xuân Năm Ây', N'Nhạc Đỏ', 7404, 'album\49_LBHDTMXjpg.jpg', 'audio\49_LBDTMX.mp3'),
(50, 17, N'Đảng Là Cuộc Sống Của Tôi', N'Nhạc Đỏ', 5421, 'album\50_ĐLCSCT.jpg', 'audio\50_ĐLCSCT.mp3'),
(51, 17, N'Dưới Lá Cờ Vinh Quang', N'Nhạc Đỏ', 1253, 'album\51_DLCVQ.jpg', 'audio\51_DLCVQ.mp3'),
(52, 18, N'Bài Ca Đường Chín Chiến Thắng', N'Nhạc Đỏ', 4512, 'album\52_BCĐCCT.jpg', 'audio\52_BCĐCCT.mp3'),
(53, 18, N'Bài Ca Người Nữ Tự Vệ Sài Gòn', N'Nhạc Đỏ', 1201, 'album\53_BCNNTVSG.jpg', 'audio\53_BCNNTVSG.mp3'),
(54, 18, N'Màu Hoa Đỏ', N'Nhạc Đỏ', 4531, 'album\54_MHĐ.jpg', 'audio\54_MHĐ.mp3'),
(55, 19, N'Đất Nước Trọn Niềm Vui', N'Nhạc Đỏ', 9682, 'album\55_ĐNTNV.jpg', 'audio\55_ĐNTNV.mp3'),
(56, 19, N'Trường Sơn Đông Trường Sơn Tây', N'Nhạc Đỏ', 9142, 'album\56_TSĐTST.jpg', 'audio\56_TSĐTST.mp3'),
(57, 19, N'Lá Đỏ', N'Nhạc Đỏ', 434, 'album\57_LĐ.jpg', 'audio\57_LĐ.mp3'),
(58, 20, N'Tổ Quốc Gọi Tên Mình', N'Nhạc Đỏ', 4524, 'album\58__TQGTM.jpg', 'audio\58_TQGTM.mp3'),
(59, 20, N'Linh Thiêng Việt Nam', N'Nhạc Đỏ', 3443, 'album\59_LTVN.jpg', 'audio\59_LTVN.mp3'),
(60, 20, N'Bài Ca Xây Dựng', N'Nhạc Đỏ', 1210, 'album\60_BCXD.jpg', 'audio\60_BCXD.mp3'),
(61, 21, N'GHỆ MỚI', N'Nhạc Rap', 1, 'album\ghemoi.jpg', 'audio\ghemoi.mp3'),
(62, 21, N'Hoàn Hảo', N'Nhạc Rap', 2, 'album\hoanhao.jpg', 'audio\hoanhao.mp3'),
(63, 21, N'ba da bum', N'Nhạc Rap', 3, 'album\badabum.jpg', 'audio\badabum.mp3'),
(64, 22, N'Rồi Lại Quên (ft. Yungd)', N'Nhạc Rap', 4, 'album\roilaiquen.jpg', 'audio\roilaiquen.mp3'),
(65, 22, N'Nhất sách', N'Nhạc Rap', 5, 'album\nhatsach.jpg', 'audio\nhatsach.mp3'),
(66, 22, N'Lời Yêu Ngàn Năm', N'Nhạc Rap', 6, 'album\loiyeungannam.jpg', 'audio\loiyeungannam.mp3'),
(67, 23, N'1TINHYEU', N'Nhạc Rap', 7, 'album\1tinhyeu.jpg', 'audio\1tinhyeu.mp3'),
(68, 23, N'Wrong Times', N'Nhạc Rap', 8, 'album\wrongtimes.jpg', 'audio\wrongtimes.mp3'),
(69, 23, N'Love somebody', N'Nhạc Rap', 9, 'album\lovesomebody.jpg', 'audio\lovesomebody.mp3'),
(70, 24, N'Lan Man', N'Nhạc Rap', 10, 'album\lanman.jpg', 'audio\lanman.mp3'),
(71, 24, N'lời không nói', N'Nhạc Rap', 11, 'album\loikhongnoi.jpg', 'audio\loikhongnoi.mp3'),
(72, 24, N'khi mà', N'Nhạc Rap', 12, 'album\khima.jpg', 'audio\khima.mp3'),
(73, 25, N'2 Phút Hơn', N'Nhạc Rap', 13, 'album\2phuthon.jpg', 'audio\2phuthon.mp3'),
(74, 25, N'sự nghiệp chướng', N'Nhạc Rap', 14, 'album\sunghiepchu.jpg', 'audio\sunghiepchuong.mp3'),
(75, 25, N'Kìa bóng dáng ai', N'Nhạc Rap', 15, 'album\kiabongdangai.jpg', 'audio\kiabongdangai.mp3'),
(76, 26, N'Vị Nhà', N'Nhạc Rap', 16, 'album\vinha.jpg', 'audio\vinha.mp3'),
(77, 26, N'nhạc của rừng', N'Nhạc Rap', 17, 'album\nhaccuarung.jpg', 'audio\nhaccuarung.mp3'),
(78, 26, N'Bài này chill phết', N'Nhạc Rap', 18, 'album\bainaychillphet.jpg', 'audio\bainaychillphet.mp3'),
(79, 27, N'Thap drill tu do', N'Nhạc Rap', 100, 'album\thapdrilltudo.jpg', 'audio\thapdrilltudo.mp3'),
(80, 27, N'Chìm sâu', N'Nhạc Rap', 20, 'album\chimsau.jpg', 'audio\chimsau.mp3'),
(81, 27, N'Phong cách', N'Nhạc Rap', 21, 'album\phongcach.jpg', 'audio\phongcach.mp3'),
(82, 28, N'COLORS', N'Nhạc Rap', 22, 'album\COLORS.jpg', 'audio\COLORS.mp3'),
(83, 28, N'Lối đi riêng', N'Nhạc Rap', 23, 'album\loidirieng.jpg', 'audio\loidirieng.mp3'),
(84, 28, N'Cung tên tình yêu', N'Nhạc Rap', 24, 'album\cungtentinhyeu.jpg', 'audio\cungtentinhyeu.mp3'),
(85, 29, N'Sài Gòn ơi', N'Nhạc Rap', 25, 'album\saigonoi.jpg', 'audio\saigonoi.mp3'),
(86, 29, N'Đánh đổi', N'Nhạc Rap', 26, 'album\danhdoi.jpg', 'audio\danhdoi.mp3'),
(87, 29, N'thap trap tu do', N'Nhạc Rap', 27, 'album\thaptraptudo.jpg', 'audio\thaptraptudo.mp3'),
(88, 30, N'Love is', N'Nhạc Rap', 28, 'album\loveis.jpg', 'audio\loveis.mp3'),
(89, 30, N'MOIEM', N'Nhạc Rap', 29, 'album\MOIEM.jpg', 'audio\MOIEM.mp3'),
(90, 30, N'ngựa ô', N'Nhạc Rap', 30, 'album\nguao.jpg', 'audio\nguao.mp3'),
(91, 31, N'Diamonds', N'Nhạc Âu', 100, 'album\diamonds.jpg', 'audio\diamonds.mp3'),
(92, 31, N'This Is What You Came For', N'Nhạc Âu', 200, 'album\thisiswhatyoucamefor.jpg', 'audio\thisiswhatyoucamefor.mp3'),
(93, 31, N'We Found Love', N'Nhạc Âu', 300, 'album\wefoundlove.jpg', 'audio\wefoundlove.mp3'),
(94, 32, N'Bad Liar', N'Nhạc Âu', 400, 'album\badliar.jpg', 'audio\badliar.mp3'),
(95, 32, N'Believer', N'Nhạc Âu', 500, 'album\believer.jpg', 'audio\believer.mp3'),
(96, 32, N'Demons', N'Nhạc Âu', 600, 'album\demons.jpg', 'audio\demons.mp3'),
(97, 33, N'Within Youll Remain', N'Nhạc Âu', 700, 'album\withinyoullremain.jpg', 'audio\withinyoullremain.mp3'),
(98, 33, N'Oriental City', N'Nhạc Âu', 800, 'album\withinyoullremain.jpg', 'audio\orientalcity.mp3'),
(99, 33, N'W thout Your Love', N'Nhạc Âu', 900, 'album\withinyoullremain.jpg', 'audio\withinyoullremain.mp3'),
(100, 34, N'Endless Love', N'Nhạc Âu', 1000, 'album\endlesslove.jpg', 'audio\endlesslove.mp3'),
(101, 34, N'I We Hold O Together', N'Nhạc Âu', 1100, 'album\ifweholdontoghether.jpg', 'audio\ifweholdontogether.mp3'),
(102, 34, N'Upside Down', N'Nhạc Âu', 1200, 'album\upsidedown.jpg', 'audio\upsidedown.mp3'),
(103, 35, N'We  T Party', N'Nhạc Âu', 1300, 'album\weliketheparty.jpg', 'audio\weliketoparty.mp3'),
(104, 35, N'T Brazil', N'Nhạc Âu', 1400, 'album\tobrazil.jpg', 'audio\tobrazil.mp3'),
(105, 35, N'Parada De Tettas', N'Nhạc Âu', 1500, 'album\paradadetettas.jpg', 'audio\parada.mp3'),
(106, 36, N'Back T The 80s', N'Nhạc Âu', 1600, 'album\aqua.jpg', 'audio\backto.mp3'),
(107, 36, N'My Mamma Said', N'Nhạc Âu', 1700, 'album\aqua.jpg', 'audio\mymam.mp3'),
(108, 36, N'Die Young', N'Nhạc Âu', 1800, 'album\aqua.jpg', 'audio\dieyoung.mp3'),
(109, 37, N'Strong Enough', N'Nhạc Âu', 1900, 'album\strong.jpg', 'audio\strong.mp3'),
(110, 37, N'Fernando', N'Nhạc Âu', 2000, 'album\fernando.jpg', 'audio\fernando.mp3'),
(111, 37, N'The Shoop Shoop Song', N'Nhạc Âu', 2100, 'album\theshoop.jpg', 'audio\theshoop.mp3'),
(112, 38, N'Every Day I Love You', N'Nhạc Âu', 2200, 'album\everyday.jpg', 'audio\everyday.mp3'),
(113, 38, N'Words', N'Nhạc Âu', 2300, 'album\words.jpg', 'audio\words.mp3'),
(114, 38, N'All That I Need', N'Nhạc Âu', 2400, 'album\allthat.jpg', 'audio\allthat.mp3'),
(115, 39, N'Right Here Waiting', N'Nhạc Âu', 2500, 'album\right.jpg', 'audio\right.mp3'),
(116, 39, N'Angelia', N'Nhạc Âu', 2600, 'album\angelia.jpg', 'audio\angelia.mp3'),
(117, 39, N'Hazard', N'Nhạc Âu', 2700, 'album\hazard.jpg', 'audio\hazard.mp3'),
(118, 40, N'Billie Jean', N'Nhạc Âu', 2800, 'album\billie.jpg', 'audio\billie.mp3'),
(119, 40, N'Beat It', N'Nhạc Âu', 2900, 'album\beat.jpg', 'audio\beat.mp3'),
(120, 40, N'Rock With You', N'Nhạc Âu', 3000, 'album\rock.jpg', 'audio\rock.mp3'),
(121, 41, N'偏向', N'Nhạc Trung', 0, 'album\im1.png', 'audio\nhactrung1.mp3'),
(122, 41, N'偏向陳子晴 - 偏向我嫌', N'Nhạc Trung', 0, 'album\im2.png', 'audio\nhactrung2.mp3'),
(123, 41, N'孤岛星愿', N'Nhạc Trung', 0, 'album\im3.png', 'audio\nhactrung3.mp3'),
(124, 42, N'葛东琪 - 囍', N'Nhạc Trung', 0, 'album\im4.png', 'audio\nhactrung4.mp3'),
(125, 42, N'葛東琪 - 懸溺', N'Nhạc Trung', 0, 'album\im5.png', 'audio\nhactrung5.mp3'),
(126, 42, N'葛東琪 - 風吹丹', N'Nhạc Trung', 0, 'album\im6.png', 'audio\nhactrung6.mp3'),
(127, 43, N'是你', N'Nhạc Trung', 0, 'album\im7.png', 'audio\nhactrung7.mp3'),
(128, 43, N'一路生花', N'Nhạc Trung', 0, 'album\im8.png', 'audio\nhactrung8.mp3'),
(129, 43, N'若月亮没来', N'Nhạc Trung', 0, 'album\im9.png', 'audio\nhactrung9.mp3'),
(130, 44, N'这辈子欠自己太多', N'Nhạc Trung', 0, 'album\im10.png', 'audio\nhactrung10.mp3'),
(131, 44, N'你的婚纱像雪花', N'Nhạc Trung', 0, 'album\im11.png', 'audio\nhactrung11.mp3'),
(132, 44, N'我要的不是雪', N'Nhạc Trung', 0, 'album\im12.png', 'audio\nhactrung12.mp3'),
(133, 45, N'好戏', N'Nhạc Trung', 0, 'album\im13.png', 'audio\nhactrung13.mp3'),
(134, 45, N'忘了没有', N'Nhạc Trung', 0, 'album\im14.png', 'audio\nhactrung14.mp3'),
(135, 45, N'泛泛之友', N'Nhạc Trung', 0, 'album\im15.png', 'audio\nhactrung15.mp3'),
(136, 46, N'白露', N'Nhạc Trung', 0, 'album\im16.png', 'audio\nhactrung16.mp3'),
(137, 46, N'撒浪嘿', N'Nhạc Trung', 0, 'album\im17.png', 'audio\nhactrung17.mp3'),
(138, 46, N'惊蛰', N'Nhạc Trung', 0, 'album\im18.png', 'audio\nhactrung18.mp3'),
(139, 47, N' 红马 (女版)', N'Nhạc Trung', 0, 'album\im19.png', 'audio\nhactrung19.mp3'),
(140, 47, N'月落的声音', N'Nhạc Trung', 0, 'album\im20.png', 'audio\nhactrung20.mp3'),
(141, 47, N'无人区玫瑰', N'Nhạc Trung', 0, 'album\im21.png', 'audio\nhactrung21.mp3'),
(142, 48, N'被神明写的歌', N'Nhạc Trung', 0, 'album\im22.png', 'audio\nhactrung22.mp3'),
(143, 48, N'別無所愛', N'Nhạc Trung', 0, 'album\im23.png', 'audio\nhactrung23.mp3'),
(144, 48, N'绳结', N'Nhạc Trung', 0, 'album\im24.png', 'audio\nhactrung24.mp3'),
(145, 49, N'疑心病', N'Nhạc Trung', 0, 'album\im25.png', 'audio\nhactrung25.mp3'),
(146, 49, N'然后呢', N'Nhạc Trung', 0, 'album\im26.png', 'audio\nhactrung26.mp3'),
(147, 49, N'李夢尹', N'Nhạc Trung', 0, 'album\im27.png', 'audio\nhactrung27.mp3'),
(148, 50, N'起风了', N'Nhạc Trung', 0, 'album\im28.png', 'audio\nhactrung28.mp3'),
(149, 50, N'周深', N'Nhạc Trung', 0, 'album\im29.png', 'audio\nhactrung29.mp3'),
(151, 50, N'青花瓷', N'Nhạc Trung', 0, 'album\im31.png', 'audio\nhactrung31.mp3');

UPDATE baihat
SET luotnghe = FLOOR(RAND(id_baihat) * (10000 - 100 + 1)) + 100;
-- --------------------------------------------------------

--
-- Table structure for table casi
--

CREATE TABLE casi (
  id_casi int PRIMARY KEY,
  tenCaSi nvarchar(100) DEFAULT NULL
)

--
-- Dumping data for table casi
--

INSERT INTO casi (id_casi, tenCaSi) VALUES
(1, N'Sơn Tùng MTP'),
(2, N'Dương Domic'),
(3, N'Bùi Trương Linh'),
(4, N'Kha'),
(5, N'Jack97'),
(6, N'Tùng Dương'),
(7, N'Hiếu Thứ 2'),
(8, N'Quang Hùng MasterD'),
(9, N'Hoà Minzy'),
(10, N'Ngân Ngân\r\n'),
(11, N'Nguyễn Thu Hằng\r\n'),
(12, N'Yên Nhiên'),
(13, N'Đỗ Thành Danh\r\n'),
(14, N'Quang Hà'),
(15, N'Hoàng Minh Thắng'),
(16, N'NSND Thanh Hoa'),
(17, N'Khương Hùng'),
(18, N'NSUT Hương Giang'),
(19, N'Tạ Minh Tâm'),
(20, N'Quang Thiện'),
(21, N'B Ray'),
(22, N'Hades'),
(23, N'Puppy'),
(24, N'RonBoogz'),
(25, N'Pháo'),
(26, N'Đen Vâu'),
(27, N'MCK'),
(28, N'Pháp Kiều'),
(29, N'Obito'),
(30, N'Dangrangto'),
(31, N'Rihanna'),
(32, N'Imagine Dragons'),
(33, N'Tokyo Square'),
(34, N'Diana Ross'),
(35, N'Vengaboys'),
(36, N'Aqua'),
(37, N'Cher'),
(38, N'Boyzone'),
(39, N'Richard Marx'),
(40, N'Michael Jackson'),
(41, N'Trần Tử Tình'),
(42, N'Cát Đông Kỳ'),
(43, N'Mộng Nhiên'),
(44, N'Lý Phát Phát'),
(45, N'Vương Tĩnh Văn'),
(46, N'Vương Tử Ngọc'),
(47, N'Hứa Lam Tâm'),
(48, N'Tưởng Tiểu Ni'),
(49, N'Nhậm Nhiên'),
(50, N'Châu Thâm');
 
--
-- Indexes for dumped tables
--

--
-- Indexes for table albumcasi
--

--
-- Indexes for table baihat
--

--
-- Indexes for table casi
--
-
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table baihat
--
ALTER TABLE baihat
  MODIFY id_baihat int AUTO_INCREMENT, AUTO_INCREMENT=152;

--
-- AUTO_INCREMENT for table casi
--
ALTER TABLE casi
  MODIFY id_casi int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=51;

--
-- Constraints for dumped tables
--

--
-- Constraints for table albumcasi
--
ALTER TABLE albumcasi
  ADD CONSTRAINT albumcasi_ibfk_1 FOREIGN KEY (id_casi) REFERENCES casi (id_casi);

--
-- Constraints for table baihat
--
ALTER TABLE baihat
  ADD FOREIGN KEY (id_casi) REFERENCES casi (id_casi);


	  select id_baihat, tenbaihat, tenCaSi, theloai, linknhac from baihat, casi WHERE baihat.id_casi = casi.id_casi and id_baihat > 0 and id_baihat < 31 order by newid()