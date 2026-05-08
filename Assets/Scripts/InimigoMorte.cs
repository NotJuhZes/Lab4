using UnityEngine;

public class InimigoMorte : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            Destroy(gameObject);
        }
    }



}
