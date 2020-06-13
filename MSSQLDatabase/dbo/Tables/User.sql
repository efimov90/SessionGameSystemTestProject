CREATE TABLE [dbo].[User]
(
	[Id] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [NickName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(256) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [Status] INT NOT NULL DEFAULT 0, 
    [LastIP] NVARCHAR(40) NOT NULL, 
    [PartyId] INT NULL, 
    CONSTRAINT [FK_User_ToParty] FOREIGN KEY (PartyId) REFERENCES Party(Id)
)
