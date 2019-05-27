using UnityEngine;

public class selectAmmo : MonoBehaviour
{
    public int selectedAmmo = 0;
    void Start()
    {
        ammoPick();
    }

    // Update is called once per frame
    void Update()
    {

        int lastAmmo = selectedAmmo;

        if(Input.GetAxis("Mouse ScrollWheel") > 0f){
            if(selectedAmmo >= transform.childCount -1){
                selectedAmmo = 0;
            }
            else{
                selectedAmmo++;
            }
            
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0f){
            if(selectedAmmo <= 0){
                selectedAmmo = transform.childCount - 1;
            }
            else{
                selectedAmmo--;
            }
        }
        if(lastAmmo != selectedAmmo){
            ammoPick();
        }
    }
    void ammoPick(){
        int i = 0;
        foreach(Transform ammo in transform){
        if(i== selectedAmmo){
            ammo.gameObject.SetActive(true);
        }
        else{
            ammo.gameObject.SetActive(false);
        }
        i++;
        }
    }
}

