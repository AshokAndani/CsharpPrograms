USE [UserEngagementDB]
GO
/****** Object:  Trigger [dbo].[updateToSummaryTable]    Script Date: 17-05-2020 22:46:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER trigger [dbo].[updateToSummaryTable] on [dbo].[user_engagement_MIS]
after insert
as
begin
truncate table SummaryTable

exec SP_updateToSummaryTable
end