CREATE TABLE [dbo].[Employe] (
    [Id]       INT           NOT NULL,
    [Name]     VARCHAR (500) NOT NULL,
    [Surname]  VARCHAR (500) NOT NULL,
    [Inserted] DATE          NOT NULL,
    [Updated]  DATE          NOT NULL,
    [FVer]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

