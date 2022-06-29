CREATE TABLE [dbo].[telefono_provedor] (
    [id_tipo_telefono] NUMERIC (18) NOT NULL,
    [id_provedor]      NUMERIC (18) NOT NULL,
    [telefono]         VARCHAR (50) NOT NULL,
    CONSTRAINT [FK_telefono_provedor_provedor] FOREIGN KEY ([id_provedor]) REFERENCES [dbo].[provedor] ([id]),
    CONSTRAINT [FK_telefono_provedor_tipo_telefono] FOREIGN KEY ([id_tipo_telefono]) REFERENCES [dbo].[tipo_telefono] ([id])
);

