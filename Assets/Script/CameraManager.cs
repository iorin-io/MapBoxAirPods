using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public GameObject Cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cubePos = Cube.transform.position;

        //カメラとプレイヤーの位置を同じにする
        transform.position = new Vector3(cubePos.x, 120, cubePos.z);

    }
}
