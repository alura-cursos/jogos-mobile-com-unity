using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GerenciadorDeInimigos : MonoBehaviour 
{

	[SerializeField]
	private List<GeradorDeInimigos> geradores;

	void Start ()
	{
		Instantiate (geradores [0]);
	}
	
}
