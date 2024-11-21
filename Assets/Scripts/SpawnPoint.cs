using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [field: SerializeField] public Transform TargetEnemy { get; private set; }

    [field: SerializeField] public Enemy TypeEnemy { get; private set; }
}