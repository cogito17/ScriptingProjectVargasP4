using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downfx;
    public Sprite upfx;
    public Sprite heldfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    // Start is called before the first frame update
    void Start()
    {
        graphic.sprite = standard;
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKey(KeyCode.Space);

        if (down)
        {
            graphic.sprite = downfx;
        }
        else if (held)
        {
            graphic.sprite = heldfx;
        }
        else if (up)
        {
            graphic.sprite = upfx;
        }
        else
        {
            graphic.sprite = standard;
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }
}
