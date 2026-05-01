# 🔗 Lista Duplamente Encadeada - C#

Aplicação Console desenvolvida para implementar uma **lista duplamente encadeada** manualmente, permitindo inserção e remoção de elementos de forma dinâmica.

---

## 📌 Funcionalidades

- Inserção de elementos na lista
- Remoção de elementos por valor
- Estrutura de lista duplamente encadeada
- Navegação bidirecional (anterior e próximo)
- Menu interativo via console

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET
- Console Application

---

## 🧠 Conceitos Aplicados

- Estrutura de Dados (Lista Duplamente Encadeada)
- Ponteiros / Referências (`next` e `prior`)
- Manipulação de memória via objetos
- Métodos com `ref`
- Estruturas condicionais e loops
- Encapsulamento básico
- Interação com usuário via `Console`

---

## 🏗️ Estrutura do Projeto

### 📦 Classe `ListaDupla`

- `info` → valor armazenado no nó
- `next` → referência para o próximo nó
- `prior` → referência para o nó anterior

### ⚙️ Métodos principais

- `Insere()`
  - Insere um novo elemento no final da lista
- `Remover()`
  - Remove um elemento pelo valor informado
  - Atualiza corretamente os ponteiros (`next` e `prior`)

---

## 🚀 Como executar

```bash
dotnet run
