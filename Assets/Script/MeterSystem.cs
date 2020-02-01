using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MeterSystem : MonoBehaviour
{
    [SerializeField] Generator myGenerator;
    [SerializeField] MeshRenderer refuelLighting;
    [SerializeField] Material activeLight;
    [SerializeField] Material inActiveLight;
    [SerializeField] Material blackLight;
    [SerializeField] float speed = 5f;
    [SerializeField] float refuelAmount = 100f;
    public float currentPercent;
    public float targetPercent;
    public bool isLow;

    [SerializeField] RectTransform arrow;

    
    private float elapsedTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        arrowCirculation();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopArrow();
            CalculatePercentage();
        }


    }

    private void CalculatePercentage()
    {
        if (targetPercent + .2f > 1)
        {
            if (currentPercent >= targetPercent || currentPercent <= targetPercent + .2f - 1)
            {
                myGenerator.SetFuel(refuelAmount);
                isLow = false;
                refuelLighting.material = activeLight;


            }
        }
        else if (currentPercent >= targetPercent && currentPercent <= targetPercent + .2f)
        {
            myGenerator.SetFuel(refuelAmount);
            isLow = false;
            refuelLighting.material = activeLight;
        }
        else
        {
            isLow = true;
            StartCoroutine(ErrorMeter());
        }
    }

    private void arrowCirculation()
    {
        elapsedTime += speed * Time.deltaTime;
        currentPercent = (elapsedTime % 101f) / 100f;
        arrow.rotation = Quaternion.Euler(0, 0, 360 * currentPercent);
    }


    IEnumerator ErrorMeter()
    {
        while (isLow)
        {
            refuelLighting.material = inActiveLight;

            yield return new WaitForSeconds(0.5f);

            refuelLighting.material = blackLight;
        }


    }

    public void StopArrow()
    {
        speed = 0f;
    }

    public void StartArrow()
    {
        speed = 30f;
    }
}
