using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//단일체 패턴턴(싱글톤)
//유일하게 하나의 인스턴스만 생성할수 있게 한다
//where다음에는 제약조건을 명시한다
//T의 제약조건은
//참조형식이어야하고 ->class
//매게변수가 없는 생성자->new()
public class SingleTon<T> where T:class, new() 
{
    private static T inst = null;

    public SingleTon()
    {

    }

    public static T instance
    {
        get
        {
            if(inst==null)
                inst = new T();
            return inst;
        }
    }
}
