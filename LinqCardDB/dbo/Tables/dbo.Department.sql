CREATE TABLE [dbo].[Department] (
    [DepartmentId]   INT        NOT NULL,
    [DepartmentName] NCHAR (10) NOT NULL,
    [EmployeeId]     INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([DepartmentId] ASC),
    CONSTRAINT [FK_depart_ToEmployee] FOREIGN KEY ([EmployeeId]) REFERENCES [dbo].[Employee] ([EmployeeId])
);

