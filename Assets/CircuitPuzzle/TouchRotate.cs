using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public int angle;
    void Start()
    {
        angle = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Rotate()
    {
        Debug.Log("click");
        angle += 90;
      
        transform.eulerAngles = new Vector3(0, 0, angle);
        if (angle == 360)
            angle = 0;
    }
}
