using UnityEngine;

public abstract class TowerFactory : MonoBehaviour
{
    public abstract ITower CreateTower(string towerType, int towerLevel, Vector3 position);
}
