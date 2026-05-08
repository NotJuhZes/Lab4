using UnityEngine;

public class BalaSai : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
