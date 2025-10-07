-- 建立資料庫
CREATE DATABASE BookLibraryDB;
GO

USE BookLibraryDB;
GO

-- =========================================================
-- Table: Users
-- =========================================================
CREATE TABLE [dbo].[Users] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Username] NVARCHAR(100) NOT NULL,
    [Password] NVARCHAR(255) NOT NULL,
    [Role] NVARCHAR(20) NOT NULL DEFAULT('User')
);
GO

-- 預設管理員帳號
INSERT INTO [dbo].[Users] ([Username], [Password], [Role])
VALUES ('admin', 'admin', 'Admin');
GO


-- =========================================================
-- Table: Books
-- =========================================================
CREATE TABLE [dbo].[Books] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Title] NVARCHAR(200) NOT NULL,
    [Author] NVARCHAR(100) NULL,
    [Publisher] NVARCHAR(100) NULL,
    [Category] NVARCHAR(100) NULL,
    [Quantity] INT NOT NULL DEFAULT(0)
);
GO


-- =========================================================
-- Table: BorrowRecords
-- =========================================================
CREATE TABLE [dbo].[BorrowRecords] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [UserId] INT NOT NULL,
    [BookId] INT NOT NULL,
    [BorrowedAt] DATETIME2 NOT NULL DEFAULT(GETDATE()),
    [ReturnedAt] DATETIME2 NULL,

    CONSTRAINT FK_BorrowRecords_Users FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users]([Id]) ON DELETE CASCADE,
    CONSTRAINT FK_BorrowRecords_Books FOREIGN KEY ([BookId]) REFERENCES [dbo].[Books]([Id]) ON DELETE CASCADE
);
GO
