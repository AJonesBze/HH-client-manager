USE [ClientManager1];
GO

CREATE TABLE [Cfar] (
    [CfarId] int NOT NULL IDENTITY,
    [ClientId] int NOT NULL,
	[Anxiety] int,
	[Traumatic_Stress] int,
	[Depression] int,
	[Emotionality Index] int,
    CONSTRAINT [PK_Cfar] PRIMARY KEY ([CfarId]),
    CONSTRAINT [FK_Post_Client_ClientId2] FOREIGN KEY ([ClientId]) REFERENCES [Client] ([ClientId]) ON DELETE CASCADE
);
GO