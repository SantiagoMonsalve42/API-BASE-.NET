CREATE TABLE [dbo].[tipo_telefono] (
    [id]   NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [tipo] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tipo_telefono] PRIMARY KEY CLUSTERED ([id] ASC)
);

