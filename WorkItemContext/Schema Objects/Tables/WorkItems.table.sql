CREATE TABLE [dbo].[WorkItems] (
    [WorkItemID]  INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Type]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Attachments] NVARCHAR (MAX) NULL,
    [EntryDate]   NVARCHAR (MAX) NULL,
    [EnteredBy]   NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([WorkItemID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);

