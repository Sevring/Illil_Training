using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UiMg : MonoBehaviour
{
    [SerializeField] private Btns btns = null;

    private BtnsFunc btnFunc = new BtnsFunc();

    private void Start()
    {
        SetFuncToBtns();
    }

    private void SetFuncToBtns()
    {
        btns.GetBtn(0).onClick.AddListener(() => btnFunc.LoadMainScene());



    }

   
    



    
}
