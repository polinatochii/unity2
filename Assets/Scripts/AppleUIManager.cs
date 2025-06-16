using UnityEngine;
using TMPro;
 using System.Collections;
public class AppleUIManager : MonoBehaviour
{
   

public TMP_Text appleCountText;

public TMP_Text plusOneText;

private int appleCount = 0;
    private void Start()
    {
        plusOneText.gameObject.SetActive(false);
        
    }
    public void AddApple()
    {
        appleCount++;
        appleCountText.text = "Apples: " + appleCount;
        StartCoroutine(ShowPlusOne());
    }
    
     private IEnumerator ShowPlusOne()
    {
        plusOneText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        plusOneText.gameObject.SetActive(false);
    }
}