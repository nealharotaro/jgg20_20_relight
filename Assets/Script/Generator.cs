using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] float fuel = 100f;
    [SerializeField] GeneratorLight statusLight;
    [SerializeField] MeshRenderer refuelLighting;
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
        FuelDepletion();
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

    private void FuelDepletion()
    {
        if(fuel > 0)
        {
            isActive = true;
        }
        fuel -= 5f * Time.deltaTime;
        if(fuel <= 0)
        {
            fuel = 0;
            isActive = false;
            refuelLighting.material = statusLight.inactiveLight;

        }
    }

    public void SetFuel(float num)
    {
        fuel += num;
        if(fuel >= 100f)
        {
            fuel = 100f;
        }
    }






}
