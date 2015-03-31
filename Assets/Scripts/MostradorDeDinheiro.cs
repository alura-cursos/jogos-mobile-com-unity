using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MostradorDeDinheiro : MonoBehaviour {

	private Text campoTexto;
	public Jogador jogador;
	
	void Start () 
	{
		campoTexto = GetComponent<Text> ();
	}
	
	void Update () 
	{
		campoTexto.text = "Dinheiro: " + jogador.GetDinheiro ();
	}
}
