using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject nextScreen;
    [SerializeField] private GameObject overScreen;
    public GameObject popupObject;
    public GameObject menuObject;
    private bool canPressEsc;
    private void Awake()
    {
        pauseScreen.SetActive(false);
        nextScreen.SetActive(false);

    }
    // Start is called before the first frame update
    void Start()
    {
        canPressEsc = true;
    }

    // Update is called once per frame
    void Update()
    {
        //cant open pauseUI when overUI active
        if (overScreen.active || nextScreen.active)
        {
            canPressEsc = false;
        }
        if (canPressEsc && Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseScreen.activeInHierarchy)
            {
                PauseGame(false);
            }

            else
            {
                PauseGame(true);
            }

        }

        //test next game
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (pauseScreen.activeInHierarchy)
            {
                NextGameDisplay(false);
            }

            else
            {
                NextGameDisplay(true);
            }

        }
        //--------------------
    }
    public void PauseGame(bool status)
    {
        //if status == true pause
        pauseScreen.SetActive(status);

        if (status)
        {
            Time.timeScale = 0;
        }

        else
        {
            Time.timeScale = 1;
        }

    }

    public void NextGameDisplay(bool status)
    {
        //if status == true pause
        nextScreen.SetActive(status);
    }

    public void RestartGame()
    {
        int idScene = PlayerPrefs.GetInt("Scene", 0);
        SceneManager.LoadScene(idScene);
        Time.timeScale = 1;
    }

    public void NextGame()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.SetInt("Scene", 2);
        PlayerPrefs.Save();
    }

    public void Quit()
    {
        overScreen.SetActive(false);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void AudioPopup()
    {
        popupObject.SetActive(true);
        menuObject.SetActive(false);
    }
}
