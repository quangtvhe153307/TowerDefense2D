using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameProgress : IntEventInvoker
{
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
        text.text = "1/2";

        EventManager.AddListener(EventName.NewWaveStartedEvent, SetText);
    }

    private void SetText(int p)
    {
        text.text = "Current Wave : " + WaveManager.main.CurrentWave + "/" + WaveManager.main.TotalWave;
    }
}
