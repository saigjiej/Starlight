﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    static public CameraManager instance;

    public GameObject target;  // 카메라가 따라갈 대상
    public float moveSpeed;  // 카메라가 얼마나 빠른 속도로
    private Vector3 targetPosition;  // 대상의 현재 위치 값

    // Start is called before the first frame update
    void Start()
    {
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
        if(target.gameObject != null)
        {
            targetPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);
        
            this.transform.position = Vector3.Lerp(this.transform.position, targetPosition, moveSpeed * Time.deltaTime);  // 1초에 movespeed만큼 이동
        }
    }
}
