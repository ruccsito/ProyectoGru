RESTORE FILELISTONLY FROM DISK = 'C:\Users\julioar\DotNet\ProyectoGru\DB\ProyectoGru.bak'

RESTORE DATABASE Proyecto
FROM DISK = 'C:\Users\julioar\DotNet\ProyectoGru\DB\ProyectoGru.bak'

WITH MOVE 'Proyecto' TO 'C:\Users\julioar\DotNet\LocalDB\Proyecto.mdf',
MOVE 'Proyecto_log' TO 'C:\Users\julioar\DotNet\LocalDB\Proyecto.ldf',
REPLACE;