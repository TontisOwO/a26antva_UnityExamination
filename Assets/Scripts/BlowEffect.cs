using UnityEngine;

public class BlowEffect : MonoBehaviour
{
    AreaEffector2D effector;
    void Start()
    {
        effector = GetComponent<AreaEffector2D>();
    }
    
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlatformerMovement>().ApplyForce(new Vector2(0, effector.forceMagnitude));
        }
    }
}
