# 📚 Lista de Exercícios — C# Console

## Fundamentos de POO, Collections e LINQ

### Atividade Prática

Nesta atividade, você irá praticar conceitos fundamentais de:

- Programação Orientada a Objetos (**POO**)
- Collections
- Lambda Expressions
- LINQ

Utilizando aplicações **C# Console**.

Os exercícios estão organizados em três níveis de dificuldade:

- 🟢 Nível Fácil
- 🟡 Nível Médio
- 🔴 Nível Difícil

Comece pelo nível fácil e avance gradualmente para os desafios mais complexos.

---

# 🟢 NÍVEL FÁCIL

## Collections e Lambda

> **Objetivo:** praticar as principais estruturas de coleção do C# e expressões lambda utilizando dados estáticos.

---

# Exercício 01 — Lista de Cidades

Crie uma:

```csharp
List<string>
```

contendo o nome de **5 cidades brasileiras**.

Utilize:

```csharp
foreach
```

para percorrer a lista e imprimir cada cidade no console.

### Conceitos

- `List<T>`
- `foreach`

---

# Exercício 02 — Manipulação de List

Crie uma:

```csharp
List<int>
```

com os valores:

```text
{ 10, 25, 8, 42, 15, 30 }
```

Realize as seguintes operações:

- Insira o número `100` na posição `2`;
- Remova o elemento que está na última posição;
- Imprima a lista final.

### Conceitos

- `List<T>`
- `Insert()`
- `RemoveAt()`
- `Count`

---

# Exercício 03 — Dictionary de Produtos

Crie um:

```csharp
Dictionary<int, string>
```

representando um **cardápio de lanchonete**.

Regras:

- A chave representa o código do produto;
- O valor representa o nome do produto;
- Cadastre pelo menos **4 produtos**.

Utilize:

```csharp
foreach
```

para imprimir:

```
Código - Nome
```

### Conceitos

- `Dictionary<TKey,TValue>`
- `Key`
- `Value`
- `foreach`

---

# Exercício 04 — Fila de Atendimento

Crie uma:

```csharp
Queue<string>
```

simulando uma fila de atendimento.

Faça:

- Adicione o nome de **5 pessoas**;
- Remova as **2 primeiras pessoas** usando atendimento;
- Imprima as pessoas restantes.

### Conceitos

- `Queue<T>`
- `Enqueue()`
- `Dequeue()`
- `foreach`

---

# Exercício 05 — Pilha de Ações

Crie uma:

```csharp
Stack<string>
```

simulando o histórico de ações de um editor de texto.

Exemplo:

```
Digitar
Colar
Negrito
Apagar
```

Realize:

- Empilhe 4 ações;
- Remova (`Pop`) as 2 últimas ações;
- Informe qual ação foi desfeita.

### Conceitos

- `Stack<T>`
- `Push()`
- `Pop()`

---

# Exercício 06 — Lambda Expression

Crie uma expressão lambda utilizando:

```csharp
Func<int, int, int>
```

A função deve calcular a multiplicação entre dois números.

Teste utilizando:

- 3 pares diferentes de valores;
- Imprima os resultados no console.

### Conceitos

- `Func<>`
- Lambda Expression

---

# 🟡 NÍVEL MÉDIO

# POO + Collections + LINQ

> **Objetivo:** combinar classes, objetos, coleções e consultas LINQ.

---

# Exercício 07 — Lista de Objetos

Crie uma classe:

```csharp
Produto
```

com as propriedades:

```text
Id
Nome
Preco
```

Depois:

- Crie uma `List<Produto>`;
- Cadastre pelo menos 5 produtos;
- Utilize LINQ para filtrar produtos com preço maior que R$ 50,00;
- Imprima os produtos encontrados.

### Conceitos

- Classes
- Objetos
- `List<T>`
- LINQ
- `Where()`

---

# Exercício 08 — Dictionary com Objetos

Crie uma classe:

```csharp
Funcionario
```

com:

```text
Matricula
Nome
Salario
```

Monte:

```csharp
Dictionary<int, Funcionario>
```

Cadastre 5 funcionários.

Utilizando:

```csharp
OrderBy()
```

ordene os funcionários pelo salário do menor para o maior.

### Conceitos

- POO
- `Dictionary<TKey,TValue>`
- LINQ
- `OrderBy()`

---

# Exercício 09 — List + Select + Where

Crie uma:

```csharp
List<int>
```

contendo 10 números inteiros positivos e negativos.

Utilizando LINQ:

- Filtre números positivos usando `Where()`;
- Multiplique cada número filtrado por 2 usando `Select()`;
- Imprima o resultado.

### Conceitos

- LINQ
- `Where()`
- `Select()`
- Lambda

---

# Exercício 10 — Sintaxe de Consulta LINQ

Crie uma classe:

```csharp
Aluno
```

com:

```text
Nome
Nota
```

Crie uma:

```csharp
List<Aluno>
```

com pelo menos 6 alunos.

Utilize a sintaxe:

```csharp
from
where
orderby
select
```

Selecione alunos com:

```text
Nota >= 7
```

Apresente em ordem decrescente de nota.

### Conceitos

- POO
- LINQ Query Syntax
- `where`
- `orderby`
- `select`

---

# 🔴 NÍVEL DIFÍCIL

## Desafios com Collections + POO + LINQ

> **Objetivo:** desenvolver soluções completas combinando estruturas de dados e recursos do C#.

---

# Exercício 11 — Sistema de Fila com Histórico

Crie uma classe:

```csharp
Cliente
```

com:

```text
Nome
Prioridade
```

Monte:

```csharp
Queue<Cliente>
```

com 6 clientes.

Simule o atendimento de 4 clientes.

Para cada atendimento:

- Remova utilizando `Dequeue()`;
- Adicione o cliente atendido em uma `Stack<string>` usando `Push()`.

Ao final apresente:

## Clientes restantes

Percorra a fila e mostre os clientes que ainda aguardam.

## Histórico

Percorra a pilha mostrando:

- Último atendido;
- Primeiro atendido.

### Conceitos

- POO
- `Queue<T>`
- `Stack<T>`
- `Enqueue()`
- `Dequeue()`
- `Push()`
- `foreach`

---

# Exercício 12 — Relatório de Vendas

Crie uma classe:

```csharp
Venda
```

com:

```text
Produto
Categoria
Valor
```

Monte:

```csharp
List<Venda>
```

com pelo menos 8 vendas.

Regras:

- Utilize pelo menos 3 categorias;
- Agrupe utilizando `GroupBy()`;
- Calcule totais usando `Sum()`;
- Mostre o faturamento por categoria;
- Identifique a categoria com maior faturamento.

Utilize:

```csharp
OrderByDescending()
First()
```

para encontrar a categoria vencedora.

### Conceitos

- POO
- `List<T>`
- LINQ
- `GroupBy()`
- `Sum()`
- `OrderByDescending()`
- `First()`

---

# 📌 Regras da Atividade

Todos os exercícios devem:

✅ Utilizar **C# Console**  
✅ Utilizar dados fixos no código  
✅ Não utilizar:

```csharp
Console.ReadLine()
```

✅ Utilizar:

```csharp
Console.WriteLine()
```

para exibir resultados.

Além disso:

- Organize o código corretamente;
- Utilize nomes claros para variáveis, classes e métodos;
- Use exatamente as estruturas solicitadas;
- Comente códigos quando necessário.

---

# ⭐ Desafio Extra

Após concluir todos os exercícios, escolha um exercício do nível difícil e melhore sua solução.

Você pode:

- Criar métodos para separar responsabilidades;
- Melhorar a apresentação dos resultados;
- Criar classes auxiliares;
- Adicionar propriedades e métodos;
- Utilizar novos recursos de LINQ;
- Tornar o código mais reutilizável.

---

# 🎯 Objetivo Final

Ao concluir esta atividade, você deverá dominar:

```
POO
 ↓
Collections
 ↓
Lambda
 ↓
LINQ
 ↓
Consultas e Relatórios
```

A proposta é transformar conhecimentos vistos em aula em **soluções práticas utilizando C#**.

---

## 💡 Dica

Não tente resolver os exercícios mais difíceis de uma vez.

Leia o problema, identifique:

- Quais classes serão necessárias;
- Qual coleção deve ser utilizada;
- Quais operações LINQ serão úteis.

Divida a solução em pequenas etapas e evolua gradualmente.