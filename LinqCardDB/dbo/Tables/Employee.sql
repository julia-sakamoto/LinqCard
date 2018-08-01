CREATE TABLE [dbo].[Employee] (
    [EmployeeId]   INT          NOT NULL,
    [Name]         VARCHAR (50) NOT NULL,
    [JobTitle]     VARCHAR (50) NOT NULL,
    [DepartmentId] VARCHAR (50) NOT NULL,
    [PhoneNumber]  VARCHAR (50) NOT NULL,
    [Hired ]       BIT          NULL,
    [Address]      VARCHAR (50) NOT NULL,
    [StartDate]    DATE         NOT NULL,
    [EndDate]      DATE         NULL,
    [CompanyId]    CHAR (6)     NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC),
    CONSTRAINT [FK_Employee_ToTable] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([CompanyId])
);

