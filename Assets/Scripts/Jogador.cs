using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour 
{

	[SerializeField]
	private int vida;

	public int GetVida () 
	{
		return vida;
	}

	public void PerdeVida () 
	{
		vida --;
	}
}
