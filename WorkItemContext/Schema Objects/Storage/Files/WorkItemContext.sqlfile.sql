ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [WorkItemContext], FILENAME = '$(DefaultDataPath)$(DatabaseName).mdf', FILEGROWTH = 1024 KB) TO FILEGROUP [PRIMARY];

