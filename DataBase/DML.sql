/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases V8.1.2                     */
/* Target DBMS:           MS SQL Server 2012                              */
/* Project file:          MovieDB.dez                                     */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database creation script                        */
/* Created on:            2022-03-04 16:02                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Add tables                                                             */
/* ---------------------------------------------------------------------- */

GO


/* ---------------------------------------------------------------------- */
/* Add table "DanhMuc"                                                    */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [DanhMuc] (
    [DanhMucID] UNIQUEIDENTIFIER NOT NULL,
    [TenDanhMuc] NVARCHAR(50) NOT NULL,
    [UuTienHienThi] INTEGER CONSTRAINT [DEF_DanhMuc_UuTienHienThi] DEFAULT 1 NOT NULL,
    [IsActive] CHAR(1) CONSTRAINT [DEF_DanhMuc_IsActive] DEFAULT 'Y' NOT NULL,
    CONSTRAINT [PK_DanhMuc] PRIMARY KEY ([DanhMucID])
)
GO


ALTER TABLE [DanhMuc] ADD CONSTRAINT [CC_DanhMuc_UuTienHienThi] 
    CHECK (UuTienHienThi>=1)
GO


/* ---------------------------------------------------------------------- */
/* Add table "HangSanXuat"                                                */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [HangSanXuat] (
    [HangSanXuatID] UNIQUEIDENTIFIER NOT NULL,
    [TenHangSanXuat] NVARCHAR(255) NOT NULL,
    CONSTRAINT [PK_HangSanXuat] PRIMARY KEY ([HangSanXuatID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "DaoDien"                                                    */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [DaoDien] (
    [DaoDienID] UNIQUEIDENTIFIER NOT NULL,
    [TenDaoDien] NVARCHAR(255) NOT NULL,
    CONSTRAINT [PK_DaoDien] PRIMARY KEY ([DaoDienID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "DanhGia"                                                    */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [DanhGia] (
    [DanhGiaID] UNIQUEIDENTIFIER NOT NULL,
    [DiemDanhGia] INTEGER NOT NULL,
    [NoiDung] NVARCHAR(1000),
    CONSTRAINT [PK_DanhGia] PRIMARY KEY ([DanhGiaID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "Tap"                                                        */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [Tap] (
    [TapID] UNIQUEIDENTIFIER NOT NULL,
    [TapSo] INTEGER NOT NULL,
    [DuongDan] NVARCHAR(500) NOT NULL,
    [ThoiGianKhoiTao] DATETIME NOT NULL,
    CONSTRAINT [PK_Tap] PRIMARY KEY ([TapID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "ChatLuong"                                                  */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [ChatLuong] (
    [ChatLuongID] UNIQUEIDENTIFIER NOT NULL,
    [TenChatLuong] NVARCHAR(20) NOT NULL,
    CONSTRAINT [PK_ChatLuong] PRIMARY KEY ([ChatLuongID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "NguoiDung"                                                  */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [NguoiDung] (
    [NguoiDungID] UNIQUEIDENTIFIER NOT NULL,
    [TenDangNhap] VARCHAR(20) NOT NULL,
    [MatKhau] CHAR(60) NOT NULL,
    [Email] VARCHAR(100) NOT NULL,
    [TrangThaiHoatDong] CHAR(1) CONSTRAINT [DEF_NguoiDung_TrangThaiHoatDong] DEFAULT 'Y' NOT NULL,
    [HoVaTen] NVARCHAR(50) NOT NULL,
    [AnhDaiDien] VARBINARY(max),
    CONSTRAINT [PK_NguoiDung] PRIMARY KEY ([NguoiDungID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "Phim"                                                       */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [Phim] (
    [PhimID] UNIQUEIDENTIFIER NOT NULL,
    [TenPhim] NVARCHAR(255) NOT NULL,
    [SoTap] INTEGER CONSTRAINT [DEF_Phim_SoTap] DEFAULT 1 NOT NULL,
    [DuongDanAnhBia] NVARCHAR(500),
    [UuTienHienThi] INTEGER CONSTRAINT [DEF_Phim_UuTienHienThi] DEFAULT 1 NOT NULL,
    [MoTa] NVARCHAR(1000),
    [IsActive] CHAR(1) CONSTRAINT [DEF_Phim_IsActive] DEFAULT 'Y' NOT NULL,
    [LuotXem] INTEGER CONSTRAINT [DEF_Phim_LuotXem] DEFAULT 0 NOT NULL,
    [ChatLuongID] UNIQUEIDENTIFIER NOT NULL,
    [ThoiGianKhoiTao] DATETIME NOT NULL,
    CONSTRAINT [PK_Phim] PRIMARY KEY ([PhimID])
)
GO


ALTER TABLE [Phim] ADD CONSTRAINT [CC_Phim_LuotXem] 
    CHECK (LuotXem >= 0)
GO


ALTER TABLE [Phim] ADD CONSTRAINT [CC_Phim_SoTap] 
    CHECK (SoTap >= 1)
GO


ALTER TABLE [Phim] ADD CONSTRAINT [CC_Phim_UuTienHienThi] 
    CHECK (UuTienHienThi >= 1)
GO


/* ---------------------------------------------------------------------- */
/* Add table "PhimHangSanXuat"                                            */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [PhimHangSanXuat] (
    [PhimHangSanXuatID] UNIQUEIDENTIFIER NOT NULL,
    [PhimID] UNIQUEIDENTIFIER NOT NULL,
    [HangSanXuatID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PhimHangSanXuat] PRIMARY KEY ([PhimHangSanXuatID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "PhimDaoDien"                                                */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [PhimDaoDien] (
    [PhimDaoDienID] UNIQUEIDENTIFIER NOT NULL,
    [PhimID] UNIQUEIDENTIFIER NOT NULL,
    [DaoDienID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PhimDaoDien] PRIMARY KEY ([PhimDaoDienID])
)
GO


ALTER TABLE [PhimDaoDien] ADD CONSTRAINT [CC_PhimDaoDien_PhimID] 
    UNIQUE (PhimID)
GO


/* ---------------------------------------------------------------------- */
/* Add table "PhimDanhMuc"                                                */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [PhimDanhMuc] (
    [PhimDanhMucID] UNIQUEIDENTIFIER NOT NULL,
    [PhimID] UNIQUEIDENTIFIER NOT NULL,
    [DanhMucID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PhimDanhMuc] PRIMARY KEY ([PhimDanhMucID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "PhimDanhGia"                                                */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [PhimDanhGia] (
    [PhimDanhGiaID] UNIQUEIDENTIFIER NOT NULL,
    [PhimID] UNIQUEIDENTIFIER NOT NULL,
    [DanhGiaID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PhimDanhGia] PRIMARY KEY ([PhimDanhGiaID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "BinhLuan"                                                   */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [BinhLuan] (
    [BinhLuanID] UNIQUEIDENTIFIER NOT NULL,
    [NguoiDungID] UNIQUEIDENTIFIER NOT NULL,
    [ThoiGianKhoiTao] DATETIME NOT NULL,
    [NoiDung] NVARCHAR(1000) NOT NULL,
    CONSTRAINT [PK_BinhLuan] PRIMARY KEY ([BinhLuanID])
)
GO


/* ---------------------------------------------------------------------- */
/* Add table "PhimBinhLuan"                                               */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [PhimBinhLuan] (
    [PhimBinhLuanID] UNIQUEIDENTIFIER NOT NULL,
    [PhimID] UNIQUEIDENTIFIER NOT NULL,
    [BinhLuanID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PhimBinhLuan] PRIMARY KEY ([PhimBinhLuanID])
)
GO


ALTER TABLE [PhimBinhLuan] ADD CONSTRAINT [CC_PhimBinhLuan_BinhLuanID] 
    UNIQUE(BinhLuanID)
GO


/* ---------------------------------------------------------------------- */
/* Add table "PhimTap"                                                    */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [PhimTap] (
    [PhimTapID] UNIQUEIDENTIFIER NOT NULL,
    [PhimID] UNIQUEIDENTIFIER NOT NULL,
    [TapID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_PhimTap] PRIMARY KEY ([PhimTapID])
)
GO


ALTER TABLE [PhimTap] ADD CONSTRAINT [CC_PhimTap_TapID] 
    UNIQUE(TAPID)
GO


/* ---------------------------------------------------------------------- */
/* Add table "TapBinhLuan"                                                */
/* ---------------------------------------------------------------------- */

GO


CREATE TABLE [TapBinhLuan] (
    [TapBinhLuan] UNIQUEIDENTIFIER NOT NULL,
    [TapID] UNIQUEIDENTIFIER NOT NULL,
    [BinhLuanID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_TapBinhLuan] PRIMARY KEY ([TapBinhLuan])
)
GO


ALTER TABLE [TapBinhLuan] ADD CONSTRAINT [CC_TapBinhLuan_BinhLuanID] 
    UNIQUE(BinhLuanID)
GO


/* ---------------------------------------------------------------------- */
/* Add foreign key constraints                                            */
/* ---------------------------------------------------------------------- */

GO


ALTER TABLE [Phim] ADD CONSTRAINT [ChatLuong_Phim] 
    FOREIGN KEY ([ChatLuongID]) REFERENCES [ChatLuong] ([ChatLuongID])
GO


ALTER TABLE [PhimHangSanXuat] ADD CONSTRAINT [Phim_PhimHangSanXuat] 
    FOREIGN KEY ([PhimID]) REFERENCES [Phim] ([PhimID])
GO


ALTER TABLE [PhimHangSanXuat] ADD CONSTRAINT [HangSanXuat_PhimHangSanXuat] 
    FOREIGN KEY ([HangSanXuatID]) REFERENCES [HangSanXuat] ([HangSanXuatID])
GO


ALTER TABLE [PhimDaoDien] ADD CONSTRAINT [Phim_PhimDaoDien] 
    FOREIGN KEY ([PhimID]) REFERENCES [Phim] ([PhimID])
GO


ALTER TABLE [PhimDaoDien] ADD CONSTRAINT [DaoDien_PhimDaoDien] 
    FOREIGN KEY ([DaoDienID]) REFERENCES [DaoDien] ([DaoDienID])
GO


ALTER TABLE [PhimDanhMuc] ADD CONSTRAINT [Phim_PhimDanhMuc] 
    FOREIGN KEY ([PhimID]) REFERENCES [Phim] ([PhimID])
GO


ALTER TABLE [PhimDanhMuc] ADD CONSTRAINT [DanhMuc_PhimDanhMuc] 
    FOREIGN KEY ([DanhMucID]) REFERENCES [DanhMuc] ([DanhMucID])
GO


ALTER TABLE [PhimDanhGia] ADD CONSTRAINT [Phim_PhimDanhGia] 
    FOREIGN KEY ([PhimID]) REFERENCES [Phim] ([PhimID])
GO


ALTER TABLE [PhimDanhGia] ADD CONSTRAINT [DanhGia_PhimDanhGia] 
    FOREIGN KEY ([DanhGiaID]) REFERENCES [DanhGia] ([DanhGiaID])
GO


ALTER TABLE [BinhLuan] ADD CONSTRAINT [NguoiDung_BinhLuan] 
    FOREIGN KEY ([NguoiDungID]) REFERENCES [NguoiDung] ([NguoiDungID])
GO


ALTER TABLE [PhimBinhLuan] ADD CONSTRAINT [BinhLuan_PhimBinhLuan] 
    FOREIGN KEY ([BinhLuanID]) REFERENCES [BinhLuan] ([BinhLuanID])
GO


ALTER TABLE [PhimBinhLuan] ADD CONSTRAINT [Phim_PhimBinhLuan] 
    FOREIGN KEY ([PhimID]) REFERENCES [Phim] ([PhimID])
GO


ALTER TABLE [PhimTap] ADD CONSTRAINT [Phim_PhimTap] 
    FOREIGN KEY ([PhimID]) REFERENCES [Phim] ([PhimID])
GO


ALTER TABLE [PhimTap] ADD CONSTRAINT [Tap_PhimTap] 
    FOREIGN KEY ([TapID]) REFERENCES [Tap] ([TapID])
GO


ALTER TABLE [TapBinhLuan] ADD CONSTRAINT [Tap_TapBinhLuan] 
    FOREIGN KEY ([TapID]) REFERENCES [Tap] ([TapID])
GO


ALTER TABLE [TapBinhLuan] ADD CONSTRAINT [BinhLuan_TapBinhLuan] 
    FOREIGN KEY ([BinhLuanID]) REFERENCES [BinhLuan] ([BinhLuanID])
GO

