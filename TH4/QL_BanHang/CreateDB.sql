CREATE DATABASE QL_BanHang;
GO
USE QL_BanHang;
GO

CREATE TABLE SanPham (
    MaSP    CHAR(10)       PRIMARY KEY,
    TenSP   NVARCHAR(100),
    DonVi   NVARCHAR(20),
    DonGia  DECIMAL(18,0),
    TonKho  INT
);

CREATE TABLE DonHang (
    MaDon     CHAR(10)     PRIMARY KEY,
    NgayDat   DATETIME,
    TongTien  DECIMAL(18,0),
    TrangThai NVARCHAR(20)
);

CREATE TABLE ChiTietDon (
    MaDon   CHAR(10)  REFERENCES DonHang(MaDon),
    MaSP    CHAR(10)  REFERENCES SanPham(MaSP),
    SoLuong INT,
    DonGia  DECIMAL(18,0),
    PRIMARY KEY (MaDon, MaSP)
);

INSERT INTO SanPham VALUES ('SP001', N'Cơm gà xối mỡ',   N'Phần', 45000, 50);
INSERT INTO SanPham VALUES ('SP002', N'Bún bò Huế',       N'Tô',   40000, 40);
INSERT INTO SanPham VALUES ('SP003', N'Phở bò',           N'Tô',   50000, 35);
INSERT INTO SanPham VALUES ('SP004', N'Bánh mì thịt',     N'Cái',  25000, 80);
INSERT INTO SanPham VALUES ('SP005', N'Nước ngọt',        N'Lon',  15000, 100);
INSERT INTO SanPham VALUES ('SP006', N'Trà sữa trân châu',N'Ly',   35000, 60);
