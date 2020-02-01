using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLights : MonoBehaviour
{
    [SerializeField] Generator myGenerator;
    [SerializeField] List<GameObject> myWallLights;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject wallLight in myWallLights)
        {
            var myLights = wallLight.GetComponentInChildren<Light>();
            if (!myGenerator.isActive)
            {
                myLights.intensity = 0;
            }
            else
            {
                myLights.intensity = 1;
            }
        }

    }


}
