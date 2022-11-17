# About

Code sample which sets a timeout on a SqlConnection which constrains opening a connection to a four second time period which is adjustable.

This can assist when there is a failure to connection to a SQL-Server where without a timeout will timeout in 30 or more seconds which can be a lifetime for a user.

:heavy_check_mark: On connection failure the exception is written to a log file.

- Read data from SQL-Server database
- Return a DataTable
- Set DataTable to BindingSource
- Set DataGridView.DataSource to BindingSource