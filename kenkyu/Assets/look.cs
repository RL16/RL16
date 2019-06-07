using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour {
 
 public Transform verRot;
 public Transform horRot;
 [SerializeField] float sensitivity;
   

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
        verRot = transform.parent;
 horRot = GetComponent<Transform>();

    }
  
 // Update is called once per frame
 void Update () {
        Camera gameCamera = Camera.main;
        //Vector3 touchWorldPosition = gameCamera.ScreenToWorldPoint(touchScreenPosition);

        /*float X_Rotation = Input.GetAxis("Mouse X");
        float Y_Rotation = Input.GetAxis("Mouse Y");
        verRot.transform.Rotate(0, X_Rotation * sensitivity, 0);
        horRot.transform.Rotate(-Y_Rotation * sensitivity, 0, 0);
        */
    }
}

//https://ekulabo.com/public-or-serializefield
//https://hatsuka.frontl1ne.net/2017/03/fps%E3%81%BF%E3%81%9F%E3%81%84%E3%81%AB%E3%83%9E%E3%82%A6%E3%82%B9%E3%81%A7%E3%81%90%E3%82%8A%E3%81%90%E3%82%8A%E8%A6%8B%E6%B8%A1%E3%81%9B%E3%82%8B%E3%82%88%E3%81%86%E3%81%AB%E3%81%99%E3%82%8B/