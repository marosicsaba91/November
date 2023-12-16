using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] Transform cameraTransform;
    [SerializeField] float speed;

    private void OnValidate()
    {
        if(cameraTransform == null)
            cameraTransform = Camera.main.transform;
    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 cameraForward = cameraTransform.forward;
        Vector3 cameraRight = cameraTransform.right;

        Vector3 directionVector = cameraRight * x + cameraForward * z;  // KAMERÁHOZ KÉPESTI
        directionVector.y = 0;
        // Vector3 directionVector = new(x, 0, z);  // GLOBÁLIS

        directionVector.Normalize();
        Vector3 velocityVector = directionVector * speed;  // Irányt és hosszt is tartalmaz
        transform.position += velocityVector * Time.deltaTime;

        if (directionVector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(directionVector);
    }
}
