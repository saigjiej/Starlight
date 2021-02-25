using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapMovement1 : MonoBehaviour
{

    static public MapMovement1 instance;
    private bool state;
    public GameObject Target;


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
        
    }
}
