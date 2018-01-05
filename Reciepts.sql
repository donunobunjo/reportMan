USE [reportMan]
GO

/****** Object:  Table [dbo].[Reciepts]    Script Date: 01/17/2017 14:59:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Reciepts](
	[iden] [int] IDENTITY(1,1) NOT NULL,
	[TellerNum] [nchar](15) NULL,
	[Namess] [nchar](80) NULL,
	[Clas] [nchar](10) NULL,
	[Session] [nchar](10) NULL,
	[Term] [nchar](10) NULL,
	[DOP] [datetime] NULL,
	[Balance] [decimal](18, 2) NULL,
	[AmountPaid] [decimal](18, 2) NULL,
	[AdmissionNumber] [nchar](20) NULL,
	[School] [nchar](15) NULL,
	[InvNumber] [nchar](15) NULL,
 CONSTRAINT [PK_Reciept] PRIMARY KEY CLUSTERED 
(
	[iden] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


