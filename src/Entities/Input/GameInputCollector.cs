using Game;
using System.Collections.Generic;

namespace Input
{

    class GameInputCollector : InputCollector
    {
        public static GameMetaData.PLAYABLE_CHARACTER CollectPlayerCharacterData()
        {
            Dictionary<int, GameMetaData.PLAYABLE_CHARACTER> inputMapper = new Dictionary<
            int, GameMetaData.PLAYABLE_CHARACTER>();
            inputMapper.Add(0, GameMetaData.PLAYABLE_CHARACTER.CLERIC);
            inputMapper.Add(1, GameMetaData.PLAYABLE_CHARACTER.MAGE);
            inputMapper.Add(2, GameMetaData.PLAYABLE_CHARACTER.Tanker);

            string inputMessage = @$"
            Player select an class:
            0 - Cleric
            1 - Mage
            2 - Tanker
            ";

            CollectInputConfig<GameMetaData.PLAYABLE_CHARACTER> config = new CollectInputConfig<
            GameMetaData.PLAYABLE_CHARACTER>(
               inputMessage,
               inputMapper
           );
            GameMetaData.PLAYABLE_CHARACTER playerCharacter = InputCollector.CollectInput<
            GameMetaData.PLAYABLE_CHARACTER>(config);
            return playerCharacter;
        }

        public static string CollectPlayerNameData()
        {
            string inputMessage = @$"
            Player write a name:
            ";
            CollectAnyInputConfig config = new CollectAnyInputConfig(inputMessage, false);
            string playerName = InputCollector.CollectAnyInput(config);
            return playerName;
        }

        public static GameMetaData.PLAYER_ACTION CollectPlayerActionData()
        {
            Dictionary<int, GameMetaData.PLAYER_ACTION> inputMapper = new Dictionary<
            int, GameMetaData.PLAYER_ACTION>();
            inputMapper.Add(0, GameMetaData.PLAYER_ACTION.ATACK);
            inputMapper.Add(1, GameMetaData.PLAYER_ACTION.SELF_HEAl);
            inputMapper.Add(2, GameMetaData.PLAYER_ACTION.SELF_MANA_RECOVER);

            string inputMessage = @$"
            Select an option:
            0 - Atack
            1 - Self Heal
            2 - Self Mana Recover
            ";
            CollectInputConfig<GameMetaData.PLAYER_ACTION> config = new CollectInputConfig<
           GameMetaData.PLAYER_ACTION>(
              inputMessage,
              inputMapper,
              false
          );
            GameMetaData.PLAYER_ACTION playerAction = InputCollector.CollectInput<
            GameMetaData.PLAYER_ACTION>(config);
            return playerAction;
        }


    }
}