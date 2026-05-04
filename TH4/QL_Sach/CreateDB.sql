CREATE DATABASE QL_Sach;
GO
USE QL_Sach;
GO

CREATE TABLE LoaiSach (
    MaLoai  CHAR(10)      PRIMARY KEY,
    TenLoai NVARCHAR(50)
);

CREATE TABLE Tacgia (
    MaTG  CHAR(10)      PRIMARY KEY,
    TenTG NVARCHAR(50)
);

CREATE TABLE NXB (
    MaNXB  CHAR(10)      PRIMARY KEY,
    TenNXB NVARCHAR(50)
);

CREATE TABLE Sach (
    MaSach  CHAR(10)      PRIMARY KEY,
    MaLoai  CHAR(10)      REFERENCES LoaiSach(MaLoai),
    TenSach NVARCHAR(100),
    MaTG    CHAR(10)      REFERENCES Tacgia(MaTG),
    MaNXB   CHAR(10)      REFERENCES NXB(MaNXB),
    Dongia  INT,
    Soluong INT
);

CREATE TABLE HD (
    MaHD     CHAR(10)     PRIMARY KEY,
    TenKhach NVARCHAR(50),
    SDT      CHAR(10),
    Tongtien INT
);

CREATE TABLE ChitietHD (
    MaHD    CHAR(10) REFERENCES HD(MaHD),
    MaSach  CHAR(10) REFERENCES Sach(MaSach),
    Soluong INT,
    Giaban  INT,
    PRIMARY KEY (MaHD, MaSach)
);

INSERT INTO LoaiSach VALUES ('LS001', N'Văn học'), ('LS002', N'Khoa học'), ('LS003', N'Lịch sử');
INSERT INTO Tacgia  VALUES ('TG001', N'Nguyễn Du'), ('TG002', N'Nam Cao'), ('TG003', N'Tô Hoài');
INSERT INTO NXB     VALUES ('NXB001', N'NXB Giáo dục'), ('NXB002', N'NXB Kim Đồng'), ('NXB003', N'NXB Văn Hóa');
INSERT INTO Sach    VALUES ('S001','LS001',N'Truyện Kiều','TG001','NXB001',85000,100);
INSERT INTO Sach    VALUES ('S002','LS001',N'Chí Phèo','TG002','NXB002',65000,50);
INSERT INTO Sach    VALUES ('S003','LS001',N'Dế Mèn Phiêu Lưu Ký','TG003','NXB003',55000,80);
