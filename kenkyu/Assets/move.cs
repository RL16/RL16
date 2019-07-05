using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public GameObject camera = null;
    [SerializeField] float speed;

    private void Start()
    {
        Vector3 Chara = new Vector3(1f, 1f, 1f);
    }
    
    // Update is called once per frame
    void Update () {

        if (Input.touchCount > 0)
        {
            Transform cameraTrans = camera.GetComponent<Transform>().transform;
            // そのオブジェクトから見て前方向に移動
            cameraTrans.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    

}
//https://tama-lab.net/2017/05/unity%E3%81%A7%E3%82%AD%E3%83%A3%E3%83%A9%E3%82%AF%E3%82%BF%E3%83%BC%E3%82%92%E7%A7%BB%E5%8B%95%E3%81%95%E3%81%9B%E3%82%8B%E6%96%B9%E6%B3%95%E3%80%903d%E7%B7%A8%E3%80%91/