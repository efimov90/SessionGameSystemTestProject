CREATE TABLE [dbo].[Party]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AutoMatchingMode] INT NOT NULL DEFAULT 0, 
    [MissionResultId] INT NULL, 
    CONSTRAINT [FK_Party_ToMissionResultId] FOREIGN KEY (MissionResultId) REFERENCES MissionResult(Id) 
)
