CREATE TABLE [dbo].[Student] (
    [StudentId]     INT NOT NULL,
    [UserId]        INT NULL,
    [FundingStatus] VARCHAR(50) NULL,
    PRIMARY KEY CLUSTERED ([StudentId] ASC)
);

