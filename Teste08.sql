ALTER TABLE alunos ADD COLUMN 
media FLOAT AFTER nota_2_semestre;
UPDATE alunos SET media = 
(nota_1_semestre + nota_2_semestre)/2;

ALTER TABLE alunos ADD COLUMN
estado VARCHAR(20) AFTER ano;
UPDATE alunos SET estado = CASE WHEN
media >= 6.5 THEN 'Aprovado' ELSE 'Reprovado' END;

SELECT * FROM alunos;