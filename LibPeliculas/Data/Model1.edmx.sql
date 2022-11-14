
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/14/2022 14:58:16
-- Generated from EDMX file: D:\Archivos\Universidad\Programacion\.NET BootCamp - Accenture\PracticaHerencia\PracticaHerencia\PracticaPeliculasEF\LibPeliculas\Data\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBPeliculas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Peliculas'
CREATE TABLE [dbo].[Peliculas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClasificacionId] int  NOT NULL,
    [GeneroId] int  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [FechaEstreno] nvarchar(max)  NOT NULL,
    [CantidadMinutos] nvarchar(max)  NOT NULL,
    [Idioma] nvarchar(max)  NOT NULL,
    [Sinopsis] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Generos'
CREATE TABLE [dbo].[Generos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clasificaciones'
CREATE TABLE [dbo].[Clasificaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Peliculas'
ALTER TABLE [dbo].[Peliculas]
ADD CONSTRAINT [PK_Peliculas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Generos'
ALTER TABLE [dbo].[Generos]
ADD CONSTRAINT [PK_Generos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clasificaciones'
ALTER TABLE [dbo].[Clasificaciones]
ADD CONSTRAINT [PK_Clasificaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClasificacionId] in table 'Peliculas'
ALTER TABLE [dbo].[Peliculas]
ADD CONSTRAINT [FK_PeliculaClasificacion]
    FOREIGN KEY ([ClasificacionId])
    REFERENCES [dbo].[Clasificaciones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PeliculaClasificacion'
CREATE INDEX [IX_FK_PeliculaClasificacion]
ON [dbo].[Peliculas]
    ([ClasificacionId]);
GO

-- Creating foreign key on [GeneroId] in table 'Peliculas'
ALTER TABLE [dbo].[Peliculas]
ADD CONSTRAINT [FK_PeliculaGenero]
    FOREIGN KEY ([GeneroId])
    REFERENCES [dbo].[Generos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PeliculaGenero'
CREATE INDEX [IX_FK_PeliculaGenero]
ON [dbo].[Peliculas]
    ([GeneroId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------