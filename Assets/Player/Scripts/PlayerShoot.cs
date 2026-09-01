using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform[] bulletSpawnPoints;
    public bool isAutoFire = false;

    [Header("Pool Settings")]
    public int poolSize = 20;

    private GameObject[] bulletPool;
    private int currentIndex = 0;
    public float CoolDownRate = 0.1f;
    public float bulletCoolDown= 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletPool = new GameObject[poolSize];

        if(bulletPrefab is not null)
        {
            for(int i=0; i < poolSize; i++)
            {
                bulletPool[i] = Instantiate(bulletPrefab);
                bulletPool[i].SetActive(false);
            }           
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(bulletCoolDown > 0) bulletCoolDown -= Time.deltaTime;

        if ((isAutoFire || Keyboard.current.spaceKey.wasPressedThisFrame) && bulletCoolDown <= 0)
        {
            GetNextBullet();
            bulletCoolDown = CoolDownRate;
        }
    }

    private void GetNextBullet()
    {
        foreach(Transform spawnPoint in bulletSpawnPoints)
        {
            GameObject bullet = bulletPool[currentIndex];
            currentIndex = (currentIndex + 1) % poolSize;
            bullet.SetActive(false);
    
            bullet.transform.position = spawnPoint.position;
            bullet.transform.rotation = spawnPoint.rotation;
            bullet.SetActive(true);
        }
    }
}
