using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // 정적변수는 인스펙터창에 나타나지 않는다
    public Player player;

    void Awake()
    {
        instance = this; // Awake 생명주기에서 인스턴스 변수를 자기자신 this로 초기화 
    }

}
