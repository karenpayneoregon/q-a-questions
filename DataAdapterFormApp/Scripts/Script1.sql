SELECT id, 
       FirstName, 
       LastName, 
       HiredDate
FROM Examples.dbo.employee;

---DELETE FROM [Examples].[dbo].[employee] WHERE [dbo].[employee].id > 5
---DBCC CHECKIDENT ('[employee]', RESEED, 5);
