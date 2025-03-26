using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 150f;
    public GameObject Bullet;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TakeDamage(int damage)
    {
        health -=25f;
        if(health <= 0.1f) Invoke(nameof(DestroyPlayer), 0.5f);
    }

    void DestroyPlayer()
    {
        Destroy(gameObject);
    }
}
