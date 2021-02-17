using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test1 : MonoBehaviour
{
    private bool state;
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("마우스 입력 받았음");
            if (state == true)
            {
                Target.SetActive(false);
                print("사라져");
                state = false;
            }
        }
    }

    internal void SetActive(bool v)
    {
        throw new NotImplementedException();
    }
}