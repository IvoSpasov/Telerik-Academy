USE [master]
GO
/****** Object:  Database [Dictionary]    Script Date: 23.8.2014 г. 10:50:43 ч. ******/
CREATE DATABASE [Dictionary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dictionary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.INSTANCEONE\MSSQL\DATA\Dictionary.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Dictionary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.INSTANCEONE\MSSQL\DATA\Dictionary_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Dictionary] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dictionary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dictionary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dictionary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dictionary] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dictionary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dictionary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dictionary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dictionary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dictionary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dictionary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dictionary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dictionary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dictionary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dictionary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dictionary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dictionary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dictionary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dictionary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dictionary] SET RECOVERY FULL 
GO
ALTER DATABASE [Dictionary] SET  MULTI_USER 
GO
ALTER DATABASE [Dictionary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dictionary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dictionary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dictionary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Dictionary] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Dictionary', N'ON'
GO
USE [Dictionary]
GO
/****** Object:  Table [dbo].[Language]    Script Date: 23.8.2014 г. 10:50:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Language](
	[LanguageId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Language] PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Word]    Script Date: 23.8.2014 г. 10:50:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Word](
	[WordId] [int] IDENTITY(1,1) NOT NULL,
	[WordAsText] [nvarchar](50) NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_Word] PRIMARY KEY CLUSTERED 
(
	[WordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WordExplanation]    Script Date: 23.8.2014 г. 10:50:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WordExplanation](
	[WordExplanationId] [int] IDENTITY(1,1) NOT NULL,
	[ExplanationAsText] [ntext] NOT NULL,
	[WordId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_WordExplanation] PRIMARY KEY CLUSTERED 
(
	[WordExplanationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WordSynonim]    Script Date: 23.8.2014 г. 10:50:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WordSynonim](
	[WordSynonimId] [int] IDENTITY(1,1) NOT NULL,
	[SynonimAsText] [nvarchar](50) NOT NULL,
	[WordId] [int] NOT NULL,
 CONSTRAINT [PK_WordSynonim] PRIMARY KEY CLUSTERED 
(
	[WordSynonimId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WordTranslation]    Script Date: 23.8.2014 г. 10:50:43 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WordTranslation](
	[WordTranslationId] [int] IDENTITY(1,1) NOT NULL,
	[WordTranslationAsText] [nvarchar](50) NOT NULL,
	[WordId] [int] NOT NULL,
	[LanguageId] [int] NOT NULL,
 CONSTRAINT [PK_WordTranslation] PRIMARY KEY CLUSTERED 
(
	[WordTranslationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Language] ON 

INSERT [dbo].[Language] ([LanguageId], [Name]) VALUES (1, N'Bulgarian')
INSERT [dbo].[Language] ([LanguageId], [Name]) VALUES (2, N'English')
INSERT [dbo].[Language] ([LanguageId], [Name]) VALUES (3, N'German')
SET IDENTITY_INSERT [dbo].[Language] OFF
SET IDENTITY_INSERT [dbo].[Word] ON 

INSERT [dbo].[Word] ([WordId], [WordAsText], [LanguageId]) VALUES (1, N'Car', 1)
SET IDENTITY_INSERT [dbo].[Word] OFF
SET IDENTITY_INSERT [dbo].[WordExplanation] ON 

INSERT [dbo].[WordExplanation] ([WordExplanationId], [ExplanationAsText], [WordId], [LanguageId]) VALUES (1, N'a road vehicle, typically with four wheels, powered by an internal combustion engine and able to carry a small number of people.', 1, 2)
INSERT [dbo].[WordExplanation] ([WordExplanationId], [ExplanationAsText], [WordId], [LanguageId]) VALUES (2, N'средство за предвижване', 1, 1)
SET IDENTITY_INSERT [dbo].[WordExplanation] OFF
SET IDENTITY_INSERT [dbo].[WordSynonim] ON 

INSERT [dbo].[WordSynonim] ([WordSynonimId], [SynonimAsText], [WordId]) VALUES (1, N' automobile', 1)
INSERT [dbo].[WordSynonim] ([WordSynonimId], [SynonimAsText], [WordId]) VALUES (2, N' vehicle', 1)
INSERT [dbo].[WordSynonim] ([WordSynonimId], [SynonimAsText], [WordId]) VALUES (3, N'motor vehicle', 1)
SET IDENTITY_INSERT [dbo].[WordSynonim] OFF
SET IDENTITY_INSERT [dbo].[WordTranslation] ON 

INSERT [dbo].[WordTranslation] ([WordTranslationId], [WordTranslationAsText], [WordId], [LanguageId]) VALUES (1, N'кола', 1, 1)
INSERT [dbo].[WordTranslation] ([WordTranslationId], [WordTranslationAsText], [WordId], [LanguageId]) VALUES (4, N'auto', 1, 3)
SET IDENTITY_INSERT [dbo].[WordTranslation] OFF
ALTER TABLE [dbo].[Word]  WITH CHECK ADD  CONSTRAINT [FK_Word_Language] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Language] ([LanguageId])
GO
ALTER TABLE [dbo].[Word] CHECK CONSTRAINT [FK_Word_Language]
GO
ALTER TABLE [dbo].[WordExplanation]  WITH CHECK ADD  CONSTRAINT [FK_WordExplanation_Language] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Language] ([LanguageId])
GO
ALTER TABLE [dbo].[WordExplanation] CHECK CONSTRAINT [FK_WordExplanation_Language]
GO
ALTER TABLE [dbo].[WordExplanation]  WITH CHECK ADD  CONSTRAINT [FK_WordExplanation_Word] FOREIGN KEY([WordId])
REFERENCES [dbo].[Word] ([WordId])
GO
ALTER TABLE [dbo].[WordExplanation] CHECK CONSTRAINT [FK_WordExplanation_Word]
GO
ALTER TABLE [dbo].[WordSynonim]  WITH CHECK ADD  CONSTRAINT [FK_WordSynonim_Word] FOREIGN KEY([WordId])
REFERENCES [dbo].[Word] ([WordId])
GO
ALTER TABLE [dbo].[WordSynonim] CHECK CONSTRAINT [FK_WordSynonim_Word]
GO
ALTER TABLE [dbo].[WordTranslation]  WITH CHECK ADD  CONSTRAINT [FK_WordTranslation_Language] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Language] ([LanguageId])
GO
ALTER TABLE [dbo].[WordTranslation] CHECK CONSTRAINT [FK_WordTranslation_Language]
GO
ALTER TABLE [dbo].[WordTranslation]  WITH CHECK ADD  CONSTRAINT [FK_WordTranslation_Word] FOREIGN KEY([WordId])
REFERENCES [dbo].[Word] ([WordId])
GO
ALTER TABLE [dbo].[WordTranslation] CHECK CONSTRAINT [FK_WordTranslation_Word]
GO
USE [master]
GO
ALTER DATABASE [Dictionary] SET  READ_WRITE 
GO
