using Core;
using Hall.UI;
using UnityEngine;

namespace Hall
{
    [RequireComponent(typeof(GameHall))]
    public abstract class GameEntryCreator<T> : MonoBehaviour where T : IGamePack
    {
        protected GameHall m_gameHall;
        protected GameEntry m_gameEntry;
        protected T m_gamePack;

        protected virtual void Start()
        {
            m_gameHall = GetComponent<GameHall>();

            m_gamePack = CreateGamePack();
            m_gameEntry = m_gameHall.CreateGameEntry(m_gamePack);
        }

        protected abstract T CreateGamePack();
    }
}