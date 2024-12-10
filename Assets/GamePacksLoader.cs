using Hall;
using UnityEngine;

[RequireComponent(typeof(GameHall))]
public class GamePacksLoader : MonoBehaviour
{
    private void Start()
    {
        var gameHall = GetComponent<GameHall>();
        gameHall.CreateGameEntry(new Game.Template.GamePack());
        gameHall.CreateGameEntry(new Game.Named.GamePack());
    }
}