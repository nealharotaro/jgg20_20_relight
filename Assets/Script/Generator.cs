using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GeneratorLight statusLight;
    [SerializeField] Light pointLight;

    public bool isActive = false;


    // Start is called before the first frame update
    void Start()
    {
        statusLight = GetComponentInChildren<GeneratorLight>();
        pointLight = statusLight.GetComponentInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //todo refactor later
        var currentLight = statusLight.GetComponent<MeshRenderer>();
        if (!isActive)
        {
            currentLight.material = statusLight.inactiveLight;
            pointLight.color = Color.red;
        }
        else
        {
            currentLight.material = statusLight.activeLight;
            pointLight.color = Color.green;
        }
    }

   




}
