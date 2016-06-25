using UnityEngine;
using System.Collections;
using UnityEditor.SceneManagement;
using UnityEngine.UI;


public class carga : MonoBehaviour {
	public bool abrir,aparece;
    public GameObject descripcion,botonInfo;
	public Image vida;
	public Text leyenda;
	public float proporcion;
	// Use this for initialization
	void Start () {
		abrir = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (abrir)
		EditorSceneManager.LoadScene (0);
		descripcion.SetActive (aparece);
		botonInfo.SetActive (!aparece);
		leyenda.text =proporcion.ToString();
		vida.fillAmount = proporcion;
	}

	//public static void LoadScene(int , SceneManagement.LoadSceneMode mode = LoadSceneMode.Single);
	public void cargaScena(){
		abrir = true;
	}

	public void describe(){
		aparece = !aparece;

	}

}
