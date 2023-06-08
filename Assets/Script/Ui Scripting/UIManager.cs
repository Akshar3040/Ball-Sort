using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : UIBaseClass
{
    public List<UIBaseClass> UiScreenList;
    UIBaseClass currentscreen;

    public static UIManager inst;

    private void Awake()
    {
        inst = this;
        currentscreen = UiScreenList[0];

    }

    public void showNextScreen(UIScreenList uIScreen)
    {
        currentscreen.OnDisable();
        UiScreenList[(int)uIScreen].OnEnable();
        currentscreen = UiScreenList[(int)uIScreen];
    }


}
