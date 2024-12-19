using System;
using Framework.Yggdrasil;
using Hall;
using UnityEngine;

[RequireComponent(typeof(GameHall))]
[RequireService(typeof(GamePacksLoader))]

public partial class GamePacksLoader : MonoBehaviour
{
    private void Start()
    {
        var gameHall = GetComponent<GameHall>();
        gameHall.CreateGameEntry(new Game.Template.GamePack());
        gameHall.CreateGameEntry(new Game.Named.GamePack());
        var i = ;
    }
}

public class RequireServiceAttribute : Attribute
{
    public RequireServiceAttribute(Type type)
    {
        throw new NotImplementedException();
    }
}