﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// BoxCollider2D에 닿으면 씬 이동

public class TransferMap : MonoBehaviour
{
    public string transferMapName; // 이동할 맵의 이름

    private MovingObject thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<MovingObject>();  // 모든 객체의 <> 컴포넌트를 검색해서 리턴
    }

    // OnTriggerEnter2D 내장함수 : BoxCollider2D에 닿으면 실행되는 내장함수(Is Trigger 설정)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player") //  BoxCollider2D에 닿은 객체의 이름 반환 => 캐릭터의 이름이 Player라면
        {
            thePlayer.currentMapName = transferMapName;
            SceneManager.LoadScene(transferMapName); // 씬 이동
        }
    }
}