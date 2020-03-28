using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public const string PLAYER_OBJECT_NAME = "PlayerBody";

    [SerializeField]
    Transform followedObjectTransform;
    float speed = 0.01f;
    Vector3 offsetFromPlayer;
    
    void Start()
    {
        followedObjectTransform = GameObject.Find(PLAYER_OBJECT_NAME).transform;
        offsetFromPlayer = transform.position - followedObjectTransform.transform.position;
    }

    void FixedUpdate()
    {
        Vector3 desiredPosition = followedObjectTransform.position + offsetFromPlayer;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        transform.position = smoothPosition;
    }
}
