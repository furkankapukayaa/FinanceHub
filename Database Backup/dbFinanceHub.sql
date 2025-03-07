USE [master]
GO
/****** Object:  Database [dbFinanceHub]    Script Date: 17.01.2025 15:51:07 ******/
CREATE DATABASE [dbFinanceHub]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbFinanceHub', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbFinanceHub.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbFinanceHub_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbFinanceHub_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbFinanceHub] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbFinanceHub].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbFinanceHub] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbFinanceHub] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbFinanceHub] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbFinanceHub] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbFinanceHub] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbFinanceHub] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbFinanceHub] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbFinanceHub] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbFinanceHub] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbFinanceHub] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbFinanceHub] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbFinanceHub] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbFinanceHub] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbFinanceHub] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbFinanceHub] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbFinanceHub] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbFinanceHub] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbFinanceHub] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbFinanceHub] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbFinanceHub] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbFinanceHub] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [dbFinanceHub] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbFinanceHub] SET RECOVERY FULL 
GO
ALTER DATABASE [dbFinanceHub] SET  MULTI_USER 
GO
ALTER DATABASE [dbFinanceHub] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbFinanceHub] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbFinanceHub] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbFinanceHub] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbFinanceHub] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbFinanceHub] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbFinanceHub', N'ON'
GO
ALTER DATABASE [dbFinanceHub] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbFinanceHub] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbFinanceHub]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17.01.2025 15:51:07 ******/
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
/****** Object:  Table [dbo].[Accounts]    Script Date: 17.01.2025 15:51:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [nvarchar](450) NOT NULL,
	[OwnerId] [nvarchar](450) NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Balance] [int] NOT NULL,
	[Currency] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
	[No] [int] NOT NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 17.01.2025 15:51:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
	[UserId] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incomes]    Script Date: 17.01.2025 15:51:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incomes](
	[Id] [nvarchar](450) NOT NULL,
	[AccountId] [nvarchar](450) NOT NULL,
	[Amount] [int] NOT NULL,
	[OldBalance] [int] NOT NULL,
	[AvaibleBalance] [int] NOT NULL,
	[IncomeDate] [datetime2](7) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Incomes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Spendings]    Script Date: 17.01.2025 15:51:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Spendings](
	[Id] [nvarchar](450) NOT NULL,
	[CategoryId] [nvarchar](450) NOT NULL,
	[Amount] [int] NOT NULL,
	[AccountId] [nvarchar](450) NOT NULL,
	[OldBalance] [int] NOT NULL,
	[AvaibleBalance] [int] NOT NULL,
	[SpendingDate] [datetime2](7) NOT NULL,
	[Business] [nvarchar](max) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Spendings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17.01.2025 15:51:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[CreatedAtTime] [datetime2](7) NOT NULL,
	[UpdatedAtTime] [datetime2](7) NULL,
	[DeletedAtTime] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Accounts_OwnerId]    Script Date: 17.01.2025 15:51:08 ******/
CREATE NONCLUSTERED INDEX [IX_Accounts_OwnerId] ON [dbo].[Accounts]
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Incomes_AccountId]    Script Date: 17.01.2025 15:51:08 ******/
CREATE NONCLUSTERED INDEX [IX_Incomes_AccountId] ON [dbo].[Incomes]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Spendings_AccountId]    Script Date: 17.01.2025 15:51:08 ******/
CREATE NONCLUSTERED INDEX [IX_Spendings_AccountId] ON [dbo].[Spendings]
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Spendings_CategoryId]    Script Date: 17.01.2025 15:51:08 ******/
CREATE NONCLUSTERED INDEX [IX_Spendings_CategoryId] ON [dbo].[Spendings]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounts] ADD  DEFAULT ((0)) FOR [No]
GO
ALTER TABLE [dbo].[Categories] ADD  DEFAULT (N'') FOR [UserId]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Users_OwnerId] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Users_OwnerId]
GO
ALTER TABLE [dbo].[Incomes]  WITH CHECK ADD  CONSTRAINT [FK_Incomes_Accounts_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Incomes] CHECK CONSTRAINT [FK_Incomes_Accounts_AccountId]
GO
ALTER TABLE [dbo].[Spendings]  WITH CHECK ADD  CONSTRAINT [FK_Spendings_Accounts_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Accounts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Spendings] CHECK CONSTRAINT [FK_Spendings_Accounts_AccountId]
GO
ALTER TABLE [dbo].[Spendings]  WITH CHECK ADD  CONSTRAINT [FK_Spendings_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Spendings] CHECK CONSTRAINT [FK_Spendings_Categories_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [dbFinanceHub] SET  READ_WRITE 
GO
