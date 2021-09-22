# Engenharia e Arquitetura de Software

## Engenharia de Software

> Qual a diferença entre programação e engenharia de software?

Programar é com você gera um software.

Engenharia de software é sobre tempo, eventual modificações futuras necessárias, escalabilidade e eficiência.

Então, como engenheiros de software, precisamos tomar decisões complexas com um participação (e risco) muito alta nas entregas, geralmente embasadas em estimativas imprecisas de tempo e crescimento.

> Qual o tempo de vida do seu código?

Qualquer resposta aqui é valida, variando de alguns minutos até decadas.

Poucos minutos != engenharia de software, é mais programação mesmo.

PQ? Não precisamos nos preocupar com novas versões das bibliotecas, sistema operacional, hardware, linguagem de programação.

Vamos para linguagem mais nerds, e por favor, se eu falar qualquer palavra que você não entenda, me avisa. Não tem pergunta burra aqui não, o que pode ter é conhecimento não claro ou não passado de uma maneira clara por mim, e não queremos isso, né?

Exemplo: Um cubo não é um quadrado.

Agora acho que consigo explicar a definição utilizada no Google para engenharia de software. Engenharia de software é programação integrada no tempo. Da mesma forma que se achatarmos um dos lados do cubo para zero ele se torna um quadrado.

Uma das lições mais importante é o código “funciona” versus “ele é sustentável”.

Essa ideia foi capturada pela lei de Hyrum:

> Com um número suficiente de usuários, não importa o que estiver acertado em contrato: todos os comportamentos observáveis de um sistema serão premissas para funcionamento de outros artefatos.

Vou demonstrar em um exemplo prático. Vou usar o Python, só porque posso fazer aqui na hora e já ter o resultado. Não vou nem criar um arquivo, direto no console.

Vou fazer um loop para imprimir os valores num set (importante observar que é não ordenado).

```python
for i in {"apple", "banana", "carrot", "durian", "eggplant"}:print(i)
```

Se você for para um especialista em python e perguntar “Posso assumir uma sequencia de saida para o meu set?" ele vai falar "Não". Essa resposta está correta, mas ela é simplista demais. A resposta detalhada seria, "Se o tempo de vida do seu código for curto, sem mudanças no seu hardware, runtime If your code is short-lived, with no changes to your hardware, tempo de execução de linguagem, ou escolha de estrutura de dados, tranquilo. Porem se você não sabe por quanto tempo seu código irá viver, ou nada que você dependa ira mudar, assumir isso está incorreto".

Para um programa de curta duração, depender da ordem da interação pode não causar nenhum problema técnico. Mas para um projeto de engenharia de software, isso causa um grande risco. Dado o tempo suficiente, alguma coisa vai eventualmente alterar a ordem de interação. Isso pode afetar em diversas formas, eficiencia, segurança, ou meramente prevenir a estrutura de dados de permitir mudanças futuras. Quando esse valor agregado fica claro, precisamos balancear entre o valor criado pelo código e a dor que será causada nos desenvolvedores e clientes.

## Conceito de Arquitetura de Software

Embora não exista consenso absoluto sobre o conceito, alguns aspectos são amplamente aceitos. **Qualquer discussão madura sobre a arquitetura de um software aborda, de maneira mais ou menos qualificada, seus componentes, a responsabilidade destes e a forma como eles se relacionam.** Aliás, isto está alinhado com a definição proposta pelo IEEE, que é uma das mais mencionadas.

> _Arquitetura de software pode ser definida como a organização fundamental de um sistema, seus componentes, as relações entre eles e o ambiente que guia seu design e evolução. (IEEE Standard 1471)_

Indiretamente, a referência a componentes, relacionamentos e responsabilidades também está presente na definição proposta no excelente “[**Software Architecture in Practice**](https://www.amazon.com.br/Software-Architecture-Practice-Len-Bass/dp/0321815734)“.

> _A arquitetura de software de um programa ou sistema computacional é a estrutura ou estruturas do sistema que abrange os componentes de software, as propriedades externamente visíveis desses componentes e as relações entre eles (Bass, Clements e Kasman)_

**A arquitetura de um software não é um conjunto de diagramas, produzidos por alguém, frequentemente desatualizados.** Os diagramas, aliás, são apenas um modelo, uma representação, da arquitetura real que está ou estará implementada no software.

Outra definição que é muito utilizada é:

- (arquiretura é o) Conjunto de decisões de design que precisam ser decididas cedo.

Martin Fowler, expert no assunto, cutucou essa frase dizendo... na verdade... são as..

- Decisões que você desejava gostaria de acertar no inicio do projeto.

O problema que você não tem essas informações cedo no projeto. Você vai descobrir elas durante o desenvolvimento. Então, o que realmente precisamos definir são as

- Decisões que são difíceis de serem mudadas.

E ai temos uma definição muito útil que podemos utilizar.
