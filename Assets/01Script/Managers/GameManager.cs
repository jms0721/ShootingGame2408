using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임의 전반적인 흐름을 관리
// 1. 게임의 시작, 게임의 중지, 게임을 종료
// 2. 사운드 관리자
// 3. 동적로딩 : 에셋 로딩(rom데이터를 Ram공안 불러오기작업)
// 4. 씬 관리 ; 씬 변경시에 데이터 주고 받고, 게임 종료되면 씬을 변경시키고
// 5. (임시) 입력 받아서, 캐릭터 전당

public class GameManager : Singleton<MonoBehaviour>
{
    ScrollManager scrollManager;

    private IInputHandler inputHandler;
    private IMovement movementController;

    GameObject obj;

    private void Start()
    {
        scrollManager = GameObject.FindAnyObjectByType<ScrollManager>();

        StartCoroutine(GameStart());

        LoadScenelnot();//임시:나중에 씬 변경될 때, 호출하도록 변경
    }

    // 씬이 변경이 될때
    // 변경된 UI에서 joystick 찾아 참조,
    // 씬에 따라서 변경되는 Player객체도 찾아서 참조
    private void LoadScenelnot()
    {
        inputHandler = GatComponent<InputKeyboard>();

        obj = FindObjectsByType<PlayerMove>(FindObjectsSortMode.None)[0].gameObject;

        if (obj != null)
        {
            if (!obj.TryGetComponent<IMovement>(out movementController))
                Debug.Log("GameManager.cs - LoadScenelnot() - movementController참조 실패");
        }

//#if UNITY_EDITOR
//        inputHandler = GetComponent<InputKeyboard>();
//#elif UNITY_ANDROID
    }

    private void Update()
    {
        if(inputHandler != null)
        {
            movementController.Move(inputHandler.GetInput());
        }
    }

    // 게임시작할때 연출을 위해서 딜레이
    IEnumerator GameStart()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("게임 준비");
        yield return new WaitForSeconds(2f);
        scrollManager?.SetScrollSpeed(4f);


    }
}
