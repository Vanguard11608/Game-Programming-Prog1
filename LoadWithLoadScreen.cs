using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoading : Monobehaviour
{
        public GameObject loadingScreen;
        public Slider slider;
        public Text progressText;


   void OnCollisionEnter(Collision coll)
   {
       //When Colliding with Player start Coroutine
       if (coll.gameObject.tag == "Player"){
            
            StartCoroutine(LoadYourAsyncScene());
       }
   }


    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        loadingScreen.SetActive(true);


        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null;
        }

    }
}