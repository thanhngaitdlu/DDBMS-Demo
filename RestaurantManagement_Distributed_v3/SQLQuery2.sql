UPDATE Employee set Branch = 2 
where id = 1
SELECT * FROM dbo.Employee
SELECT * FROM LINK.RestaurantManagement.dbo.Employee
INSERT [dbo].[Category] ([Name], [Type]) VALUES ( N'Nuong', 1)
SELECT * FROM LINK.RestaurantManagement.dbo.Category
SELECT * FROM dbo.Category

Select *
from (SELECT * FROM dbo.Employee
		UNION
		SELECT * FROM LINK.RestaurantManagement.dbo.Employee) TEMP
WHERE Address LIKE N'Mai%'

Select ID, FirstName + LastName as Name
from (SELECT ID, FirstName, LastName FROM dbo.Employee WHERE Address LIKE N'%Mai%'
		UNION
		SELECT ID, FirstName, LastName FROM LINK.RestaurantManagement.dbo.Employee WHERE Address LIKE N'%Mai%') TEMP

ALTER PROC [dbo].[sp_GetAllUser]
AS
BEGIN
	SELECT ID = Users.name, ROLENAME = temp3.name
	FROM (SELECT groupuid, Name
			FROM (SELECT uid, Name FROM sys.sysusers where LEN(Name) = 1) temp1
			INNER JOIN sys.sysmembers temp2 ON temp1.uid = temp2.memberuid) Users
	INNER JOIN sys.sysusers temp3 ON Users.groupuid = temp3.uid
END
