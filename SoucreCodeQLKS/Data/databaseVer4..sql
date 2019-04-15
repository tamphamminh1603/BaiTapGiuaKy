create database dataQLKS
go
use dataQLKS
go

--table chuc vu

--create table chucvu(
--	macv char(2) primary key,
--	tencv nvarchar(30) not null
--)
--go
--insert into chucvu values('GD',N'Giám đốc')
--insert into chucvu values('PD',N'Phó Giám đốc')
--insert into chucvu values('KT',N'Kế toán')
--insert into chucvu values('TK',N'Thư ký')
--insert into chucvu values('LT',N'Lễ tân')
--insert into chucvu values('PV',N'Phụ vụ')
--insert into chucvu values('BV',N'Bảo vệ')

--go

--table nhanvien

create table nhanvien(
	manv char(5) primary key,
	--macv char(2) foreign key references chucvu(macv) not null,
	hoten nvarchar(30) not null,
	ngaysinh date check(ngaysinh < getdate()) not null,
	gioitinh nvarchar(3) check(gioitinh in(N'Nam',N'Nữ')) not null,
	sdt varchar(12) check(sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	cmnd char(9) check(cmnd like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique not null,
	diachi nvarchar(50) not null,
	email varchar(30) unique check(email  like '[a-z]%@[a-z]%.[a-z]%')
)
go
insert into nhanvien values('NV001',N'Nguyễn Hùng',convert(date,'05/05/1975',105),N'Nam','01223503050','212555667',N'Hải Châu, Đà Nẵng','hungnguyen@gmail.com')
insert into nhanvien values('NV002',N'Nguyễn Hoàng Anh',convert(date,'02/02/1985',105),N'Nữ','01223503052','212555666',N'Hải Châu, Đà Nẵng','hoanganh@gmail.com')
insert into nhanvien values('NV003',N'Nguyễn Anh Thư',convert(date,'02/06/1988',105),N'Nữ','01223503053','212555668',N'Thanh Khê, Đà Nẵng','anhthu@gmail.com')
insert into nhanvien values('NV004',N'Lê Quốc Bảo',convert(date,'25/12/1978',105),N'Nam','01223503054','212555669',N'Cẩm Lệ, Đà Nẵng','quocbao@gmail.com')
insert into nhanvien values('NV005',N'Nguyễn Hồng Hoa',convert(date,'01/02/1985',105),N'Nữ','01223503055','212555676',N'Hải Châu, Đà Nẵng','honghoa@gmail.com')
insert into nhanvien values('NV006',N'Trần Hoàng Minh',convert(date,'02/02/1978',105),N'Nam','01223503056','212555686',N'Hòa Khánh, Đà Nẵng','hoangminh@gmail.com')
insert into nhanvien values('NV007',N'Nguyễn Ngọc My',convert(date,'02/07/1983',105),N'Nữ','01223503057','212555696',N'Hải Châu, Đà Nẵng','ngocmy@gmail.com')
insert into nhanvien values('NV008',N'Nguyễn Thị Ngọc',convert(date,'12/12/1985',105),N'Nữ','01223503058','212555766',N'Hải Châu, Đà Nẵng','ngocngoc@gmail.com')
insert into nhanvien values('NV009',N'Lê Bảo Trâm',convert(date,'22/02/1985',105),N'Nữ','01223503059','212555866',N'Hải Châu, Đà Nẵng','baotram@gmail.com')
insert into nhanvien values('NV010',N'Nguyễn Ngọc Anh',convert(date,'15/06/1985',105),N'Nam','01223503060','212555966',N'Hải Châu, Đà Nẵng','ngocanh@gmail.com')
insert into nhanvien values('admin',N'Phạm Minh Tâm',convert(date,'24/01/1997',105),N'Nam','01223503060','225609815',N'Nha Trang, Khánh Hòa','tam.phamminh@gmail.com')

go

--table loaiphong

create table loaiphong(
	tenlp varchar(10) primary key,
	soluong int not null,
	giaphong int not null
)
go
insert into loaiphong values('Standard',5,200000)
insert into loaiphong values('Deluxe',5,300000)
insert into loaiphong values('Suite',5,400000)
insert into loaiphong values('Superio',5,500000)

go

--table phong

create table phong(
	maphong char(4) primary key,
	tenlp varchar(10) foreign key references loaiphong(tenlp),
	tinhtrang bit
)
go

insert into phong values('S101','Standard',0)
insert into phong values('S102','Standard',0)
insert into phong values('S103','Standard',0)
insert into phong values('S104','Standard',1)
insert into phong values('S105','Standard',1)
insert into phong values('D201','Deluxe',0)
insert into phong values('D202','Deluxe',0)
insert into phong values('D203','Deluxe',1)
insert into phong values('D204','Deluxe',1)
insert into phong values('D205','Deluxe',1)
insert into phong values('E301','Suite',0)
insert into phong values('E302','Suite',0)
insert into phong values('E303','Suite',1)
insert into phong values('E304','Suite',1)
insert into phong values('E305','Suite',1)
insert into phong values('V401','Superio',0)
insert into phong values('V402','Superio',0)
insert into phong values('V403','Superio',0)
insert into phong values('V404','Superio',1)
insert into phong values('V405','Superio',1)

go

--table khachhang

create table khachhang(
	makh char(5) primary key,
	hoten nvarchar(30) not null,
	cmnd char(9) check(cmnd like '[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique not null,
	sdt varchar(12) check(sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or sdt like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
	email varchar(30) unique check(email  like '[a-z]%@[a-z]%.[a-z]%'),
	diachi nvarchar(50) not null
)
go
insert into khachhang values('KH001',N'Võ Hoài Linh','222555888','0909050505','hoailinh@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH002',N'Hồ Ngọc Hà','222777511','01668135131','haho@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH003',N'Đàm Vĩnh Hưng','222555782','0909050805','dvh@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH004',N'Hồ Quang Hiếu','222444456','01668135181','hqh@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH005',N'Cao Thái Sơn','229995753','0913050505','thaison@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH006',N'Cao Thái Tú','229995751','0913050501','thaitu@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH007',N'Cao Thái','229995752','0813050505','sonthai@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH008',N'Hồ Sơn','229995754','0163050505','son@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH009',N'Hoài Lâm','228995755','0983050505','HoaiLam@yahoo.com',N'Hồ Chí Minh')
insert into khachhang values('KH010',N'Đinh Hiếu Trung','229995756','0923050505','trungdinh@gmail.com',N'Hồ Chí Minh')
go

--table datphong

create table datphong(
	madp char(5) primary key,
	manv char(5) foreign key references nhanvien(manv) not null,
	makh char(5) foreign key references khachhang(makh) not null,
	tenlp varchar(10) foreign key references loaiphong(tenlp) not null,
	ngaydat date default(getdate()) not null,
	ngayden date default(getdate()) not null,
	ngaydi date default(getdate()) not null,
	tiendatcoc int,
	soluong int not null,
	trangthai bit,
)
go
insert into datphong values('DP001','NV001','KH001','Standard',convert(date,'07/01/2015',105),convert(date,'08/01/2015',105),convert(date,'11/01/2015',105),100000,2,0)
insert into datphong values('DP002','NV002','KH002','Standard',convert(date,'07/01/2015',105),convert(date,'08/01/2015',105),convert(date,'11/01/2015',105),100000,2,0)
insert into datphong values('DP003','NV003','KH003','Standard',convert(date,'07/01/2015',105),convert(date,'08/01/2015',105),convert(date,'11/01/2015',105),100000,2,0)
insert into datphong values('DP101','NV004','KH004','Deluxe',convert(date,'08/01/2015',105),convert(date,'09/01/2015',105),convert(date,'10/01/2015',105),60000,3,0)
insert into datphong values('DP102','NV005','KH005','Deluxe',convert(date,'03/02/2015',105),convert(date,'04/02/2015',105),convert(date,'12/02/2015',105),60000,2,0)
insert into datphong values('DP201','NV001','KH006','Suite',convert(date,'08/03/2015',105),convert(date,'08/03/2015',105),convert(date,'10/03/2015',105),60000,2,0)
insert into datphong values('DP202','NV002','KH007','Superio',convert(date,'22/12/2015',105),convert(date,'25/12/2014',105),convert(date,'28/12/2015',105),80000,2,1)
insert into datphong values('DP301','NV003','KH008','Superio',convert(date,'22/12/2015',105),convert(date,'25/12/2014',105),convert(date,'28/12/2015',105),80000,2,1)
insert into datphong values('DP302','NV004','KH009','Superio',convert(date,'22/12/2015',105),convert(date,'25/12/2014',105),convert(date,'28/12/2015',105),80000,2,1)
insert into datphong values('DP303','NV005','KH010','Superio',convert(date,'22/12/2015',105),convert(date,'25/12/2014',105),convert(date,'28/12/2015',105),80000,2,1)

go

--table ctphongdat

create table ctphongdat(
	madp char(5) foreign key references datphong(madp) not null,
	maphong char(4) foreign key references phong(maphong) not null,
	primary key(madp,maphong)
)
go
insert into ctphongdat values('DP001','S101')
insert into ctphongdat values('DP002','S102')
insert into ctphongdat values('DP003','S103')
insert into ctphongdat values('DP004','S104')
insert into ctphongdat values('DP005','S105')
insert into ctphongdat values('DP101','D201')
insert into ctphongdat values('DP102','D202')
insert into ctphongdat values('DP103','D203')
insert into ctphongdat values('DP104','D204')
insert into ctphongdat values('DP105','E205')
insert into ctphongdat values('DP201','E301')
insert into ctphongdat values('DP202','E302')
insert into ctphongdat values('DP203','E303')
insert into ctphongdat values('DP204','E304')
insert into ctphongdat values('DP205','E305')
insert into ctphongdat values('DP301','v401')
insert into ctphongdat values('DP302','v402')
insert into ctphongdat values('DP303','v403')
insert into ctphongdat values('DP304','v404')
insert into ctphongdat values('DP305','v405')
go

--table hoadon

--create table hoadon(
--	mahd char(5) primary key,
--	madp char(5) foreign key references datphong(madp) not null,
--	ngaylap date default(getdate()) not null,
--	tongtien int not null
--)
--go

--insert into hoadon values('HD001','DP001',getdate(),2400000)
--insert into hoadon values('HD002','DP002',getdate(),2400000)
--insert into hoadon values('HD003','DP003',getdate(),2400000)
--insert into hoadon values('HD004','DP004',getdate(),2400000)
--insert into hoadon values('HD005','DP005',getdate(),2400000)

--go

--table phanquyen

--create table phanquyen(
--	id char(1) primary key,
--	quyen nvarchar(10) not null
--)
--go
--insert into phanquyen values('A',N'Quản trị')
--insert into phanquyen values('B',N'Nhân viên')
--insert into phanquyen values('C',N'Khách')

--go

--table taikhoan

create table taikhoan
(
	manv char(5) foreign key references nhanvien(manv) not null,
	--id char(1) foreign key references phanquyen(id) not null,
	matkhau char(3) not null,
	primary key(manv)
)
go
insert into taikhoan values('admin','123')
insert into taikhoan values('NV001','123')
insert into taikhoan values('NV002','123')
insert into taikhoan values('NV003','123')
insert into taikhoan values('NV004','123')
insert into taikhoan values('NV005','123')


go

--create proc gethoadon
--	@madp char(5)
--as
--begin
--	select hd.mahd,hd.ngaylap,dp.madp,dp.makh,kh.hoten,dp.tenlp,dp.soluong,dp.ngayden,dp.ngaydi,hd.tongtien
--	from hoadon as hd,datphong as dp,khachhang as kh
--	where hd.madp=dp.madp and dp.makh = kh.makh and hd.madp = @madp
--end

--go

--create proc getdsnv
--as
--begin
--	select manv,tencv,hoten,ngaysinh,gioitinh,sdt,cmnd,diachi,email
--	from nhanvien,chucvu
--	where nhanvien.macv = chucvu.macv
--end

--go

--create proc getdskh
--as
--begin
--	select * from khachhang
--end

--select * from datphong

--go

select * from taikhoan where manv = N'admin' and matkhau = N'123'
go

create proc USP_taikhoan
@manv nvarchar(100), @matkhau nvarchar(100)
As
Begin 
	select * from taikhoan where manv =@manv and matkhau = @matkhau
End
GO

--Declare @i int = 0 
--while @i <20
--begin
--	insert into phong values('S503','Standard',1)
--end
--go

create proc USP_phong
as select * from phong
go

exec USP_phong 