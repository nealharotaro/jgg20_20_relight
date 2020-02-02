using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitPuzzle3 : MonoBehaviour
{
    public Transform[] tiles;
    public static CircuitPuzzle3 instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tiles[1].eulerAngles.z == 270 && tiles[2].eulerAngles.z == 180 && tiles[4].eulerAngles.z
            == 90 && tiles[5].eulerAngles.z == 270 && tiles[8].eulerAngles.z == 180)
        {
            this.gameObject.SetActive(false);
        }
    }
}
