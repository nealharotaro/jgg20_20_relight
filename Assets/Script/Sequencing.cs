using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencing : MonoBehaviour
{
    // Start is called before the first frame update
    private char[] sequence1,
        sequence2,
        sequence3;
    public KeyCode UserInput;
    private int index;
    void Start()
    {
        sequence1 = new char[3];
        sequence1[0] = 'A';
        sequence1[1] = 'S';
        sequence1[2] = 'D';
        index = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void sequenceCheck()
    {

         if (Input.GetKeyDown(UserInput))
         {
            char input = char(UserInput);

         }
         else
         {
             index = 0;
         }
         if (index == 3)
         {
             this.gameObject.SetActive(false);
         }
    }
    
}
