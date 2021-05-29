# Projeto WishList
Foi designada a você a tarefa de desenvolver um projeto envolvendo todas as etapas de desenvolvimento (desde prototipação quanto desenvolvimento das áreas – bd/backend/design/frontend). Foca no desafio: você desenvolverá uma WishList. Sim, isso mesmo. Então, você deverá desenvolver um projeto para cadastrar e listar todos os seus desejos! Quais? Os que você quiser. Foca nos objetivos e cadastre nesse sistema, pra conquista-los no futuro.

# LAYOUT

O layout de alta fidelidade foi desenvolvido nas ferramentas disponibilizadas no Figma.
O design foi pensado de maneira simples e objetiva, porém com uma aparência mais analógica, como eram feitas as listas no papel há não muito tempo atrás. Onde o autor separava uma página e escrevia seus desejos a serem realizados de maneira informal, pessoal e personalizável. Daí as cores escolhidas, como forma de remeter ao uso de canetas azuis e vermelhas para destacar títulos e textos.

# BD

A modelagem do banco de dados foi desenvolvida de acordo com o MVP da atividade. Nele possuímos duas entidades, são elas 'Usuário' e 'Desejo'.
Na entidade Usuário temos como atributos o 'id', 'nome', 'email' e 'senha', mesmo não sendo o foco da atividade criar tokens para gerenciar qual usuário está logado, é importante para entendimento do projeto como um todo.
Na entidade 'desejo' os atributos são 'id', 'idusuário' e 'desejo', onde é necessário a identificação de quem é o usuário que registrou tal desejo. Desta maneira, temos uma ligação 1:N, ou seja, um usuário pode possuir muitos desejos, mas o desejo possui apenas um usuário.

# BACK-END
Desenvolvido com o uso das tecnologias C# e ASP.NET Core e Entity Framework.

# FRONT-END