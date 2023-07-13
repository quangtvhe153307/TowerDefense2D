using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        }
        else
        {
            volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
