using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float speed = 3;

	void FixedUpdate() {
		Vector3 moveDirection =
				new Vector3(Input.GetAxis("Horizontal"),
							0,
							Input.GetAxis("Vertical"))
							.normalized
				* Time.deltaTime
				* speed;
		Vector3 pointToLookAt = transform.position
						  + moveDirection * 100;

		transform.position += moveDirection;
		transform.LookAt(pointToLookAt);
	}
}
