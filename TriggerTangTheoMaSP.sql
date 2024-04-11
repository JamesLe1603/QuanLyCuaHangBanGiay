go
--Tạo trigger cho bảng nhà cung cấp
create trigger Trig_TangMaNCC
on NhaCungCap
after insert 
as 
begin
	declare @MaNCC  int 
	set @MaNCC =( select MAX(MaNCC) +1 from NHACUNGCAP)
	UPDATE NHACUNGCAP 
	SET MANCC = @MaNCC
	WHERE MANCC = 0
end 
--Tạo trigger cho bảng sản phẩm 
alter trigger Trig_TangMaSP
on SanPham
after insert 
as 
begin
	declare @MaSP  int 
	set @MaSP =( select MAX(MaSP) +1 from SANPHAM)
	UPDATE SANPHAM
	SET MASP = @MaSP
	WHERE MASP = 0
end 

--Tạo trigger cho bảng khách hàng
create trigger Trig_TangMaKH
on KHACHHANG
after insert 
as 
begin
	declare @MaKH int 
	set @MaKH =( select MAX(MaKH) +1 from KHACHHANG)
	UPDATE KHACHHANG
	SET MAKH = @MaKH
	WHERE MAKH = 0
end 
--Tạo trigger cho bảng NHAN VIEN
create trigger Trig_TangMaNV
on NHANVIEN
after insert 
as 
begin
	declare @MaNV  int 
	set @MaNV =( select MAX(MaNV) +1 from NHANVIEN)
	UPDATE NHANVIEN
	SET MANV = @MaNV
	WHERE MANV = 0
end 
--Tạo trigger cho bảng HOADON
create trigger Trig_TangMaHD
on HOADON
after insert 
as 
begin
	declare @MaHD  int 
	set @MaHD =( select MAX(MaHD) +1 from HOADON)
	UPDATE HOADON
	SET MAHD = @MaHD
	WHERE MAHD = 0
end 
