using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
  // We need access to the animator, why? 
  // because we want to change the animation
  // from this script.
  [SerializeField]
  Animator mAnimator;

  [SerializeField]
  CharacterController mCharacterController;

  [SerializeField]
  float mWalkSpeed = 1.5f;

  [SerializeField]
  float mRotationalSpeed = 50.0f;

  // Start is called before the first frame update
  void Start()
  {
    //mCharcterCntroller = GetComponent<CharacterController>();
  }

  // Update is called once per frame
  void Update()
  {
    // We cannot make the player move
    // without the below two components.
    if (mAnimator == null) return;
    if (mCharacterController == null) return;


    // we are going to manipulate our character.
    float hInput = Input.GetAxis("Horizontal");
    float vInput = Input.GetAxis("Vertical");

    float speed = mWalkSpeed;

    if(Input.GetKey(KeyCode.LeftShift))
    {
      speed = mWalkSpeed * 2.0f;
    }

    transform.Rotate(0.0f, hInput * mRotationalSpeed * Time.deltaTime, 0.0f);
    Vector3 forward = transform.forward;
    forward.y = 0.0f;

    mCharacterController.Move(forward * vInput * Time.deltaTime * speed);

    mAnimator.SetFloat("PosX", 0.0f);

    float posz_value = vInput * speed / (2.0f * mWalkSpeed);
    mAnimator.SetFloat("PosZ", posz_value);

    Debug.Log(posz_value);
  }
}
