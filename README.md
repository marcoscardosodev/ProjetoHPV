🏥 Saúde em Dia - HPV

<div align="center">
https://img.shields.io/badge/C%2523-239120?style=for-the-badge&logo=c-sharp&logoColor=white
https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
https://img.shields.io/badge/Windows%2520Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white
https://img.shields.io/badge/License-MIT-blue?style=for-the-badge

Uma plataforma educativa completa para conscientização sobre HPV desenvolvida em C# Windows Forms

</div>
📋 Sobre o Projeto
A HPV Education Platform é uma aplicação desktop desenvolvida para democratizar o acesso à informação sobre HPV (Papilomavírus Humano), combinando tecnologia e educação em saúde pública. A plataforma oferece conteúdo educativo validado por fontes oficiais através de uma interface moderna e acessível.

🎯 Objetivos
✅ Educar sobre prevenção, transmissão e tratamento do HPV

✅ Combater a desinformação com dados científicos atualizados

✅ Oferecer experiência de usuário engajadora e educativa

✅ Promover conscientização sobre saúde pública

✨ Funcionalidades
🧠 Sistema de Quiz Educativo
20 perguntas elaboradas com especialistas médicos

Sistema de pontuação inteligente com feedback detalhado

Algoritmo de embaralhamento de respostas

Barra de progresso em tempo real

Explicações educativas para cada resposta

📊 Painel de Estatísticas
Dados epidemiológicos atualizados (OMS, INCA, Ministério da Saúde)

Visualização categorizada (Prevalência, Prevenção, Tipos de HPV)

Interface tabbed para melhor organização

Informações sobre vacinação e prevenção

🎨 Experiência do Usuário
Design responsivo que se adapta a diferentes resoluções

Modo tela cheia dinâmico

Animações suaves e transições

Navegação por teclado (atalhos)

Paleta de cores acessível e temática

🚀 Como Usar
Pré-requisitos
Windows 7 ou superior

.NET Framework 4.7.2 ou superior

512MB RAM mínimo (1GB recomendado)

📥 Instalação
Download do Executável

bash
# Baixe a versão mais recente na seção Releases
# Execute o arquivo HPVEducationPlatform.exe
Compilação from Source

bash
# Clone o repositório
https://github.com/marcoscardosodev/ProjetoHPV

# Abra a solução no Visual Studio
cd hpv-education-platform
start HPVEducationPlatform.sln

# Compile e execute (F5)
🎮 Controles
F11: Alternar tela cheia

ESC: Sair do modo tela cheia

Mouse: Navegação principal

Teclado: Navegação alternativa

🛠 Tecnologias
💻 Stack Principal
Tecnologia	Versão	Finalidade
C#	8.0	Linguagem principal
.NET Framework	4.7.2	Runtime environment
Windows Forms	4.8	Framework UI
System.Drawing	4.7.2	Gráficos e design
📚 Bibliotecas e Componentes
System.Windows.Forms - Interface gráfica

System.Drawing - Custom drawing e efeitos visuais

System.Collections.Generic - Estruturas de dados

LINQ - Manipulação de collections

📁 Estrutura do Projeto
text
HPVEducationPlatform/
├── Forms/
│   ├── FormMenuPrincipal.cs      # Tela principal de navegação
│   ├── FormQuiz.cs               # Sistema de quiz educativo
│   └── FormEstatisticas.cs       # Painel de estatísticas
├── Models/
│   ├── Pergunta.cs               # Modelo de questões do quiz
│   └── Estatistica.cs            # Estrutura de dados estatísticos
├── Resources/
│   ├── Icons/                    # Ícones e imagens
│   └── Data/                     # Dados e conteúdo educativo
├── Utils/
│   ├── DesignManager.cs          # Gerenciador de temas
│   └── AnimationHelper.cs        # Auxiliar de animações
└── Program.cs                    # Ponto de entrada da aplicação
🏗 Arquitetura
text
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   FormMenu      │◄──►│   FormQuiz      │◄──►│ FormEstatisticas│
│   Principal     │    │                 │    │                 │
└─────────────────┘    └─────────────────┘    └─────────────────┘
         │                       │                       │
         ▼                       ▼                       ▼
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│  Navigation     │    │  Quiz Engine    │    │ Data Visualization│
│   Manager       │    │                 │    │                 │
└─────────────────┘    └─────────────────┘    └─────────────────┘
🔧 Desenvolvimento
📋 Requisitos para Desenvolvimento
Visual Studio 2019 ou superior

.NET Framework 4.7.2 SDK

Conhecimento em C# e Windows Forms

🛠 Configuração do Ambiente
Instale as ferramentas

bash
# Visual Studio Community (gratuito)
# .NET Framework Developer Pack
Clone e explore

bash
https://github.com/marcoscardosodev/ProjetoHPV
cd hpv-education-platform
📊 Dados e Fontes
🏥 Fontes Oficiais
Organização Mundial da Saúde (OMS)

Instituto Nacional de Câncer (INCA)

Ministério da Saúde do Brasil

Centers for Disease Control (CDC)

📈 Estatísticas Incluídas
Prevalência mundial e nacional

Dados de vacinação

Informações sobre prevenção

Tipos de HPV e riscos associados



📄 Licença
Este projeto está sob a licença MIT. Veja o arquivo LICENSE para detalhes.

text
MIT License

Copyright (c) 2024 [Seu Nome]

Permissão é concedida, gratuitamente, a qualquer pessoa que obtenha uma cópia
deste software e arquivos de documentação associados...
🏆 Reconhecimentos
👨‍💻 Desenvolvedor
Marcos Cardoso - Desenvolvimento e design

🎨 Design e UX
Inspiração em guidelines modernas de UI/UX

Paleta de cores acessível

🏥 Consultoria Educacional
Conteúdo validado por fontes médicas oficiais

Revisão de especialistas em saúde pública



<div align="center">
💙 Apoie este projeto
Se este projeto foi útil para você, considere dar uma ⭐ no repositório!

Juntos podemos combater a desinformação sobre saúde pública! 🏥✨

</div>
