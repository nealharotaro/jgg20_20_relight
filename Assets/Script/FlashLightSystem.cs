using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float angleDecay = 1f;
    [SerializeField] float minimunAngle = 40f;
    [SerializeField] float rechargeTimeIntensity = 0.2f;
    [SerializeField] float rechargeTimeAngle = 0.5f;
    [SerializeField] Slider flashLightBar;

    Light myLight;
    Color onColor;
    Color offColor;
    bool isPressed = false;
    bool isEnough = true;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        onColor = this.myLight.color;
        offColor = Color.black;
        myLight.color    = offColor;
        //OffLight();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isPressed = !isPressed;
        }
        OnLight();
        OffLight();



    }

    private void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
        flashLightBar.value -= lightDecay * Time.deltaTime;
       

    }

    private void DecreaseLightAngle()
    {
        if(myLight.spotAngle <= minimunAngle)
        {
            return;
        }
        else
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }

    }

    private void OffLight()
    {
        if (!isPressed)
        {
            myLight.color = offColor;
            RechargeLightIntensity();
            RechargeLightAngle();
        }     

    }

    private void OnLight()
    {
        if (isPressed)
        {
            myLight.color = onColor;
            DecreaseLightIntensity();
            DecreaseLightAngle();
        }

    }

    private void RechargeLightAngle()
    {
        if (myLight.spotAngle <= 60)
        {
            myLight.spotAngle += rechargeTimeAngle * Time.deltaTime;
        }
    }

    private void RechargeLightIntensity()
    {
        if (myLight.intensity <= 1)
        {
            myLight.intensity += rechargeTimeIntensity * Time.deltaTime;
            flashLightBar.value += rechargeTimeIntensity * Time.deltaTime;
        }
    }
}
