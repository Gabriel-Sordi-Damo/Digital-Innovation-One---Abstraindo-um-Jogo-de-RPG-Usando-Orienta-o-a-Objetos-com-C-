
# Jogo
Duas pessoas podem jogar.
Antes do jogo iniciar é necessário selecionar as classes dos players.
O jogo é travado em rodadas.
Cada rodada permite que um player tome uma das seguintes ações.
- Atacar o adversário: Se houver mana suficiente para um super ataque ela é consumida automaticamente e o ataque é aprimorado
- Curar a si mesmo: O player cura a si mesmo
- Regenerar mana: O player regenera um pedaço da mana

Valores como:
- Dano de ataque
- Quantidade de cura de vida
- Quantidade de regeneração de mana

Dependem tanto da classe escolhida pelo personagem quanto por randomização
## Classes
São 3 classes
- Mage
- Tanker
- Cleric

Cada classe possui difentes valores de atributos e eles influnciam os valores de ataque, cura de vida e regeneração de mana
O jogo acaba quando um dos players morre

# Código

## class Character
- É abstrata, não possui métodos abstratos, não deve ser instanciada, apenas herdada e apresenta métodos virtuais
## Class CharacterStatus
- Funciona como um holder para todos os atributos que um personagem deve ter. Como existem váris atributos, a ideia de status foi abstraida para classe CharacterStatus
## class GameManager
- Gerencia a partirda, regras do jogo, processamento e coleta da dados de entrada
## class InputCollector
- Abstrai as funcinabilidades padrao de coleta de dados na classe responsavel por fazer coleta <T> de dados
## class GameInputCollector
- Utiliza da InputCollector porém coleta dados mais específicos do jogo
