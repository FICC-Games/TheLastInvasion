using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    //Det är en float variable som används till att påverka hur mycket backgrunden rör sig när spelaren går
    private float EffectMultiplier;
    //Gör att man kan lägga in kameran och använda den som ett GameObject i koden, I koden kollar det hur mycket kameran rör sig ocj flyttar backrunden åt motsatt håll.
    public GameObject Camera1;
    //Som vi ser i "private void start" så är det kamerans position som sparas i den här variabeln.
    private Transform CTransform;
    //Visar camerans position.
    private Vector3 CameraLast;
    // Start is called before the first frame update
    private void Start()
    {
        CTransform = Camera1.transform;
        CameraLast = CTransform.position;
    }
    

    // Update is called once per frame
    private void Update()
    {
        
        Vector3 deltaMovment = CTransform.position - CameraLast;
        // flyttar det koden står på lika mycket som cameran rör sig och sedan gånger den speed som backgrunden
        // ska gå i den ska vara lägre än 1 om man vill att bakgrunden ska gå långsammare än gubben
        transform.position += deltaMovment * EffectMultiplier;
        //Gör så att inte bakgrunden fortsätter lägga på vellocity.
        CameraLast = CTransform.position;
    }
}
