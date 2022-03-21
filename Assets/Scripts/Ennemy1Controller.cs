using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ennemy1Controller : MonoBehaviour
{

    public int Speed = 5;
    private Vector3 DirectionDeplacement = Vector3.zero;
    private CharacterController Ennemy1;
    //public Image healthbar;
    //public float startHealth = 100f;
    //private float health;
    //private float amount;




    // Start is called before the first frame update
    void Start()
    {
        Ennemy1 = GetComponent<CharacterController>();
        //health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        DirectionDeplacement.z = Input.GetAxisRaw("Vertical");
        DirectionDeplacement.x = Input.GetAxisRaw("Horizontal");
        DirectionDeplacement = transform.TransformDirection(DirectionDeplacement);
        Ennemy1.Move(DirectionDeplacement * Time.deltaTime * Speed);


    }

    //public void TakeDammage(float amount)
    //{
    //health -= amount;

    //healthbar.fillAmount = health / startHealth;
    // if(health <= 0)
    // {

    // }
//}
}
