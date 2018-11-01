CREATE TABLE [dbo].[Department] (
    [Id]       INT           NOT NULL,
    [Name]     VARCHAR (500) NOT NULL,
    [Inserted] DATE          NOT NULL DEFAULT GETDATE(),
    [Updated]  DATE          NOT NULL DEFAULT GETDATE(),
    [FVer]     INT           NOT NULL DEFAULT 1,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

