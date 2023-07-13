using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHook : MonoBehaviour
{
    [SerializeField] private GameObject continueObj;
    public GameObject audioSettingObject;
    // Start is called before the first frame update
    void Start()
    {
        checkUiContinue();
        GameObject.Find("AudioPopup").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void checkUiContinue()
    {
        int idScene = PlayerPrefs.GetInt("Scene", 0);
        if (idScene != 0)
        {
            continueObj.SetActive(true);
        }else continueObj.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void NewGame()
    {
        PlayerPrefs.SetInt("Scene", 1);
        PlayerPrefs.Save();
        Exit();
        Debug.Log("Save");
    }
    public void ContinueGame()
    {
        int idScene = PlayerPrefs.GetInt("Scene", 0);
        SceneManager.LoadScene(idScene);
        Exit();
    }

    public void Exit() { Invoke("CrossfadeDelayed", 0.5f); }

    private void CrossfadeDelayed()
    {
        GameObject.Find("Crossfade").GetComponent<Animator>().SetBool("out", true);
        Invoke("ExitDelayed", 2f);
    }

    public void Audio()
    {
        audioSettingObject.SetActive(true);
        GameObject.Find("Canvas").SetActive(false);
    }

    private void ExitDelayed()
    {
        SceneManager.LoadScene(1);
    }
}
