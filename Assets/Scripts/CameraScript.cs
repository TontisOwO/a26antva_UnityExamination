using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Vector3 position;
    [SerializeField] private float speed;
    
    void Update()
    {
        position = Vector2.Lerp(player.transform.position, transform.position, Mathf.Pow(0.5f,speed*Time.deltaTime));
        position.z = -10;
        transform.position = position;
    }
}
