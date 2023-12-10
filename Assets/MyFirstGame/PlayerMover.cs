using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 directionVector = new(x, 0, z);            // Max 1 hosszú vector
        directionVector.Normalize();
        Vector3 velocityVector = directionVector * speed;  // Irányt és hosszt is tartalmaz

        transform.position += velocityVector * Time.deltaTime;

        if(directionVector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(directionVector);
    }
}
