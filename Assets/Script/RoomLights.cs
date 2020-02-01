using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLights : MonoBehaviour
{
    [SerializeField] Generator myGenerator;
    [SerializeField] Light myWallLight;
    // Start is called before the first frame update
    void Start()
    {
        myWallLight = GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!myGenerator.isActive)
        {
            myWallLight.intensity = 0;
        }
        else
        {
            myWallLight.intensity = 1;
        }
    }


}
