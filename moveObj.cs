using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObj : MonoBehaviour {

    float distance = 10f;
    public Camera mainCam;

    public float smooth;

    

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
       Vector3 ObjPosition = mainCam.ScreenToWorldPoint(mousePosition);
       

        transform.position = ObjPosition;
       // transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }

    



}
