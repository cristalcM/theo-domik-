using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public CharacterMover[] characters;     // 4 personajes
    public Transform[] positions;           // 4 posiciones 

    private CharacterMover selectedCharacter;

    public string[] characterNames; 
    public TMPro.TextMeshProUGUI selectedNameText; 

    public void SelectCharacter(int index)
    {
        selectedCharacter = characters[index];

        // Muestra cuál personaje está seleccionado visualmente
        for (int i = 0; i < characters.Length; i++)
        {
            SelectionIndicator indicator = characters[i].GetComponent<SelectionIndicator>();
            if (indicator != null)
                indicator.SetSelected(i == index);
        }


        //Muestra el nombre
        if (selectedNameText != null && characterNames.Length > index)
            selectedNameText.text = "Seleccionado: " + characterNames[index];
    }

    public void MoveToPosition(int positionIndex)
    {
        if (selectedCharacter == null) return;

        Vector3 targetPosition = positions[positionIndex].position;


        //----------------------------------
        // Verifica si otro personaje ya está en la posición
        //----------------------------------
        foreach (CharacterMover character in characters)
        {
            if (character != selectedCharacter && Vector3.Distance(character.transform.position, targetPosition) < 0.1f)
            {
                // Intercambio: el personaje que estaba en la posición se va a donde estaba el seleccionado
                Vector3 originalPosition = selectedCharacter.transform.position;
                character.MoveTo(originalPosition);
                break;
            }
        }

        //----------------------------------
        // Mover personaje seleccionado al destino
        //--------------------------------------
        selectedCharacter.MoveTo(targetPosition);
    }
}

