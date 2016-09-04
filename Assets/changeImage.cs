using UnityEngine;
using System.Collections;

public class changeImage : MonoBehaviour {
	//テクスチャを用意
	public Texture image;
	public Texture image2;
	public Texture pos1;
	public Texture pos2;
	public Texture pos3;
	public Texture pos4;
	bool bChange = true;
	int pos =0;
	// Use this for initialization
	void Start () {
		pos = PlayerPrefs.GetInt ("pos", 0);
		PlayerPrefs.DeleteKey("pos"); 
		switch (pos) {
		case 1:
			renderer.material.mainTexture = pos1;
			break;
		case 2:
			renderer.material.mainTexture = pos2;
			break;
		case 3:
			renderer.material.mainTexture = pos3;
			break;
		case 4:
			renderer.material.mainTexture = pos4;
			break;
		default:
			renderer.material.mainTexture = image;
			break;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.DownArrow)){

		}

	}

	public void OnClick1(){
		if (pos == 0) {
			if (bChange) {
				renderer.material.mainTexture = image2; 
				bChange = false;
			} else {
				renderer.material.mainTexture = image; 
				bChange = true;
			}
		}
	}
	public void OnClick2(){
		Application.Quit ();
	}
}
