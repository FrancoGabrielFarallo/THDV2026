using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    public float velocidad = 5f;

  
    public Transform capsula;

   
    public Camera camara;

    void Update()
    {
      
        Vector3 direccion = new Vector3(0, 0, 0);

    
        if (Input.GetKey(KeyCode.W))
        {
            direccion.z = direccion.z + 1;
        }

      
        if (Input.GetKey(KeyCode.S))
        {
            direccion.z = direccion.z - 1;
        }

      
        if (Input.GetKey(KeyCode.D))
        {
            direccion.x = direccion.x + 1;
        }

       
        if (Input.GetKey(KeyCode.A))
        {
            direccion.x = direccion.x - 1;
        }

       
        direccion.Normalize();

       
        transform.position = transform.position + direccion * velocidad * Time.deltaTime;

      
        Ray rayo = camara.ScreenPointToRay(Input.mousePosition);

     
        Plane piso = new Plane(Vector3.up, transform.position);

      
        float distancia;
        if (piso.Raycast(rayo, out distancia))
        {
        
            Vector3 puntoMouse = rayo.GetPoint(distancia);

     
            puntoMouse.y = capsula.position.y;

          
            capsula.LookAt(puntoMouse);
        }
    }
}