using UnityEngine;

public class JumpingCube : MonoBehaviour
{
    bool isGrounded;
    Rigidbody rigidbodyBody;

    void Start()
    {
        isGrounded = true;
        rigidbodyBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.Space)){
                rigidbodyBody.velocity = new Vector3(0f, 5f, 0f);
                isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Plane"))
        {
            isGrounded = true;
        }
    }

}
