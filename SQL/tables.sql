CREATE TABLE [dbo].[Cats] (
    [cat_id]   INT        IDENTITY (1, 1) NOT NULL,
    [cat_name] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([cat_id] ASC)
);
  
 GO

CREATE TABLE [dbo].[Items] (
    [item_id]   INT        IDENTITY (1, 1) NOT NULL,
    [item_name] NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([item_id] ASC)
);

GO

CREATE TABLE [dbo].[item_cats] (
    [Id]      INT IDENTITY (1, 1) NOT NULL,
    [cat_id]  INT NULL,
    [item_id] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_item_cats_cats] FOREIGN KEY ([cat_id]) REFERENCES [dbo].[Cats] ([cat_id]),
    CONSTRAINT [FK_item_cats_items] FOREIGN KEY ([item_id]) REFERENCES [dbo].[Items] ([item_id])
);

