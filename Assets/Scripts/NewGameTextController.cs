using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewGameTextController : MonoBehaviour
  
{
    public TextMeshProUGUI NewGameText;

    private void Start()
    {
        StartCoroutine(ShowNewGameText());
    }

    IEnumerator ShowNewGameText()
    {
        NewGameText.gameObject.SetActive(true); //  
        yield return new WaitForSeconds(3f);    //  
        NewGameText.gameObject.SetActive(false); //  
    }
}