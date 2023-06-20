CREATE DATABASE Quan_Ly_Ban_Hang
use Quan_Ly_Ban_Hang
-- Câu lênh sql tạo bảng T_ChatLieu
CREATE TABLE T_ChatLieu
(
    MaChatLieu NCHAR(20) not null,
    TenChatLieu NVARCHAR(200) not null,
    PRIMARY KEY(MaChatLieu)
)
-- Câu lênh sql tạo bảng T_KhachHang
CREATE TABLE T_KhachHang
(
    MaKhach NCHAR(20) not null,
    TenKhach NVARCHAR(200) not null,
    GioiTinh NCHAR(10) not null,
    NgaySinh DATETIME not null,
    DiaChi NVARCHAR(200) not null,
    DienThoai char(20) not null,
    PRIMARY key(MaKhach)
)
-- Câu lênh sql tạo bảng T_HangHoa
CREATE TABLE T_HangHoa
(
    MaHang NCHAR(20) not null,
    TenHang NVARCHAR(200) not null,
    MaChatLieu NCHAR(20) not null,
    SoLuong int not null,
    DonGiaNhap FLOAT not null,
    DonGiaBan FLOAT not null,
    GhiChu NVARCHAR(300) null,
    PRIMARY key(MaHang),
    FOREIGN key(MaChatLieu) REFERENCES T_ChatLieu (MaChatLieu)
)

-- Câu lênh sql tạo bảng T_NhanVien
CREATE TABLE T_NhanVien
(
    MaNhanVien nchar(20) not null,
    TenNv NVARCHAR(200) not null,
    GioiTinh NCHAR(10) not null,
    NgaySinh DATETIME not null,
    DiaChi NVARCHAR(100) not null,
    DienThoai NCHAR(20) not null,
    PRIMARY key(MaNhanVien)
)

-- Câu lênh sql tạo bảng T_HoaDonBan
CREATE TABLE T_HoaDonBan
(
    MaHDBan NCHAR(20) not null,
    MaNhanVien nchar(20) not null,
    NgayBan DATETIME not null,
    MaKhach NCHAR(20) not null,
    PRIMARY key(MaHDBan),
    FOREIGN key(MaNhanVien) REFERENCES T_NhanVien(MaNhanVien),
    FOREIGN key (MaKhach) REFERENCES T_KhachHang(MaKhach) 
)

-- Câu lênh sql tạo bảng T_ChiTietHDBan
CREATE TABLE T_ChiTietHDBan
(
    MaHDBan NCHAR(20) not null,
    MaHang NCHAR(20) not null,
    SoLuong int not null,
    GiamGia float not null,
    PRIMARY key(MaHDBan,MaHang),
    FOREIGN key(MaHDBan) REFERENCES T_HoaDonBan(MaHDBan),
    FOREIGN key (MaHang) REFERENCES T_HangHoa(MaHang)
)

-- Câu lênh sql tạo bảng T_TaiKhoan
CREATE TABLE T_TaiKhoan
(
    TaiKhoan NCHAR(50) not null,
    MatKhau NVARCHAR(100) not null,
    Email NVARCHAR(100) not null,
    PRIMARY key(TaiKhoan)
)

--cau 1
select* from T_TaiKhoan where TaiKhoan = 'admin' and MatKhau = 'admin'
--câu 2
select MaHang as N'Mã Hàng', TenHang as N'Tên Hàng',MaChatLieu as N'Mã chất liệu',SoLuong as N'Số lượng',DonGiaNhap N'Đơn giá nhập',DonGiaBan N'Đơn giá bán',GhiChu N'Ghi chú' from T_HangHoa
--câu 3
select MaKhach as N'Mã khách',TenKhach as N'Tên khách',GioiTinh as N'Ngày Sinh',DiaChi as N'Địa chỉ',DienThoai as N'Điện thoại' from T_KhachHang
--câu4
select MaHang as N'Mã Hàng', TenHang as N'Tên Hàng',TenChatLieu as N'Tên chất liệu',SoLuong as N'Số lượng',DonGiaNhap N'Đơn giá nhập',DonGiaBan N'Đơn giá bán',GhiChu N'Ghi chú' from T_HangHoa,T_ChatLieu where T_HangHoa.MaChatLieu = T_ChatLieu.MaChatLieu and MaHang like '%52%'
--câu 5
select MaNhanVien as N'Mã nhân viên',TenNv as N'Tên nhân viên',GioiTinh as N'Giới tính',NgaySinh as N'Ngày sinh',DiaChi as N'Địa chỉ',DienThoai as N'Điện thoại' from T_NhanVien
--câu 6
select T_HangHoa.MaHang,TenHang,T_ChiTietHDBan.SoLuong,DonGiaBan,GiamGia,(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*3/100) as N'Thành tiền' from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa
--câu7
select T_HoaDonBan.MaHDban as N'Mã hóa đơn',T_NhanVien.MaNhanVien as N'Mã nhân viên',TenNv as N'Tên nhân viên',NgayBan as N'Ngày Bán',T_KhachHang.MaKhach as N'Mã khách',TenKhach as N'Tên Khách' from T_ChiTietHDBan,T_HoaDonBan,T_NhanVien,T_KhachHang where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_NhanVien.MaNhanVien =T_HoaDonBan.MaNhanVien and T_HoaDonBan.MaKhach = T_KhachHang.MaKhach
--câu8
select T_ChiTietHDBan.MaHDBan, T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Thành tiền' from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan
--câu 9
select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) as N'Tổng tiền'
from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa ,T_NhanVien,T_KhachHang
where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaHDBan = 'HD1' 
group by(T_HoaDonBan.MaHDBan)
--câu 10
select T_HoaDonBan.MaNhanVien,TenNv,T_HoaDonBan.MaHDBan,NgayBan,T_ChiTietHDBan.MaHang,TenHang,T_ChiTietHDBan.SoLuong,DonGiaBan,GiamGia,(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*3/100) as N'Thành tiền' 
from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa,T_NhanVien 
where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaNhanVien = T_NhanVien.MaNhanVien and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_HoaDonBan.MaNhanVien = '001' and NgayBan = '5/9/2023'
--câu 11
select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*3/100)
from T_ChiTietHDBan,T_HoaDonBan,T_HangHoa,T_NhanVien 
where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_HoaDonBan.MaNhanVien = T_NhanVien.MaNhanVien and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang and T_HoaDonBan.MaNhanVien = '001'
group by (T_HoaDonBan.MaNhanVien)
--câu 12
select T_ChiTietHDBan.MaHDBan as N'Mã hóa đơn',T_HangHoa.MaHang as N'Mã hàng',TenHang as N'Tên hàng',NgayBan as N'Ngày bán',T_ChiTietHDBan.SoLuong as N'Số lượng',DonGiaBan as N'Đơn giá',GiamGia as N'Giảm giá',(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*3/100) as N'Tổng tiền' 
from T_ChiTietHDBan,T_HangHoa,T_HoaDonBan 
where T_ChiTietHDBan.MaHDBan = T_HoaDonBan.MaHDBan and T_ChiTietHDBan.MaHang = T_HangHoa.MaHang 
--cau1
select sum(T_ChiTietHDBan.SoLuong*DonGiaBan - T_ChiTietHDBan.SoLuong*DonGiaBan*GiamGia/100) from T_ChiTietHDBan,T_HangHoa where T_ChiTietHDBan.MaHang = T_HangHoa.MaHang

--câu 13 
select T_HangHoa.TenHang,sum(T_ChiTietHDBan.SoLuong) as N'Số lượng bán'
from T_HangHoa,T_ChiTietHDBan,T_ChatLieu
where T_HangHoa.MaHang = T_ChiTietHDBan.MaHang and T_HangHoa.MaChatLieu = T_ChatLieu.MaChatLieu
group by(T_HangHoa.TenHang)
--câu 14
select T_HangHoa.MaHang,TenHang,T_ChatLieu.MaChatLieu,TenChatLieu,SoLuong,DonGiaNhap,DonGiaBan
from T_HangHoa,T_ChatLieu
where T_HangHoa.MaChatLieu = T_ChatLieu.MaChatLieu








