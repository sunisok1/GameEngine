using Core;
using UnityEngine;

namespace Hall.UI
{
    [RequireComponent(typeof(GameHall))]
    public abstract class EntryCreator<T> : MonoBehaviour where T : IGamePack, new()
    {
        protected EntryUI m_entryUI;
        protected T m_gamePack;

        private void Start()
        {
            m_gamePack = new T();
            m_entryUI = GetComponent<GameHall>().CreateGameEntry(m_gamePack);
        }
    }
}