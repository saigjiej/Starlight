using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMoving : MonoBehaviour
{
    static public MapMoving instance;

    private bool state;
    public GameObject Target;

    public void Awake()
    {
        state = true;

        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject); // 이 gameObject를 다음 씬을 로드할 때마다 파괴시키지 않음
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
                    SceneManager.LoadScene("FullMap1");
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
