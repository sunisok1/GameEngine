using System.Threading;
using Core;
using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using JetBrains.Annotations;

namespace Game.Template
{
    public class GameRunner : GameRunnerBase<GameService>
    {
    }

    public class GamePack : IGamePack
    {
        public string Name => "Template";
        public string Path => "Game/Template/";
        public string Version => "0.1.0";
        public string Icon => "";
    }

    [UsedImplicitly]
    public class GameService : IGameService
    {
        private ILoggerService m_logger;

        [ServiceConstructor]
        public GameService(ILoggerService logger)
        {
            m_logger = logger;
        }

        public void OnAdd()
        {
            m_logger = Injector.Instance.GetService<ILoggerService>();
        }

        public void OnRemove()
        {
        }

        public CancellationToken CancellationToken { get; }

        public void Run()
        {
            m_logger.Log("Game started");
        }
    }
}