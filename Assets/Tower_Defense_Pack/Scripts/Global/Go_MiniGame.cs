
/*
 	It loads the Example scene
*/

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Go_MiniGame : MonoBehaviour {
	public Sprite StartClicked;
	private Sprite auxClicked;
    [SerializeField] private GameObject quit;

    private void Awake()
    {
        quit.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		auxClicked = GetComponent<SpriteRenderer>().sprite;
	}

	void OnMouseDown() {GetComponent<SpriteRenderer>().sprite = StartClicked;}
	void OnMouseUp(){
		GetComponent<SpriteRenderer>().sprite = auxClicked;
		Exit();
        quit.SetActive(false);
    }

	public void Exit(){Invoke("CrossfadeDelayed",0.5f);}

	private void CrossfadeDelayed(){
		GameObject.Find("Crossfade").GetComponent<Animator>().SetBool("out",true);
		Invoke("ExitDelayed",2f);
	}

	private void ExitDelayed(){
		if(this.gameObject.name=="Start"){            
            SceneManager.LoadScene("Scene1");

        }
    }
}
