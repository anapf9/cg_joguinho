using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
  public Text texto;
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player")
    {
      texto.color = Color.green;
      texto.text = "Você completou o level";
      Invoke("ReloadScene", 3);
      Debug.Log("Hitou");

    }


  }
  void ReloadScene()
  {
    SceneManager.LoadScene(0);
  }
}
