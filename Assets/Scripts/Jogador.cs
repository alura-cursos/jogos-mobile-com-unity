using UnityEngine;
using System.Collections;

public class Jogador : MonoBehaviour 
{

	[SerializeField]
	private int vida;

	[SerializeField] 
	private int dinheiro;

	public int GetVida () 
	{
		return vida;
	}

	public int GetDinheiro ()
	{
		return dinheiro;
	}

	public void PerdeVida () 
	{
		if (EstaVivo ()) 
		{
			vida --;
		}
	}

	public bool EstaVivo () 
	{
		return vida > 0;
	}
}
