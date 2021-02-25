using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 캐릭터의 움직임을 담당하는 스크립트

public class MovingObject : MonoBehaviour
{
    static public MovingObject instance = null;

    public string currentMapName; // TransferMap 스크립트에 있는 transferMapName 변수의 값을 저장.

    private BoxCollider2D boxCollider;
    public LayerMask layerMask;

    public float speed;

    private Vector3 vector;

    public float runSpeed;
    private float applyRunSpeed;
    private bool applyRunFlag = false;

    public int walkCount;
    private int currentWalkCount;

    // Coroution 반복 실행 방지
    private bool canMove = true;

    // 애니메이션
    private Animator animator;

    //private static string s_Instance = null;

    public GameObject cube;


    void Start()
    {

        
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject); // 이 gameObject를 다음 씬을 로드할 때마다 파괴시키지 않음
            boxCollider = GetComponent<BoxCollider2D>();
            animator = GetComponent<Animator>();  // 애니메이션 통제
            
            instance = this;
            if (SceneManager.GetActiveScene().name == "FullMap1")
            {
                cube.SetActive(false);
            }
        }
     
        
        else
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    IEnumerator MoveCoroutine()
    {
        while (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                applyRunSpeed = runSpeed;
                applyRunFlag = true;
            }
            else
            {
                applyRunSpeed = 0;
                applyRunFlag = false;
            }

            vector.Set(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), transform.position.z);

            if (vector.x != 0)
                vector.y = 0;

            animator.SetFloat("DirX", vector.x);
            animator.SetFloat("DirY", vector.y);

            RaycastHit2D hit;

            Vector2 start = transform.position;
            Vector2 end = start + new Vector2(vector.x * speed * walkCount, vector.y * speed * walkCount);

            boxCollider.enabled = false;
            hit = Physics2D.Linecast(start, end, layerMask);
            boxCollider.enabled = true;

            if (hit.transform != null)
                break;

            animator.SetBool("Walking", true);

            while (currentWalkCount < walkCount)
            {
                if (vector.x != 0)
                {
                    transform.Translate(vector.x * (speed + applyRunSpeed), 0, 0);
                }
                else if (vector.y != 0)
                {
                    transform.Translate(0, vector.y * (speed + applyRunSpeed), 0);
                }
                if (applyRunFlag)
                {
                    currentWalkCount++;
                }
                currentWalkCount++;
                yield return new WaitForSeconds(0.01f);
            }
            currentWalkCount = 0;


        }
        animator.SetBool("Walking", false);
        canMove = true;
    }


    void Update()
    {
        if (canMove)
        {
            if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                canMove = false;
                StartCoroutine(MoveCoroutine());

            }
        }
    }
}