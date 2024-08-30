using UnityEngine;

[System.Serializable]
public class WeaponStats
{
    [Header("Weapon Stats")]
    public int damage = 1;
    public float realoadTime = 0.35f;
    [Tooltip("Number of hittable enemies in one shot")]
    public int pierce = 1;
    [Tooltip("Interval between each shot (lower = faster)")]
    public float fireRate = 1f;

    [Space(10)]
    [Header("Weapon Ammos")]
    public int ammos = 30;
    public int defaultAmmos = 30;
    public int ammosInUse = 10;
    public int maxAmmosInUse = 10;
}