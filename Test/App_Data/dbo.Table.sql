CREATE TABLE [dbo].[Questionary]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NOT NULL, 
    [Age] INT NOT NULL, 
    [Gender] NCHAR(10) NOT NULL, 
    [Birth] DATE NOT NULL, 
    [Martial] NCHAR(10) NOT NULL, 
    [Programming] NCHAR(10) NOT NULL, 
    [Creative] TEXT NOT NULL 
)
