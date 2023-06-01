using UnityEngine;

namespace Assets.Script.Common
{
    public class Common : MonoBehaviour
    {
        // public static void showInterface(string interfaceName, GameObject parent, Transform position)
        // {
        //     if (GameObject.Find("Interface"))
        //     {
        //         DisableOtherInterface();
        //     }
        //     GameObject interface_ = Instantiate(Resources.Load("Interface/" + interfaceName), GameObject.Find("Out").transform.position, Quaternion.identity) as GameObject;
        //     interface_.name = "Interface";
        //     interface_.transform.SetParent(parent.transform);
        //     interface_.transform.position = new Vector3(position.transform.position.x, position.transform.position.y, position.transform.position.y - 3f); 
        // }
        public static void showCPInterface(string interfaceName, GameObject parent, GameObject selected)
        {
            if (GameObject.Find("Interface"))
            {
                DisableOtherInterface();
            }
            GameObject interface_ = Instantiate(Resources.Load("Interface/" + interfaceName), GameObject.Find("Out").transform.position, Quaternion.identity) as GameObject;
            interface_.name = "Interface";
            interface_.transform.SetParent(parent.transform);
            if(interface_.transform.Find("BuyArcherLv1Button") != null && interface_.transform.Find("BuyArcherLv1Button").GetComponent<OnClickCPInterface>() != null){
                interface_.transform.Find("BuyArcherLv1Button").GetComponent<OnClickCPInterface>().Initialize(selected);
            } else if(interface_.transform.Find("BuyArcherLv2Button") != null && interface_.transform.Find("BuyArcherLv2Button").GetComponent<UpgradeToArcherTowerLv2ButtonController>() != null){
                interface_.transform.Find("BuyArcherLv2Button").GetComponent<UpgradeToArcherTowerLv2ButtonController>().Initialize(selected);
            } else if(interface_.transform.Find("BuyArcherLv3Button") != null && interface_.transform.Find("BuyArcherLv3Button").GetComponent<UpgradeToArcherTowerLv3ButtonController>() != null){
                interface_.transform.Find("BuyArcherLv3Button").GetComponent<UpgradeToArcherTowerLv3ButtonController>().Initialize(selected);
            }
            if(interface_.transform.Find("SellButton") != null && interface_.transform.Find("SellButton").GetComponent<SellButtonController>() != null){
                interface_.transform.Find("SellButton").GetComponent<SellButtonController>().Initialize(selected);
            }
            interface_.transform.position = new Vector3(-20, -11, 0); 
        }
        public static void DisableOtherInterface()
        {
            // GameObject.Find("Interface").transform.parent.gameObject.GetComponent<CircleCollider2D>().enabled = true;
            Destroy(GameObject.Find("Interface"));
        }
    }
}
