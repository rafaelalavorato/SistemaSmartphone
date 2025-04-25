# 📱 Sistema de Smartphones - C#

Este projeto simula um sistema de gerenciamento de smartphones utilizando os conceitos de **Programação Orientada a Objetos (POO)** em C#. 

## 🚀 Objetivo

Demonstrar o uso de:
- Abstração
- Herança
- Polimorfismo
- Encapsulamento

## 📦 Estrutura

- Uma classe abstrata `Smartphone` define o modelo base para celulares.
- As classes `Iphone` e `Samsung` herdam de `Smartphone` e sobrescrevem o método `InstalarAplicativo` com comportamentos distintos.
- O projeto permite simular ações como ligar, receber ligações e instalar aplicativos.

## 🧠 Conceitos aplicados

- `abstract class`: usada para criar uma base que não pode ser instanciada.
- `override`: usado para personalizar o método de instalação de aplicativos conforme a marca do celular.
- Construtores sobrecarregados para permitir diferentes formas de instanciar os objetos.

## ▶ Como executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/sistema-smartphones.git

2. Acesse a pasta:
   ```bash
    cd sistema-smartphones

3. Rode o projeto:
   ```bash
   dotnet run

📷 Exemplo de saída no console   <br>
=== iPhone ===  <br>
Número: 11 98765-4321  <br>
Modelo: iPhone 13  <br>
IMEI: 123456789012345  <br>
Memória: 128 GB  <br>
Ligando...  <br>
Recebendo ligação...  <br>
Instalando o aplicativo "Instagram" no iPhone via App Store...  <br>



