CREATE DATABASE [KUAS]
GO

USE [KUAS]
GO

CREATE TABLE [dbo].[course](
	[course_id]   [nvarchar](20) NOT NULL,
	[course_name] [nvarchar](200) NOT NULL,
	[course_Description]  [nvarchar](1000) NULL,
 CONSTRAINT [PK_course_id] PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[course] ([course_id], [course_name], [course_Description]) VALUES (N'C01'  , N'ASP', N'ASP.NETASP.NETASP.NET ');
INSERT [dbo].[course] ([course_id], [course_name], [course_Description]) VALUES (N'C02', N'c#', N'MVCMVCMVCMVCMVC');
INSERT [dbo].[course] ([course_id], [course_name], [course_Description]) VALUES (N'C03'  , N'JAVA', N'xxxxJAVAxxxxx');
GO
