using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_Nat : MonoBehaviour
{
    Vector3 moving;
    public float speed;//プレイヤーの移動スピード
    Rigidbody rb;
    public Vector3 movingVelocity;
    Vector3 roteuler;

    public GameObject bulletPrefab;
    GameObject bullet;
    public GameObject Barrel;

    public float ballspeed;

    public GameObject Player;

    public float limit;
    public int maxlimit;
    public int minlimit;

    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        roteuler = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);//視点移動の奴です

        limit = 50;
    }
    void Update()
    {

        limit += 10 * Time.deltaTime;

        limit = System.Math.Min(limit, maxlimit);
        limit = System.Math.Max(limit, minlimit);

        var velocity = Vector3.zero;//プレイヤーの移動　見にくいもので申し訳ないです。
        if (Input.GetKey(KeyCode.W))
        {
            velocity.z = speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z = -speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = speed * Time.deltaTime;
        }
        if (velocity.x != 0 || velocity.z != 0)
        {
           transform.position += transform.rotation * velocity;
        }

        if (Input.GetMouseButtonDown(0))//左クリックでRay発射
        {
            limit -= 5;
            Ray ray = new Ray(Player.transform.position, Player.transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 1);
                bullet = Instantiate(bulletPrefab, Barrel.transform.position, Quaternion.identity);
                Vector3 worldDir = ray.direction;
                bullet.GetComponent<BulletScript>().Shot(worldDir * ballspeed);
                Destroy(bullet, 1f);
            }
            else
            {
                Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 1);
                bullet = Instantiate(bulletPrefab, Barrel.transform.position, Quaternion.identity);
                Vector3 worldDir = ray.direction;
                bullet.GetComponent<BulletScript>().Shot(worldDir * ballspeed);
                Destroy(bullet, 1f);
            }
        }

        float mouseInputX = Input.GetAxis("Mouse X");//横の視点移動

        roteuler = new Vector3(0, roteuler.y + mouseInputX * -1, 0f);
        transform.localEulerAngles = roteuler;
    }
}
