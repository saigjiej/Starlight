using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 여기서 start(캐릭터 이동)

public class StartPoint : MonoBehaviour
{
    public string startPoint;  // 맵이 이동, 플레이어가 시작될 위치  / transferMapName의 값과 startPoint의 값이 같으면 startPoint로 이동

    //public string current = thePlayer.currentMapName;

    private MovingObject thePlayer;
    private CameraManager theCamera;


    // Start is called before the first frame update
    void Start()
    {
        //log = SceneManager.GetActiveScene().name;

        thePlayer = FindObjectOfType<MovingObject>();  // 모든 객체의 <> 컴포넌트를 검색해서 리턴
        theCamera = FindObjectOfType<CameraManager>();

        if (startPoint == thePlayer.currentMapName)
        {
            thePlayer.transform.position = this.transform.position;
            theCamera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, theCamera.transform.position.z);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
