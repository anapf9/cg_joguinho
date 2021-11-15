using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] float torqueAmount = 1f;

  Rigidbody2D rigidBody2d;
  Vector3 scaleChange;
  Vector3 spaceChange;
  // Start is called before the first frame update
  void Start()
  {
    rigidBody2d = GetComponent<Rigidbody2D>();
    scaleChange = new Vector3(0.005f, 0.005f, 0);
    spaceChange = new Vector3(0, 0.2f, 0);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      rigidBody2d.AddTorque(torqueAmount);
    }
    else if (Input.GetKey(KeyCode.RightArrow))
    {
      rigidBody2d.AddTorque(-torqueAmount);
    }
    //---
    if (Input.GetKey(KeyCode.UpArrow))
    {
      rigidBody2d.transform.localScale += scaleChange;
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      rigidBody2d.transform.localScale -= scaleChange;
    }
    if (Input.GetKey(KeyCode.Space))
    {
      rigidBody2d.transform.position += spaceChange;
    }
  }
}
