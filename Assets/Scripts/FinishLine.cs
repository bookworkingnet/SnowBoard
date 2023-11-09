using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public static int sceneIndex = 0; // khai báo sceneIndex ở ngoài

  [SerializeField] float loadDelay = 0.5f;
  [SerializeField] ParticleSystem finishEffect;

  
  
  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.tag == "Player")
    {
      finishEffect.Play();
      GetComponent<AudioSource>().Play();
      Invoke("ReloadScene", loadDelay); 
    }
  }

  void ReloadScene()
  {   
    
    sceneIndex++; // tăng sceneIndex lên 1
    if(sceneIndex > 2) {
      Debug.Log("Man Cuoi");
      return ;
    }
    SceneManager.LoadScene(sceneIndex); 
    
    
  }

}
