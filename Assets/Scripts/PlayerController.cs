using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float HorizontalInput;
    private float VerticalInput;
    [SerializeField] private float Speed;
    private Rigidbody PlayerRb;

    void FixedUpdate ()
    {
        HorizontalInput = Input.GetAxis("Horizontal"); 
        VerticalInput = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(HorizontalInput, 0, VerticalInput) * Speed * Time.fixedDeltaTime;
        Movement.Normalize();
        PlayerRb.AddForce(Movement, ForceMode.VelocityChange);
    }

    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }
}
