namespace Core
{
    public interface IGamePack
    {
        string Name { get; }
        string Version { get; }
        string Icon { get; }
        void Load();
    }
}