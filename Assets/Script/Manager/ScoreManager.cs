using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
     [SerializeField] public static int currentScore;
    // Start is called before the first frame update
    void Start()
    {
         EventManager.AddListener(EventName.ScoreAddedEvent, AddScoreKillEnemy);
    }

    public void AddScoreKillEnemy(int enemyPoint)
    {
        currentScore += enemyPoint;
        Debug.Log("Current Score: "+ currentScore );
    }

    public static void SubtractScoreUpgradeTower(int upgradeCost)
    {
        if (currentScore >= upgradeCost)
        {
            currentScore -= upgradeCost;
            Debug.Log("Current Score: "+ currentScore );
        }
        else
        {
            Debug.Log("Can't Upgrade!");
        }
    }

    public static void AddScoreSellTower(int towerPrice)
    {
        currentScore += towerPrice;
        Debug.Log("Current Score: "+ currentScore );
    }
}
