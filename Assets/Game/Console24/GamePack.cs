using Core;
using UnityEngine.SceneManagement;

namespace Game.Console24
{
    public class GamePack : IGamePack
    {
        public string Name => "Console24";
        public string Version => "0.1.0";
        public string Icon => "";

        public void Load()
        {
            SceneManager.LoadScene("Console24");
        }
    }
}