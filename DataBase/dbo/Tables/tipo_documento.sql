CREATE TABLE [dbo].[tipo_documento] (
    [id]   NUMERIC (18) IDENTITY (1, 1) NOT NULL,
    [tipo] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tipo_documento] PRIMARY KEY CLUSTERED ([id] ASC)
);

