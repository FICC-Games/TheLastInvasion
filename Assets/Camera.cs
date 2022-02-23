using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField, Range(0, 10)]
    //Det �r en float variable som anv�nds till att p�verka hur mycket backgrunden r�r sig n�r spelaren g�r
    private float EffectMultiplier;
    //G�r att man kan l�gga in kameran och anv�nda den som ett GameObject i koden, I koden kollar det hur mycket kameran r�r sig ocj flyttar backrunden �t motsatt h�ll.
    public GameObject Camera1;
    //Som vi ser i "private void start" s� �r det kamerans position som sparas i den h�r variabeln.
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
        // flyttar det koden st�r p� lika mycket som cameran r�r sig och sedan g�nger den speed som backgrunden
        // ska g� i den ska vara l�gre �n 1 om man vill att bakgrunden ska g� l�ngsammare �n gubben
        transform.position += deltaMovment * EffectMultiplier;
        //G�r s� att inte bakgrunden forts�tter l�gga p� vellocity.
        CameraLast = CTransform.position;
    }
}
