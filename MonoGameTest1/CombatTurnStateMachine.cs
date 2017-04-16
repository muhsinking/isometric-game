using System;
using System.Collections.Generic;

namespace MonoGameTest1
{
	public class CombatTurnStateMachine
	{
		public int currentTurn { get; set;}
		List<Character> characters;

		public CombatTurnStateMachine(List<Character> characters)
		{
			this.characters = characters;
			SortInitiative();
		}

		public Character getCurrentCharacte()
		{
			return characters[currentTurn];
		}

		public void NextTurn()
		{
			currentTurn++;
		}

		public void SortInitiative()
		{
			characters.Sort((a, b) => a.initiative.CompareTo(b.initiative)); // lambda expression comparing character intiatives
		}

		public void RemoveCharacter(Character c)
		{
			characters.Remove(c);
		}
	}
}
