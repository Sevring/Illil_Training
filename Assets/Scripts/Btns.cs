using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Btns : MonoBehaviour
{

    [SerializeField] private List<Button> btnList = null;


    public Button GetBtn(int _idx)
    {
        return btnList[_idx];
    }


}
