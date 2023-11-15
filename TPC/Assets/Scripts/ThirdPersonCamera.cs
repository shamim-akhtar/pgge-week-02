using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
  [SerializeField]
  Transform mPlayer;
  public enum ThirdPersoncameraType
  {
    Track,
    //Follow,
    //Follow_PosAndRotation,
    //TopDown,
    //Independent
  }

  private TPC mTpc;

  // Start is called before the first frame update
  void Start()
  {
    mTpc = new TPCTrack(mPlayer, transform);
  }

  // Update is called once per frame
  void Update()
  {
    mTpc.Update();
  }
}
