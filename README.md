# 📱 Calculadora de Vértice de Parábola (.NET MAUI)

Uma aplicação mobile moderna, responsiva e intuitiva desenvolvida em **.NET MAUI (C# / XAML)** para cálculo e visualização das coordenadas do vértice de funções quadráticas ($f(x) = ax^2 + bx + c$).

O projeto foi construído focado na entrega de uma excelente experiência de utilizador (**UX/UI**), utilizando uma paleta de cores escura personalizada ("Deep Midnight") e testado em dispositivo móvel físico.

---

## 🎨 Interface & Design

* **Tema Deep Midnight**: Design escuro focado no conforto visual e contraste otimizado em tons de azul-marinho (`#0A192F` / `#112240`) com destaques em verde-menta (`#64FFDA`).
* **Componentes Customizados**: Cartões e campos de entrada estilizados com `Border` e cantos arredondados (`RoundRectangle`).
* **Acessibilidade Móvel**: Teclado numérico nativo ativado para facilitar a digitação de coeficientes em ecrãs táteis.

---

## ⚙️ Funcionalidades

- [x] **Cálculo de Vértice ($X_v$ e $Y_v$)**: Apresentação clara das coordenadas calculadas.
- [x] **Validação de Entrada**: Tratamento para impedir valores nulos ou entradas inválidas.
- [x] **Regra do Termo $a$**: Verificação para garantir que $a \neq 0$ (evitando divisão por zero e garantindo uma função quadrática válida).
- [x] **Card Dinâmico de Resultado**: Exibição condicional do resultado após a realização do cálculo.

---

## 🛠️ Tecnologias Utilizadas

* **Framework**: .NET MAUI
* **Linguagem**: C#
* **Layout**: XAML
* **IDE**: Visual Studio 2022
* **Ambiente de Testes/Depuração**: Dispositivo físico Android (POCO M5s / Xiaomi HyperOS) via USB Debugging.

---

## 📐 Fórmulas Utilizadas

A aplicação calcula o vértice com base nas fórmulas matemáticas da equação do 2º grau:

$$\Delta = b^2 - 4ac$$

$$X_v = \frac{-b}{2a} \quad \text{e} \quad Y_v = \frac{-\Delta}{4a}$$

---

## 🚀 Como Executar o Projeto

1. Clona este repositório:
   ```bash
git clone https://github.com/samuelcunhamoraes2009/Calculadora-Vertice-app.git
