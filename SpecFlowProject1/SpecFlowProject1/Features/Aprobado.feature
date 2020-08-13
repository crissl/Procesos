# language: es
Característica: Aprobado
	Como docente
	Quiero aprobar a los estudiantes
	Para que pasesn al siguiente nivel

#@mytag
Escenario: Calificacion mayor igual  a 7
	Dado que que estoy logeado
	Y tengo el perfil de docente
	Y el estudiante es "Paul"
	Y la nota es 7
	Cuando aprueba
	Entonces el estudiante  es promovido

Escenario: Calificacion es 6
	Dado que que estoy logeado
	Y tengo el perfil de docente
	Y el estudiante es "Paul"
	Y la nota es 6
	Cuando no aprueba
	Entonces el estudiante no es promovido