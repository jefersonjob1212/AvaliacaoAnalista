# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
I. Code base - Uma aplicação 12 fatores é sempre rastreada em um sistema de controle de versão, como Git, Mercurial, ou Subversion. Uma cópia da base de dados do rastreamento de revisões é conhecido como repositório de código, normalmente abreviado como repositório ou repo.
II. Dependencies - Uma aplicação declara todas as dependências, completa e exatamente, por meio de um manifesto de declaração de dependência. Além disso, ela usa uma ferramenta de isolamento de dependência durante a execução para garantir que não há dependências implícitas “vazamento” a partir do sistema circundante. A completa e explícita especificação de dependências é aplicada de maneira uniforme tanto para produção quanto para desenvolvimento. Exemplos: Gerenciamento de pacotes Nuget (C#) e package.json (NodeJS).
III. Config - A configuração de uma aplicação é tudo o que é provável variar entre deploys (homologação, produção, ambientes de desenvolvimento, etc). 
V Build, release, run - O app doze-fatores usa separação estrita entre os estágios de construção, lançamento e execução. Por exemplo, é impossível alterar código em tempo de execução, já que não há meios de se propagar tais mudanças de volta ao estágio de construção.
VIII. Concurrency - Na aplicação doze-fatores, processos são cidadãos de primeira classe. Processos na aplicação doze-fatores utilizam fortes sugestões do modelo de processos UNIX para execução de serviços daemon, o desenvolvedor pode arquitetar a aplicação dele para lidar com diversas cargas de trabalho, atribuindo a cada tipo de trabalho a um tipo de processo.
IX. Disposability - Os processos de um app doze-fatores são descartáveis, significando que podem ser iniciados ou parados a qualquer momento. Isso facilita o escalonamento elástico, rápido deploy de código ou mudanças de configuração, e robustez de deploys de produção.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
As principais camadas no desenvolvimento de um software são: Camada de apresentação ou interface do usuário, Camada de dados, Camada de lógica de negócios, Camada de controle, Camada de modelo.

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
A arquitetura orientada a serviços (SOA) é um método de desenvolvimento de software que usa componentes de software chamados de serviços para criar aplicações de negócios. Cada serviço fornece uma capacidade de negócios. Já a arquitetura de microsserviços é uma evolução do estilo de arquitetura da SOA. Embora cada serviço de SOA seja um recurso de negócios completo, cada microsserviço é um componente de software muito menor, especializado em apenas uma única tarefa.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
O principal objetivo de uma API Management é gerenciar os acessos as APIs para ter controle e visibilidade da comunicação dos sistemas. As principais vantagens são aprimoramento da experiência do cliente, agilidade nos negócios e integração de sistemas simplificada, mas como desvantagens temos aumento no tempo de resposta das requisições, aumentar a complexidade de gerenciamento e que pontos de extremidade podem ser vistos publicamente, o que aumenta o risco da segurança.

5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Uma Class é um conjunto ou um conjunto de objetos que compartilham de propriedades e métodos comuns. Um Struct é semelhante a uma classe, mas são usados para criar instâncias mais simples e leves, porém não existem heranças em structs.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET Core surgiu para ser multiplataforma, enquanto o .NET Framework só roda em ambiente Windows. A partir da versão 5, o .NET passou a ser multiplataforma, embora ainda exista versões recentes do .NET Framework.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST utiliza requisições e verbos HTTP, devolvendo e consumindo dados em XML ou JSON, onde é possível fazer apenas uma requisição por vez, enquanto o GRPC utiliza o Protobuf por padrão (embora haja suporte para JSON) para troca de dados e um cliente pode enviar uma ou várias solicitações de API ao servidor, o que pode resultar em uma ou várias respostas do servidor.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O gerenciamento de rotas permite impedir o acesso de usuários não autorizados a determinadas rotas. Permite que o usuário interaja com a página, que é atualizada dinamicamente para exibir informações mais recentes. Permite também que o navegador atualize apenas a parte da página que foi alterada, em vez de recarregar a página inteira. Ele pode ser feito com route guards, como no Angular, por exemplo.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
DevOps é a forma de trabalhar integrando a parte de desenvolvimento com operação, com o objetivo de entregar melhoria contínua, melhorando a qualidade dos produtos e a capacidade de resposta às suas necessidades. Promove a colaboração entre as equipes, a automação de processos e a criação de um ciclo de feedback contínuo. 

10. Explique sobre um método agile.

**Resposta:**
O Scrum é uma metodologia ágil que divide o projeto em ciclos que duram entre uma e quatro semanas (chamados sprints). As funcionalidades a serem implementadas são colocadas em uma lista de pendências chamada backlog.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
Continuous Integration (CI) e Continuous Delivery (CD) são práticas de desenvolvimento que utiliza automação para criar e implantar software. As principais ferramentas de CI/CD que existem no mercado hoje são Azure Pipelines dentro do Azure DevOps, GitLab, Aws CodeStar, entre outros.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Docker é uma plataforma de containers, enquanto um container é uma forma de empacotamento de um software. Através do Docker é possível criar, testar, implementar, enviar e controlar a versão dos contaieres.

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
O Red Hat OpenShift é uma plataforma de aplicações open source e de padrão empresarial criada para acelerar o desenvolvimento e a entrega de aplicações nativas em nuvem em ambientes de nuvem híbrida, multicloud ou na edge. O Kubernetes é um software open source que automatiza a implantação, o gerenciamento e o escalonamento de containers.

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Como vantagens, temos flexibilidade, escalabilidade, automatização, integração, agilidade e melhor experiência do usuário. Porém, como desvantagem, temos complexidade de criação, necessidade de documentação e limitações de armazenamento. Por isso, sempre precisamos analisar quais dados consumir nas nossas APIs, para não sobrecarregar serviços sem necessidade.

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Conseguimos garantir adotando medidas como usar firewalls de API para bloquear solicitações maliciosas, validar os dados enviados pelos usuários para evitar injeções de código, utilizar autenticação de token para enviar um token único em cada requisição, criptografar todas as comunicações com a API, utilizar protocolos de segurança de rede atualizados, implementar limites de tentativas de login, utilizar verificação de captchas, manter os sistemas e bibliotecas atualizados, testar regularmente vulnerabilidades e monitorar a atividade da API.

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Uma arquitetura de mensageria consiste em construir uma solução para processar informações de forma assíncrona, permitindo que os usuários continuem a utilizar o sistema enquanto as operações são processadas.

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
SAGA conta com duas estratégias de utilização: Coreografia e Orquestração. Os dois possuem suas particularidades, mas trabalham para resolver esse problema apresentado de transações distribuídas. A coreografia consiste em cada microsserviço realizando uma chamada de forma assíncrona com outro ao finalizar seu processamento com sucesso e a orquestração trabalha de forma síncrona, delegando a um “responsável” o poder de organizar esse fluxo de entrega, centralizando as chamadas dos microsserviços e separando por steps ou pequenos flows.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Baseando em que o GitOps é uma metodologia que utiliza o controle de versão do Git, para o Kubernetes ele coloca o estado desejado da infraestrutura de cluster sob controle de versão. Um exemplo de utilização é o Argo CD.