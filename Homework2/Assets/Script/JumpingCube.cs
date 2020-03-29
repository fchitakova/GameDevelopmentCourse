using UnityEngine;

public class JumpingCube : MonoBehaviour
{
    const string PLANE_OBJECT_NAME = "Plane";

    bool isGrounded;
    Rigidbody rigidBody;

    void Start()
    {
        isGrounded = true;
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        if (isGrounded && Input.GetKey(KeyCode.Space))
        {
            rigidBody.velocity = new Vector3(0f, 5f, 0f) + moveDirection;
            isGrounded = false;
        }
        else
        {
            transform.position += moveDirection;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals(PLANE_OBJECT_NAME))
        {
            isGrounded = true;
        }
    }

}
