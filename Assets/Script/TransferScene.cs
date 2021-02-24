using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// BoxCollider2D에 닿으면 씬 이동

public class TransferScene : MonoBehaviour
{
    public string transferMapName;  // 이동할 맵의 이름

    private MovingObject thePlayer;

    
    void Start()
    {
        thePlayer = FindObjectOfType<MovingObject>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")  // BoxCollider2D에 닿은 객체의 이름 반환 => 캐릭터의 이름이 Player라면
        {
            thePlayer.currentMapName = transferMapName;
            SceneManager.LoadScene(transferMapName);  // 씬 이동
        }
    }

}
