using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    public GameObject FlowObj;
    Vector3 dir;
    float fSpeed = 25.0f;
    public Image Skill_1;
    public Image coolDownImage;
    float coolDown = 2f;
    float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        dir = FlowObj.transform.position - transform.position;
        float fAngle = Vector3.Angle(transform.forward, dir);
        Debug.Log(fAngle.ToString());
        Transform coolTr = Skill_1.transform.GetChild(0);
        coolTr.gameObject.GetComponent<Image>().fillAmount = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        float fDistance = Vector3.Distance(transform.position, FlowObj.transform.position);
        dir = FlowObj.transform.position - transform.position;
        if(fDistance >=2f)
        {
            transform.Translate(dir * Time.deltaTime * fSpeed);
        }
        //if(elapsedTime >= coolDown)
        //{
        //    elapsedTime = 0;
        //    coolDownImage.fillAmount = 0f;
        //}
        //else
        //{
        //    elapsedTime += Time.deltaTime;
        //    coolDownImage.fillAmount = elapsedTime/2;
        //}
    }
}
