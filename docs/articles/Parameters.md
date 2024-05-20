## Static parameters

Static parameters are values which can be defined before the evaluation of an expression.
These parameters can be accesed using the **Parameters** dictionary of the **Expression** instance.

```c#
  Expression e = new Expression("2 * [x] ^ 2 + 5 * [y]");
  e.Parameters["x"] = 5;
  e.Parameters["y"] = 1;

  Console.WriteLine(e.Evaluate());
```
Parameters can be useful when a value is unknown at compile time, or when performance is important and the parsing can be saved for further calculations.

## Expression parameters

Expressions can be split into several ones by defining expression parameters. Those parameters are not simple values but **Expression** instances themselves.

```c#
  Expression volume = new Expression("[surface] * h");
  Expression surface = new Expression("[l] * [L]");
  volume.Parameters["surface"] = surface;
  surface.Parameters["l"] = 1;
  surface.Parameters["L"] = 2;
```

## Dynamic parameters

Sometimes parameters can be even more complex to evaluate and need a dedicated method to be evaluated. This can be done by intercepting there evaluation using the **EvaluateParameter** event published on **Expression** instances. Thus, each time a parameter is not defined in the dictionary, this event is called to try to resolve the value.

```c#
  Expression e = new Expression("Round(Pow([Pi], 2) + Pow([Pi], 2) + [X], 2)");

  e.Parameters["Pi2"] = new Expression("Pi * [Pi]");
  e.Parameters["X"] = 10;

  e.EvaluateParameter += delegate(string name, ParameterArgs args)
    {
      if (name == "Pi")
        args.Result = 3.14;
    };
```

## Square brackets parameters

Parameters in between square brackets can contain special characters like spaces, dots, and also start with digits.
```c#
  Expression e = new Expression("[My First Parameter] + [My Second Parameter]");
```
## Multi-valued parameters

When parameters are IEnumerable and the **EvaluationOptions.IterateParameters** is used, the result is an **IList** made of the evaluation of each value in the parameter.

```c#
 Expression e = new Expression("(a * b) ^ c", ExpressionOptions.IterateParameters);
 e.Parameters["a"] = new int[] { 1, 2, 3, 4, 5 };
 e.Parameters["b"] = new int[] { 6, 7, 8, 9, 0 };
 e.Parameters["c"] = 3;

 foreach (var result in (IList)e.Evaluate())
 {
     Console.WriteLine(result);
 }

 //  216
 //  2744
 //  13824
 //  46656
 //  0
```