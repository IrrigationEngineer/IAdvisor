USE [master]
GO
CREATE LOGIN [IRAdvisor] WITH PASSWORD=N'PGWWater2014', DEFAULT_DATABASE=[IrrigationAdvisor], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [IrrigationAdvisor]
GO
CREATE USER [IRAdvisor] FOR LOGIN [IRAdvisor]
GO
USE [IrrigationAdvisor]
GO
EXEC sp_addrolemember N'db_owner', N'IRAdvisor'
GO
