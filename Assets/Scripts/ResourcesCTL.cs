using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesCTL
{
   private static ResourcesCTL instance = null;

    public static ResourcesCTL Instance
    {
        get 
        { 
            if (instance == null)
            {
                instance = new ResourcesCTL();
            }
            return instance;
        }
    }

    private Material blackCellMaterial;
    public Material BlackCellMaterial { 
        get 
        { 
            if (blackCellMaterial == null) 
            {
                blackCellMaterial = Resources.Load<Material>("Materials/black_cell");
            }
            return blackCellMaterial; 
        } 
    }

    private Material whiteCellMaterial;

    public Material WhiteCellMaterial 
    { 
        get 
        { 
            if (whiteCellMaterial == null)
            {
                whiteCellMaterial = Resources.Load<Material>("Materials/white_cell");
            }
        
            return whiteCellMaterial; 
        } 
    }

    private ResourcesCTL()
    {

    }

    //Load game Object
    private Dictionary<string, GameObject> _dict = new Dictionary<string, GameObject>();
    public GameObject GetGameObject(string path)
    {
        if(_dict.ContainsKey(path) == false)
        {
            _dict.Add(path, Resources.Load<GameObject>(path));

        }
        return _dict[path];
    }

   
}
