using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMovement2 : MonoBehaviour
{
    static public MapMovement2 instance;
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
            if (gameObject != null)
            {
                print("마우스 입력 받았음");
                if (state == true)
                {
                    Target.SetActive(false);
                    print("사라져");
                    SceneManager.LoadScene("FullMap2");
                    state = false;
                }
                else
                {
                    Target.SetActive(true);
                    print("생겨나");
                    SceneManager.LoadScene("Map1");
                    state = true;
                }
            }
        }
    }
}
