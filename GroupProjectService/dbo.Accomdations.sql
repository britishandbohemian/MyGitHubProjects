CREATE TABLE [dbo].[Accomdations] (
    [AccomadationID]          INT          NOT NULL,
    [AccomadationName]        VARCHAR (50) NULL,
    [AccomadationLocation]    VARCHAR (50) NULL,
    [AccomadationRating]      INT          NULL,
    [AccomadationFacilities]  VARCHAR (50) NULL,
    [AccomadationDescription] VARCHAR (50) NULL,
    [BookingsID] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([AccomadationID] ASC),
	FOREIGN KEY (BookingsID) REFERENCES Bookings(BookingsId)
);

