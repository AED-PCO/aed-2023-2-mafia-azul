<h1 align="center"> Renda Familiar - Aplicação DeskTop em C# </h1>

## Funcionalidades
:heavy_check_mark: `Funcionalidade 1:` Realizar cadastro dos usuários.
<br>
![image](https://github.com/AED-PCO/aed-2023-2-mafia-azul/assets/70597769/b0f61a5f-90dd-4466-b695-0615321c01b8)
<br>
:heavy_check_mark: `Funcionalidade 2:` Login e saldo inicial.
<br>
![image](https://github.com/AED-PCO/aed-2023-2-mafia-azul/assets/70597769/0b63113c-c8c8-4df4-a9d6-2bf3723e451b)
<br>
:heavy_check_mark: `Funcionalidade 3:` Cadastro de transação (Crédito ou débito)
<br>
![image](https://github.com/AED-PCO/aed-2023-2-mafia-azul/assets/70597769/c802117e-9adb-4090-bf48-10d63283b351)
<br>

## Pré-requisitos

![image](https://github.com/AED-PCO/aed-2023-2-mafia-azul/assets/70597769/8c1d5d68-90f5-40be-a803-cf3875b9c960)

## Como rodar a aplicação :arrow_forward:

No terminal, clone o projeto: 

```
git clone [https://github.com/AED-PCO/aed-2023-2-mafia-azul.git]
```

Acesse a pasta 'Renda_Familiar' :open_file_folder: > 'bin' > 'Debub' > 'net6.0-windows' > execute:

![image](https://github.com/AED-PCO/aed-2023-2-mafia-azul/assets/70597769/ade635bb-bd3d-440c-abff-f97977dffe8a)

## Árvore e Algoritmo de ordenação

Para garantir uma maior otimização foi utilizado uma **árvore binária** para o cadastro de transação de forma com que os créditos fossem armazenados a esquerda e os débitos a esquerda, na hora de consultar o maior crédito é selecionado o **nodo mais a esquerda** e para o meior débito o **nodo mais a direita**

Para alimentar o gridview de transações os elementos são ordenados por data atravez do **Selection Sort**, foi escolhido esse algoritmo de ordenação porque os dados **já estão pré-ordenados** e não é necessário comparar todas as datas uma a uma como o **Bubble Sort** faz por exemplo, garantindo assim uma maior otimização
