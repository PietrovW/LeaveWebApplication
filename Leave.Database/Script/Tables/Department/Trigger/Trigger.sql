CREATE TRIGGER [Trigger]
	ON [dbo].[Department]
	AFTER INSERT, UPDATE
	AS
	BEGIN
		SET NOCOUNT ON;
		  
	UPDATE X 
	SET Inserted = GETDATE(),
	 Updated = GETDATE()
	FROM [dbo].[Department] X
	JOIN inserted i ON X.Id = i.Id
END;
