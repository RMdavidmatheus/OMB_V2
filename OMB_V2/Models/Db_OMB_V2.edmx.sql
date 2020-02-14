
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/13/2020 20:13:20
-- Generated from EDMX file: C:\Users\David PC\source\repos\OMB_V2\OMB_V2\Models\Db_OMB_V2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [OMB_Seguros];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Poliza_Aseguradora]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Poliza] DROP CONSTRAINT [FK_Poliza_Aseguradora];
GO
IF OBJECT_ID(N'[dbo].[FK_Poliza_Beneficiario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Poliza] DROP CONSTRAINT [FK_Poliza_Beneficiario];
GO
IF OBJECT_ID(N'[dbo].[FK_Poliza_Tipo_poliza]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Poliza] DROP CONSTRAINT [FK_Poliza_Tipo_poliza];
GO
IF OBJECT_ID(N'[dbo].[FK_Poliza_Tomador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Poliza] DROP CONSTRAINT [FK_Poliza_Tomador];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[FK_Polizas_Vehiculos_Poliza]', 'F') IS NOT NULL
    ALTER TABLE [OMB_Seguros_ModelStoreContainer].[Polizas_Vehiculos] DROP CONSTRAINT [FK_Polizas_Vehiculos_Poliza];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[FK_Polizas_Vehiculos_Vehiculo]', 'F') IS NOT NULL
    ALTER TABLE [OMB_Seguros_ModelStoreContainer].[Polizas_Vehiculos] DROP CONSTRAINT [FK_Polizas_Vehiculos_Vehiculo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Aseguradora]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aseguradora];
GO
IF OBJECT_ID(N'[dbo].[Beneficiario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Beneficiario];
GO
IF OBJECT_ID(N'[dbo].[Poliza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Poliza];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Tipo_poliza]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_poliza];
GO
IF OBJECT_ID(N'[dbo].[Tomador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tomador];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Vehiculo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehiculo];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Polizas_Vehiculos]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Polizas_Vehiculos];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Reporte_SOAT_V3]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Reporte_SOAT_V3];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_Ben_2]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_Ben_2];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_Beneficiario]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_Beneficiario];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_Listado_Polizas]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_Listado_Polizas];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_reporte_soat]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_reporte_soat];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_reporte_vigencias]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_reporte_vigencias];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_Tom_2]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_Tom_2];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_Tomador]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_Tomador];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_Vehiculos]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_Vehiculos];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[Vista_Vig_Pol_2]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[Vista_Vig_Pol_2];
GO
IF OBJECT_ID(N'[OMB_Seguros_ModelStoreContainer].[database_firewall_rules]', 'U') IS NOT NULL
    DROP TABLE [OMB_Seguros_ModelStoreContainer].[database_firewall_rules];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Aseguradora'
CREATE TABLE [dbo].[Aseguradora] (
    [Aseguradora_ID] int IDENTITY(1,1) NOT NULL,
    [Aseguradora_Nombre] varchar(20)  NOT NULL,
    [Fecha_de_creacion] datetime  NOT NULL
);
GO

-- Creating table 'Beneficiario'
CREATE TABLE [dbo].[Beneficiario] (
    [Ben_Documento] bigint  NOT NULL,
    [Ben_Tipo_Doc] varchar(30)  NOT NULL,
    [Ben_Nombres] varchar(30)  NOT NULL,
    [Ben_Apellidos] varchar(30)  NOT NULL,
    [Ben_Direccion] varchar(50)  NOT NULL,
    [Ben_Telefono] bigint  NOT NULL,
    [Ben_Email] varchar(40)  NOT NULL,
    [Ben_Fecha_Nacimiento] datetime  NOT NULL,
    [Fecha_Creacion] datetime  NOT NULL
);
GO

-- Creating table 'Poliza'
CREATE TABLE [dbo].[Poliza] (
    [Pol_Numero_Poliza] bigint  NOT NULL,
    [Tipo_Poliza_ID] int  NOT NULL,
    [Aseguradora_ID] int  NOT NULL,
    [Tomador_Documento] bigint  NOT NULL,
    [Beneficiario_Documento] bigint  NOT NULL,
    [Pol_Vigencia_Inicial] datetime  NOT NULL,
    [Pol_Vigencia_Final] datetime  NOT NULL,
    [Pol_Valor_Prima] decimal(19,4)  NOT NULL,
    [Pol_Estado] varchar(10)  NULL,
    [Fecha_Creacion] datetime  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Tipo_poliza'
CREATE TABLE [dbo].[Tipo_poliza] (
    [ID_Tipo_poliza] int IDENTITY(1,1) NOT NULL,
    [Nombre_Ramo] varchar(20)  NOT NULL,
    [Fecha_creacion] datetime  NOT NULL
);
GO

-- Creating table 'Tomador'
CREATE TABLE [dbo].[Tomador] (
    [Tom_Documento] bigint  NOT NULL,
    [Tom_Tip_Doc] varchar(30)  NOT NULL,
    [Tom_Nombres] varchar(30)  NOT NULL,
    [Tom_Apellidos] varchar(30)  NOT NULL,
    [Tom_Direccion] varchar(50)  NOT NULL,
    [Tom_Telefono] bigint  NOT NULL,
    [Tom_Email] varchar(40)  NOT NULL,
    [Tom_Fecha_Nacimiento] datetime  NOT NULL,
    [Fecha_Creacion] datetime  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Nombre_Usuario] varchar(20)  NOT NULL,
    [Contraseña_Usuario] varchar(30)  NOT NULL,
    [Email_Usuario] varchar(30)  NOT NULL,
    [Documento_Usuario] bigint  NOT NULL,
    [Imagenes_Usuario] varbinary(max)  NULL,
    [Fecha_creacion] datetime  NOT NULL
);
GO

-- Creating table 'Vehiculo'
CREATE TABLE [dbo].[Vehiculo] (
    [Veh_Placa] varchar(10)  NOT NULL,
    [Veh_Modelo] varchar(4)  NOT NULL,
    [Veh_Fasecolda] int  NOT NULL,
    [Veh_Servicio] varchar(20)  NOT NULL,
    [Veh_Clase] varchar(20)  NOT NULL,
    [Veh_Marca] varchar(20)  NOT NULL,
    [Veh_Valor_Auto] decimal(19,4)  NOT NULL,
    [Veh_Vigencia_Soat] datetime  NOT NULL,
    [Veh_Soat_Estado] varchar(10)  NULL,
    [Fecha_creacion] datetime  NOT NULL
);
GO

-- Creating table 'Polizas_Vehiculos'
CREATE TABLE [dbo].[Polizas_Vehiculos] (
    [PolVeh_Numero_Poliza] bigint  NOT NULL,
    [PolVeh_Veh_Placa] varchar(10)  NOT NULL,
    [Fecha_creacion] datetime  NOT NULL
);
GO

-- Creating table 'Vista_Ben_2'
CREATE TABLE [dbo].[Vista_Ben_2] (
    [Documento] bigint  NOT NULL,
    [Tipo_documento] varchar(30)  NOT NULL,
    [Nombres] varchar(61)  NOT NULL,
    [Fecha_de_nacimiento] datetime  NOT NULL,
    [Direccion] varchar(50)  NOT NULL,
    [Email] varchar(40)  NOT NULL,
    [Telefono] bigint  NOT NULL
);
GO

-- Creating table 'Vista_Beneficiario'
CREATE TABLE [dbo].[Vista_Beneficiario] (
    [Tipo_de_documento] varchar(20)  NOT NULL,
    [Documento] bigint  NOT NULL,
    [Nombres] varchar(41)  NOT NULL,
    [Direccion] varchar(20)  NOT NULL,
    [Telefono] int  NOT NULL,
    [Email] varchar(30)  NOT NULL,
    [Fecha_de_nacimiento] datetime  NOT NULL
);
GO

-- Creating table 'Vista_Listado_Polizas'
CREATE TABLE [dbo].[Vista_Listado_Polizas] (
    [Numero_de_Poliza] bigint  NOT NULL,
    [Ramo] varchar(20)  NULL,
    [Nombre_Aseguradora] varchar(20)  NULL,
    [Tipo_documento_Tomador] varchar(20)  NULL,
    [Documento_Tomador] bigint  NULL,
    [Nombres_Tomador] varchar(41)  NOT NULL,
    [Tipo_documento_Beneficiario] varchar(20)  NULL,
    [Documento_Beneficiario] bigint  NULL,
    [Nombres_Beneficiario] varchar(41)  NOT NULL,
    [Vigencia_Inicial] nvarchar(4000)  NULL,
    [Vigencia_Final] nvarchar(4000)  NULL,
    [Valor_Prima] varchar(32)  NOT NULL,
    [Estado] varchar(10)  NULL
);
GO

-- Creating table 'Vista_reporte_soat'
CREATE TABLE [dbo].[Vista_reporte_soat] (
    [Numero_de_poliza] bigint  NOT NULL,
    [Tipo_de_Documento] varchar(20)  NULL,
    [Documento] bigint  NULL,
    [Nombres] varchar(41)  NOT NULL,
    [Placa] varchar(10)  NOT NULL,
    [Fasecolda] int  NULL,
    [Servicio] varchar(20)  NULL,
    [Clase] varchar(20)  NULL,
    [Modelo] varchar(4)  NULL,
    [Marca] varchar(20)  NULL,
    [Valor_del_Auto] varchar(32)  NOT NULL,
    [Vigencia_SOAT] datetime  NULL,
    [Estado_SOAT] varchar(10)  NULL
);
GO

-- Creating table 'Vista_reporte_vigencias'
CREATE TABLE [dbo].[Vista_reporte_vigencias] (
    [Numero_de_poliza] bigint  NOT NULL,
    [Tipo_de_documento] varchar(20)  NULL,
    [Documento] bigint  NULL,
    [Nombres_Tomador] varchar(41)  NOT NULL,
    [Telefono] int  NULL,
    [Valor_prima] varchar(32)  NOT NULL,
    [Vigencia_Inicial] datetime  NOT NULL,
    [Vigencia_Final] datetime  NOT NULL,
    [Estado_de_la_poliza] varchar(10)  NULL
);
GO

-- Creating table 'Vista_Tom_2'
CREATE TABLE [dbo].[Vista_Tom_2] (
    [Documento] bigint  NOT NULL,
    [Tipo_documento] varchar(30)  NOT NULL,
    [Nombres] varchar(61)  NOT NULL,
    [Fecha_de_nacimiento] datetime  NOT NULL,
    [Direccion] varchar(50)  NOT NULL,
    [Email] varchar(40)  NOT NULL,
    [Telefono] bigint  NOT NULL
);
GO

-- Creating table 'Vista_Tomador'
CREATE TABLE [dbo].[Vista_Tomador] (
    [Tipo_de_documento] varchar(20)  NOT NULL,
    [Documento] bigint  NOT NULL,
    [Nombres] varchar(41)  NOT NULL,
    [Direccion] varchar(25)  NOT NULL,
    [Telefono] int  NOT NULL,
    [Email] varchar(30)  NOT NULL,
    [Fecha_de_nacimiento] datetime  NOT NULL
);
GO

-- Creating table 'Vista_Vehiculos'
CREATE TABLE [dbo].[Vista_Vehiculos] (
    [Numero_de_Poliza] bigint  NULL,
    [Aseguradora] varchar(20)  NULL,
    [Ramo] varchar(20)  NULL,
    [Tipo_Documento_Tomador] varchar(20)  NULL,
    [Documento_Tomador] bigint  NULL,
    [Nombres_Tomador] varchar(41)  NOT NULL,
    [Placa] varchar(10)  NULL,
    [Fasecolda] int  NOT NULL,
    [Clase] varchar(20)  NOT NULL,
    [Marca] varchar(20)  NOT NULL,
    [Modelo] varchar(4)  NOT NULL,
    [Servicio] varchar(20)  NOT NULL
);
GO

-- Creating table 'Vista_Vig_Pol_2'
CREATE TABLE [dbo].[Vista_Vig_Pol_2] (
    [Numero_Poliza] bigint  NOT NULL,
    [Tipo_documento] varchar(30)  NOT NULL,
    [Nombres] varchar(61)  NOT NULL,
    [Telefono] bigint  NOT NULL,
    [Valor_prima] varchar(32)  NOT NULL,
    [VIgencia_Inicial] datetime  NOT NULL,
    [Vigencia_Final] datetime  NOT NULL,
    [Estado] varchar(10)  NULL
);
GO

-- Creating table 'database_firewall_rules'
CREATE TABLE [dbo].[database_firewall_rules] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(128)  NOT NULL,
    [start_ip_address] varchar(45)  NOT NULL,
    [end_ip_address] varchar(45)  NOT NULL,
    [create_date] datetime  NOT NULL,
    [modify_date] datetime  NOT NULL
);
GO

-- Creating table 'Reporte_SOAT_V3'
CREATE TABLE [dbo].[Reporte_SOAT_V3] (
    [Numero_de_poliza] bigint  NOT NULL,
    [Tipo_de_Documento] varchar(30)  NULL,
    [Documento] bigint  NULL,
    [Nombres] varchar(61)  NOT NULL,
    [Placa] varchar(10)  NOT NULL,
    [Fasecolda] int  NULL,
    [Servicio] varchar(20)  NULL,
    [Clase] varchar(20)  NULL,
    [Modelo] varchar(4)  NULL,
    [Marca] varchar(20)  NULL,
    [Valor_del_Auto] varchar(32)  NOT NULL,
    [Vigencia_SOAT] datetime  NULL,
    [Estado] varchar(10)  NULL
);
GO

-- Creating table 'Pol_veh_entity_frameworkSet'
CREATE TABLE [dbo].[Pol_veh_entity_frameworkSet] (
    [PolizaPol_Numero_Poliza] bigint  NOT NULL,
    [VehiculoVeh_Placa] varchar(10)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Aseguradora_ID] in table 'Aseguradora'
ALTER TABLE [dbo].[Aseguradora]
ADD CONSTRAINT [PK_Aseguradora]
    PRIMARY KEY CLUSTERED ([Aseguradora_ID] ASC);
GO

-- Creating primary key on [Ben_Documento] in table 'Beneficiario'
ALTER TABLE [dbo].[Beneficiario]
ADD CONSTRAINT [PK_Beneficiario]
    PRIMARY KEY CLUSTERED ([Ben_Documento] ASC);
GO

-- Creating primary key on [Pol_Numero_Poliza] in table 'Poliza'
ALTER TABLE [dbo].[Poliza]
ADD CONSTRAINT [PK_Poliza]
    PRIMARY KEY CLUSTERED ([Pol_Numero_Poliza] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID_Tipo_poliza] in table 'Tipo_poliza'
ALTER TABLE [dbo].[Tipo_poliza]
ADD CONSTRAINT [PK_Tipo_poliza]
    PRIMARY KEY CLUSTERED ([ID_Tipo_poliza] ASC);
GO

-- Creating primary key on [Tom_Documento] in table 'Tomador'
ALTER TABLE [dbo].[Tomador]
ADD CONSTRAINT [PK_Tomador]
    PRIMARY KEY CLUSTERED ([Tom_Documento] ASC);
GO

-- Creating primary key on [Nombre_Usuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Nombre_Usuario] ASC);
GO

-- Creating primary key on [Veh_Placa] in table 'Vehiculo'
ALTER TABLE [dbo].[Vehiculo]
ADD CONSTRAINT [PK_Vehiculo]
    PRIMARY KEY CLUSTERED ([Veh_Placa] ASC);
GO

-- Creating primary key on [PolVeh_Numero_Poliza], [PolVeh_Veh_Placa], [Fecha_creacion] in table 'Polizas_Vehiculos'
ALTER TABLE [dbo].[Polizas_Vehiculos]
ADD CONSTRAINT [PK_Polizas_Vehiculos]
    PRIMARY KEY CLUSTERED ([PolVeh_Numero_Poliza], [PolVeh_Veh_Placa], [Fecha_creacion] ASC);
GO

-- Creating primary key on [Documento], [Tipo_documento], [Nombres], [Fecha_de_nacimiento], [Direccion], [Email], [Telefono] in table 'Vista_Ben_2'
ALTER TABLE [dbo].[Vista_Ben_2]
ADD CONSTRAINT [PK_Vista_Ben_2]
    PRIMARY KEY CLUSTERED ([Documento], [Tipo_documento], [Nombres], [Fecha_de_nacimiento], [Direccion], [Email], [Telefono] ASC);
GO

-- Creating primary key on [Tipo_de_documento], [Documento], [Nombres], [Direccion], [Telefono], [Email], [Fecha_de_nacimiento] in table 'Vista_Beneficiario'
ALTER TABLE [dbo].[Vista_Beneficiario]
ADD CONSTRAINT [PK_Vista_Beneficiario]
    PRIMARY KEY CLUSTERED ([Tipo_de_documento], [Documento], [Nombres], [Direccion], [Telefono], [Email], [Fecha_de_nacimiento] ASC);
GO

-- Creating primary key on [Numero_de_Poliza], [Nombres_Tomador], [Nombres_Beneficiario], [Valor_Prima] in table 'Vista_Listado_Polizas'
ALTER TABLE [dbo].[Vista_Listado_Polizas]
ADD CONSTRAINT [PK_Vista_Listado_Polizas]
    PRIMARY KEY CLUSTERED ([Numero_de_Poliza], [Nombres_Tomador], [Nombres_Beneficiario], [Valor_Prima] ASC);
GO

-- Creating primary key on [Numero_de_poliza], [Nombres], [Placa], [Valor_del_Auto] in table 'Vista_reporte_soat'
ALTER TABLE [dbo].[Vista_reporte_soat]
ADD CONSTRAINT [PK_Vista_reporte_soat]
    PRIMARY KEY CLUSTERED ([Numero_de_poliza], [Nombres], [Placa], [Valor_del_Auto] ASC);
GO

-- Creating primary key on [Numero_de_poliza], [Nombres_Tomador], [Valor_prima], [Vigencia_Inicial], [Vigencia_Final] in table 'Vista_reporte_vigencias'
ALTER TABLE [dbo].[Vista_reporte_vigencias]
ADD CONSTRAINT [PK_Vista_reporte_vigencias]
    PRIMARY KEY CLUSTERED ([Numero_de_poliza], [Nombres_Tomador], [Valor_prima], [Vigencia_Inicial], [Vigencia_Final] ASC);
GO

-- Creating primary key on [Documento], [Tipo_documento], [Nombres], [Fecha_de_nacimiento], [Direccion], [Email], [Telefono] in table 'Vista_Tom_2'
ALTER TABLE [dbo].[Vista_Tom_2]
ADD CONSTRAINT [PK_Vista_Tom_2]
    PRIMARY KEY CLUSTERED ([Documento], [Tipo_documento], [Nombres], [Fecha_de_nacimiento], [Direccion], [Email], [Telefono] ASC);
GO

-- Creating primary key on [Tipo_de_documento], [Documento], [Nombres], [Direccion], [Telefono], [Email], [Fecha_de_nacimiento] in table 'Vista_Tomador'
ALTER TABLE [dbo].[Vista_Tomador]
ADD CONSTRAINT [PK_Vista_Tomador]
    PRIMARY KEY CLUSTERED ([Tipo_de_documento], [Documento], [Nombres], [Direccion], [Telefono], [Email], [Fecha_de_nacimiento] ASC);
GO

-- Creating primary key on [Nombres_Tomador], [Fasecolda], [Clase], [Marca], [Modelo], [Servicio] in table 'Vista_Vehiculos'
ALTER TABLE [dbo].[Vista_Vehiculos]
ADD CONSTRAINT [PK_Vista_Vehiculos]
    PRIMARY KEY CLUSTERED ([Nombres_Tomador], [Fasecolda], [Clase], [Marca], [Modelo], [Servicio] ASC);
GO

-- Creating primary key on [Numero_Poliza], [Tipo_documento], [Nombres], [Telefono], [Valor_prima], [VIgencia_Inicial], [Vigencia_Final] in table 'Vista_Vig_Pol_2'
ALTER TABLE [dbo].[Vista_Vig_Pol_2]
ADD CONSTRAINT [PK_Vista_Vig_Pol_2]
    PRIMARY KEY CLUSTERED ([Numero_Poliza], [Tipo_documento], [Nombres], [Telefono], [Valor_prima], [VIgencia_Inicial], [Vigencia_Final] ASC);
GO

-- Creating primary key on [id], [name], [start_ip_address], [end_ip_address], [create_date], [modify_date] in table 'database_firewall_rules'
ALTER TABLE [dbo].[database_firewall_rules]
ADD CONSTRAINT [PK_database_firewall_rules]
    PRIMARY KEY CLUSTERED ([id], [name], [start_ip_address], [end_ip_address], [create_date], [modify_date] ASC);
GO

-- Creating primary key on [Numero_de_poliza], [Nombres], [Placa], [Valor_del_Auto] in table 'Reporte_SOAT_V3'
ALTER TABLE [dbo].[Reporte_SOAT_V3]
ADD CONSTRAINT [PK_Reporte_SOAT_V3]
    PRIMARY KEY CLUSTERED ([Numero_de_poliza], [Nombres], [Placa], [Valor_del_Auto] ASC);
GO

-- Creating primary key on [PolizaPol_Numero_Poliza], [VehiculoVeh_Placa] in table 'Pol_veh_entity_frameworkSet'
ALTER TABLE [dbo].[Pol_veh_entity_frameworkSet]
ADD CONSTRAINT [PK_Pol_veh_entity_frameworkSet]
    PRIMARY KEY CLUSTERED ([PolizaPol_Numero_Poliza], [VehiculoVeh_Placa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Aseguradora_ID] in table 'Poliza'
ALTER TABLE [dbo].[Poliza]
ADD CONSTRAINT [FK_Poliza_Aseguradora]
    FOREIGN KEY ([Aseguradora_ID])
    REFERENCES [dbo].[Aseguradora]
        ([Aseguradora_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Poliza_Aseguradora'
CREATE INDEX [IX_FK_Poliza_Aseguradora]
ON [dbo].[Poliza]
    ([Aseguradora_ID]);
GO

-- Creating foreign key on [Beneficiario_Documento] in table 'Poliza'
ALTER TABLE [dbo].[Poliza]
ADD CONSTRAINT [FK_Poliza_Beneficiario]
    FOREIGN KEY ([Beneficiario_Documento])
    REFERENCES [dbo].[Beneficiario]
        ([Ben_Documento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Poliza_Beneficiario'
CREATE INDEX [IX_FK_Poliza_Beneficiario]
ON [dbo].[Poliza]
    ([Beneficiario_Documento]);
GO

-- Creating foreign key on [Tipo_Poliza_ID] in table 'Poliza'
ALTER TABLE [dbo].[Poliza]
ADD CONSTRAINT [FK_Poliza_Tipo_poliza]
    FOREIGN KEY ([Tipo_Poliza_ID])
    REFERENCES [dbo].[Tipo_poliza]
        ([ID_Tipo_poliza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Poliza_Tipo_poliza'
CREATE INDEX [IX_FK_Poliza_Tipo_poliza]
ON [dbo].[Poliza]
    ([Tipo_Poliza_ID]);
GO

-- Creating foreign key on [Tomador_Documento] in table 'Poliza'
ALTER TABLE [dbo].[Poliza]
ADD CONSTRAINT [FK_Poliza_Tomador]
    FOREIGN KEY ([Tomador_Documento])
    REFERENCES [dbo].[Tomador]
        ([Tom_Documento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Poliza_Tomador'
CREATE INDEX [IX_FK_Poliza_Tomador]
ON [dbo].[Poliza]
    ([Tomador_Documento]);
GO

-- Creating foreign key on [PolVeh_Numero_Poliza] in table 'Polizas_Vehiculos'
ALTER TABLE [dbo].[Polizas_Vehiculos]
ADD CONSTRAINT [FK_Polizas_Vehiculos_Poliza]
    FOREIGN KEY ([PolVeh_Numero_Poliza])
    REFERENCES [dbo].[Poliza]
        ([Pol_Numero_Poliza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PolVeh_Veh_Placa] in table 'Polizas_Vehiculos'
ALTER TABLE [dbo].[Polizas_Vehiculos]
ADD CONSTRAINT [FK_Polizas_Vehiculos_Vehiculo]
    FOREIGN KEY ([PolVeh_Veh_Placa])
    REFERENCES [dbo].[Vehiculo]
        ([Veh_Placa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Polizas_Vehiculos_Vehiculo'
CREATE INDEX [IX_FK_Polizas_Vehiculos_Vehiculo]
ON [dbo].[Polizas_Vehiculos]
    ([PolVeh_Veh_Placa]);
GO

-- Creating foreign key on [PolizaPol_Numero_Poliza] in table 'Pol_veh_entity_frameworkSet'
ALTER TABLE [dbo].[Pol_veh_entity_frameworkSet]
ADD CONSTRAINT [FK_Pol_veh_entity_frameworkPoliza]
    FOREIGN KEY ([PolizaPol_Numero_Poliza])
    REFERENCES [dbo].[Poliza]
        ([Pol_Numero_Poliza])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [VehiculoVeh_Placa] in table 'Pol_veh_entity_frameworkSet'
ALTER TABLE [dbo].[Pol_veh_entity_frameworkSet]
ADD CONSTRAINT [FK_Pol_veh_entity_frameworkVehiculo]
    FOREIGN KEY ([VehiculoVeh_Placa])
    REFERENCES [dbo].[Vehiculo]
        ([Veh_Placa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pol_veh_entity_frameworkVehiculo'
CREATE INDEX [IX_FK_Pol_veh_entity_frameworkVehiculo]
ON [dbo].[Pol_veh_entity_frameworkSet]
    ([VehiculoVeh_Placa]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------