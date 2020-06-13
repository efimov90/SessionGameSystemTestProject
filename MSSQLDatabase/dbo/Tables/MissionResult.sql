CREATE TABLE [dbo].[MissionResult]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [MissionId] INT NOT NULL, 
    [MissionStarted] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [MissionEnded] DATETIME2 NULL, 
    [MissionEndStatus] INT NULL DEFAULT 0, 
    CONSTRAINT [FK_MissionResult_ToMission] FOREIGN KEY (MissionId) REFERENCES Mission(Id)
)
