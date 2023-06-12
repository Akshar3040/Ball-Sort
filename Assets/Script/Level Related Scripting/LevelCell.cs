using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCell : MonoBehaviour
{
   private Button LevelButton;
    public int index;


    public void OnCellEnable()
    {
        LevelButton.onClick.AddListener(OnLevelButtonClicked);
    }

    private void Start()
    {
        LevelButton = GetComponent<Button>();
    }

    public void OnLevelButtonClicked()
    {
        LevelManager.inst.LoadLevel(index);
    }


    public void SetData(int levelIndex)
    {
        index = levelIndex;
    }

    public void OnCellDissable()
    {
        LevelButton.onClick.RemoveListener(OnLevelButtonClicked);
    }


}
