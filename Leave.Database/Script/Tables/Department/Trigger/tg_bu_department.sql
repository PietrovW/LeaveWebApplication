CREATE TRIGGER [tg_bu_department]
	ON [dbo].[Department]
	FOR UPDATE
	AS
	BEGIN
		SET NOCOUNT ON
	END
