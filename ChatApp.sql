CREATE DATABASE ChatApp
GO
USE ChatApp
GO

CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(256) NOT NULL,
	AvatarImage VARBINARY(MAX) NULL,
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE UserStatus (
    UserID INT PRIMARY KEY,
    LastOnline DATETIME,
    FOREIGN KEY(UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

CREATE TABLE ChatGroups (
    GroupID INT IDENTITY(1,1) PRIMARY KEY,
    GroupName NVARCHAR(100) NOT NULL UNIQUE,
    CreatedAt DATETIME DEFAULT GETDATE()
);

GO
CREATE TABLE GroupMembers (
    GroupID INT,
    UserID INT,
    JoinedAt DATETIME DEFAULT GETDATE(),
    PRIMARY KEY(GroupID, UserID),
    FOREIGN KEY(GroupID) REFERENCES ChatGroups(GroupID) ON DELETE CASCADE,
    FOREIGN KEY(UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

CREATE TABLE [Messages] (
    MessageID INT IDENTITY(1,1) PRIMARY KEY,
    SenderID INT,
    ReceiverID INT NULL,  -- Null nếu là group message
    GroupID INT NULL,     -- Null nếu là private message
    Content NVARCHAR(MAX),
    AttachmentPath NVARCHAR(255) NULL,
    SentAt DATETIME DEFAULT GETDATE(),

    FOREIGN KEY(SenderID) REFERENCES Users(UserID),
    FOREIGN KEY(ReceiverID) REFERENCES Users(UserID),
    FOREIGN KEY(GroupID) REFERENCES ChatGroups(GroupID)
);
GO
select * from Users