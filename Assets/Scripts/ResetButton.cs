using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Onclick()
    {
        GameObject.Find("PlayerTarget").transform.rotation = new Quaternion(0, 0, 0, 0);
    }

}
