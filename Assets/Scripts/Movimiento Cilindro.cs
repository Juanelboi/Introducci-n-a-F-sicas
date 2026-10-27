using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoCilindro : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float Force = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Keyboard kb = Keyboard.current;
        if (kb.rightArrowKey.isPressed)
        {
            this.rb.AddForce(Vector3.right * Time.deltaTime * this.Force);
        }
        if (kb.leftArrowKey.isPressed)
        {
            this.rb.AddForce(Vector3.left * Time.deltaTime * this.Force);
        }
        if (kb.upArrowKey.isPressed)
        {
            this.rb.AddForce(Vector3.forward * Time.deltaTime * this.Force);
        }
        if (kb.downArrowKey.isPressed)
        {
            this.rb.AddForce(Vector3.back * Time.deltaTime * this.Force);
        }

    }
}
