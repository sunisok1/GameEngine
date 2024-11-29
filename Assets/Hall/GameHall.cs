using Core;
using Cysharp.Threading.Tasks;
using Hall.UI;
using UnityEngine;
using UnityEngine.Serialization;

namespace Hall
{
    public class GameHall : MonoBehaviour
    {
        [FormerlySerializedAs("gamePackItemPrefab")] [SerializeField] private GameEntry gameEntryPrefab;
        [SerializeField] private Transform content;

        public GameEntry CreateGameEntry(IGamePack gamePack)
        {
            var gamePackItem = Instantiate(gameEntryPrefab, content);
            gamePackItem.Init(gamePack).Forget();
            return gamePackItem;
        }
    }
}