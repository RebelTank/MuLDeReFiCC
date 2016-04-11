GO
CREATE TABLE [dbo].[FileType] (
    [FileTypeID]            INT          NOT NULL IDENTITY(1,1),
    [ExtensionName]         VARCHAR (50) NULL,
    [ExtensionLitteral]     VARCHAR (50) NULL,
    [FileCompressionFormat] VARCHAR (50) NULL
);