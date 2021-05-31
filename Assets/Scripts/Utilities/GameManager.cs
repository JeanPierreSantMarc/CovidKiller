using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Player currentPayer;

    public Player CurrentPlayer
    {
        get { return currentPayer; }
    }

    private void Awake()
    {
        Assert.IsNotNull(currentPayer);
    }

}
