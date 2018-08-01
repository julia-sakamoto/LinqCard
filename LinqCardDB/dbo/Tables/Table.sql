CREATE TABLE [dbo].[Table] (
    [DepartmentId]   INT        NOT NULL,
    [DepartmentName] NCHAR (10) NOT NULL,
    [EmployeeId]     INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([DepartmentId] ASC),
    CONSTRAINT [FK_Table_ToTable] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId])
);

