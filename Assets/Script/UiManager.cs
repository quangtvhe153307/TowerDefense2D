using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;

    private void Awake()
    {
        pauseScreen.SetActive(false);

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
    }
    public void PauseGame(bool status)
    {
        //if status == true pause
        pauseScreen.SetActive(status);

        if (status)
        {
            Time.timeScale = 0;

            //GameObject objectToDisable = GameObject.FindWithTag("Player");
            //objectToDisable.GetComponent<MovementController>().enabled = false;
        }

        else
        {
            Time.timeScale = 1;
            //GameObject objectToDisable = GameObject.FindWithTag("Player");
            //objectToDisable.GetComponent<MovementController>().enabled = true;
        }

    }
    public void Quit()
    {
        //    Time.timeScale = 1;
        //    GameObject objectToDisable = GameObject.FindWithTag("Player");
        //    objectToDisable.GetComponent<MovementController>().enabled = true;
        //SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadScene("HookGame");
        Time.timeScale = 1;
    }

    


}
