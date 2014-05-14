USE [HarkkaprojektiDB]
GO

/****** Object:  Table [dbo].[Event]    Script Date: 05/14/2014 14:58:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Event](
	[EventId] [uniqueidentifier] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Summary] [varchar](255) NULL,
	[Location] [varchar](255) NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
 CONSTRAINT [PK_EVENT] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_EVENT_TYPEID] FOREIGN KEY([TypeId])
REFERENCES [dbo].[EventType] ([TypeId])
GO

ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_EVENT_TYPEID]
GO

