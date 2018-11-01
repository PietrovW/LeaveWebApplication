CREATE TRIGGER [tg_bi_department]
	ON [dbo].[Department]
	FOR  INSERT
	AS
	BEGIN
		SET NOCOUNT ON
	END
