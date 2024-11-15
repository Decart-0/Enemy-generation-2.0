using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _targetEnemy;
    [SerializeField] private Enemy _typeEnemy;

    public Transform GetTargetEnem() 
    {
        return _targetEnemy;
    }

    public Enemy GetTypeEnemy() 
    {
        return _typeEnemy;
    }
}