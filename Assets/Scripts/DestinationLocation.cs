using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mapbox.Unity.Utilities;
using Mapbox.Unity.Map;
using Mapbox.Utils;

public class DestinationLocation : MonoBehaviour
{
    public AbstractMap map = null;
    public GameObject cube = null;
    public InputField inputField_lat;
    public InputField inputField_lng;

    void Start()
    {
          //Componentを扱えるようにする
             inputField_lat = GameObject.Find("InputField_lat").GetComponent<InputField> ();
             inputField_lng = GameObject.Find("InputField_lng").GetComponent<InputField> ();

             double lat = double.Parse(inputField_lat.text);
             double lng = double.Parse(inputField_lng.text);
 
        map.MapVisualizer.OnMapVisualizerStateChanged += (state) =>
        {
            if (state == ModuleState.Finished) {
                //double lat = 32.7503353; // 緯度
                //double lng = 129.8777355; // 経度

                Vector2d latlng = new Vector2d(lat, lng);

                Vector3 pos = map.GeoToWorldPosition(latlng);
                Debug.Log(pos);

                cube.transform.position = pos;
            }
        };
    }

    void Update()
    {

    }
}