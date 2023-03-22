using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon : MonoBehaviour
{
    public WeaponConfig weaponConfig;
    public WeaponAttachment mainWeaponAttachment;
    public WeaponAttachment secondaryAttachment;

    private bool isFiring;
    private IWeapon weapon;
    private bool isDecorated;

    // Start is called before the first frame update
    void Start()
    {
        this.weapon = new Weapon(weaponConfig);
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(5, 50, 200, 100), "Firing Rate: + " + weapon.Rate);
        GUI.Label(new Rect(5, 70, 200, 100), "Firing Rate: + " + weapon.Range);
        GUI.Label(new Rect(5, 90, 200, 100), "Firing Rate: + " + weapon.Strength);
        GUI.Label(new Rect(5, 110, 200, 100), "Firing Rate: + " + weapon.Cooldown);
        GUI.Label(new Rect(5, 130, 200, 100), "Firing Rate: + " + isFiring);

        if (mainWeaponAttachment && isDecorated)
        {
            GUI.Label(new Rect(5, 170, 200, 100), "Main Attachment: " + mainWeaponAttachment.attachmentName);

        }
        if (mainWeaponAttachment && isDecorated)
        {
            GUI.Label(new Rect(5, 200, 200, 100), "Secondary Attachment: " + secondaryAttachment.attachmentName);

        }
    }

    public void ToggleFire()
    {
        isFiring = !isFiring;

        if (isFiring)
        {
            StartCoroutine("FireWeapon");
        }
    }

    IEnumerable FireWeapon()
    {
        float firingRate = 10 / weapon.Rate;

        while (isFiring)
        {
            yield return new WaitForSeconds(firingRate);
        }
    }

    public void Reset()
    {
        weapon = new Weapon(weaponConfig);
        isFiring = false;
        isDecorated = false;
    }

    public void Decorate()
    {
        isFiring = false;

        if (mainWeaponAttachment && !secondaryAttachment)
        {
            weapon = new WeaponDecorator(weapon, mainWeaponAttachment);
        }

        if (mainWeaponAttachment && secondaryAttachment)
        {
            weapon = new WeaponDecorator(new WeaponDecorator(weapon, mainWeaponAttachment), secondaryAttachment);
        }
        isDecorated = !isDecorated;
    }
}
