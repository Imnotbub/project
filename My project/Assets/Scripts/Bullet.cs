using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float damage;

    public GameObject DeathScreen;

    public GameObject Player;
    
    
    private void Start()
    {
        Destroy(gameObject, 10f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Health>().TakeDamage(damage);
            Player.SetActive(false);

        }
    }
}
