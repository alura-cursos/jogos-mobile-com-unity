using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GerenciadorDeInimigos : MonoBehaviour 
{

	[SerializeField]
	private List<GeradorDeInimigos> geradores;
	private int geradoresCriados = 0;

	//	void Start () {}

	void Update ()
	{
		if (!temPontoGerador ()) 
		{
			criaPontoGerador();
		}
	}

	private bool temPontoGerador ()
	{
		return GameObject.FindGameObjectWithTag ("PontoGerador") != null;
	}

	private void criaPontoGerador() 
	{
		Instantiate (geradores [geradoresCriados % 2]);
		geradoresCriados ++;
	}
}
