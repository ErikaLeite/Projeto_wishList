USE wishList;
GO

INSERT INTO usuario (nome, email, senha)
VALUES				('Camila','camila@senai.com','camila123')
				   ,('Erika','erika@senai.com','erika123')
				   ,('Kemilly','kemilly@senai.com','kemilly123')
				   ,('Renato','renato@senai.com','renato123');
GO

INSERT INTO desejo (idUsuario, desejo)
VALUES			   (1, 'Interc�mbio')
				  ,(2, 'Est�gio Google')
				  ,(3, 'Me tornar milion�ria')
				  ,(4, 'Montar meu pr�prio neg�cio')
GO