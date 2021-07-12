/****** Script do comando SelectTopNRows de SSMS  ******/
-- Creat
Insert into Produto
(
	Nome
	, Descricao

)
Values
(
	'Celular'
	,'Motorola Tijolão'
)
Select 
*
From Produto

-- Update
UPDATE Produto
	SET
		Nome = 'Chapeu'
		, Descricao = 'de Palha'
	WHERE id = 1

-- DELETE
	DELETE FROM Produto

