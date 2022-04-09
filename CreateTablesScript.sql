------------------------------------------------ [OLD]

CREATE TABLE [dbo].[Books] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (50)  NULL,
    [Info]         VARCHAR (MAX) NULL,
    [Bookquantity] INT           NULL,
    [Price]        DECIMAL(19,4) NULL,
    [Imgfile]      VARCHAR (50)  NULL,
    [Cataid]       INT           NULL,
    [Author]       VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Orders] (
    [Id]        INT  IDENTITY (1, 1) NOT NULL,
    [BookId]    INT  NOT NULL,
    [Userid]    INT  NULL,
    [Quantity]  INT  NULL,
    [Orderdate] DATE DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    [Pass] VARCHAR (50) NULL,
    [Role] VARCHAR (50) NULL,
    [Email] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


------------------------------------------------ [UPDATED]

CREATE TABLE [dbo].[Books] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (50)    NULL,
    [Info]         VARCHAR (MAX)   NULL,
    [Bookquantity] INT             NULL,
    [Price]        DECIMAL (19, 4) NULL,
    [Imgfile]      VARCHAR (50)    NULL,
    [Category]     VARCHAR (50)    NULL,
    [Author]       VARCHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Name]  VARCHAR (50) NULL,
    [Pass]  VARCHAR (50) NULL,
    [Role]  VARCHAR (50) NULL,
    [Email] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Orders] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [BookId]    INT          NOT NULL,
    [Userid]    INT          NULL,
    [Quantity]  INT          NULL,
    [Orderdate] DATE         DEFAULT (getdate()) NULL,
    [Status]    VARCHAR (50) NULL,
    CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Feedbacks] (
    [Id]           INT             IDENTITY (1, 1) NOT NULL,
    [BookId]       INT             NULL,
    [UserId]       INT             NULL,
    [FeedbackText] VARCHAR (MAX)   NULL,
    [Rating]       DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
