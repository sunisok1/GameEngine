using Core;
using Framework.Yggdrasil;
using Framework.Yggdrasil.Services;
using JetBrains.Annotations;

namespace Game.Template
{
    public class GamePack : IGamePack
    {
        public string Name => "Template";
        public string Path => "Game/Template/";
        public string Version => "0.1.0";
        public string Icon => "";

        public IGameService CreateGameService()
        {
            return Injector.Instance.Register<IGameService, GameService>();
        }
    }

    [UsedImplicitly]
    public class GameService : IGameService
    {
        private readonly ILoggerService m_logger;

        [ServiceConstructor]
        public GameService(ILoggerService logger)
        {
            m_logger = logger;
        }

        public void OnAdd()
        {
        }

        public void OnRemove()
        {
        }

        public void Run()
        {
            m_logger.Log("Game started");
        }
    }
}