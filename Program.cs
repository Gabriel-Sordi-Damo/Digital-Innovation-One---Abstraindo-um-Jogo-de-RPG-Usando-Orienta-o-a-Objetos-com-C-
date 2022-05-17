using System;
using System.Collections.Generic;
using Game;
using Input;
namespace AbstraindoUmRpg
{
    class Program
    {
        private enum OPTION
        {
            PLAY_GAME,
            EXIT
        }
        static void Main(string[] args)
        {


            Dictionary<int, OPTION> inputMapper = new Dictionary<int, OPTION>();
            inputMapper.Add(0, OPTION.PLAY_GAME);
            inputMapper.Add(1, OPTION.EXIT);
            string inputMessage = @$"
            Please, select an option:
            0 - Play game
            1 - Exit 
            ";
            InputCollector.CollectInputConfig<OPTION> config = new InputCollector.CollectInputConfig<
            OPTION>(inputMessage, inputMapper, false);
            while (true)
            {
                OPTION chosedOption = InputCollector.CollectInput<OPTION>(config);
                switch (chosedOption)
                {
                    case OPTION.PLAY_GAME:
                        GameManager game = new GameManager();
                        game.StartGame();
                        break;
                    case OPTION.EXIT:
                        const int NO_ERROR_CODE = 0;
                        System.Environment.Exit(NO_ERROR_CODE);
                        break;
                }

            }
        }
    }
}
