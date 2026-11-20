using UnityEngine;

public class BoxDestruction : MonoBehaviour
{
    float timer;
    
    void Update()
    {
        if (timer >= 5)
        {
            Destroy(this);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;
        }
    }
}
