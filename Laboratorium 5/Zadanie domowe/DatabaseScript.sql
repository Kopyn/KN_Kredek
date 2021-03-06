USE [master]
GO
/****** Object:  Database [GuitarCenter]    Script Date: 30.05.2021 23:05:08 ******/
CREATE DATABASE [GuitarCenter]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GuitarCenter', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MACIEKSQL\MSSQL\DATA\GuitarCenter.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GuitarCenter_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MACIEKSQL\MSSQL\DATA\GuitarCenter_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GuitarCenter] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GuitarCenter].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GuitarCenter] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GuitarCenter] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GuitarCenter] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GuitarCenter] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GuitarCenter] SET ARITHABORT OFF 
GO
ALTER DATABASE [GuitarCenter] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GuitarCenter] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GuitarCenter] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GuitarCenter] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GuitarCenter] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GuitarCenter] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GuitarCenter] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GuitarCenter] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GuitarCenter] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GuitarCenter] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GuitarCenter] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GuitarCenter] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GuitarCenter] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GuitarCenter] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GuitarCenter] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GuitarCenter] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GuitarCenter] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GuitarCenter] SET RECOVERY FULL 
GO
ALTER DATABASE [GuitarCenter] SET  MULTI_USER 
GO
ALTER DATABASE [GuitarCenter] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GuitarCenter] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GuitarCenter] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GuitarCenter] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GuitarCenter] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GuitarCenter] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GuitarCenter', N'ON'
GO
ALTER DATABASE [GuitarCenter] SET QUERY_STORE = OFF
GO
USE [GuitarCenter]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30.05.2021 23:05:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 30.05.2021 23:05:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](40) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Baskets]    Script Date: 30.05.2021 23:05:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Baskets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
 CONSTRAINT [PK_Baskets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guitars]    Script Date: 30.05.2021 23:05:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guitars](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ManufacturerId] [int] NOT NULL,
	[Model] [nvarchar](30) NOT NULL,
	[Type] [nvarchar](30) NOT NULL,
	[BasketId] [int] NULL,
 CONSTRAINT [PK_Guitars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturers]    Script Date: 30.05.2021 23:05:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Manufacturers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210530163403_Initial', N'5.0.6')
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([Id], [Login], [Password], [Email], [FirstName], [LastName]) VALUES (3, N'MAbacki', N'haslo123', N'mabacki@gmail.com', N'Maciej', N'Abacki')
INSERT [dbo].[Accounts] ([Id], [Login], [Password], [Email], [FirstName], [LastName]) VALUES (4, N'PRapacki', N'passwd', N'prapacki@gmail.com', N'Paweł', N'Rapacki')
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Baskets] ON 

INSERT [dbo].[Baskets] ([Id], [AccountId]) VALUES (3, 3)
INSERT [dbo].[Baskets] ([Id], [AccountId]) VALUES (4, 4)
SET IDENTITY_INSERT [dbo].[Baskets] OFF
GO
SET IDENTITY_INSERT [dbo].[Guitars] ON 

INSERT [dbo].[Guitars] ([Id], [ManufacturerId], [Model], [Type], [BasketId]) VALUES (3, 4, N'Classical', N'Klasyczna', 3)
INSERT [dbo].[Guitars] ([Id], [ManufacturerId], [Model], [Type], [BasketId]) VALUES (4, 5, N'Acoustic', N'Akustyczna', 3)
SET IDENTITY_INSERT [dbo].[Guitars] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufacturers] ON 

INSERT [dbo].[Manufacturers] ([Id], [Name]) VALUES (4, N'Ibanez')
INSERT [dbo].[Manufacturers] ([Id], [Name]) VALUES (5, N'Fender')
INSERT [dbo].[Manufacturers] ([Id], [Name]) VALUES (6, N'LAG')
SET IDENTITY_INSERT [dbo].[Manufacturers] OFF
GO
/****** Object:  Index [IX_Baskets_AccountId]    Script Date: 30.05.2021 23:05:09 ******/
CREATE NONCLUSTERED INDEX [IX_Baskets_AccountId] ON [dbo].[Baskets]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Guitars_BasketId]    Script Date: 30.05.2021 23:05:09 ******/
CREATE NONCLUSTERED INDEX [IX_Guitars_BasketId] ON [dbo].[Guitars]
(
	[BasketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Guitars_ManufacturerId]    Script Date: 30.05.2021 23:05:09 ******/
CREATE NONCLUSTERED INDEX [IX_Guitars_ManufacturerId] ON [dbo].[Guitars]
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Baskets]  WITH CHECK ADD  CONSTRAINT [FK_Baskets_Accounts_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Baskets] CHECK CONSTRAINT [FK_Baskets_Accounts_AccountId]
GO
ALTER TABLE [dbo].[Guitars]  WITH CHECK ADD  CONSTRAINT [FK_Guitars_Baskets_BasketId] FOREIGN KEY([BasketId])
REFERENCES [dbo].[Baskets] ([Id])
GO
ALTER TABLE [dbo].[Guitars] CHECK CONSTRAINT [FK_Guitars_Baskets_BasketId]
GO
ALTER TABLE [dbo].[Guitars]  WITH CHECK ADD  CONSTRAINT [FK_Guitars_Manufacturers_ManufacturerId] FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[Manufacturers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Guitars] CHECK CONSTRAINT [FK_Guitars_Manufacturers_ManufacturerId]
GO
USE [master]
GO
ALTER DATABASE [GuitarCenter] SET  READ_WRITE 
GO
