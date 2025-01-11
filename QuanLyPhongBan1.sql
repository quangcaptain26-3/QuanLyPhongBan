create database QuanLyPhongBan
use QuanLyPhongBan

create table PhongBan(
	MaPhongBan NVARCHAR(3) PRIMARY KEY,
	TenPhongBan NVARCHAR(30) NOT NULL UNIQUE,
	NgayThanhLap DATETIME NOT NULL,
	PhuCap FLOAT NOT NULL CHECK(PhuCap > 0)
);
go
create table NhanVien(
	MaNhanVien NVARCHAR(5) PRIMARY KEY,
	HoTen NVARCHAR(30) NOT NULL,
	MaPhongBan NVARCHAR(3),
	NgayVaoLam DATE NOT NULL,
	MucLuong FLOAT NOT NULL CHECK(MucLuong > 0),
	FOREIGN KEY (MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);
go
create table DuAn(
	MaDuAn NVARCHAR(3) PRIMARY KEY,
	TenDuAn NVARCHAR(30) NOT NULL UNIQUE,
	TongKinhPhi DECIMAL(18,2) NOT NULL CHECK(TongKinhPhi > 0),
	MaNhanVienPhuTrach NVARCHAR(5),
	FOREIGN KEY (MaNhanVienPhuTrach) REFERENCES NhanVien(MaNhanVien)
);


INSERT INTO PhongBan (MaPhongBan, TenPhongBan, NgayThanhLap, PhuCap)
VALUES 
('HR', 'Human Resources', '2022-01-15', 2000.0),
('IT', 'Information Technology', '2022-02-20', 3000.0),
('MK', 'Marketing', '2022-03-10', 2500.0),
('FN', 'Finance', '2022-04-25', 3500.0),
('PR', 'Public Relations', '2022-05-30', 1500.0);


INSERT INTO NhanVien (MaNhanVien, HoTen, MaPhongBan, NgayVaoLam, MucLuong)
VALUES
('E001', 'John Doe', 'HR', '2023-01-10', 5000.0),
('E002', 'Jane Smith', 'IT', '2023-02-15', 6000.0),
('E003', 'Bill Gates', 'MK', '2023-03-20', 5500.0),
('E004', 'Elon Musk', 'FN', '2023-04-25', 6500.0),
('E005', 'Jeff Bezos', 'PR', '2023-05-30', 4500.0);


INSERT INTO DuAn (MaDuAn, TenDuAn, TongKinhPhi, MaNhanVienPhuTrach)
VALUES
('D01', 'Project Alpha', 100000.00, 'E001'),
('D02', 'Project Beta', 200000.00, 'E002'),
('D03', 'Project Gamma', 150000.00, 'E003'),
('D04', 'Project Delta', 250000.00, 'E004'),
('D05', 'Project Epsilon', 300000.00, 'E005');

--Cau 1
create procedure ThemNhanVien
	@MaNhanVien nvarchar(5), 
	@HoTen nvarchar(30),
	@MaPhongBan nvarchar(3),
	@NgayVaoLam date,
	@MucLuong float
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from NhanVien where MaNhanVien = @MaNhanVien);
	if @Dem > 0
		set @Loi = N'Ma nhan vien da ton tai';

	set @Dem = (select count(*) from PhongBan where MaPhongBan = @MaPhongBan);
	if @Dem > 0
		set @Loi = N'Ma phong ban khong ton tai';

	if @MucLuong <= 0
		set @Loi = N'Muc luong khong hop le'

	if @Loi = ' '
		insert into NhanVien(MaNhanVien, HoTen, MaPhongBan, NgayVaoLam, MucLuong)
		values (@MaNhanVien, @HoTen, @MaPhongBan, @NgayVaoLam, @MucLuong);
	else
		raiserror(@Loi, 16, 1);
end

--Cau 2
create function TimKiemDuAn(@TuKhoa nvarchar(40))
returns table
as return
(
select
	da.MaDuAn,
	da.TenDuAn,
	da.TongKinhPhi,
	nv.HoTen as TenNhanVienPhuTrach
from DuAn da
inner join NhanVien nv on da.MaNhanVienPhuTrach = nv.MaNhanVien
where
da.MaDuAn LIKE '%' + @TuKhoa + '%'
or da.TenDuAn LIKE '%' + @TuKhoa + '%'
or nv.HoTen LIKE '%' + @TuKhoa + '%'
);

drop function TimKiemDuAn

select * from TimKiemDuAn(N'l');


--Cau 3
create procedure ThemPhongBan
	@MaPhongBan nvarchar(3),
	@TenPhongBan nvarchar(30),
	@NgayThanhLap datetime,
	@PhuCap float
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from PhongBan where MaPhongBan = @MaPhongBan);
	if @Dem > 0
		set @Loi = N'Ma phong ban da ton tai';

	set @Dem = (select count(*) from PhongBan where TenPhongBan = @TenPhongBan);
	if @Dem > 0
		set @Loi = N'Ten phong ban da ton tai';

	if @PhuCap < 0
		set @Loi = N'Phu cap khong hop le'

	if @Loi = ' '
		insert into PhongBan(MaPhongBan, TenPhongBan, NgayThanhLap, PhuCap) 
		values (@MaPhongBan, @TenPhongBan, @NgayThanhLap, @PhuCap);
	else 
		raiserror(@Loi, 16, 1);
end

EXEC ThemPhongBan 
    @MaPhongBan = N'RR', 
    @TenPhongBan = N'Human Hires', 
    @NgayThanhLap = '2022-01-15', 
    @PhuCap = 2000.0;

create procedure SuaPhongBan
	@MaPhongBan nvarchar(3),
	@TenPhongBan nvarchar(30),
	@NgayThanhLap datetime,
	@PhuCap float
as begin
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from PhongBan where MaPhongBan = @MaPhongBan);
	if @Dem = 0
		set @Loi = N'Ma phong ban khong ton tai';

	set @Dem = (select count(*) from PhongBan where TenPhongBan = @TenPhongBan and MaPhongBan != @MaPhongBan);
    if @Dem > 0
        set @Loi = N'Ten phong ban da ton tai';

	if @PhuCap < 0
		set @Loi = N'Phu cap khong hop le'

	if @Loi = ' '
		update PhongBan
		set TenPhongBan = @TenPhongBan, NgayThanhLap = @NgayThanhLap, PhuCap = @PhuCap
		where MaPhongBan = @MaPhongBan;
	else 
		raiserror(@Loi, 16, 1);
end

drop procedure SuaPhongBan

EXEC SuaPhongBan 
    @MaPhongBan = N'RR', 
    @TenPhongBan = N'Human Fires', 
    @NgayThanhLap = '2022-01-15', 
    @PhuCap = 2000.0;


create procedure XoaPhongBan
	@MaPhongBan nvarchar(3)
as begin 
	declare @Dem int;
	declare @Loi nvarchar(300);
	set @Loi = ' ';

	set @Dem = (select count(*) from PhongBan where MaPhongBan = @MaPhongBan);
	if @Dem = 0
		set @Loi = N'Ma phong ban khong ton tai';

	set @Dem = (select count(*) from NhanVien where MaPhongBan = @MaPhongBan);
	if @Dem > 0
		set @Loi = N'Khong the xoa do ton tai o bang NhanVien';

	if @Loi = ' '
		delete from PhongBan
		where MaPhongBan = @MaPhongBan
	else
		raiserror(@Loi, 16, 1)
end

EXEC XoaPhongBan @MaPhongBan = N'RR';

create function TimKiemPhongBan (@TuKhoa nvarchar(50))
returns table
as return
(
	select
		pb.MaPhongBan,
		pb.TenPhongBan,
		pb.NgayThanhLap,
		pb.PhuCap
	from 
		PhongBan pb
	where 
		pb.MaPhongBan like '%' + @TuKhoa + '%'
		or pb.TenPhongBan like '%' + @TuKhoa + '%'
		or pb.PhuCap like '%' + @TuKhoa + '%'
		or pb.NgayThanhLap like '%' + @TuKhoa + '%'
);

drop function TimKiemPhongBan;

select * from TimKiemPhongBan(N'f');