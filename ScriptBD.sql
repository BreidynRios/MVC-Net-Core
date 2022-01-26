CREATE DATABASE [BDKaits]
GO
USE [BDKaits]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 1/26/2022 4:17:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[ApellidoPaterno] [nvarchar](20) NULL,
	[ApellidoMaterno] [nvarchar](20) NULL,
	[DNI] [char](8) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 1/26/2022 4:17:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[IdDetalle] [int] IDENTITY(1,1) NOT NULL,
	[IdOrden] [int] NOT NULL,
	[CodigoProducto] [int] NOT NULL,
	[Descripcion] [nvarchar](500) NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[SubTotal] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_DetallePedido] PRIMARY KEY CLUSTERED 
(
	[IdDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 1/26/2022 4:17:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[IdOrden] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[CodigoCliente] [int] NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[IdOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 1/26/2022 4:17:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[Codigo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 
GO
INSERT [dbo].[Cliente] ([Codigo], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [DNI]) VALUES (1, N'Juan', N'Perez', N'Lujan', N'12345678')
GO
INSERT [dbo].[Cliente] ([Codigo], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [DNI]) VALUES (2, N'Pedro', N'Lopez', N'Garcia', N'11223344')
GO
INSERT [dbo].[Cliente] ([Codigo], [Nombres], [ApellidoPaterno], [ApellidoMaterno], [DNI]) VALUES (3, N'Lucia', N'Castillo', N'Rodriguez', N'11114444')
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallePedido] ON 
GO
INSERT [dbo].[DetallePedido] ([IdDetalle], [IdOrden], [CodigoProducto], [Descripcion], [Cantidad], [PrecioUnitario], [SubTotal]) VALUES (1, 11, 1, N'Gaseosa', CAST(1.00 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[DetallePedido] ([IdDetalle], [IdOrden], [CodigoProducto], [Descripcion], [Cantidad], [PrecioUnitario], [SubTotal]) VALUES (2, 11, 2, N'Atun', CAST(2.00 AS Decimal(18, 2)), CAST(4.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[DetallePedido] ([IdDetalle], [IdOrden], [CodigoProducto], [Descripcion], [Cantidad], [PrecioUnitario], [SubTotal]) VALUES (3, 12, 2, N'Atun', CAST(2.00 AS Decimal(18, 2)), CAST(6.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[DetallePedido] ([IdDetalle], [IdOrden], [CodigoProducto], [Descripcion], [Cantidad], [PrecioUnitario], [SubTotal]) VALUES (4, 12, 1, N'Gaseosa', CAST(1.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)), CAST(8.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[DetallePedido] ([IdDetalle], [IdOrden], [CodigoProducto], [Descripcion], [Cantidad], [PrecioUnitario], [SubTotal]) VALUES (5, 12, 4, N'Yogurt', CAST(2.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[DetallePedido] ([IdDetalle], [IdOrden], [CodigoProducto], [Descripcion], [Cantidad], [PrecioUnitario], [SubTotal]) VALUES (6, 13, 1, N'Gaseosa', CAST(2.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[DetallePedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedido] ON 
GO
INSERT [dbo].[Pedido] ([IdOrden], [Fecha], [CodigoCliente], [Total]) VALUES (8, CAST(N'2022-01-26T15:59:07.093' AS DateTime), 1, CAST(29.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedido] ([IdOrden], [Fecha], [CodigoCliente], [Total]) VALUES (9, CAST(N'2022-01-26T16:00:23.587' AS DateTime), 1, CAST(29.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedido] ([IdOrden], [Fecha], [CodigoCliente], [Total]) VALUES (11, CAST(N'2022-01-26T16:08:28.583' AS DateTime), 1, CAST(29.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedido] ([IdOrden], [Fecha], [CodigoCliente], [Total]) VALUES (12, CAST(N'2022-01-26T16:10:24.427' AS DateTime), 2, CAST(40.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Pedido] ([IdOrden], [Fecha], [CodigoCliente], [Total]) VALUES (13, CAST(N'2022-01-26T16:12:45.797' AS DateTime), 1, CAST(24.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([Codigo], [Descripcion]) VALUES (1, N'Gaseosa')
GO
INSERT [dbo].[Producto] ([Codigo], [Descripcion]) VALUES (2, N'Atun')
GO
INSERT [dbo].[Producto] ([Codigo], [Descripcion]) VALUES (3, N'Sublime')
GO
INSERT [dbo].[Producto] ([Codigo], [Descripcion]) VALUES (4, N'Yogurt')
GO
INSERT [dbo].[Producto] ([Codigo], [Descripcion]) VALUES (5, N'Cereal')
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Orden] FOREIGN KEY([IdOrden])
REFERENCES [dbo].[Pedido] ([IdOrden])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Orden]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Producto] FOREIGN KEY([CodigoProducto])
REFERENCES [dbo].[Producto] ([Codigo])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Producto]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([CodigoCliente])
REFERENCES [dbo].[Cliente] ([Codigo])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
USE [master]
GO
ALTER DATABASE [BDKaits] SET  READ_WRITE 
GO
