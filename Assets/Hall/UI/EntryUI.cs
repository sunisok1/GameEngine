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
            var resourcesService = Injector.GetService<IResourcesService>();
            nameText.text = gamePack.Name;
            if (!string.IsNullOrEmpty(gamePack.Icon))
                iconImage.sprite = await resourcesService.LoadAsync<Sprite>(gamePack.Icon);
            button.onClick.AddListener(gamePack.LoadScene);
        }
    }
}