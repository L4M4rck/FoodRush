using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Camera Camera;
    public float sensibilidad = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxisRaw("Mouse X") * sensibilidad * Time.deltaTime;
        float MouseY = Input.GetAxisRaw("Mouse Y") * sensibilidad * 1.5f * Time.deltaTime;
        transform.Rotate(0 , MouseX, 0);
        Debug.Log(Camera.transform.rotation.x);

        if (Camera.transform.rotation.x < 0.6 && Camera.transform.rotation.x > -0.45) 
        {
                Camera.transform.Rotate(-MouseY , 0, 0);
        }
        
    }
}
