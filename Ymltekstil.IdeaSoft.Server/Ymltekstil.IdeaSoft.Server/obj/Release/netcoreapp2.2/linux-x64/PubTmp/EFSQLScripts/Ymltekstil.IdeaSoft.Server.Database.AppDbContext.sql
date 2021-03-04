IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210303114636_Initial')
BEGIN
    CREATE TABLE [Settings] (
        [Id] uniqueidentifier NOT NULL,
        [Key] nvarchar(max) NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_Settings] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210303114636_Initial')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Key', N'Value') AND [object_id] = OBJECT_ID(N'[Settings]'))
        SET IDENTITY_INSERT [Settings] ON;
    INSERT INTO [Settings] ([Id], [Key], [Value])
    VALUES ('44783db6-948d-422d-84fc-2af908e4cc0a', N'RefreshToken', N'MmIwMjU1NTg0ODAyZTA1OThhYmU2ZWVhYmY1YzUxZTI3YmI5MDAwM2YyMDdmZjM3ZGQyN2Y5Y2NhOGYzYTJkOA');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Key', N'Value') AND [object_id] = OBJECT_ID(N'[Settings]'))
        SET IDENTITY_INSERT [Settings] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210303114636_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210303114636_Initial', N'2.2.6-servicing-10079');
END;

GO

