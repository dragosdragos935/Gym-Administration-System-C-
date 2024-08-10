CREATE TABLE [dbo].[MemberTbl]
(
	[MId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MName] VARCHAR(50) NULL, 
    [MPhone] VARCHAR(50) NULL, 
    [MGen] VARCHAR(50) NULL, 
    [MAge] INT NULL, 
    [MAmount] INT NULL, 
    [MTiming] VARCHAR(50) NULL
)
