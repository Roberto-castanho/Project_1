public class InventorySummary
{
	public static void Main()
	{
		DateTime localDate = DateTime.Now;
		var ExpressionCodeList = new List<string>();
		ExpressionCodeList.Add("x1=(x + y)/z");
		ExpressionCodeList.Add("y1=22");
		ExpressionCodeList.Add("x1+y1");
		
		var argList = new List<Argument>();
		var ExpressionVariableArgs = new Dictionary<string, double>();
		ExpressionVariableArgs.Add("x", 19);
		ExpressionVariableArgs.Add("y", 32);
		ExpressionVariableArgs.Add("z", -12);
		
		var InlineExpressionVariableArgs = new Dictionary<string, double>();
		InlineExpressionVariableArgs.Add("x1", 0);
		InlineExpressionVariableArgs.Add("y1", 0);
		
		var functString = "f(";
		foreach (var eArg in ExpressionVariableArgs)
		{
			functString += eArg.Key + ",";
		}

		functString = functString.Substring(0, functString.Length - 1) + ")";
		
		foreach (var eArg in ExpressionVariableArgs)
		{
			argList.Add(new Argument(eArg.Key, eArg.Value));
		}

		
		foreach (var eArg in InlineExpressionVariableArgs)
		{
			argList.Add(new Argument(eArg.Key, eArg.Value));
		}

		
		Console.WriteLine(@"#001 :: {0}:{1}:{2} - User Created Function: {3}", localDate.Hour, localDate.Minute, localDate.Second, functString);
		var lineCount = 0;
		foreach (var codeLine in ExpressionCodeList)
		{
			lineCount++;
			Console.WriteLine("");
			Console.WriteLine(@"#002 :: {0}:{1}:{2} - === Line #{3} ==================================", localDate.Hour, localDate.Minute, localDate.Second, lineCount);
			Function function = new Function(functString + "=" + codeLine);
			Console.WriteLine(@"#003 :: {0}:{1}:{2} - Function String: {3}", localDate.Hour, localDate.Minute, localDate.Second, function.getFunctionExpressionString());
			var exp = new Expression(functString, function);
			
			foreach (Argument arg in argList)
			{
				exp.addArguments(arg);
			}

			Console.WriteLine(@"#004 :: {0}:{1}:{2} - Expression String: {3}", localDate.Hour, localDate.Minute, localDate.Second, exp.getExpressionString());
						
			exp.checkSyntax();
			if (exp.getSyntaxStatus())
			{
				Console.WriteLine(@"#005 :: {0}:{1}:{2} - Syntax check found no errors", localDate.Hour, localDate.Minute, localDate.Second);
			}
			else
			{
				var syntaxResult = exp.getErrorMessage();
				Console.WriteLine(@"#006 :: {0}:{1}:{2} - Syntax check found error(s): {3}{4}", localDate.Hour, localDate.Minute, localDate.Second, System.Environment.NewLine, syntaxResult);
			}

			
			try
			{
				var calculationResult = exp.calculate();
				if (!Double.IsNaN(calculationResult))
				{
					Console.WriteLine(@"#007 :: {0}:{1}:{2} - Calculation Success!!! Result: {3}", localDate.Hour, localDate.Minute, localDate.Second, calculationResult);
				}
				else
				{
					var err = exp.getErrorMessage();
					Console.WriteLine(@"#008 :: {0}:{1}:{2} - Calculation Failed!!! Message: {3}{4}", localDate.Hour, localDate.Minute, localDate.Second, System.Environment.NewLine, err);
				}
			}
			catch (Exception ex)
			{
				var err = exp.getErrorMessage();
				Console.WriteLine(@"#999 :: {0}:{1}:{2} - Exception on calculation: {3}", localDate.Hour, localDate.Minute, localDate.Second, ex.Message);
			}

			
			exp.removeFunctions(function);
		}
	}
}