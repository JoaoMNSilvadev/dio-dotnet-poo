# Desafio de Projeto – POO com .NET (Smartphone)

## 📌 Descrição do Projeto

Este projeto foi desenvolvido como parte do desafio do módulo de **Programação Orientada a Objetos (POO)** da trilha **.NET** da **DIO**.

O objetivo é modelar um sistema simples de celulares utilizando conceitos fundamentais de POO, como **abstração**, **herança** e **polimorfismo**, permitindo o reaproveitamento de código e a especialização de comportamentos.

---

## 🧠 Conceitos Aplicados

* Classe abstrata
* Herança
* Polimorfismo (sobrescrita de métodos)
* Encapsulamento
* Construtores e reutilização de código

---

## 🏗️ Estrutura do Projeto

O sistema é composto pelas seguintes classes:

### 🔹 Smartphone (classe abstrata)

Classe base que serve como modelo para os celulares.

**Propriedades:**

* `Numero`
* `Modelo`
* `IMEI`
* `Memoria`

**Métodos:**

* `Ligar()`
* `ReceberLigacao()`
* `InstalarAplicativo(string nomeApp)` (método abstrato)

> Essa classe não pode ser instanciada diretamente.

---

### 🔹 Iphone (classe filha)

Herda da classe `Smartphone` e implementa seu próprio comportamento para instalação de aplicativos.

* Sobrescreve o método `InstalarAplicativo`

---

### 🔹 Nokia (classe filha)

Também herda da classe `Smartphone` e possui sua própria implementação do método de instalação de aplicativos.

* Sobrescreve o método `InstalarAplicativo`

---

## ▶️ Execução do Programa

No arquivo `Program.cs`, são criadas instâncias de um **iPhone** e de um **Nokia**, demonstrando:

* Chamada de métodos herdados da classe abstrata
* Polimorfismo no método `InstalarAplicativo`

O programa exibe no console as ações realizadas por cada tipo de smartphone.

---

## ✅ Regras do Desafio Atendidas

* ✔ Classe `Smartphone` definida como abstrata
* ✔ Classes `Iphone` e `Nokia` herdando de `Smartphone`
* ✔ Método `InstalarAplicativo` sobrescrito em cada classe filha
* ✔ Sistema funcional em aplicação console (.NET)

---

## 🚀 Conclusão

O desafio foi concluído com sucesso, aplicando corretamente os conceitos de Programação Orientada a Objetos. O projeto demonstra de forma clara como a abstração e o polimorfismo facilitam a extensão e manutenção do código.

Projeto finalizado e pronto para entrega 🎉
