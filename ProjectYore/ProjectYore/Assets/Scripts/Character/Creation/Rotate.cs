using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace Character.Creation
{
    public class Rotate : MonoBehaviour
    {
        public GameObject character;
        public Button rotateLeft;
        public Button rotateRight;

        public int speed = 50;

        // Use this for initialization
        void Start()
        {
            if(character == null || rotateLeft == null || rotateRight == null)
            {
                Debug.Log("Double check public variables.  Unable to rotate character");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void RotateRight()
        {
            character.transform.Rotate(-(Vector3.up * speed * Time.deltaTime),Space.World);
        }

        public void RotateLeft()
        {
            character.transform.Rotate(Vector3.up * speed * Time.deltaTime, Space.World);
        }
    }
}
