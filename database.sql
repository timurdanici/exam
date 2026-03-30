-- =============================================
-- AutoService Database Creation Script
-- SQL Server / LocalDB
-- =============================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'AutoService')
BEGIN
    CREATE DATABASE [AutoService];
END
GO

USE [AutoService];
GO

-- =============================================
-- Table: Клиенты (Clients)
-- =============================================
IF NOT EXISTS (
    SELECT * FROM sys.objects
    WHERE object_id = OBJECT_ID(N'[dbo].[Клиенты]') AND type = N'U'
)
BEGIN
    CREATE TABLE [dbo].[Клиенты] (
        [ID_клиента]  INT IDENTITY(1,1) NOT NULL,
        [Фамилия]     NVARCHAR(100)     NOT NULL,
        [Имя]         NVARCHAR(100)     NOT NULL,
        [Телефон]     NVARCHAR(20)      NULL,
        [Адрес]       NVARCHAR(255)     NULL,
        CONSTRAINT [PK_Клиенты] PRIMARY KEY ([ID_клиента])
    );
    PRINT 'Table Клиенты created.';
END
ELSE
BEGIN
    PRINT 'Table Клиенты already exists.';
END
GO

-- =============================================
-- Table: Автомобили (Cars)
-- =============================================
IF NOT EXISTS (
    SELECT * FROM sys.objects
    WHERE object_id = OBJECT_ID(N'[dbo].[Автомобили]') AND type = N'U'
)
BEGIN
    CREATE TABLE [dbo].[Автомобили] (
        [ID_автомобиля] INT IDENTITY(1,1) NOT NULL,
        [Марка]         NVARCHAR(100)     NOT NULL,
        [Модель]        NVARCHAR(100)     NOT NULL,
        [Год_выпуска]   INT               NOT NULL,
        [Гос_номер]     NVARCHAR(20)      NOT NULL,
        [ID_клиента]    INT               NOT NULL,
        CONSTRAINT [PK_Автомобили]        PRIMARY KEY ([ID_автомобиля]),
        CONSTRAINT [FK_Автомобили_Клиенты] FOREIGN KEY ([ID_клиента])
            REFERENCES [dbo].[Клиенты]([ID_клиента])
            ON DELETE CASCADE
    );
    PRINT 'Table Автомобили created.';
END
ELSE
BEGIN
    PRINT 'Table Автомобили already exists.';
END
GO

-- =============================================
-- Sample data (optional)
-- =============================================
IF NOT EXISTS (SELECT TOP 1 1 FROM [dbo].[Клиенты])
BEGIN
    INSERT INTO [dbo].[Клиенты] ([Фамилия], [Имя], [Телефон], [Адрес]) VALUES
        (N'Иванов',   N'Иван',    N'+7-900-111-11-11', N'г. Москва, ул. Ленина, д. 1'),
        (N'Петров',   N'Пётр',    N'+7-900-222-22-22', N'г. Санкт-Петербург, ул. Пушкина, д. 5'),
        (N'Сидоров',  N'Сидор',   N'+7-900-333-33-33', N'г. Казань, пр. Победы, д. 10');

    INSERT INTO [dbo].[Автомобили] ([Марка], [Модель], [Год_выпуска], [Гос_номер], [ID_клиента]) VALUES
        (N'Toyota',   N'Camry',   2019, N'А123ВС77',  1),
        (N'Ford',     N'Focus',   2017, N'В456ГД78',  2),
        (N'Lada',     N'Granta',  2021, N'С789ЕЖ16',  3),
        (N'BMW',      N'X5',      2020, N'Е321КМ77',  1);

    PRINT 'Sample data inserted.';
END
GO
