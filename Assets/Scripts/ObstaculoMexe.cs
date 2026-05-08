using UnityEngine;

public class ObstaculoMexe : MonoBehaviour
    
{
    public float speed;
    public float limit;
    
    void Update()
    {
        float direction = Mathf.PingPong(Time.time * speed, limit - -limit) + -limit;
        transform.Translate(Vector3.forward * direction * Time.deltaTime);
    }
}
