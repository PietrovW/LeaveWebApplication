CREATE TABLE [dbo].[Record] (
    [Id]          INT  NOT NULL,
    [EmployeId]   INT  NOT NULL,
    [FurlouhId]   INT  NOT NULL,
    [DepartmetId] INT  NOT NULL,
    [Inserted]    DATE NOT NULL,
    [Updated]     DATE NOT NULL,
    [FVer]        INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

