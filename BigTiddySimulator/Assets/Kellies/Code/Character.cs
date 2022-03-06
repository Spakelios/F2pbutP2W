using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character : MonoBehaviour
{

    public string characterName;
    /// Root is the container for all images relate to the character in the scene. The root object
    [HideInInspector] public RectTransform root;

    public bool isMultiLayerCharacter{get{ return renderers.renderer == null;}}

// create a new character
    public Character (string _name)
    {
        CharacterManager cm = CharacterManager.instance;

        // locate the character prefab
        GameObject prefab = Resources.Load("Simp") as GameObject;

        // spawn an instance of the prefab directly on the character panel
        GameObject ob = Instantiate (prefab, cm.characterPanel);

        root = ob.GetComponent<RectTransform> ();
        characterName = _name;

//get the renderer(s)
        renderers.renderer = ob.GetComponentInChildren<RawImage> ();
    
        if (isMultiLayerCharacter)
        {
            renderers.bodyRenderer = ob.transform.Find ("bodyLayer").GetComponent<Image> ();
            renderers.expressionRenderer = ob.transform.Find ("expressionLayer").GetComponent<Image> ();
        }

    }

    class Renderers
    {
        // used as the only image for single layer character
        public RawImage renderer;

        //sprites use images
        //the body renderer for the multilayer character
        public Image bodyRenderer;

        //the expression renderer for the multilayer character
        public Image expressionRenderer;
    }

    Renderers renderers = new Renderers();
}