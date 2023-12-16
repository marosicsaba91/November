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

        Vector3 directionVector = cameraRight * x + cameraForward * z;  // KAMER�HOZ K�PESTI
        directionVector.y = 0;
        // Vector3 directionVector = new(x, 0, z);  // GLOB�LIS

        directionVector.Normalize();
        Vector3 velocityVector = directionVector * speed;  // Ir�nyt �s hosszt is tartalmaz
        transform.position += velocityVector * Time.deltaTime;

        if (directionVector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(directionVector);
    }
}
