using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManger : MonoBehaviour
{
    public GameObject[] object_distance;
    public DragObject[] distance_trigger_level;
    [SerializeField]
    private Slider Progress;
    private float increase_score;
    private bool newdiffult;
    int select_level, select_level_1;
    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
    }
    private void Start()
    {
        for (int i = 0; i < object_distance.Length; i++)
        {
            Level_Design();
            
        }
        increase_score = PlayerPrefs.GetFloat("slidepro");
        select_level = PlayerPrefs.GetInt("scene");
        select_level_1 = PlayerPrefs.GetInt("scene");
    }

    void Distance_Trigger()
    {
        if(distance_trigger_level[0].isture && distance_trigger_level[1].isture && distance_trigger_level[2].isture && distance_trigger_level[3].isture && distance_trigger_level[4].isture &&
            distance_trigger_level[5].isture && distance_trigger_level[6].isture)
        {
            if (newdiffult && distance_trigger_level[7].isture && distance_trigger_level[8].isture)
            {
                increase_score += 10.0f;
                PlayerPrefs.SetFloat("slidepro", increase_score);
                
                select_level = Random.Range(0, 3);
                SceneManager.LoadScene(select_level);
            }
            else
            {
                 
                select_level_1 = Random.Range(0, 3);
                increase_score += 10.0f;
                PlayerPrefs.SetFloat("slidepro", increase_score);
                SceneManager.LoadScene(select_level_1);
            }
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            select_level_1 = Random.Range(0, 3);            
            SceneManager.LoadScene(select_level_1);
        }
        Progress.value = increase_score;
        if (Progress.value >= 100)
        {
            increase_score = 0;
            PlayerPrefs.SetFloat("slidepro", increase_score);
            SceneManager.LoadScene(1);
        }
        Distance_Trigger();
    }
    void Level_Design()
    {
 
      object_distance[Random.Range(0, object_distance.Length)].transform.position = new Vector3(Random.Range(0, 4), Random.Range(0, 4), Random.Range(0, 4));
         
    }
}
