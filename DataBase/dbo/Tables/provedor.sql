CREATE TABLE [dbo].[provedor] (
    [id]         NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [nombre]     VARCHAR (100) NOT NULL,
    [direccion]  VARCHAR (100) NOT NULL,
    [pagina_web] VARCHAR (150) NOT NULL,
    [rut]        VARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_provedor] PRIMARY KEY CLUSTERED ([id] ASC)
);

