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

    void LateUpdate()
    { 
        Vector3 desiredPosition = followedObjectTransform.position + offsetFromPlayer;
        transform.position = desiredPosition;
    }
}
