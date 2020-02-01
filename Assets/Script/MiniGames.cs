using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets.Characters.FirstPerson
{


    public class MiniGames : MonoBehaviour
    {
        [SerializeField] Generator myGenerator;
        [SerializeField] TextMesh myText;
        // Start is called before the first frame update
        void Start()
        {
            myGenerator = GetComponentInParent<Generator>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name == "Player")
            {
                if (!myGenerator.isActive)
                {
                    myText.gameObject.SetActive(true);
                }
                else
                    return;

            }
        }


        private void OnTriggerStay(Collider other)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                UnpauseMovement(other);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                PauseMovement(other);
                if (gameObject.name == "Refuel")
                {
                    Refuel();
                }
                if (gameObject.name == "Circuit")
                {
                    Circuit();
                }
                if(gameObject.name == "Sequence")
                {
                    Sequence();
                }
            }
        }


        private static void UnpauseMovement(Collider other)
        {
            other.GetComponent<FirstPersonController>().isPaused = false;
        }

        private static void PauseMovement(Collider other)
        {
            other.gameObject.GetComponent<FirstPersonController>().isPaused = true;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.name == "Player")
            {
                myText.gameObject.SetActive(false);
            }
        }


        private void Refuel()
        {
            Debug.Log("Start Refuel Mini Game");
            myText.gameObject.SetActive(false);

        }

        private void Circuit()
        {
            Debug.Log("Start Circuit Mini Game");
            myText.gameObject.SetActive(false);
        }

        private void Sequence()
        {
            Debug.Log("Start Sequence Mini Game");
            myText.gameObject.SetActive(false);
        }

    }
}
