
CREATE TABLE [dbo].[Flights]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,  
    [airlineId] INT NOT NULL, 
    [countryId] INT NOT NULL, 
    [image] TEXT NULL, 
    [price] INT NULL, 
    [departureDate] DATE NULL, 
    [returnDate] DATE NULL, 
    [numSeats] INT NULL, 
    [numPassengers] INT NULL, 
    [update] NVARCHAR(50) NULL,
    foreign key ([airlineId]) references Airlines([airlineId]), 
	foreign key ([countryId]) references Countries([countryId])
) 

CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [roleId] INT NOT NULL , 
    [name] NVARCHAR(20) NULL, 
    [password] NVARCHAR(14) NULL, 
    [email] NVARCHAR(20) NULL, 
    [advertisements] BIT NULL,
    foreign key ([roleId]) references Roles([roleId])
)

CREATE TABLE [dbo].[FlightDetails]
(
	[orderId] INT NOT NULL PRIMARY KEY Identity, 
    [flightId] INT NOT NULL, 
    [userId] INT NOT NULL,
	foreign key ([flightId]) references Flights([Id]), 
	foreign key ([userId]) references Users([Id])
)
CREATE TABLE [dbo].[Messages]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [name] NVARCHAR(20) NOT NULL, 
    [email] NVARCHAR(20) NOT NULL, 
    [subject] NVARCHAR(20) NOT NULL, 
    [message] NVARCHAR(200) NOT NULL, 
    [answer] NVARCHAR(200) NULL,
)
CREATE TABLE [dbo].[Credits]
(
	[userId] INT NOT NULL PRIMARY KEY, 
    [creditNum] INT NOT NULL, 
    [month] INT NOT NULL, 
    [year] INT NOT NULL, 
    [cvv] INT NOT NULL,
	foreign key ([userId]) references Users([Id]),
)
CREATE TABLE [dbo].[Airlines]
(
	[airlineId] INT NOT NULL PRIMARY KEY Identity, 
    [airlineName] NVARCHAR(10) NOT NULL
)
CREATE TABLE [dbo].[Countries]
(
	[countryId] INT NOT NULL PRIMARY KEY Identity, 
    [countryName] NVARCHAR(10) NOT NULL
)
CREATE TABLE [dbo].[Roles] 
(
	[roleId] INT NOT NULL PRIMARY KEY Identity, 
    [roleName] NVARCHAR(10) NOT NULL
)

CREATE TABLE [dbo].[Updates] 
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [update] NVARCHAR(100) NOT NULL
)

