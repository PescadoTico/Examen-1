Trabajo hecho por Jose Arturo Gutierrez Mora y Dorian Ramirez Tercero

# Examen-1

# Parte 1

1. ¿Que datos necesitas almacenar para cada empleado y su jornada de trabajo?

R/ Se deben registrar el ID del empleado, la fecha de la jornada, las horas de entrada y salida, y el tipo de jornada (diurna, nocturna, extra o festiva). Tambien es necesario diferenciar las horas ordinarias de las horas especiales y detallar las actividades realizadas si afectan el pago. Ademas, se deben incluir bonificaciones (como premios por productividad) y deducciones (como ausencias o impuestos) para calcular el pago total.

2. ¿Como determinarias la cantidad total de horas trabajadas en una semana?

R/ Se suman las horas trabajadas de lunes a domingo, separando horas ordinarias de horas especiales (extras, nocturnas o en festivos). Se verifica que el total no exceda el limite semanal permitido. Si hay actividades especiales, se evalua si aplican recargos o bonificaciones segun las politicas de la empresa o la normativa laboral.

3. ¿Como se diferenciarian las horas ordinarias de las horas especiales?

R/ Las horas ordinarias son las trabajadas en el horario regular de la empresa, mientras que las horas especiales incluyen:
Horas extras: Mas alla del horario regular.
Nocturnas: Horas trabajadas en la noche.
Fines de semana y festivos: Tienen recargos adicionales.
Actividades especiales: Si requieren mayor esfuerzo o urgencia, segun las politicas de la empresa.
La diferenciacion depende de las normativas de la empresa.

4. ¿Como se calcularia el pago total de un empleado considerando bonificaciones y deducciones?
   
R/ Primero, se multiplica el total de horas ordinarias por la tarifa base. Luego, se suman los pagos adicionales por horas especiales, que se pagan con recargos establecidos. Se agregan bonificaciones (como premios por desempeño) y se restan deducciones (como impuestos o descuentos por ausencias). El pago total es la suma de todos los ingresos menos las deducciones, respetando las normativas laborales.

5. ¿Que validaciones deberias realizar para asegurarte de que los datos ingresados son correctos?
   
R/ Es necesario validar que la hora de entrada sea antes que la de salida y verificar que las horas trabajadas no excedan los limites diarios o semanales permitidos. Tambien se deben revisar traslapes de horarios y comprobar la coherencia de las actividades registradas con la jornada laboral. Ademas, se deben validar las bonificaciones y deducciones aplicadas y revisar la consistencia de los datos, como fechas y horas en el orden correcto.
