using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelCell : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI numberText;
    [SerializeField] private Button LevelButton;
    private int index;

    private void OnEnable()
    {
        LevelButton.onClick.AddListener(OnLevelButtonClicked);
    }

    private void Start()
    {
        LevelButton = GetComponent<Button>();
    }

    public void OnLevelButtonClicked()
    {
       LevelManager.inst.RemoveLastLevel();
       UIManager.inst.ChangeUI(ScreenType.GamePlayScreen);
       LevelManager.inst.LoadLevel(index);

    }


    public void SetData(int levelIndex)
    {
        index = levelIndex+1;
        numberText.text = index.ToString();        
    }

    private void OnDisable()
    {
        LevelButton.onClick.RemoveListener(OnLevelButtonClicked);
    }


}
