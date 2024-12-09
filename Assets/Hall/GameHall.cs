using Core;
using Cysharp.Threading.Tasks;
using Hall.UI;
using UnityEngine;
using UnityEngine.Serialization;

namespace Hall
{
    public class GameHall : MonoBehaviour
    {
        [FormerlySerializedAs("gameEntryUIPrefab")] [FormerlySerializedAs("gameEntryPrefab")] [SerializeField] private EntryUI entryUIPrefab;
        [SerializeField] private Transform content;

        public EntryUI CreateGameEntry(IGamePack gamePack)
        {
            var gamePackItem = Instantiate(entryUIPrefab, content);
            gamePackItem.Init(gamePack).Forget();
            return gamePackItem;
        }
    }
}