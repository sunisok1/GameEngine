using Hall;
using UnityEngine;

[RequireComponent(typeof(GameHall))]
public class GamePacksLoader : MonoBehaviour
{
    private void Start()
    {
        GetComponent<GameHall>().CreateGameEntry(new Game.Template.GamePack());
        GetComponent<GameHall>().CreateGameEntry(new Game.Named.GamePack());
    }
}