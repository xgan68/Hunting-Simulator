using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character {
	

	public Character(int maxHitPoint, float speed, int attackPower, int defendRate, int money, string weapon){
		MaxHitPoint = maxHitPoint;
		AttackPower = attackPower;
		DefendRate = defendRate;
		Money = money;
		Speed = speed;
		CurrentHitpoint = MaxHitPoint;
		NormalSpeed = Speed;
		Weapon = weapon;
	}

	public Character(int maxHitPoint, float speed, int attackPower, int money){
		MaxHitPoint = maxHitPoint;
		AttackPower = attackPower;
		DefendRate = 0;
		Money = 0;
		Speed = speed;
		NormalSpeed = Speed;
		CurrentHitpoint = MaxHitPoint;
	}

	public Character(int maxHitPoint, float speed, int attackPower, float attackSpeed){
		MaxHitPoint = maxHitPoint;
		AttackPower = attackPower;
		AttackSpeed = attackSpeed;
		DefendRate = 0;
		Money = 0;
		Speed = speed;
		NormalSpeed = Speed;
		CurrentHitpoint = MaxHitPoint;
	}

	public int MaxHitPoint{ get; set;}
	public int AttackPower{ get; set;}
	public float AttackSpeed{ get; set;}
	public int DefendRate{ get; set;}
	public float Speed{ get; set;}
	public float NormalSpeed{ get; set;}
	public int CurrentHitpoint{ get; set;}
	public int Money{ get; set;}
	public string Weapon{ get; set;}

	public void TakeDamage(int damage){
		//Debug.Log ("Take");
		int actualDamage;

		if (damage <= DefendRate)
			actualDamage = 1;
		else
			actualDamage = damage - DefendRate;

		CurrentHitpoint = CurrentHitpoint - actualDamage;
		Debug.Log ( hpPercentage());
	}

	public void Slowed(float slowPercentage){
		float normalSpeed;
		normalSpeed = Speed;
		Speed = NormalSpeed * slowPercentage;

	}

	public void Heal(int healing){
		CurrentHitpoint = CurrentHitpoint + healing;
		if (CurrentHitpoint > MaxHitPoint) {
			CurrentHitpoint = MaxHitPoint;
		}
	}

	public float hpPercentage(){
		return (float)CurrentHitpoint / MaxHitPoint;
	}



}
