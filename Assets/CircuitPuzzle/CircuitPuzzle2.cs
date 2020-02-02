using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitPuzzle2 : MonoBehaviour
{
    public Transform[] tiles;
    public static CircuitPuzzle2 instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((tiles[2].eulerAngles.z == 180) && tiles[5].eulerAngles.z == 90 && tiles[6].eulerAngles.z == 180)
        {
            this.gameObject.SetActive(false);
        }

    }
}
