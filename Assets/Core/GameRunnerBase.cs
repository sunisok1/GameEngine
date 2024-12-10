using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using UnityEngine;

namespace Core
{
    public abstract class GameRunnerBase<T> : MonoBehaviour where T : IGameService
    {
        private IGameService m_gameService;

        private void Start()
        {
            m_gameService = Injector.Instance.Register<IGameService, T>();
            m_gameService.Run();
        }

        private void OnApplicationFocus(bool hasFocus)
        {
            m_gameService.OnApplicationFocus(hasFocus);
        }
    }
}