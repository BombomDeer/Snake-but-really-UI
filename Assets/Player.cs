using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image HP;
    Transform uiTr;
    float fill = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        uiTr = transform.Find("hpnode");
        Vector3 uiPos = Camera.main.WorldToScreenPoint(uiTr.position);
        HP.transform.position = uiPos;

        HP.fillAmount = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 uiPos = Camera.main.WorldToScreenPoint(uiTr.position);
        HP.transform.position = uiPos;

        if(HP.fillAmount>=1)
        {
            fill = -0.05f;
        }
        if(HP.fillAmount<=0)
        {
            fill = 0.05f;
        }
        HP.fillAmount += fill; 
    }
}
