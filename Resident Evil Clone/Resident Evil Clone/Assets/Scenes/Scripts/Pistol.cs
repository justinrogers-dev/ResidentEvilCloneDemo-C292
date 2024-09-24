using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    // Start is called before the first frame update
    void Start()
    {
        canFire = true;
        ammoCapacity = 10;
        currentAmmo = ammoCapacity;
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void Fire()
    {
        if (currentAmmo > 0 && canFire)
        {
            Debug.Log("Pistol Fired");
            currentAmmo--;

        }
        else 
        {
            Debug.Log("Out of ammo");
        }
    }

    protected override void Reload()
    {
        StartCoroutine(ReloadCoroutine());
    }

    private IEnumerator ReloadCoroutine(reloadTime)
    {
        canFire = false;
        yield return new WaitForSeconds(reloadTime);
        canFire = true;
        currentAmmo = ammoCapacity;
    }

}
