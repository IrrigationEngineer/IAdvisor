/****** Script for Select User  ******/
SELECT u.[UserId] AS 'Id'
      ,u.[Name] AS 'Nombre'
      ,u.[Surname] As 'Apellido'
      ,u.[Phone] As 'Telefono'
      ,u.[Address] As 'Direccion'
      ,u.[Email] As 'Email'
      ,r.[Name] As 'Rol'
      ,[UserName] As 'User'
      ,[Password] As 'Password'
  FROM [IrrigationAdvisor].[dbo].[User] u
  Inner Join [IrrigationAdvisor].[dbo].[Role] r
  ON r.RoleId = u.RoleId
  
  /*
  Select * 
  from Role
  */