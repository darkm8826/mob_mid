using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    private float hp = 100f;
    private GameObject focusEnemy;

    void Start()
    {

    }

    void Update()
    {
        // 找到最近的一個目標 Enemy 的物件
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Player");

        float miniDist = 9999;
        foreach (GameObject enemy in enemys)
        {
            // 計算距離
            float d = Vector3.Distance(transform.position, enemy.transform.position);

            // 跟上一個最近的比較，有比較小就記錄下來
            if (d < miniDist)
            {
                miniDist = d;
                focusEnemy = enemy;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Bullet bullet = other.GetComponent<Bullet>();
            hp -= bullet.atk;
            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
    void Fire()
    {
        Instantiate(bulletPrefab, firePoint.transform.position, transform.rotation);
    }
    IEnumerator KeepShooting()
    {
        while (true)
        {
            // 射擊
            Fire();
            // 暫停 0.5 秒
            yield return new WaitForSeconds(0.5f);
        }
    }
}
