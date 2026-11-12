using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PistolBulletPool : NetworkBehaviour
{
    public static PistolBulletPool main;
    public GameObject PistolbulletPrefab;
    public int poolSize = 100;
    private List<Bullet> availableBullets;

    private void Awake()
    {
        main = this;
    }
    private void Start()
    {
        availableBullets = new List<Bullet>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject Bullets = Instantiate(PistolbulletPrefab, transform);
            Bullet b = Bullets.GetComponent<Bullet>();

            b.gameObject.SetActive(false);
            availableBullets.Add(b);
        }
    }

    public void PickFromPool(Vector3 position, Vector3 velocity, Vector3 playerpos)
    {
        if (availableBullets.Count < 1) return;
        availableBullets[0].Activate(position, velocity, playerpos);
        availableBullets.RemoveAt(0);
    }
    public void AddToPool(Bullet bullet)
    {
        if (!availableBullets.Contains(bullet)) availableBullets.Add(bullet);
    }
}
