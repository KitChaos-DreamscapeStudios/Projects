using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
        Debug.Log(cam.orthographic);
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(hori/50, verti/50);
        if (Input.GetKey(KeyCode.Q))
        {
            cam.orthographicSize += 0.1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            cam.orthographicSize -= 0.1f;
        }
        if(cam.orthographicSize < 0)
        {
            cam.orthographicSize *= -1;
        }
        
    }
}
