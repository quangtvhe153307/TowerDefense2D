using Assets.Script.Common;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CPController : MonoBehaviour
{
    SelectEvent selectEvent = new SelectEvent();
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = "CP";
        transform.Find("SelectCircle").gameObject.SetActive(false);
        SelectEventManager.AddSelectCPEventInvoker(this);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void AddSelectCPEventListener(UnityAction<GameObject> listener)
    {
        selectEvent.AddListener(listener);
    }
    void OnMouseDown()
    {
        if (GameObject.Find("SelectCircle"))
        {
            GameObject.Find("SelectCircle").gameObject.SetActive(false);
        }
        transform.Find("SelectCircle").gameObject.SetActive(true);
        selectEvent.Invoke(this.gameObject);
    }
}
