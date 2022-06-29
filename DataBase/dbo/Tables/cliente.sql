CREATE TABLE [dbo].[cliente] (
    [id]                NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [id_tipo_documento] NUMERIC (18)  NOT NULL,
    [nombre]            VARCHAR (100) NOT NULL,
    [direccion]         VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_cliente_tipo_documento] FOREIGN KEY ([id_tipo_documento]) REFERENCES [dbo].[tipo_documento] ([id])
);

