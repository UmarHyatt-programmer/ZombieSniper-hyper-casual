using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GunsData : ScriptableObject
{
  public string gunName;
  public float damage;
  public float reloadTime;
  public float fireRate;
}