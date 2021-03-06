﻿CREATE TABLE [dbo].[Company] (
    [CompanyId]      INT      NOT NULL IDENTITY,
    [CompanyWebsite] VARCHAR (50)  NOT NULL,
    [CompanyName]    VARCHAR (50)  NOT NULL,
    [CompanyType]    VARCHAR (50)  NOT NULL,
    [CompanyInfo]    VARCHAR (MAX) NOT NULL,
    [CeoName]        VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([CompanyId] ASC)
);

