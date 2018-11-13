USE [Leave]
GO

--select * from [dbo].[Department] ;
insert [dbo].[Department] 
go


CREATE TABLE [dbo].[Department] (
    [Id]       INT           NOT NULL,
    [Name]     VARCHAR (500) NOT NULL,
    [Inserted] DATE          NOT NULL,
    [Updated]  DATE          NOT NULL,
    [FVer]     INT           NOT NULL
);


