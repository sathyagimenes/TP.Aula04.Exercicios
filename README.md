# TP.Aula04.Exercicios

Este repositório contém minha solução para os exercícios propostos na aula 04 do Módulo Técnicas de Programação. <br/>
Estes exercícios foram propostos para a fixação do conteúdo de ArrayList e List.

## Enunciados
### Exercício 1 - ArrayList
Crie uma função que receba uma ArrayList e um número. Ela deve mostrar todos os índices onde esse número aparece na ArrayList.
<br/>

### Exercício 2 - List
Dado uma lista de inteiros, retorne a contagem de números positivos e a soma de números negativos. Zero não é positivo nem negativo. Se a entrada for uma lista vazia ou for nula, exiba um mensagem com erro.<br/>
Exemplo:<br/>
entrada = 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15<br/>
resultado = 10, -65
<br/>

### Exercício 3 - List
Você deve implementar uma função que retorne a diferença entre o maior e o menor valor em uma determinada lista recebida como parâmetro.
- a lista contém números inteiros, o que significa que pode conter alguns números negativos
- se a lista estiver vazia ou contiver um único elemento, retorne 0
- a lista não está ordenada

Exemplo:

```C#
[1, 2, 3, 4]   //  RETORNE 3 PORQUE 4 -   1  == 3
[1, 2, 3, -4]  //  RETORNE 7 PORQUE 3 - (-4) == 7
```
<br/>

### Exercício 4
Basta encontrar o valor mais próximo de zero na lista. Observe que há negativos na lista.

A lista não está sempre vazia e contém apenas números inteiros. Retorne "Nenhum" se não for possível definir apenas um desses valores. E, claro, esperamos 0 como valor mais próximo de zero.

Exemplo:
```C#
[2, 4, -1, -3]  => -1
[5, 2, -2]      => Nenhum
[5, 2, 2]       => 2
[13, 0, -6]     => 0
```
<br/>

## :hammer: Como executar o programa
Clone o repositório em uma pasta local: `git clone https://github.com/sathyagimenes/TP.Aula04.Exercicios.git` <br/>
Abra a solução do projeto com o Visual Studio: arquivo `TP.Aula04.Exercicios.sln` <br/>
Execute o projeto com `CTRL + F5` <br/>
No Menu, selecione o exercício que deseja testar.
