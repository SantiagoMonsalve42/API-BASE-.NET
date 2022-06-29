CREATE TABLE [dbo].[telefono_cliente] (
    [id_cliente]       NUMERIC (18) NOT NULL,
    [id_tipo_telefono] NUMERIC (18) NOT NULL,
    [telefono]         VARCHAR (50) NOT NULL,
    CONSTRAINT [FK_telefono_cliente_cliente] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[cliente] ([id]),
    CONSTRAINT [FK_telefono_cliente_tipo_telefono] FOREIGN KEY ([id_tipo_telefono]) REFERENCES [dbo].[tipo_telefono] ([id])
);

