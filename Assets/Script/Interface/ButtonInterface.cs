using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInterface : MonoBehaviour, IButtonInterface
{
    public GameObject SelectedTower { get; set; }
    public virtual void Initialize(GameObject selected)
    {
        SelectedTower = selected;
    }
    private void onDestroy()
    {
        Destroy(this.gameObject.transform.parent.gameObject);
        Destroy(SelectedTower.gameObject);
    }
}