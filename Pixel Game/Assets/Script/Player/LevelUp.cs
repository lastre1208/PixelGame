using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;


public interface IUpgread
{
    float GetParameter(Lv_Type type);
    void SetParameter(Lv_Type type, float value);
}

public enum Lv_Type
{
    HP,
    Attack,
    Speed,
    Duration,
    Exp,
    Weapon_Attack,
    Weapon_Speed,
    Weapon_Duration,
    Weapon_Shot,
}
[System.Serializable]
public class Lv_Array
{
 public int Lv_cost;//�����ɕK�v�ȃR�X�g
    public float Lv_grade;//�㏸��
   public Lv_Type Lv_type;//��������p�����[�^�[
    public bool IsLimit;//���E���ǂ���
}
[System.Serializable]

public class LevelExecute
{
    public GameObject UpgradeTarget;//��������I�u�W�F�N�g
    public string Lv_name;//�����̖��O
    public int Lv_lv;//�������x��
   public List<Lv_Array> Lv;
}
[System.Serializable]
public class LevelMenu
{
    public TMP_Text Name;
    public TMP_Text Lv;
    public TMP_Text Cost;
    public Button Button;
}
public class LevelUp : MonoBehaviour
{
    
    [SerializeField] LevelMenu[] Menu;//�����_���ɑI�o���ꂽ�������e��\�������郁�j���[
    [SerializeField]LevelExecute[] levelExecute;//�������e
    [SerializeField] TMP_Text Shuffle;
    [SerializeField] int Cost;
    [SerializeField] GameObject LevelMenu;//���x���A�b�v���\��������I�u�W�F�N�g
    PlayerParameter player;
    
    private LevelExecute[] SelectedExecute; 
    // Start is called before the first frame update
    void Start()
    {
        LevelMenu.SetActive(false);
        
        player = GameObject.FindWithTag("P_Status").GetComponent<PlayerParameter>();
    }

    // Update is called once per frame
   
    public void OpenMenu()
    {
        Time.timeScale = 0;
        LevelMenu.SetActive(true);
        SetMenu();
    }
    public void CloseMenu()
    {
        Time.timeScale = 1;
        LevelMenu.SetActive(false);
    }
    public void SetMenu()
    {

        SelectMenu();
       LoadLevelUp();
    }

    public void SelectMenu()
    {
        int menuCount = 0;
        // SelectedExecute��Menu.Length�ɍ��킹�ď�����
        if (SelectedExecute == null || SelectedExecute.Length != Menu.Length)
        {
            SelectedExecute = new LevelExecute[Menu.Length];
        }

        // levelExecute�����X�g�Ƃ��ăR�s�[
        List<LevelExecute> availableExecutions = new List<LevelExecute>(levelExecute);

       while(menuCount!=Menu.Length)
        {
            if (availableExecutions.Count == 0)
            {
                Debug.LogWarning("�I���\�ȋ������s�����Ă��܂��I");
                break;
            }

            // �����_���ɑI��
            int randomIndex = Random.Range(0, availableExecutions.Count);
            if (!availableExecutions[randomIndex].Lv[availableExecutions[randomIndex].Lv_lv - 1].IsLimit) { 
            
                SelectedExecute[menuCount] = availableExecutions[randomIndex];
                menuCount++;
            }
         
            // �I�΂ꂽ���̂����X�g����폜
            availableExecutions.RemoveAt(randomIndex);
        }
    }
    public void LoadLevelUp()
    {
        for (int i = 0; i < Menu.Length; i++)
        {
            int index = i;
            Menu[i].Name.text = "" + SelectedExecute[i].Lv_name;
            Menu[i].Lv.text = "Lv" + SelectedExecute[i].Lv_lv;
            
            Menu[i].Button.onClick.RemoveAllListeners();
            if (SelectedExecute[i].Lv[SelectedExecute[i].Lv_lv - 1].IsLimit)
            {
                Menu[i].Cost.text = "<color=red>MAX!!</color>\n";
            }
            else
            {
                Menu[i].Cost.text = SelectedExecute[i].Lv[SelectedExecute[i].Lv_lv - 1].Lv_cost + "\nPoints";
                Menu[i].Button.onClick.AddListener(() => ApplyUpgrade(index));
            }
           

           
            
        }
        DisplayShuffle();
    }
    public void ApplyUpgrade(int index)
    {
     
        LevelExecute selected = SelectedExecute[index];
        int currentLevel = SelectedExecute[index].Lv_lv - 1;
        Lv_Array Upgrade = SelectedExecute[index].Lv[currentLevel];
       


        IUpgread target = selected.UpgradeTarget.GetComponent<IUpgread>();
        if (player.SkillPoint > selected.Lv[selected.Lv_lv-1].Lv_cost)
        {
            float currentParameter = target.GetParameter(Upgrade.Lv_type);

            float upgreadParameter = currentParameter + (currentParameter * Upgrade.Lv_grade / 100);


            target.SetParameter(Upgrade.Lv_type, upgreadParameter);
            player.SkillPoint -= selected.Lv[selected.Lv_lv-1].Lv_cost;
            if (selected.Lv_lv < selected.Lv.Count)
            {
                selected.Lv_lv++;
            }

        }
        



      

        LoadLevelUp();
    }
    public void DisplayShuffle()
    {
        Shuffle.text = Cost + "\nPoints";
    }
    public void ShuffleCostUp()
    {
        Cost ++;
        DisplayShuffle();
    }
   
}
