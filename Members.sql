CREATE TABLE [dbo].[PaymentTbl]
(
	[Pid] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PMonth] VARCHAR(50) NULL, 
    [PMember] VARCHAR(50) NULL, 
    [PAmount] INT NULL
)
