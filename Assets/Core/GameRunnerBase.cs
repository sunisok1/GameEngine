using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using UnityEngine;

namespace Core
{
    public abstract class GameRunnerBase<T> : MonoBehaviour where T : IGameService
    {
        protected T GameService { get; private set; }

        protected virtual void Start()
        {
            GameService = Injector.Instance.Register<IGameService, T>();
            GameService.Run();
        }

        private void OnApplicationFocus(bool hasFocus)
        {
            GameService.OnApplicationFocus(hasFocus);
        }
    }
}