using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSlotManager : MonoBehaviour
{
    public List<SkillSlot> slotList = new List<SkillSlot>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DoSkill_1()
    {
        slotList[0].BeginCoolTime();
        Debug.Log("111111");
    }
    public void DoSkill_2()
    {
        slotList[1].BeginCoolTime();

        Debug.Log("222222");
    }
    public void DoSkill_3()
    {
        slotList[2].BeginCoolTime();

        Debug.Log("333333");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
