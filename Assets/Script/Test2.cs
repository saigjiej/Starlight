using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test2 : MonoBehaviour
{
    private bool state;
    Test1 target = GameObject.Find("Target").GetComponent<Test1>();

    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("마우스 입력 받았음");
            if (state == false)
            {
                target.SetActive(true);
                print("사라져");
                state = true;
            }
        }
    }
}