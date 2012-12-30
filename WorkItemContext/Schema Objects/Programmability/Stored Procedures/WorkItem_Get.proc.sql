CREATE PROCEDURE [dbo].[WorkItem_Get]
	@WorkItemId int
AS
	SELECT w.WorkItemID, w.Name, w.Description, w.Type, w.Description, w.EnteredBy, w.EntryDate
	FROM WorkItems w
	WHERE WorkItemID = @WorkItemId

RETURN 0