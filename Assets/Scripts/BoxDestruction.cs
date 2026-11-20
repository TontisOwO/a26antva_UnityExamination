using TMPro;
using UnityEngine;

public class BoxDestruction : MonoBehaviour
{
    float timer;
    
    [SerializeField] Counter text;
    
    void Update()
    {
        if (timer >= 5)
        {
            Destroy(this);
            text.destroyedObjects++;
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
