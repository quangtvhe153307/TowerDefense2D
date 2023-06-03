using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusScore : MonoBehaviour
{
    public static int currentScore;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        //  currentScore = ConfigurationUtils.defaultScore;
         currentScore = 500;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = currentScore.ToString();
      //  Debug.Log("UpdateScore");
    }
}
