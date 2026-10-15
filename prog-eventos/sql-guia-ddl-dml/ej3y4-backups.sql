/*select name,recovery_model_desc
from sys.databases
where name='empleados';*/

--alter database Empleados set recovery full;--

/*select name,recovery_model_desc from sys.databases
where name='empleados'*/

backup database Empleados
to disk='C:\SQLbackup\empleados.bak'

