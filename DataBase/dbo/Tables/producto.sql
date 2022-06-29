CREATE TABLE [dbo].[producto] (
    [id]            NUMERIC (18)    IDENTITY (1, 1) NOT NULL,
    [nombre]        VARCHAR (50)    NOT NULL,
    [precio_actual] NUMERIC (18, 2) NOT NULL,
    [stock]         NUMERIC (18)    NOT NULL,
    [id_provedor]   NUMERIC (18)    NOT NULL,
    CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_producto_provedor] FOREIGN KEY ([id_provedor]) REFERENCES [dbo].[provedor] ([id])
);

