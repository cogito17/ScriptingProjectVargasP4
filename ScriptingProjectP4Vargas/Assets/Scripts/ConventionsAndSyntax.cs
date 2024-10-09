using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //I want the exposition of my game object to appear on the console
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        //I want to know what my y position is at all times
        Debug.Log(transform.position.y);

        //I want the console to say something if my object is below 5
        if (transform.position.y <= 5f)
        {
            Debug.Log("CURSE YOU BAYLE!!! I HEREBY VOW, YOU WILL RUE THIS DAY!!! BEHOLD, A TRUE DRAKE WARRIOR AND I, IGON!!! YOUR FEARS MADE FLESH!!! SOLID OF SCALE YOU MIGHT BE FOUL DRAGON!!! BUT I WILL RIDDLE WITH HOLES YOUR ROTTEN HIDE!!! WITH A HAIL OF HARPOONS!!! WITH EVERY DROP OF MY BEING!!! RRRRAAAAAAHHHHHH!!!");
        }
    }
}
