using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _targetEnemy;

    private void Update()
    {
        if (_targetEnemy != null)
            Move();
    }

    public void Init(Transform targetEnemy)
    {
        _targetEnemy = targetEnemy;
    }

    private void Move()
    {
        Vector3 direction = (_targetEnemy.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, _speed);
        transform.position += direction * _speed * Time.deltaTime;
    }
}