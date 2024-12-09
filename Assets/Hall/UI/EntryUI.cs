using System.Threading.Tasks;
using Core;
using Cysharp.Threading.Tasks;
using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Hall.UI
{
    public class EntryUI : MonoBehaviour
    {
        public TextMeshProUGUI nameText;
        public Image iconImage;
        public Button button;

        public async UniTask Init(IGamePack gamePack)
        {
            nameText.text = gamePack.Name;
            var path = gamePack.Icon;
            await SetImage(path);
            button.onClick.AddListener(gamePack.LoadScene);
        }

        private async Task SetImage(string path)
        {
            var resourcesService = Injector.GetService<IResourcesService>();
            if (!string.IsNullOrEmpty(path))
                iconImage.sprite = await resourcesService.LoadAsync<Sprite>(path);
        }
    }
}