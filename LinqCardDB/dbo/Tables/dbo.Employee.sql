CREATE TABLE [dbo].[Employee] (
    [EmployeeId]   INT           NOT NULL IDENTITY,
    [Name]         VARCHAR (50)  NOT NULL,
    [JobTitle]     VARCHAR (50)  NOT NULL,
    [PhoneNumber]  VARCHAR (50)  NOT NULL,
    [Address]      VARCHAR (MAX) NOT NULL,
    [Email]		   VARCHAR (50) NOT NULL,
	[CompanyId]    INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC), 
    CONSTRAINT [FK_Employee_ToCompany] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([CompanyId])
);

