using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{

    private Quaternion startRotation;

    //Para que sea mas exagerado o no
    public float swayAmount = 8;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        Sway();
    }


    private void Sway()
    {
        /**
         * Tenemos que encontrar 2 ejes el Y y X
         * Es parecido al Cameralook
         * 
         */

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        Quaternion xAngle = Quaternion.AngleAxis(mouseX * -1.25f, Vector3.up);
        Quaternion yAngle = Quaternion.AngleAxis(mouseY * -1.25f, Vector3.right);

        Quaternion targetRotation = startRotation * xAngle * yAngle;

        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * swayAmount);

    }

}
