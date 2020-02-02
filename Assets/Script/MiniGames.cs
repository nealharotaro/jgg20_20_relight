using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UnityStandardAssets.Characters.FirstPerson
{


    public class MiniGames : MonoBehaviour
    {
        [SerializeField] Generator myGenerator;
        [SerializeField] TextMesh myText;
        [SerializeField] RectTransform goalMeter;
        [SerializeField] MeterSystem meter;
        public GameObject CircuitPuzzle1;
   
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
                if (meter.gameObject)
                {
                    meter.gameObject.SetActive(false);
                }
                
            }

            if (Input.GetKeyDown(KeyCode.E) && !other.GetComponent<FirstPersonController>().isPaused)
            {
                PauseMovement(other);
                if (gameObject.name == "Refuel")
                {
                    Refuel();
                }
                if (gameObject.name == "Circuit")
                {
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    Circuit(CircuitPuzzle1);
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

            meter.targetPercent = Random.Range(0, 100f) / 100f;
            RandomizeGoalMeter();
            meter.gameObject.SetActive(true);
            meter.StartArrow();
            myText.gameObject.SetActive(false);

        }

        private void Circuit(GameObject puzzle)
        {
            Debug.Log("Start Circuit Mini Game");
            puzzle.SetActive(true);
            myText.gameObject.SetActive(false);
           
        }

        private void Sequence()
        {
            Debug.Log("Start Sequence Mini Game");
            myText.gameObject.SetActive(false);
        }


        private void RandomizeGoalMeter()
        {
            goalMeter.rotation = Quaternion.Euler(0, 0,meter.targetPercent * 360);
        }

    }
}
