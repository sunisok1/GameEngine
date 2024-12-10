using System.IO;
using System.Threading.Tasks;
using Core;
using Cysharp.Threading.Tasks;
using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Hall.UI
{
    public class EntryUI : MonoBehaviour
    {
        public TextMeshProUGUI nameText;
        public Image iconImage;
        public Button button;
        private IGamePack m_gamePack;

        public async UniTask Init(IGamePack gamePack)
        {
            m_gamePack = gamePack;
            nameText.text = gamePack.Name;
            await SetImage(gamePack.Icon);
            button.onClick.AddListener(LoadScene);
        }

        private async void LoadScene()
        {
            var sceneName = Path.Combine(m_gamePack.Path, "Game");
            await SceneManager.LoadSceneAsync(sceneName);
            var gameService = m_gamePack.CreateGameService();
            gameService.Run();
        }

        private async Task SetImage(string path)
        {
            var resourcesService = Injector.GetService<IResourcesService>();
            if (!string.IsNullOrEmpty(path))
                iconImage.sprite = await resourcesService.LoadAsync<Sprite>(path);
        }
    }
}