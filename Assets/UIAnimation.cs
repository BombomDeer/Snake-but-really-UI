using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIAnimation : MonoBehaviour
{
    public AnimationCurve curv;
    float fSumTime = 0f;

    public Transform trStart; //spacial coord
    Vector3 screenPos = Vector3.zero; //on-screen coord


    // Start is called before the first frame update
    void Start()
    {
        screenPos = Camera.main.WorldToScreenPoint(trStart.position);
        transform.position = screenPos;
    }

    // Update is called once per frame
    void Update()
    {
        fSumTime += Time.deltaTime;
        float fResult = curv.Evaluate(fSumTime);


        float y = screenPos.y + fResult * 10f;
        Vector3 tmp = transform.position;
        tmp.y = y;
        transform.position = tmp;
    }
}
