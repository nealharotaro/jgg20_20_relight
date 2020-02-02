using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircuitPuzzle : MonoBehaviour
{
    public Transform[] tiles;
    public static CircuitPuzzle instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
       
    }

    // Update is called once per frame
    void Update()
    {
        if ((tiles[0].eulerAngles.z==90) && (tiles[1].eulerAngles.z == 90) && tiles[4].eulerAngles.z == 180 && tiles[8].eulerAngles.z == 90)
        {
            Debug.Log("END");
            this.gameObject.SetActive(false);
        }
    }
}
