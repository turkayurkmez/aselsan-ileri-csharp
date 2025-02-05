// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
ParameterExpression parameterExpression = Expression.Parameter(typeof(int), "number");
ConstantExpression constantExpression = Expression.Constant(5, typeof(int));

BinaryExpression binaryExpression = Expression.Add(parameterExpression, constantExpression);
Expression<Func<int, int>> lambda = Expression.Lambda<Func<int, int>>(binaryExpression, parameterExpression);

Func<int, int> compiled = lambda.Compile();

int result = compiled(21);

Console.WriteLine(result);

