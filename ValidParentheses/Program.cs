



bool IsValid(string s)
{
    Stack<char> stack = new Stack<char>();

	foreach (char item in s)
	{
		if(item.Equals('(') || item.Equals('{') || item.Equals('['))
		{
			stack.Push(item);
		}
		else
		{
			if (stack.Count != 0)
			{
				char poppedChar = stack.Pop();
				switch (poppedChar)
				{
					case '(':
						if (!item.Equals(')'))
							return false;
						break;
					case '{':
						if (!item.Equals('}'))
							return false;
						break;
					case '[':
						if (!item.Equals(']'))
							return false;
						break;

					default:
						break;
				}
			}
			else
				return false;
		}
	}

	if (stack.Count != 0)
		return false;

	return true;
}


Console.WriteLine(IsValid("()[]{}"));

