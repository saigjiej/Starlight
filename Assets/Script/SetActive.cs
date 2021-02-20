using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActive : MonoBehaviour
{
    static public SetActive instance;

    private bool state;
    public GameObject Target;

    public void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Map1" || SceneManager.GetActiveScene().name == "FullMap1")
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
        if (SceneManager.GetActiveScene().name == "Map2" || SceneManager.GetActiveScene().name == "FullMap9")
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
                        SceneManager.LoadScene("FullMap9");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map2");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map3" || SceneManager.GetActiveScene().name == "FullMap8")
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
                        SceneManager.LoadScene("FullMap8");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map3");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map4" || SceneManager.GetActiveScene().name == "FullMap2")
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
                        SceneManager.LoadScene("Map4");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map5" || SceneManager.GetActiveScene().name == "FullMap10")
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
                        SceneManager.LoadScene("FullMap10");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map5");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map6" || SceneManager.GetActiveScene().name == "FullMap11")
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
                        SceneManager.LoadScene("FullMap11");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map6");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map7" || SceneManager.GetActiveScene().name == "FullMap12")
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
                        SceneManager.LoadScene("FullMap12");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map7");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map8" || SceneManager.GetActiveScene().name == "FullMap3")
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
                        SceneManager.LoadScene("FullMap3");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map8");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map9" || SceneManager.GetActiveScene().name == "FullMap13")
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
                        SceneManager.LoadScene("FullMap13");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map9");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map11" || SceneManager.GetActiveScene().name == "FullMap14")
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
                        SceneManager.LoadScene("FullMap14");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map11");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map12" || SceneManager.GetActiveScene().name == "FullMap4")
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
                        SceneManager.LoadScene("FullMap4");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map12");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map13" || SceneManager.GetActiveScene().name == "FullMap5")
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
                        SceneManager.LoadScene("FullMap5");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map13");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map14" || SceneManager.GetActiveScene().name == "FullMap15")
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
                        SceneManager.LoadScene("FullMap15");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map14");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map15" || SceneManager.GetActiveScene().name == "FullMap16")
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
                        SceneManager.LoadScene("FullMap16");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map15");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map17" || SceneManager.GetActiveScene().name == "FullMap17")
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
                        SceneManager.LoadScene("FullMap17");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map17");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map18" || SceneManager.GetActiveScene().name == "FullMap6")
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
                        SceneManager.LoadScene("FullMap6");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map18");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map19" || SceneManager.GetActiveScene().name == "FullMap18")
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
                        SceneManager.LoadScene("FullMap18");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map19");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map20" || SceneManager.GetActiveScene().name == "FullMap19")
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
                        SceneManager.LoadScene("FullMap19");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map20");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map21" || SceneManager.GetActiveScene().name == "FullMap20")
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
                        SceneManager.LoadScene("FullMap20");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map21");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map22" || SceneManager.GetActiveScene().name == "FullMap21")
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
                        SceneManager.LoadScene("FullMap21");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map22");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map26" || SceneManager.GetActiveScene().name == "FullMap25")
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
                        SceneManager.LoadScene("FullMap25");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map26");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map27" || SceneManager.GetActiveScene().name == "FullMap26")
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
                        SceneManager.LoadScene("FullMap26");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map27");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map28" || SceneManager.GetActiveScene().name == "FullMap27")
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
                        SceneManager.LoadScene("FullMap27");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map28");
                        state = true;
                    }
                }
            }
        }
        if (SceneManager.GetActiveScene().name == "Map29" || SceneManager.GetActiveScene().name == "FullMap7")
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
                        SceneManager.LoadScene("FullMap7");
                        state = false;
                    }
                    else
                    {
                        Target.SetActive(true);
                        print("생겨나");
                        SceneManager.LoadScene("Map29");
                        state = true;
                    }
                }
            }
        }
    }
}