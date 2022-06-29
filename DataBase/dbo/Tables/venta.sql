CREATE TABLE [dbo].[venta] (
    [id]          NUMERIC (18)    IDENTITY (1, 1) NOT NULL,
    [fecha]       DATE            NOT NULL,
    [id_cliente]  NUMERIC (18)    NOT NULL,
    [descuento]   NUMERIC (18, 2) NOT NULL,
    [monto_final] NUMERIC (18)    NOT NULL,
    CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_venta_cliente] FOREIGN KEY ([id_cliente]) REFERENCES [dbo].[cliente] ([id])
);

