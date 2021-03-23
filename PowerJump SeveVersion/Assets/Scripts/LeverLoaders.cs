using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeverLoaders : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider; 
    public GameObject button;

    public Text ProgressText;
    
    public void LoadLevel (int sceneIndex) {
          
          StartCoroutine(LoadAsynchronously(sceneIndex));

    }
      
      IEnumerator LoadAsynchronously (int sceneIndex){

          AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
          
          operation.allowSceneActivation = false;

          loadingScreen.SetActive(true); 



          while (!operation.isDone)
          {
              float progress = Mathf.Clamp01(operation.progress / .9f );

               slider.value = progress;
            ProgressText.text = progress *100f + "%";
               button.SetActive(false);

              if (operation.progress >= .9f && !operation.allowSceneActivation)
              {
                  if (Input.anyKeyDown)
                  {
                      operation.allowSceneActivation = true; 
                      
                  }
              }   


              yield return null;
          }

          

      }
 

}
