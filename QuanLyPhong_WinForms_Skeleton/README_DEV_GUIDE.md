# Skeleton phát triển tính năng 3.1–3.8 (WinForms .NET 9)

Sinh lúc: 2025-10-29T03:20:15.139132

## Mapping nhanh
- 3.1.1 OTP: `Security/OtpService.cs`, UI: `Forms/FrmOtp.cs`
- 3.1.2 Mã hoá: `Data/EncryptionHelper.cs` (AES-256)
- 3.1.3 Backup: `Security/BackupService.cs`, UI: `Forms/FrmBackup.cs`

- 3.2.x Phòng: `Forms/FrmPhong.cs`, `Models/Phong.cs`, `Models/LoaiPhong.cs`, `Models/TienIch.cs`
- 3.2.4 API phòng: `Services/ApiPhongService.cs`

- 3.3.x Khách/Hợp đồng: `Forms/FrmKhachThue.cs`, `Forms/FrmHopDong.cs`, Upload: `FrmHopDong` + `FileHopDongPath`
  - Lịch sử người thuê: `Models/LichSuNguoiThue.cs`
  - Nhắc hết hạn HĐ: `Services/NotificationService.cs` + `Services/SchedulerService.cs`

- 3.4.x Biểu phí & Điện/Nước: `Models/BieuPhi.cs`, `Models/LichSuBieuPhi.cs`, `Forms/FrmDienNuoc.cs`
  - OCR: `Services/OcrService.cs`
  - Phí xe: `Models/PhuongTien.cs`, Rule: `Services/RuleService.cs`

- 3.5.x Thanh toán & thông báo: `Forms/FrmHoaDon.cs`
  - Template mapping & PDF/Excel: `Services/PdfExportService.cs`
  - Email/SMS/Zalo: `Services/NotificationService.cs`
  - Scheduler: `Services/SchedulerService.cs`

- 3.6.x Báo cáo: `Forms/FrmBaoCao.cs` + `Services/ReportService.cs`

- 3.7.x Bảo trì: `Forms/FrmBaoTri.cs`

- 3.8.x Vân tay & auto-reminder: `Models/VanTay.cs`, UI: `Forms/FrmVanTay.cs`

## Khởi động
- `Program.cs` → `FrmDangNhap` → OTP (`FrmOtp`) → `FrmMain` (menu gọi các form).

## Gợi ý triển khai kế tiếp
1. Kết nối CRUD thực cho `FrmPhong` (dùng `ApiPhongService`). 
2. Thêm EF cho `Khách/Hợp đồng`, `Điện/Nước`, generate bảng & seed.
3. `PdfExportService` → QuestPDF/OpenXML.
4. `NotificationService` → SMTP/SMS Gateway.
5. `SchedulerService` → lập lịch nhắc phí & hết hạn HĐ.
