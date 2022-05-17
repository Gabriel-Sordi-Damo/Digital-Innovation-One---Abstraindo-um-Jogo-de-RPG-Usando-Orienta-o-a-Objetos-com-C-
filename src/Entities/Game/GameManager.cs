using Characters;
using System.Collections.Generic;
using System;
using Input;
namespace Game
{

    class GameManager
    {
        private List<Character> players = new List<Character>();
        private const int MAX_PLAYERS = 2;

        public void StartGame()
        {
            int currentPlayerIndex = 0;
            bool isAllPlayersCreated = false;
            while (!isAllPlayersCreated)
            {
                this.CreatePlayer();
                currentPlayerIndex++;
                isAllPlayersCreated = currentPlayerIndex >= GameManager.MAX_PLAYERS
                ? true : false;
            }
            this.ExecuteGameLoop();
        }

        public void ExecuteGameLoop()
        {
            int playerIndex = 0;
            int opponentIndex = 1;
            while (!this.IsGameOver())
            {

                Character player = players[playerIndex];
                Character opponent = players[opponentIndex];
                this.ShowRoundInfo(player, opponent);
                GameMetaData.PLAYER_ACTION playerAction = GameInputCollector.CollectPlayerActionData();
                this.ExecutePlayerAction(player, opponent, playerAction);
                playerIndex = (playerIndex + 1) % players.Count;
                opponentIndex = (opponentIndex + 1) % players.Count;
            }
            this.EndGame();

        }

        void EndGame()
        {
            Console.Clear();
            foreach (Character player in players)
            {
                string playerMessage = "";
                if (player.IsDead())
                    playerMessage += "LOSER\n";
                else
                    playerMessage += "WINNER\n";
                playerMessage += player.ToString();
                Console.WriteLine(playerMessage);
            }
        }
        bool IsGameOver()
        {
            foreach (Character player in players)
                if (player.IsDead())
                    return true;
            return false;
        }

        private void ExecutePlayerAction(Character player, Character opponent,
        GameMetaData.PLAYER_ACTION action)
        {
            switch (action)
            {
                case GameMetaData.PLAYER_ACTION.ATACK:
                    player.Atack(opponent);
                    break;
                case GameMetaData.PLAYER_ACTION.SELF_HEAl:
                    player.SelfHeal();
                    break;
                case GameMetaData.PLAYER_ACTION.SELF_MANA_RECOVER:
                    player.RecoverMana();
                    break;
            }
        }

        private void CreatePlayer()
        {
            GameMetaData.PLAYABLE_CHARACTER playerCharacter = GameInputCollector.CollectPlayerCharacterData();
            string playerName = GameInputCollector.CollectPlayerNameData();

            switch (playerCharacter)
            {
                case GameMetaData.PLAYABLE_CHARACTER.MAGE:
                    this.players.Add(new Mage(playerName));
                    break;
                case GameMetaData.PLAYABLE_CHARACTER.CLERIC:
                    this.players.Add(new Cleric(playerName));
                    break;
                case GameMetaData.PLAYABLE_CHARACTER.Tanker:
                    this.players.Add(new Tanker(playerName));
                    break;
            }


        }

        private void ShowRoundInfo(Character player, Character opponent)
        {
            Console.Clear();
            string roundInfo = "";
            roundInfo += "\t\t------------------------------\t\n";
            roundInfo += "\tYour Turn";
            roundInfo += player.ToString() + "\t";
            roundInfo += "------------------------------\t";
            roundInfo += opponent.ToString() + "\t";
            roundInfo += "------------------------------\t";
            Console.WriteLine(roundInfo);
        }


    }
}