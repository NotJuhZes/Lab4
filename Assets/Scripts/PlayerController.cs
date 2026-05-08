using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float HorizontalInput;
    private float VerticalInput;
    [SerializeField] private float Speed;
    private Rigidbody PlayerRb;
    public GameObject bala;

    void FixedUpdate ()
    {
        HorizontalInput = Input.GetAxis("Horizontal"); 
        VerticalInput = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(HorizontalInput, 0, VerticalInput) * Speed * Time.fixedDeltaTime;
        Movement.Normalize();
        PlayerRb.AddForce(Movement, ForceMode.VelocityChange);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, transform.position, Quaternion.identity);
        }
    }

    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }
}
