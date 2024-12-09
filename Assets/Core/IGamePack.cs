using System.IO;
using UnityEngine.SceneManagement;

namespace Core
{
    public interface IGamePack
    {
        string Name { get; }
        string Path { get; }
        string Version { get; }
        string Icon { get; }

        void LoadScene()
        {
            SceneManager.LoadScene(System.IO.Path.Combine(Path, "Game"));
        }
    }
}