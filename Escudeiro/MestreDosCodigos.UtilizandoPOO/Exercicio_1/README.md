## 1. Responda e demonstre no código os itens abaixo:
## O que é POO?
Programação Orientada à Objetos. É um paradigma de programação que trata da resolução de problemas com classes, propriedades e métodos;

## O que é Polimorfismo?
Um princípio no qual duas ou mais classes derivadas de uma baseclass podem invocar métodos que têm a mesma assinatura porém comportamentos diferentes;

## O que é Abstração?
Capacidade de definir uma estrutura base para ser herdada com propriedades e métodos que são, ou não, implementados por padrão;

## O que é Encapsulamento?
Um conceito que protege a implementação e evita acessos indevidos do contexto externo definindo modificadores de acesso que alteram a visibilidade dos objetos, suas propriedades e métodos. Getters, Setters, Public, Private, Sealed e outros recursos são utilizados para aplicar o encapasulamento no C#;

## Quando usar uma classe abstrata e quando devo usar uma interface?
Utilizamos Interface quando é necessário expôr uma abstração como um contrato, sem implementações ou comportamentos padrão;<br>
Uma classe abstrata é utilizada quando a abstração possui comportamentos que serão reaproveitados pelas classes derivadas podendo, ou não, sobrescerver esses comportamentos para cada especificação diferente;

## O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
IDisposable: Fornece um mecanismo para liberar recursos não gerenciados;<br>
IComparable: Define um método de comparação que permite ordenar e classificar as instâncias;<br>
ICloneable: Permite uma implementação que cria uma cópia superficial ou profunda de um objeto;<br>
IEnumerable: Expõe um enumerador que dá suporte à iteração em uma coleção;<br>

## Existe herança múltipla (de classes) em C#?
Não. Assim como o JAVA, C# permite que uma classe implemente mais de uma Interface porém somente de uma única Classe. Herança Diamante é um caso do problema abordado;
