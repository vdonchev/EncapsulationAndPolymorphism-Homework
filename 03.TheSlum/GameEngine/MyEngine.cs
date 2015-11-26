namespace TheSlum.GameEngine
{
    using System;
    using Models.Characters;
    using Models.Items;

    public class MyEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    throw new InvalidOperationException("Command not found in the game!");
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            var id = inputParams[2];
            var x = int.Parse(inputParams[3]);
            var y = int.Parse(inputParams[4]);
            Team team;
            Enum.TryParse(inputParams[5], out team);

            switch (inputParams[1])
            {
                case "mage":
                    this.characterList.Add(new Mage(id, x, y, 150, 50, 300, team, 5));
                    break;
                case "warrior":
                    this.characterList.Add(new Warrior(id, x, y, 200, 100, 150, team, 2));
                    break;
                case "healer":
                    this.characterList.Add(new Healer(id, x, y, 75, 50, 60, team, 6));
                    break;
                default:
                    throw new InvalidOperationException("Character not found in the game!");
            }
        }

        private new void AddItem(string[] inputParams)
        {
            var characterId = inputParams[1];
            var itemId = inputParams[3];
            var currentCharacter = this.GetCharacterById(characterId);

            switch (inputParams[2])
            {
                case "axe":
                    currentCharacter.AddToInventory(new Axe(itemId));
                    break;
                case "shield":
                    currentCharacter.AddToInventory(new Shield(itemId));
                    break;
                case "injection":
                    currentCharacter.AddToInventory(new Injection(itemId));
                    break;
                case "pill":
                    currentCharacter.AddToInventory(new Pill(itemId));
                    break;
                default:
                    throw new InvalidOperationException("Iteam not found in the game!");
            }
        }
    }
}