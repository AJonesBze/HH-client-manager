CREATE DATABASE [ClientManager1]; /* */
GO

USE [ClientManager1];
GO

CREATE TABLE [Client] (
    [ClientId] int NOT NULL IDENTITY,
    [Dob] date,
    [Gender] nvarchar(max),
    [Ethnicity] nvarchar(max),
    [Race] nvarchar(max),
    [Partner_Gender] nvarchar(max),
    [Relationship_Status] nvarchar(max),
    [Advocate_Name] nvarchar(max),
    [Notes] nvarchar(max),
	[Date_Enrolled] date,
	[Exit_Date] date,
    CONSTRAINT [PK_Client] PRIMARY KEY ([ClientId])
);
GO

CREATE TABLE [Ppsr] (
    [PpsrId] int NOT NULL IDENTITY,
    [ClientId] int NOT NULL,
	[A] int,
	[B] int,
	[C] int,
	[D] int,
	[E] int,
	[F] int,
	[G] int,
    CONSTRAINT [PK_Ppsr] PRIMARY KEY ([PpsrId]),
    CONSTRAINT [FK_Ppsr_Client_ClientId] FOREIGN KEY ([ClientId]) REFERENCES [Client] ([ClientId]) ON DELETE CASCADE
);
GO

CREATE TABLE [Pcl] (
    [PclId] int NOT NULL IDENTITY,
    [ClientId] int NOT NULL,
	[Severity_Score] int,
    CONSTRAINT [PK_Pcl] PRIMARY KEY ([PclId]),
    CONSTRAINT [FK_Post_Client_ClientId1] FOREIGN KEY ([ClientId]) REFERENCES [Client] ([ClientId]) ON DELETE CASCADE
);
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

INSERT INTO [Client] (Dob, Gender, Ethnicity, Race, Partner_Gender, Relationship_Status, Advocate_Name, Date_Enrolled)
VALUES
    ('1990-11-11', 'Female', 'African American', 'African-American', 'Male', 'Dating', 'Gale', '2018-07-11')
GO