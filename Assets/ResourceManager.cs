using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager:SingleTon<ResourceManager>
{
    List<Sprite> iconlist = new List<Sprite>();

    public void LoadIcon()
    {
        //특정 폴더를 모구 로드 
        Sprite [] sps = Resources.LoadAll<Sprite>("Icon");
        for(int i = 0;i<sps.Length;i++)
        {
            iconlist.Add(sps[i]);
        }
    }

    public Sprite GetIcon(string strName)
    {
        return iconlist.Find(o => (o.name == strName));
        
    }
}
