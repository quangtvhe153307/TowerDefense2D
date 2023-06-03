using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreManager
{
    public static int currentScore;

    // Start is called before the first frame update
    public static void Initialize()
    {
         EventManager.AddListener(EventName.ScoreAddedEvent, AddScoreKillEnemy);
       //  currentScore = ConfigurationUtils.defaultScore;
         currentScore = 50;
    }

    public static void AddScoreKillEnemy(int enemyPoint)
    {
        currentScore += enemyPoint;
        StatusScore.currentScore = currentScore;
      //  Debug.Log("Current Score: "+ currentScore );
    }

    public static bool SubtractScoreUpgradeTower(int upgradeCost)
    {
        if (currentScore >= upgradeCost)
        {
            currentScore -= upgradeCost;
            StatusScore.currentScore = currentScore;
         //   Debug.Log("Current Score: "+ currentScore );
            return true;
        }
        else
        {
            Debug.Log("Can't Upgrade!");
            return false;
        }
    }

    public static void AddScoreSellTower(int towerPrice)
    {
        currentScore += towerPrice;
        StatusScore.currentScore = currentScore;
       // Debug.Log("Current Score: "+ currentScore );
    }
}
