using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class LevelUp : MonoBehaviour
{

    [SerializeField]PlayerParameter Player;
    [SerializeField]AttackParameter[] Attack;
    [SerializeField] GameObject LevelMenu;
    [SerializeField] UnityAction action;
    // Start is called before the first frame update
    void Start()
    {
        LevelMenu.SetActive(false);
    }

    // Update is called once per frame
   
    public void OpenMenu()
    {
        Time.timeScale = 0;
        LevelMenu.SetActive(true);
    }
    public void CloseMenu()
    {
        Time.timeScale = 1;
        LevelMenu.SetActive(false);
    }
}
