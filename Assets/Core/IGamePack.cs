namespace Core
{
    public interface IGamePack
    {
        string Name { get; }
        string Path { get; }
        string Version { get; }
        string Icon { get; }
    }
}