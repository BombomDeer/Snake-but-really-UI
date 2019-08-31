using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//눈에 보이는 UI를 관리하기 위한 관리자
public class HudManager : MonoBehaviour
{
    public SkillSlotManager skillslotManager;
    public Button btExit;

    // Start is called before the first frame update
    void Start()
    {
        btExit.onClick.AddListener(OnExit);
        btExit.onClick.AddListener(OnExit2);

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnExit()
    {
        Debug.Log("OnExit");

    }
    public void OnExit2()
    {
        Debug.Log("OnExit2");

    }
}
