using UnityEngine;

public abstract class TowerFactory : MonoBehaviour
{
    public abstract void CreateTower(string towerType, int towerLevel, Vector3 position);
}
