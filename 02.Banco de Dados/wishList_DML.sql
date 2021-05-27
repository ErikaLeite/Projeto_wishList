USE wishList;
GO

INSERT INTO usuario (nome, email, senha)
VALUES				('Camila','camila@senai.com','camila123')
				   ,('Erika','erika@senai.com','erika123')
				   ,('Kemilly','kemilly@senai.com','kemilly123')
				   ,('Renato','renato@senai.com','renato123');
GO

INSERT INTO desejo (idUsuario, desejo)
VALUES			   (1, 'Intercâmbio')
				  ,(2, 'Estágio Google')
				  ,(3, 'Me tornar milionária')
				  ,(4, 'Montar meu próprio negócio')
GO