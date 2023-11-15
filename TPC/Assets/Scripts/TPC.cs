using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class TPC
{
  protected Transform mCamera;
  protected Transform mPlayer;

  public TPC(Transform player, Transform camera)
  {
    mCamera = camera;
    mPlayer = player;
  }

  // We will keep this function as an abstract
  // because TPC doesnt know how to change the position
  // and rotation of the camera.
  // 

  public abstract void Update();
}

public class TPCTrack : TPC
{

  public TPCTrack(Transform player, Transform camera)
    : base(player, camera)
  {
  }

  // In TPCTrack we know exactly how we want to manipulate our 
  // camera. So, we can override the original abstract method from TPC.

  public override void Update()
  {
    Vector3 targetPos = mPlayer.position;
    targetPos.y += 2.0f;
    mCamera.LookAt(targetPos);
  }
}
