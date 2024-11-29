using Hall;
using UnityEngine;

namespace Game.Console24
{
    public class EntryCreator : GameEntryCreator<GamePack>
    {
        protected override GamePack CreateGamePack()
        {
            return new GamePack();
        }

        private void Update()
        {
            var color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            m_gameEntry.nameText.color = color;
        }
    }
}