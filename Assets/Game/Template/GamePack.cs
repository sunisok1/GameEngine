using Core;
using UnityEngine.SceneManagement;

namespace Game.Template
{
    public class GamePack : IGamePack
    {
        public string Name => "Template";
        public string Path => "Game/Template/";
        public string Version => "0.1.0";
        public string Icon => "";

        public void LoadScene()
        {
            SceneManager.LoadScene($"{Path}Game");
        }
    }
}