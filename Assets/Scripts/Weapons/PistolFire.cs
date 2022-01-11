using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolFire : MonoBehaviour
{
    public GameObject blackPistol;
    public bool isFiring = false;
    public GameObject muzzleFlash;
    public AudioSource pistolShot;

    public float toTarget;

    public RaycastHit rayHit;
    public GameObject bulletHoleGraphic;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FireThePistol());
            }
        }
    }

    IEnumerator FireThePistol()
    {
        isFiring = true;
        toTarget = PlayerCasting.distanceFromTarget;
        blackPistol.GetComponent<Animator>().Play("FirePistol");
        pistolShot.Play();
        muzzleFlash.SetActive(true);
        Instantiate(bulletHoleGraphic, rayHit.point, Quaternion.Euler(0, 180, 0));
        yield return new WaitForSeconds(0.03f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.22f);
        blackPistol.GetComponent<Animator>().Play("Idle");
        isFiring = false;
    }
}
