using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public int minZoom2D, maxZoom2D;
    public int zoomSpeed2D;

    public int minZoom3D, maxZoom3D;
    public int zoomSpeed3D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //2DCamera
        if(Camera.main.orthographic)
        {
            if(Input.GetAxis("Mouse ScrollWheel")>0)
            {
                //zoomIn
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;

            }
            if(Input.GetAxis("Mouse ScrollWheel")<0)
            {
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
            }

            //Restrict the value by using Mathf.clamp
            Camera.main.orthographicSize= Mathf.Clamp(Camera.main.orthographicSize, minZoom2D, maxZoom2D);
            
        }
        else
        {
            //3DCamera
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //zoomIn
                Camera.main.fieldOfView -= zoomSpeed3D * Time.deltaTime;

            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
            }
            //Restrict the value by using Mathf.clamp
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3D, maxZoom3D);


        }
    }
}
