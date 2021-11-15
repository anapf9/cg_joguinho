using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
  public Text test;

  void Start()
  {
    test.text = "";
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Ground")
    {
      test.color = Color.red;
      test.text = "Você perdeu";
      Invoke("ReloadScene", 3);
      Debug.Log("crashou");
    }

  }

  void ReloadScene()
  {
    SceneManager.LoadScene(0);

  }

}
