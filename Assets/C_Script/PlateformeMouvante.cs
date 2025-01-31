using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformeMouvante : MonoBehaviour
{
   public float speed = 2f; // Vitesse de déplacement de la plateforme
    public float height = 3f; // Hauteur maximale du mouvement
    private float startY;
    private bool movingUp = true;

    void Start()
    {
        startY = transform.position.y; // Sauvegarde de la position initiale en Y
    }

    void Update()
    {
        // Calcul de la nouvelle position en Y
        float newY = transform.position.y + (movingUp ? speed : -speed) * Time.deltaTime;

        // Vérifie si la plateforme doit changer de direction
        if (newY > startY + height)
        {
            newY = startY + height;
            movingUp = false;
        }
        else if (newY < startY - height)
        {
            newY = startY - height;
            movingUp = true;
        }
     // Met à jour la position de la plateforme
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
