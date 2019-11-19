using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum GameStat
{
    Running,
    Paused,
    Ended
}

public class EnumExample : MonoBehaviour
{
    // Start is called before the first frame update

    private GameStat _gameStat;

    void Start()
    {
        _gameStat = GameStat.Running;
    }

    // Update is called once per frame
    void Update()
    {
        switch (_gameStat)
        {
            case GameStat.Ended:
                Debug.Log("The Game has ended");
                break;
            case GameStat.Running:
                Debug.Log("The Game is running");
                break;
            case GameStat.Paused:
                Debug.Log("The Game has paused");
                break;
        }
    }
}
