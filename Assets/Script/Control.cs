using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Control : MonoBehaviour
{
    public static float scorevalue = 0f;
    public Text score;
    private float scoreincrease = 1f;

    void Update(){
        score.text = "Distance: "+ ((int)scorevalue).ToString() + "m";
        StartCoroutine(delay());
        
    }
    IEnumerator delay(){
        scorevalue += scoreincrease* Time.deltaTime*10f;
        yield return new WaitForSeconds(1);
    }
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
