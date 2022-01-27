using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    
    private float mZCoord;
    private Vector3 mOffset;
    
    void OnMouseDown()
    {
        if (gameObject.tag == "Lamp")
        {
            
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            mOffset = gameObject.transform.position - GetMouseWorldPos();

            
        }
        else
            return;
    }
    void OnMouseUp()
    {
        //camera.GetComponent<CameraMover>().enabled = true;
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;
    }

}
