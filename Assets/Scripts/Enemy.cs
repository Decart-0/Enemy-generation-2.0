using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _targetEnem;

    private void Update()
    {
        if (_targetEnem != null)
            Move();
    }

    public void Init(Spawner spawner)
    {
        _targetEnem = spawner.GetTargetEnem();
        transform.position = spawner.transform.position;
    }

    private void Move()
    {
        Vector3 direction = (_targetEnem.position - transform.position).normalized;
        transform.position += direction * _speed * Time.deltaTime;
    }
}