using System;
using System.Collections.Generic;

class Dictionary
{
	public static string BestScore(Dictionary<string, int> myDict)
	{
		int bestScore = -1;
		string key = "None";

		foreach (KeyValuePair<string, int> kvp in myDict)
		{
			int value = kvp.Value;
			if (value > bestScore)
			{
				bestScore = value;
				key = kvp.Key;
			}
		}
	   return key;
	}
}

