USE [master]
GO
/****** Object:  Database [reportMan]    Script Date: 04/27/2016 21:43:09 ******/
CREATE DATABASE [reportMan] ON  PRIMARY 
( NAME = N'reportMan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\reportMan.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'reportMan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\reportMan_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [reportMan] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [reportMan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [reportMan] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [reportMan] SET ANSI_NULLS OFF
GO
ALTER DATABASE [reportMan] SET ANSI_PADDING OFF
GO
ALTER DATABASE [reportMan] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [reportMan] SET ARITHABORT OFF
GO
ALTER DATABASE [reportMan] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [reportMan] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [reportMan] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [reportMan] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [reportMan] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [reportMan] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [reportMan] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [reportMan] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [reportMan] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [reportMan] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [reportMan] SET  DISABLE_BROKER
GO
ALTER DATABASE [reportMan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [reportMan] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [reportMan] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [reportMan] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [reportMan] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [reportMan] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [reportMan] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [reportMan] SET  READ_WRITE
GO
ALTER DATABASE [reportMan] SET RECOVERY FULL
GO
ALTER DATABASE [reportMan] SET  MULTI_USER
GO
ALTER DATABASE [reportMan] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [reportMan] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'reportMan', N'ON'
GO
USE [reportMan]
GO
/****** Object:  Table [dbo].[TableAD]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableAD](
	[Admin] [nchar](10) NOT NULL,
	[pwd] [nchar](10) NULL,
 CONSTRAINT [PK_TableAD] PRIMARY KEY CLUSTERED 
(
	[Admin] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TableAD] ([Admin], [pwd]) VALUES (N'ADMIN     ', N'admin     ')
INSERT [dbo].[TableAD] ([Admin], [pwd]) VALUES (N'ADMIN1    ', N'admin     ')
/****** Object:  Table [dbo].[Subject]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Subject] [nchar](20) NOT NULL,
	[Category] [nchar](5) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Subject] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'AGRICULTURAL SCIENCE', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'BASIC SCIENCE       ', N'JSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'BIOLOGY             ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'BUSINESS STUDIES    ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'CHEMISTRY           ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'CHRISTIAN RELIGIOUS ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'CIVIC EDUCATION     ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'COMMERCE            ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'COMPUTER STUDIES    ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'ECONOMICS           ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'ENGLISH             ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'FINANCIAL ACCOUNTS  ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'FOODS AND NUTRITION ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'FRENCH              ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'FURTHER MATHEMATICS ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'GEOGRAPHY           ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'GOVERNMENT          ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'HAUSA               ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'HISTORY             ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'HOME ECONOMICS      ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'IGBO                ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'INTER. SCIENCE      ', N'JSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'INTRO. TECH         ', N'JSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'ISLAMIC RELIGIOUS ST', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'LITERATURE IN ENGLIS', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'MATHEMATICS         ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'MUSIC               ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'PHYSICAL EDUCATION  ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'PHYSICS             ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'SOCIAL STUDIES      ', N'JSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'TECHNICAL DRAWING   ', N'SSS  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'TYPING              ', N'ALL  ')
INSERT [dbo].[Subject] ([Subject], [Category]) VALUES (N'YORUBA              ', N'ALL  ')
/****** Object:  Table [dbo].[StudentInfo]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInfo](
	[FormNumber] [nchar](10) NOT NULL,
	[FirstName] [nchar](20) NULL,
	[MiddleName] [nchar](20) NULL,
	[Surname] [nchar](20) NULL,
	[FulllName] [nchar](60) NOT NULL,
	[BloodGrooup] [nchar](10) NULL,
	[Genotype] [nchar](10) NULL,
	[GuardiansName] [nchar](60) NULL,
	[GuardiansAddress] [nchar](150) NULL,
	[GuardiansOfficePhoneNum] [nchar](20) NULL,
	[GuardiansHousePhoneNum] [nchar](20) NULL,
	[guardiansAlternateNumber] [nchar](20) NULL,
	[Gendre] [nchar](10) NULL,
	[State] [nchar](15) NULL,
	[localGovt] [nchar](20) NULL,
	[Clas] [nchar](10) NULL,
	[Active] [nchar](3) NULL,
	[DOB] [datetime] NULL,
	[passport] [nchar](90) NULL,
	[Scholarship] [nchar](10) NULL,
	[House] [nchar](15) NULL,
	[Tribe] [nchar](20) NULL,
	[ActiveMain] [bit] NULL,
 CONSTRAINT [PK_StudentInfo_1] PRIMARY KEY CLUSTERED 
(
	[FormNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[StudentInfo] ([FormNumber], [FirstName], [MiddleName], [Surname], [FulllName], [BloodGrooup], [Genotype], [GuardiansName], [GuardiansAddress], [GuardiansOfficePhoneNum], [GuardiansHousePhoneNum], [guardiansAlternateNumber], [Gendre], [State], [localGovt], [Clas], [Active], [DOB], [passport], [Scholarship], [House], [Tribe], [ActiveMain]) VALUES (N'1234      ', N'DON                 ', N'OJU                 ', N'UNO                 ', N'UNO DON OJU                                                 ', N'o         ', N'a         ', N'DOM                                                         ', N'EKO                                                                                                                                                   ', N'8979789             ', N'8979                ', N'879797              ', N'male      ', N'delta          ', N'aboh                ', N'js1a      ', N'YES', CAST(0x0000A5BB0100A301 AS DateTime), N'C:\reportMAN\StudentPassport\okey.jpg                                                     ', NULL, NULL, NULL, NULL)
INSERT [dbo].[StudentInfo] ([FormNumber], [FirstName], [MiddleName], [Surname], [FulllName], [BloodGrooup], [Genotype], [GuardiansName], [GuardiansAddress], [GuardiansOfficePhoneNum], [GuardiansHousePhoneNum], [guardiansAlternateNumber], [Gendre], [State], [localGovt], [Clas], [Active], [DOB], [passport], [Scholarship], [House], [Tribe], [ActiveMain]) VALUES (N'1977      ', N'AUSTIN              ', N'OGHENE              ', N'UCHE                ', N'UCHE AUSTIN OGHENE                                          ', N'B         ', N'AA        ', N'UCHE                                                        ', N'ABA                                                                                                                                                   ', N'876868787           ', N'876868              ', N'8687786             ', N'MALE      ', N'kebbi          ', N'kebbi               ', N'JS3A      ', N'YES', CAST(0x0000A5BC00B5722A AS DateTime), N'C:\reportMAN\StudentPassport\frank.jpg                                                    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[StudentInfo] ([FormNumber], [FirstName], [MiddleName], [Surname], [FulllName], [BloodGrooup], [Genotype], [GuardiansName], [GuardiansAddress], [GuardiansOfficePhoneNum], [GuardiansHousePhoneNum], [guardiansAlternateNumber], [Gendre], [State], [localGovt], [Clas], [Active], [DOB], [passport], [Scholarship], [House], [Tribe], [ActiveMain]) VALUES (N'1987      ', N'MARK                ', N'AYOK                ', N'AKUT                ', N'AKUT MARK AYOK                                              ', N'          ', N'          ', N'AKUT                                                        ', N'ADR                                                                                                                                                   ', N'7657667             ', N'686878              ', N'                    ', N'MALE      ', N'               ', N'                    ', N'JS1B      ', N'YES', CAST(0x0000A5BC00B5722A AS DateTime), N'C:\reportMAN\StudentPassport\blank.jpg                                                    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[StudentInfo] ([FormNumber], [FirstName], [MiddleName], [Surname], [FulllName], [BloodGrooup], [Genotype], [GuardiansName], [GuardiansAddress], [GuardiansOfficePhoneNum], [GuardiansHousePhoneNum], [guardiansAlternateNumber], [Gendre], [State], [localGovt], [Clas], [Active], [DOB], [passport], [Scholarship], [House], [Tribe], [ActiveMain]) VALUES (N'4321      ', N'ADE                 ', N'FEMI                ', N'OJU                 ', N'OJU ADE FEMI                                                ', N'O         ', N'AA        ', N'JASOMIA                                                     ', N'JOS                                                                                                                                                   ', N'87687687            ', N'5878687             ', N'678687              ', N'MALE      ', N'kano           ', N'kano                ', N'JS3A      ', N'YES', CAST(0x00009C3F011871C0 AS DateTime), N'C:\reportMAN\StudentPassport\ado.jpg                                                      ', NULL, NULL, NULL, NULL)
INSERT [dbo].[StudentInfo] ([FormNumber], [FirstName], [MiddleName], [Surname], [FulllName], [BloodGrooup], [Genotype], [GuardiansName], [GuardiansAddress], [GuardiansOfficePhoneNum], [GuardiansHousePhoneNum], [guardiansAlternateNumber], [Gendre], [State], [localGovt], [Clas], [Active], [DOB], [passport], [Scholarship], [House], [Tribe], [ActiveMain]) VALUES (N'7654      ', N'SREH                ', N'GHAM                ', N'AMIR                ', N'AMIR SREH GHAM                                              ', N'A         ', N'AA        ', N'HARRY                                                       ', N'ADR                                                                                                                                                   ', N'768687              ', N'86868               ', N'68876887            ', N'          ', N'KANO           ', N'KANO                ', N'JS1A      ', N'YES', CAST(0x0000A5BC00B2E728 AS DateTime), N'C:\reportMAN\StudentPassport\blank.jpg                                                    ', NULL, NULL, NULL, NULL)
INSERT [dbo].[StudentInfo] ([FormNumber], [FirstName], [MiddleName], [Surname], [FulllName], [BloodGrooup], [Genotype], [GuardiansName], [GuardiansAddress], [GuardiansOfficePhoneNum], [GuardiansHousePhoneNum], [guardiansAlternateNumber], [Gendre], [State], [localGovt], [Clas], [Active], [DOB], [passport], [Scholarship], [House], [Tribe], [ActiveMain]) VALUES (N'9123      ', N'ALEEZ               ', N'EGU                 ', N'UNO                 ', N'UNO ALEEZ EGU                                               ', N'A         ', N'AA        ', N'UCHEREWE                                                    ', N'ABRAKA                                                                                                                                                ', N'903474747           ', N'687687687           ', N'87686787            ', N'MALE      ', N'delta          ', N'ethiope             ', N'JS1A      ', N'YES', CAST(0x0000A530011871C0 AS DateTime), N'C:\reportMAN\StudentPassport\adama.jpg                                                    ', NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[States]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[LGA] [nvarchar](60) NULL,
	[State] [nvarchar](60) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abadam', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abaji', N'FCT')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abak', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abakaliki', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aba North', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aba South', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abeokuta North', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abeokuta South', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abi', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aboh Mbaise', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Abua/Odual', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Adavi', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ado Ekiti', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ado-Odo/Ota', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Afijio', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Afikpo North', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Afikpo South (Edda)', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Agaie', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Agatu', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Agwara', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Agege', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aguata', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ahiazu Mbaise', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ahoada East', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ahoada West', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ajaokuta', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ajeromi-Ifelodun', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ajingi', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akamkpa', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akinyele', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akko', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akoko-Edo', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akoko North-East', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akoko North-West', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akoko South-West', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akoko South-East', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akpabuyo', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akuku-Toru', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akure North', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akure South', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Akwanga', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Albasu', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aleiro', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Alimosho', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Alkaleri', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Amuwo-Odofin', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Anambra East', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Anambra West', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Anaocha', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Andoni', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aninri', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aniocha North', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aniocha South', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Anka', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ankpa', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Apa', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Apapa', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ado', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ardo Kola', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Arewa Dandi', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Argungu', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Arochukwu', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Asa', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Asari-Toru', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Askira/Uba', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Atakunmosa East', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Atakunmosa West', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Atiba', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Atisbo', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Augie', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Auyo', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Awe', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Awgu', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Awka North', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Awka South', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ayamelum', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aiyedaade', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Aiyedire', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Babura', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Badagry', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bagudo', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bagwai', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bakassi', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bokkos', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bakori', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bakura', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Balanga', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bali', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bama', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bade', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Barkin Ladi', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Baruten', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bassa', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bassa', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Batagarawa', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Batsari', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bauchi', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Baure', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bayo', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bebeji', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bekwarra', N'Cross River State')
GO
print 'Processed 100 total records'
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bende', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Biase', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bichi', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bida', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Billiri', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bindawa', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Binji', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Biriniwa', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Birnin Gwari', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Birnin Kebbi', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Birnin Kudu', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Birnin Magaji/Kiyaw', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Biu', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bodinga', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bogoro', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Boki', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Boluwaduro', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bomadi', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bonny', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Borgu', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Boripe', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bursari', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bosso', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Brass', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Buji', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bukkuyum', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Buruku', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bungudu', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bunkure', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bunza', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Burutu', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Bwari', N'FCT')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Calabar Municipal', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Calabar South', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Chanchaga', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Charanchi', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Chibok', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Chikun', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dala', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Damaturu', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Damban', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dambatta', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Damboa', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dandi', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dandume', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dange Shuni', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Danja', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dan Musa', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Darazo', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dass', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Daura', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dawakin Kudu', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dawakin Tofa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Degema', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dekina', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Demsa', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dikwa', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Doguwa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Doma', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Donga', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dukku', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dunukofia', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dutse', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dutsi', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Dutsin Ma', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Eastern Obolo', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ebonyi', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Edati', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ede North', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ede South', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Edu', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ife Central', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ife East', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ife North', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ife South', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Efon', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Egbado North', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Egbado South', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Egbeda', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Egbedore', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Egor', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ehime Mbano', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ejigbo', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ekeremor', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Eket', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ekiti', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ekiti East', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ekiti South-West', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ekiti West', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ekwusigo', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Eleme', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Emuoha', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Emure', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Enugu East', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Enugu North', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Enugu South', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Epe', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Esan Central', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Esan North-East', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Esan South-East', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Esan West', N'Edo State')
GO
print 'Processed 200 total records'
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ese Odo', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Esit Eket', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Essien Udim', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Etche', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ethiope East', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ethiope West', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Etim Ekpo', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Etinan', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Eti Osa', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Etsako Central', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Etsako East', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Etsako West', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Etung', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ewekoro', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ezeagu', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ezinihitte', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ezza North', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ezza South', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Fagge', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Fakai', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Faskari', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Fika', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Fufure', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Funakaye', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Fune', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Funtua', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gabasawa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gada', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gagarawa', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gamawa', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ganjuwa', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ganye', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Garki', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Garko', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Garun Mallam', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gashaka', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gassol', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gaya', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gayuk', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gezawa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gbako', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gboko', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gbonyin', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Geidam', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Giade', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Giwa', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gokana', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gombe', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gombi', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Goronyo', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Grie', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gubio', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gudu', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gujba', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gulani', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Guma', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gumel', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gummi', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gurara', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Guri', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gusau', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Guzamala', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwadabawa', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwagwalada', N'FCT')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwale', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwandu', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwaram', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwarzo', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwer East', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwer West', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwiwa', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Gwoza', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Hadejia', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Hawul', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Hong', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibadan North', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibadan North-East', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibadan North-West', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibadan South-East', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibadan South-West', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibaji', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibarapa Central', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibarapa East', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibarapa North', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibeju-Lekki', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibeno', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibesikpo Asutan', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibi', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ibiono-Ibom', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Idah', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Idanre', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ideato North', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ideato South', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Idemili North', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Idemili South', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ido', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ido Osi', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ifako-Ijaiye', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ifedayo', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ifedore', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ifelodun', N'Kwara State')
GO
print 'Processed 300 total records'
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ifelodun', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ifo', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Igabi', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Igalamela Odolu', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Igbo Etiti', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Igbo Eze North', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Igbo Eze South', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Igueben', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ihiala', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ihitte/Uboma', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ilaje', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ijebu East', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ijebu North', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ijebu North East', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ijebu Ode', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ijero', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ijumu', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ika', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ika North East', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikara', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ika South', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikeduru', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikeja', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikenne', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikere', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikole', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikom', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikono', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikorodu', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikot Abasi', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikot Ekpene', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikpoba Okha', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikwerre', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikwo', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ikwuano', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ila', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ilejemeje', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ile Oluji/Okeigbo', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ilesa East', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ilesa West', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Illela', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ilorin East', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ilorin South', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ilorin West', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Imeko Afon', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ingawa', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ini', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ipokia', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Irele', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Irepo', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Irepodun', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Irepodun', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Irepodun/Ifelodun', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Irewole', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isa', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ise/Orun', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Iseyin', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ishielu', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isiala Mbano', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isiala Ngwa North', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isiala Ngwa South', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isin', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isi Uzo', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isokan', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isoko North', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isoko South', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isu', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Isuikwuato', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Itas/Gadau', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Itesiwaju', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Itu', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ivo', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Iwajowa', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Iwo', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Izzi', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jaba', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jada', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jahun', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jakusko', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jalingo', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jama''are', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jega', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jema''a', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jere', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jibia', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jos East', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jos North', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Jos South', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kabba/Bunu', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kabo', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kachia', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaduna North', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaduna South', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kafin Hausa', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kafur', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaga', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kagarko', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaiama', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaita', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kajola', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kajuru', N'Kaduna State')
GO
print 'Processed 400 total records'
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kala/Balge', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kalgo', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaltungo', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kanam', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kankara', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kanke', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kankia', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kano Municipal', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Karasuwa', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Karaye', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Karim Lamido', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Karu', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Katagum', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Katcha', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Katsina', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Katsina-Ala', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaura', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaura Namoda', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kauru', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kazaure', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Keana', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kebbe', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Keffi', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Khana', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kibiya', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kirfi', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kiri Kasama', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kiru', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kiyawa', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kogi', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Koko/Besse', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kokona', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kolokuma/Opokuma', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Konduga', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Konshisha', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kontagora', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kosofe', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kaugama', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kubau', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kudan', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kuje', N'FCT')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kukawa', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kumbotso', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kumi', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kunchi', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kura', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kurfi', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kusada', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kwali', N'FCT')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kwande', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kwami', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kware', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Kwaya Kusar', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lafia', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lagelu', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lagos Island', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lagos Mainland', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Langtang South', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Langtang North', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lapai', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lamurde', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lau', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lavun', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lere', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Logo', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Lokoja', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Machina', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Madagali', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Madobi', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mafa', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Magama', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Magumeri', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mai''Adua', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Maiduguri', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Maigatari', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Maiha', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Maiyama', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Makarfi', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Makoda', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Malam Madori', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Malumfashi', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mangu', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mani', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Maradun', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mariga', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Makurdi', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Marte', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Maru', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mashegu', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mashi', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Matazu', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mayo Belwa', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mbaitoli', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mbo', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Michika', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Miga', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mikang', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Minjibir', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Misau', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Moba', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mobbar', N'Borno State')
GO
print 'Processed 500 total records'
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mubi North', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mubi South', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mokwa', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Monguno', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mopa Muro', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Moro', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Moya', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mkpat-Enin', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Municipal Area Council', N'FCT')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Musawa', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Mushin', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nafada', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nangere', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nasarawa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nasarawa', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nasarawa Egon', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ndokwa East', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ndokwa West', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nembe', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ngala', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nganzai', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ngaski', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ngor Okpala', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nguru', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ningi', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Njaba', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Njikoka', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nkanu East', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nkanu West', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nkwerre', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nnewi North', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nnewi South', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nsit-Atai', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nsit-Ibom', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nsit-Ubium', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nsukka', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Numan', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Nwangele', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obafemi Owode', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obanliku', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obi', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obi', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obi Ngwa', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obio/Akpor', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obokun', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obot Akara', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obowo', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obubra', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Obudu', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Odeda', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Odigbo', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Odogbolu', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Odo Otin', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Odukpani', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Offa', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ofu', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogba/Egbema/Ndoni', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogbadibo', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogbaru', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogbia', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogbomosho North', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogbomosho South', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogu/Bolo', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogoja', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogo Oluwa', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogori/Magongo', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ogun Waterside', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oguta', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ohafia', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ohaji/Egbema', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ohaozara', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ohaukwu', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ohimini', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Orhionmwon', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oji River', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ojo', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oju', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okehi', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okene', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oke Ero', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okigwe', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okitipupa', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okobo', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okpe', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okrika', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Olamaboro', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ola Oluwa', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Olorunda', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Olorunsogo', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oluyole', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Omala', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Omuma', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ona Ara', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ondo East', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ondo West', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Onicha', N'Ebonyi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Onitsha North', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Onitsha South', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Onna', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Okpokwu', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Opobo/Nkoro', N'Rivers State')
GO
print 'Processed 600 total records'
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oredo', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Orelope', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oriade', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ori Ire', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Orlu', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Orolu', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oron', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Orsu', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oru East', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oruk Anam', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Orumba North', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Orumba South', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oru West', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ose', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oshimili North', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oshimili South', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oshodi-Isolo', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Osisioma', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Osogbo', N'Osun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oturkpo', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ovia North-East', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ovia South-West', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Owan East', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Owan West', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Owerri Municipal', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Owerri North', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Owerri West', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Owo', N'Ondo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oye', N'Ekiti State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oyi', N'Anambra State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oyigbo', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oyo', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oyo East', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Oyun', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Paikoro', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Pankshin', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Patani', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Pategi', N'Kwara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Port Harcourt', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Potiskum', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Qua''an Pan', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Rabah', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Rafi', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Rano', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Remo North', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Rijau', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Rimi', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Rimin Gado', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ringim', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Riyom', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Rogo', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Roni', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sabon Birni', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sabon Gari', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sabuwa', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Safana', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sagbama', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sakaba', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Saki East', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Saki West', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sandamu', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sanga', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sapele', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sardauna', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shagamu', N'Ogun State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shagari', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shanga', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shani', N'Borno State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shanono', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shelleng', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shendam', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shinkafi', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shira', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shiroro', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shongom', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Shomolu', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Silame', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Soba', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sokoto North', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sokoto South', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Song', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Southern Ijaw', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Suleja', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sule Tankarkar', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Sumaila', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Suru', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Surulere', N'Oyo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Surulere', N'Lagos State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tafa', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tafawa Balewa', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tai', N'Rivers State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Takai', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Takum', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Talata Mafara', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tambuwal', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tangaza', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tarauni', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tarka', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tarmuwa', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Taura', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Toungo', N'Adamawa State')
GO
print 'Processed 700 total records'
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tofa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Toro', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Toto', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Chafe', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tsanyawa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tudun Wada', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Tureta', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Udenu', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Udi', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Udu', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Udung-Uko', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ughelli North', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ughelli South', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ugwunagbo', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Uhunmwonde', N'Edo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ukanafun', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ukum', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ukwa East', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ukwa West', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ukwuani', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Umuahia North', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Umuahia South', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Umu Nneochi', N'Abia State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ungogo', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Unuimo', N'Imo State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Uruan', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Urue-Offong/Oruko', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ushongo', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Ussa', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Uvwie', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Uyo', N'Akwa Ibom State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Uzo Uwani', N'Enugu State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Vandeikya', N'Benue State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wamako', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wamba', N'Nasarawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Warawa', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Warji', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Warri North', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Warri South', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Warri South West', N'Delta State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wasagu/Danko', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wase', N'Plateau State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wudil', N'Kano State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wukari', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wurno', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Wushishi', N'Niger State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yabo', N'Sokoto State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yagba East', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yagba West', N'Kogi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yakuur', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yala', N'Cross River State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yamaltu/Deba', N'Gombe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yankwashi', N'Jigawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yauri', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yenagoa', N'Bayelsa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yola North', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yola South', N'Adamawa State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yorro', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yunusari', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Yusufari', N'Yobe State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Zaki', N'Bauchi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Zango', N'Katsina State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Zangon Kataf', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Zaria', N'Kaduna State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Zing', N'Taraba State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Zurmi', N'Zamfara State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (N'Zuru', N'Kebbi State')
INSERT [dbo].[States] ([LGA], [State]) VALUES (NULL, NULL)
INSERT [dbo].[States] ([LGA], [State]) VALUES (NULL, NULL)
/****** Object:  Table [dbo].[StaffInfo]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffInfo](
	[StaffNumber] [nchar](10) NOT NULL,
	[StaffNames] [nchar](30) NULL,
	[Passport] [nchar](30) NULL,
	[State] [nchar](20) NULL,
	[LG] [nchar](20) NULL,
	[Tribe] [nchar](20) NULL,
	[Department] [nchar](10) NULL,
	[DOE] [date] NULL,
	[DOB] [date] NULL,
	[Gender] [nchar](8) NULL,
	[Religion] [nchar](10) NULL,
	[HouseAddress] [nchar](50) NULL,
	[CorrespondenceAddress] [nchar](50) NULL,
	[FirstNumber] [nchar](15) NULL,
	[SecondNumber] [nchar](15) NULL,
	[FirstRefreeName] [nchar](30) NULL,
	[SecondRefreeName] [nchar](30) NULL,
	[FirstRefreeNumbers] [nchar](40) NULL,
	[SecondRefreeNumbers] [nchar](40) NULL,
	[NextOfKin] [nchar](30) NULL,
	[MaritalStatus] [nchar](20) NULL,
	[FirstSchoolAttended] [nchar](20) NULL,
	[SecondSchoolAttended] [nchar](20) NULL,
	[thirdSchoolAttende] [nchar](20) NULL,
	[FouthSchoolAttended] [nchar](20) NULL,
	[FifthSchoolAttended] [nchar](20) NULL,
	[FirstQual] [nchar](20) NULL,
	[SecondQual] [nchar](20) NULL,
	[ThirdQual] [nchar](20) NULL,
	[FouthQual] [nchar](20) NULL,
	[FifthQual] [nchar](20) NULL,
	[FirstDate] [date] NULL,
	[SecondDate] [date] NULL,
	[ThirdDate] [date] NULL,
	[FouthDate] [date] NULL,
	[FifthDate] [date] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_StaffInfo] PRIMARY KEY CLUSTERED 
(
	[StaffNumber] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Session]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Session](
	[Sessionn] [nchar](10) NOT NULL,
	[ActiveSession] [nchar](6) NULL,
 CONSTRAINT [PK_Session] PRIMARY KEY CLUSTERED 
(
	[Sessionn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Session] ([Sessionn], [ActiveSession]) VALUES (N'2014/2015 ', NULL)
/****** Object:  Table [dbo].[RevenueItem]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RevenueItem](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nchar](30) NULL,
	[Item] [nchar](30) NULL,
 CONSTRAINT [PK_RevenueItem] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RevenueExpenses]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RevenueExpenses](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[RefNumber] [nchar](10) NULL,
	[Date] [date] NULL,
	[Student] [nchar](30) NULL,
	[AdmNumber] [nchar](10) NULL,
	[Person] [nchar](10) NULL,
	[Company] [nchar](20) NULL,
	[Category] [nchar](10) NULL,
	[Session] [nchar](10) NULL,
	[Term] [nchar](10) NULL,
	[Class] [nchar](10) NULL,
	[Item] [nchar](10) NULL,
	[TransType] [nchar](10) NULL,
	[Quantity] [numeric](18, 2) NULL,
	[Debit] [numeric](18, 2) NULL,
	[Credit] [numeric](18, 2) NULL,
	[Mode] [nchar](8) NULL,
	[Note] [nchar](40) NULL,
 CONSTRAINT [PK_IncomeExpenses] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'expense or revenue' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RevenueExpenses', @level2type=N'COLUMN',@level2name=N'TransType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'cash or credit' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RevenueExpenses', @level2type=N'COLUMN',@level2name=N'Mode'
GO
/****** Object:  Table [dbo].[ResultReport]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResultReport](
	[Iden] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nchar](60) NULL,
	[Clas] [nchar](10) NULL,
	[Session] [nchar](10) NULL,
	[Term] [nchar](10) NULL,
	[Subject] [nchar](20) NULL,
	[CA1] [decimal](18, 2) NULL,
	[CA2] [decimal](18, 2) NULL,
	[Exam] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[GrandTotal] [decimal](18, 2) NULL,
	[Grade] [nchar](5) NULL,
	[Average] [decimal](18, 2) NULL,
	[PositionSubject] [nchar](4) NULL,
	[PositionTotal] [nchar](4) NULL,
	[Remark] [nchar](10) NULL,
	[NoInClass] [int] NULL,
	[ClassAverage] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ResultReport] PRIMARY KEY CLUSTERED 
(
	[Iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ResultReport] ON
INSERT [dbo].[ResultReport] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [GrandTotal], [Grade], [Average], [PositionSubject], [PositionTotal], [Remark], [NoInClass], [ClassAverage]) VALUES (1, N'UNO DON OJU                                                 ', N'JS1A      ', N'2014/2015 ', N'1st       ', N'AGRICULTURAL SCIENCE', CAST(12.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), CAST(69.00 AS Decimal(18, 2)), CAST(69.00 AS Decimal(18, 2)), N'B    ', CAST(72.66 AS Decimal(18, 2)), N'2nd ', N'2nd ', NULL, 3, CAST(72.66 AS Decimal(18, 2)))
INSERT [dbo].[ResultReport] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [GrandTotal], [Grade], [Average], [PositionSubject], [PositionTotal], [Remark], [NoInClass], [ClassAverage]) VALUES (2, N'AMIR SREH GHAM                                              ', N'JS1A      ', N'2014/2015 ', N'1st       ', N'AGRICULTURAL SCIENCE', CAST(10.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(34.00 AS Decimal(18, 2)), CAST(49.00 AS Decimal(18, 2)), CAST(49.00 AS Decimal(18, 2)), N'D    ', CAST(72.66 AS Decimal(18, 2)), N'3rd ', N'3rd ', NULL, 3, CAST(72.66 AS Decimal(18, 2)))
INSERT [dbo].[ResultReport] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [GrandTotal], [Grade], [Average], [PositionSubject], [PositionTotal], [Remark], [NoInClass], [ClassAverage]) VALUES (3, N'UNO ALEEZ EGU                                               ', N'JS1A      ', N'2014/2015 ', N'1st       ', N'AGRICULTURAL SCIENCE', CAST(20.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'A    ', CAST(72.66 AS Decimal(18, 2)), N'1st ', N'1st ', NULL, 3, CAST(72.66 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[ResultReport] OFF
/****** Object:  Table [dbo].[Result]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[Iden] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nchar](60) NULL,
	[Clas] [nchar](10) NULL,
	[Session] [nchar](10) NULL,
	[Term] [nchar](10) NULL,
	[Subject] [nchar](20) NULL,
	[CA1] [decimal](18, 2) NULL,
	[CA2] [decimal](18, 2) NULL,
	[Exam] [decimal](18, 2) NULL,
	[Total] [decimal](18, 2) NULL,
	[Position1] [nchar](4) NULL,
	[Position2] [nchar](4) NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[Iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Result] ON
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (46, N'AUDU FRANCA NYA                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(9.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (47, N'BROWN MICHEAL UZO                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(17.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(35.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (48, N'SADIQ MAMAM LAGOS                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(15.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), CAST(43.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (49, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(12.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (50, N'ULOR ENOR IKOMI                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(4.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (51, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(19.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (52, N'ONOVAE OSA MIKE                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(8.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (53, N'UGBAJA CLEM AFAM                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(16.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(46.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (54, N'MOHAMMED ADO IBN                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(15.00 AS Decimal(18, 2)), CAST(19.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (55, N'NWAKWO OKEY FRANK                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(6.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (56, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(18.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(59.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (57, N'KILLIAN BLESSING NNEKA                                      ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(4.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (58, N'MAFALCHA BALA KAREN                                         ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(19.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(57.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (59, N'SIMON GEORGE ABU                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(7.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(32.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (60, N'NWACHUKWU AFAM A                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ENGLISH             ', CAST(13.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (61, N'UGBAJA CLEM AFAM                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(10.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(26.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (62, N'MOHAMMED ADO IBN                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(13.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(42.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (63, N'NWAKWO OKEY FRANK                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(9.00 AS Decimal(18, 2)), CAST(3.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (64, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(15.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (65, N'ONOVAE OSA MIKE                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(14.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(43.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (66, N'ULOR ENOR IKOMI                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(11.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (67, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(20.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(58.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (68, N'NWACHUKWU AFAM A                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(17.00 AS Decimal(18, 2)), CAST(14.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (69, N'KILLIAN BLESSING NNEKA                                      ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(13.00 AS Decimal(18, 2)), CAST(4.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (70, N'BROWN MICHEAL UZO                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(13.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (71, N'SIMON GEORGE ABU                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(4.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (72, N'MAFALCHA BALA KAREN                                         ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(18.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (73, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(15.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(33.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (74, N'SADIQ MAMAM LAGOS                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(12.00 AS Decimal(18, 2)), CAST(19.00 AS Decimal(18, 2)), CAST(33.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (75, N'AUDU FRANCA NYA                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'BIOLOGY             ', CAST(4.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (76, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(17.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(48.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (77, N'NWAKWO OKEY FRANK                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(10.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(35.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (78, N'MOHAMMED ADO IBN                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(4.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (79, N'UGBAJA CLEM AFAM                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(14.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)), CAST(35.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (80, N'ONOVAE OSA MIKE                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(12.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)), CAST(43.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (81, N'SIMON GEORGE ABU                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(9.00 AS Decimal(18, 2)), CAST(2.00 AS Decimal(18, 2)), CAST(19.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (82, N'MAFALCHA BALA KAREN                                         ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(11.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(32.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (83, N'KILLIAN BLESSING NNEKA                                      ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(2.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (84, N'BROWN MICHEAL UZO                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(19.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (85, N'AUDU FRANCA NYA                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(15.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(33.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (86, N'SADIQ MAMAM LAGOS                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(17.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (87, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(15.00 AS Decimal(18, 2)), CAST(17.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (88, N'NWACHUKWU AFAM A                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(10.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(32.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (89, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(17.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(22.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (90, N'ULOR ENOR IKOMI                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'ECONOMICS           ', CAST(9.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (91, N'ULOR ENOR IKOMI                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(17.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (92, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(15.00 AS Decimal(18, 2)), CAST(14.00 AS Decimal(18, 2)), CAST(33.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (93, N'NWACHUKWU AFAM A                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(8.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (94, N'KILLIAN BLESSING NNEKA                                      ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(11.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (95, N'BROWN MICHEAL UZO                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(14.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (96, N'AUDU FRANCA NYA                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(11.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(28.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (97, N'SADIQ MAMAM LAGOS                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(19.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(48.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (98, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(13.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (99, N'MAFALCHA BALA KAREN                                         ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(18.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(50.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (100, N'SIMON GEORGE ABU                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(7.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (101, N'ONOVAE OSA MIKE                                             ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(16.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (102, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(17.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(49.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (103, N'NWAKWO OKEY FRANK                                           ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(9.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (104, N'MOHAMMED ADO IBN                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(12.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (105, N'UGBAJA CLEM AFAM                                            ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'MATHEMATICS         ', CAST(17.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(31.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (107, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'COMPUTER STUDIES    ', CAST(13.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (108, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'COMPUTER STUDIES    ', CAST(15.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(32.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (109, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'COMPUTER STUDIES    ', CAST(9.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (110, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'CHEMISTRY           ', CAST(8.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (111, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'CHEMISTRY           ', CAST(11.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (112, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'CHEMISTRY           ', CAST(18.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(39.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (113, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'PHYSICS             ', CAST(13.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(56.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (114, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'PHYSICS             ', CAST(8.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (115, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'PHYSICS             ', CAST(12.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(31.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (116, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'FURTHER MATHEMATICS ', CAST(15.00 AS Decimal(18, 2)), CAST(9.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (117, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'FURTHER MATHEMATICS ', CAST(8.00 AS Decimal(18, 2)), CAST(15.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (118, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'FURTHER MATHEMATICS ', CAST(10.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (119, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'TECHNICAL DRAWING   ', CAST(10.00 AS Decimal(18, 2)), CAST(11.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (120, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'TECHNICAL DRAWING   ', CAST(15.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(40.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (121, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'TECHNICAL DRAWING   ', CAST(10.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (122, N'ADEDAMOLA DIRAN DANXY                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'CIVIC EDUCATION     ', CAST(15.00 AS Decimal(18, 2)), CAST(7.00 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (123, N'DEHINDE BOSE FUNKE                                          ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'CIVIC EDUCATION     ', CAST(14.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(29.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (124, N'OLATUNDE ADEOLA GRACE                                       ', N'SS1A      ', N'2014/2015 ', N'2nd       ', N'CIVIC EDUCATION     ', CAST(17.00 AS Decimal(18, 2)), CAST(18.00 AS Decimal(18, 2)), CAST(55.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (125, N'ABBEB ABEEB A                                               ', N'JS1A      ', N'2014/2015 ', N'3rd       ', N'HAUSA               ', CAST(12.00 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (126, N'MARY JAMES B                                                ', N'JS1A      ', N'2014/2015 ', N'3rd       ', N'HAUSA               ', CAST(3.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(23.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (127, N'UNO DON OJU                                                 ', N'JS1A      ', N'2014/2015 ', N'1st       ', N'AGRICULTURAL SCIENCE', CAST(12.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(45.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (128, N'AMIR SREH GHAM                                              ', N'JS1A      ', N'2014/2015 ', N'1st       ', N'AGRICULTURAL SCIENCE', CAST(10.00 AS Decimal(18, 2)), CAST(5.00 AS Decimal(18, 2)), CAST(34.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[Result] ([Iden], [FullName], [Clas], [Session], [Term], [Subject], [CA1], [CA2], [Exam], [Total], [Position1], [Position2]) VALUES (129, N'UNO ALEEZ EGU                                               ', N'JS1A      ', N'2014/2015 ', N'1st       ', N'AGRICULTURAL SCIENCE', CAST(20.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Result] OFF
/****** Object:  Table [dbo].[Positions]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[Number] [nchar](3) NOT NULL,
	[Position] [nchar](6) NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'1  ', N'1st   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'10 ', N'10th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'100', N'100th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'101', N'101st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'102', N'102nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'103', N'103rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'104', N'104th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'105', N'105th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'106', N'106th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'107', N'107th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'108', N'108th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'109', N'109th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'11 ', N'11th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'110', N'110th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'111', N'111th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'112', N'112th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'113', N'113th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'114', N'114th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'115', N'115th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'116', N'116th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'117', N'117th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'118', N'118th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'119', N'119th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'12 ', N'12th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'120', N'120th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'121', N'121st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'122', N'122nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'123', N'123rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'124', N'124th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'125', N'125th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'126', N'126th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'127', N'127th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'128', N'128th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'129', N'129th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'13 ', N'13th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'130', N'130th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'131', N'131st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'132', N'132nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'133', N'133rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'134', N'134th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'135', N'135th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'136', N'136th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'137', N'137th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'138', N'138th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'139', N'139th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'14 ', N'14th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'140', N'140th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'141', N'141st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'142', N'142nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'143', N'143rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'144', N'144th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'145', N'145th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'146', N'146th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'147', N'147th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'148', N'148th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'149', N'149th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'15 ', N'15th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'150', N'150th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'151', N'151st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'152', N'152nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'153', N'153rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'154', N'154th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'155', N'155th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'156', N'156th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'157', N'157th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'158', N'158th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'159', N'159th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'16 ', N'16th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'160', N'160th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'161', N'161st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'162', N'162nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'163', N'163rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'164', N'164th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'165', N'165th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'166', N'166th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'167', N'167th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'168', N'168th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'169', N'169th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'17 ', N'17th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'170', N'170th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'171', N'171st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'172', N'172nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'173', N'173rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'174', N'174th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'175', N'175th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'176', N'176th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'177', N'177th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'178', N'178th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'179', N'179th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'18 ', N'18th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'180', N'180th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'181', N'181st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'182', N'182nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'183', N'183rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'184', N'184th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'185', N'185th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'186', N'186th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'187', N'187th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'188', N'188th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'189', N'189th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'19 ', N'19th  ')
GO
print 'Processed 100 total records'
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'190', N'190th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'191', N'191st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'192', N'192nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'193', N'193rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'194', N'194th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'195', N'195th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'196', N'196th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'197', N'197th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'198', N'198th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'199', N'199th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'2  ', N'2nd   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'20 ', N'20th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'200', N'200th ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'201', N'201st ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'202', N'202nd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'203', N'203rd ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'21 ', N'21st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'22 ', N'22nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'23 ', N'23rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'24 ', N'24th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'25 ', N'25th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'26 ', N'26th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'27 ', N'27th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'28 ', N'28th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'29 ', N'29th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'3  ', N'3rd   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'30 ', N'30th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'31 ', N'31st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'32 ', N'32nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'33 ', N'33rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'34 ', N'34th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'35 ', N'35th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'36 ', N'36th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'37 ', N'37th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'38 ', N'38th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'39 ', N'39th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'4  ', N'4th   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'40 ', N'40th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'41 ', N'41st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'42 ', N'42nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'43 ', N'43rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'44 ', N'44th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'45 ', N'45th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'46 ', N'46th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'47 ', N'47th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'48 ', N'48th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'49 ', N'49th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'5  ', N'5th   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'50 ', N'50th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'51 ', N'51st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'52 ', N'52nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'53 ', N'53rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'54 ', N'54th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'55 ', N'55th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'56 ', N'56th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'57 ', N'57th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'58 ', N'58th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'59 ', N'59th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'6  ', N'6th   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'60 ', N'60th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'61 ', N'61st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'62 ', N'62nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'63 ', N'63rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'64 ', N'64th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'65 ', N'65th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'66 ', N'66th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'67 ', N'67th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'68 ', N'68th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'69 ', N'69th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'7  ', N'7th   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'70 ', N'70th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'71 ', N'71st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'72 ', N'72nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'73 ', N'73rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'74 ', N'74th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'75 ', N'75th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'76 ', N'76th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'77 ', N'77th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'78 ', N'78th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'79 ', N'79th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'8  ', N'8th   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'80 ', N'80th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'81 ', N'81st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'82 ', N'82nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'83 ', N'83rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'84 ', N'84th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'85 ', N'85th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'86 ', N'86th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'87 ', N'87th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'88 ', N'88th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'89 ', N'89th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'9  ', N'9th   ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'90 ', N'90th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'91 ', N'91st  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'92 ', N'92nd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'93 ', N'93rd  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'94 ', N'94th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'95 ', N'95th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'96 ', N'96th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'97 ', N'97th  ')
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'98 ', N'98th  ')
GO
print 'Processed 200 total records'
INSERT [dbo].[Positions] ([Number], [Position]) VALUES (N'99 ', N'99th  ')
/****** Object:  Table [dbo].[Items]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[types] [nchar](20) NULL,
	[item] [nchar](20) NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InventoryItem]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryItem](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nchar](20) NULL,
	[Item] [nchar](30) NULL,
 CONSTRAINT [PK_InventoryItem] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[RefNumber] [nchar](10) NULL,
	[Date] [date] NULL,
	[AdmNumber] [nchar](10) NULL,
	[StudentName] [nchar](30) NULL,
	[Person] [nchar](20) NULL,
	[Supplier] [nchar](30) NULL,
	[Category] [nchar](10) NULL,
	[Item] [nchar](10) NULL,
	[Quantity] [numeric](18, 2) NULL,
	[Session] [nchar](10) NULL,
	[Term] [nchar](10) NULL,
	[Class] [nchar](10) NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseItem]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseItem](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[item] [nchar](30) NULL,
 CONSTRAINT [PK_ExpenseItem] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[defaulters]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[defaulters](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[names] [nchar](80) NULL,
	[classs] [nchar](10) NULL,
	[FeesAmount] [decimal](18, 2) NULL,
	[AmountPaid] [decimal](18, 2) NULL,
	[Balance] [decimal](18, 2) NULL,
 CONSTRAINT [PK_defaulters] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clas]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clas](
	[Clas] [nchar](10) NOT NULL,
	[pwd] [nchar](10) NULL,
 CONSTRAINT [PK_Clas] PRIMARY KEY CLUSTERED 
(
	[Clas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'JS1A      ', N'js1a      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'JS1B      ', N'js1b      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'JS2A      ', N'JS2A      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'JS2B      ', N'JS2B      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'JS3A      ', N'JS3A      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'JS3B      ', N'JS3B      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'SS1A      ', N'SS1A      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'SS1B      ', N'SS1B      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'SS2A      ', N'SS2A      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'SS2B      ', N'SS2B      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'SS3A      ', N'SS3A      ')
INSERT [dbo].[Clas] ([Clas], [pwd]) VALUES (N'SS3B      ', N'SS3B      ')
/****** Object:  Table [dbo].[Bill]    Script Date: 04/27/2016 21:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[TellerNum] [nchar](15) NULL,
	[Namess] [nchar](80) NULL,
	[Clas] [nchar](10) NULL,
	[Session] [nchar](10) NULL,
	[Term] [nchar](10) NULL,
	[DOP] [datetime] NULL,
	[BillAmount] [decimal](18, 2) NULL,
	[AmountPaid] [decimal](18, 2) NULL,
	[AdmissionNumber] [nchar](20) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bill] ON
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (1, N'               ', N'UNO DON OJU                                                                     ', N'JS1A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5BD00000000 AS DateTime), CAST(123000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (2, N'               ', N'AMIR SREH GHAM                                                                  ', N'JS1A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5BD00000000 AS DateTime), CAST(43000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (3, N'               ', N'UNO ALEEZ EGU                                                                   ', N'JS1A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5BD00000000 AS DateTime), CAST(23000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (4, N'               ', N'AKUT MARK AYOK                                                                  ', N'JS1B      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5BD00000000 AS DateTime), CAST(4500.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (5, N'12345          ', N'UNO DON OJU                                                                     ', N'JS1A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5BF015B2148 AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(40000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (6, N'3123313        ', N'AMIR SREH GHAM                                                                  ', N'JS1A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5BF015B2148 AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(23000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (7, N'4534534        ', N'UNO ALEEZ EGU                                                                   ', N'JS1A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5BF015B2148 AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(12000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (8, N'5757554        ', N'UNO ALEEZ EGU                                                                   ', N'JS1A      ', N'2014/2015 ', N'2nd       ', CAST(0x0000A5C000868AC9 AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(5000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (9, N'               ', N'OJU ADE FEMI                                                                    ', N'JS3A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5C000000000 AS DateTime), CAST(45000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (10, N'756799         ', N'OJU ADE FEMI                                                                    ', N'JS3A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5C0008C3366 AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (11, N'58688          ', N'OJU ADE FEMI                                                                    ', N'JS3A      ', N'2014/2015 ', N'1st       ', CAST(0x0000A5C0008C3366 AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (12, N'               ', N'OJU ADE FEMI                                                                    ', N'JS3A      ', N'2014/2015 ', N'2nd       ', CAST(0x0000A5C000000000 AS DateTime), CAST(30000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), NULL)
INSERT [dbo].[Bill] ([iden], [TellerNum], [Namess], [Clas], [Session], [Term], [DOP], [BillAmount], [AmountPaid], [AdmissionNumber]) VALUES (13, N'35346          ', N'OJU ADE FEMI                                                                    ', N'JS3A      ', N'2014/2015 ', N'2nd       ', CAST(0x0000A5C0008CD4FA AS DateTime), CAST(0.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), NULL)
SET IDENTITY_INSERT [dbo].[Bill] OFF
