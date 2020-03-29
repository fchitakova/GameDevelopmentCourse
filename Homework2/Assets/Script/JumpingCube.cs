using UnityEngine;

public class JumpingCube : MonoBehaviour
{
    const string PLANE_OBJECT_NAME = "Plane";

    bool isGrounded;
    Rigidbody rigidBody;
    float speed;

    void Start()
    {
        isGrounded = true;
        rigidBody = GetComponent<Rigidbody>();
        speed = 3f;
    }

    void Update()
    {

        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f) * Time.deltaTime * speed;
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpDirection= new Vector3(0f, 5f, 0f);
            rigidBody.velocity += jumpDirection + moveDirection;
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
