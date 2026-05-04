CREATE DATABASE QL_SinhVien;
GO
USE QL_SinhVien;
GO

CREATE TABLE SinhVien (
    MaSV     CHAR(10)     PRIMARY KEY,
    HoSV     NVARCHAR(50),
    TenSV    NVARCHAR(20),
    NgaySinh DATE,
    GioiTinh NVARCHAR(5),
    MaKhoa   CHAR(10)
);

INSERT INTO SinhVien VALUES ('K6100001', N'Phạm Văn',   N'Bình',   '2000-06-17', N'Nam', 'TOAN');
INSERT INTO SinhVien VALUES ('K6100002', N'Nguyễn Thị', N'Hoài',   '2001-03-23', N'Nữ',  'HOAH');
INSERT INTO SinhVien VALUES ('K6100003', N'Trần Thị',   N'Thường', '1999-12-04', N'Nữ',  'DIAL');
INSERT INTO SinhVien VALUES ('K6100004', N'Lê Công',    N'Phương', '2001-02-03', N'Nam', 'CNTT');
INSERT INTO SinhVien VALUES ('K6100005', N'Nguyễn Văn', N'Toàn',   '1999-12-04', N'Nam', 'DIAL');
INSERT INTO SinhVien VALUES ('K6100006', N'Lê Thị',     N'Hoa',    '2001-07-03', N'Nữ',  'HOAH');
INSERT INTO SinhVien VALUES ('K6100007', N'Nguyễn Anh', N'Đức',    '2000-06-19', N'Nam', 'CNTT');
