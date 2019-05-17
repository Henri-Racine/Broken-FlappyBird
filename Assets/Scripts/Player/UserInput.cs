using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    [RequireComponent(typeof(Bird))]
    public class UserInput : MonoBehaviour
    {
        private GameObject bird;


        // Update is called once per frame
        void Update()
        {
            var bird = GetComponent<Bird>();
            // Check for mouse down
            if (Input.GetMouseButtonDown(0))
            {
                // Flap the bird
                bird.Flap();
            }
        }
    }
}