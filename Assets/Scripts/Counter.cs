using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    
    public int destroyedObjects;
    
    // Update is called once per frame
    void Update()
    {
        text.text = $"Destroyed Objects: {destroyedObjects}";
    }
}
