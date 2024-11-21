using UnityEngine;

public class RemoveEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy _))
            Destroy(collision.gameObject);
    }
}