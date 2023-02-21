# About

Shows how to perform a bulk delete for a SQL-Server database table.

We have the following columns but for a forum question ignore the primary key `Id`

```sql
SELECT Id,
       Serial,
       SomeDate
FROM dbo.Demo1;
```

- All data operations are performed in DataOperations class.
- There are 100 records which are chunked into a string array of 20
- Each chunk performs a delete with a WHERE IN
- Has limited exception handling
