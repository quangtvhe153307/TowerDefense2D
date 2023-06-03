using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHook : MonoBehaviour
{
    [SerializeField] private GameObject continueObj;
    // Start is called before the first frame update
    void Start()
    {
        checkUiContinue();
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
        PlayerPrefs.SetInt("Scene", 0);
        PlayerPrefs.Save();
        Exit();
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

    private void ExitDelayed()
    {
        
            SceneManager.LoadScene(1);

    }
}
