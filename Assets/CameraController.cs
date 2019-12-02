using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public float mouseSpeed = 5f;

    // Use this for initialization
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Mouse X") * mouseSpeed;
        float vertical = Input.GetAxis("Mouse Y") * mouseSpeed;
        target.Rotate(0, horizontal, 0);
        transform.Rotate(-vertical,0, 0);

    }
}