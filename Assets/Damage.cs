using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Damage : MonoBehaviour
{
    public Transform trStartPos;
    private Text _uiText;
    private Text uiText
    {
        get
        {
            if (_uiText == null)
            {
                _uiText = GetComponent<Text>();

            }
            return _uiText;
        }
    }
    public Vector3 startPos = Vector3.zero;
    float fSpeed = 5.0f;
    Color originCol;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
        Vector3 uiPos = Camera.main.WorldToScreenPoint(trStartPos.position);
        transform.position = trStartPos.position;
        originCol = uiText.color;
    }

    void FadeOut()
    {
        Color tmp = uiText.color;
        tmp.a -= Time.deltaTime;
        uiText.color = tmp;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * fSpeed);
    }
}
