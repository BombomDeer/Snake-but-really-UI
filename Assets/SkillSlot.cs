using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillSlot : MonoBehaviour
{
    public Image Icon;
    public Image Coolgauge;
    public float coolDown = 2f;
    float elapsedTime = 0f;
    bool bBegin = false;

    // Start is called before the first frame update
    void Start()
    {
        //Coolgauge.fillClockwise = false;
        //Icon.sprite = ResourceManager.instance.GetIcon("HEAL");
        Icon.gameObject.SetActive(false);
    }

    public void SetIcon(string strName)
    {
        Icon.gameObject.SetActive(true);
        Icon.sprite = ResourceManager.instance.GetIcon(strName);
    }

    public void BeginCoolTime()
    {
        bBegin = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (bBegin == true)
        {
            elapsedTime += Time.deltaTime;
            Coolgauge.fillAmount = (coolDown - elapsedTime) / coolDown;
            if (Coolgauge.fillAmount <= 0)
            {
                bBegin = false;
                elapsedTime = 0;
            }
        }
    }
}
