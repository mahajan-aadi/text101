using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Parts")]
public class Parts : ScriptableObject
{
    [SerializeField] [TextArea(10, 14)] string _matter;
    [SerializeField] Parts[] _next_part;
    // Start is called before the first frame update
    public string written_text()
    {
        return _matter;
    }
    public Parts[] next_parts()
    {
        return _next_part;
    }
}
