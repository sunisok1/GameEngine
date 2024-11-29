using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game.Console24
{
    public class Game : MonoBehaviour
    {
        private static readonly double TargetSum = 24.0;
        private static readonly HashSet<string> Operations = new() { "+", "-", "*", "/" };

        [SerializeField] private TextMeshProUGUI outputText;
        [SerializeField] private TMP_InputField inputField;

        private async void Start()
        {
            while (true)
            {
                var question = GetQuestion();
                outputText.text = GetListString(question);

                var input = await inputField.OnSubmitAsync();
                outputText.text = CheckAnswer(input, question) ? "Correct!" : "Wrong!";
                await UniTask.WaitForSeconds(1);
            }
        }

        private bool CheckAnswer(string input, List<int> numbers)
        {
            try
            {
                var tokens = input.Split(' ');
                Array.Reverse(tokens);
                if (!CheckFormat(tokens, numbers)) return false;

                var stack = new Stack<double>();
                for (var i = 0; i < tokens.Length; i += 2)
                {
                    stack.Push(double.Parse(tokens[i]));
                }

                for (var i = 1; i < tokens.Length; i += 2)
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    var op = tokens[i];

                    switch (op)
                    {
                        case "+":
                            stack.Push(a + b);
                            break;
                        case "-":
                            stack.Push(a - b);
                            break;
                        case "*":
                            stack.Push(a * b);
                            break;
                        case "/":
                            if (b == 0)
                            {
                                return false;
                            }

                            stack.Push(a / b);
                            break;
                    }
                }

                return Math.Abs(stack.Pop() - TargetSum) < 1e-6;
            }
            catch
            {
                return false;
            }
        }

        private static bool CheckFormat(string[] tokens, IEnumerable<int> numbers)
        {
            if (tokens.Length != 7)
            {
                return false;
            }

            var hashSet = numbers.ToHashSet();
            for (var i = 0; i < tokens.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (!int.TryParse(tokens[i], out var num) || !hashSet.Contains(num))
                    {
                        return false;
                    }
                }
                else
                {
                    if (!Operations.Contains(tokens[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private List<int> GetQuestion()
        {
            return new List<int> { Random.Range(1, 11), Random.Range(1, 11), Random.Range(1, 11), Random.Range(1, 11) };
        }

        private string GetListString<T>(List<T> numbers)
        {
            return $"{numbers[0]},{numbers[1]},{numbers[2]},{numbers[3]}";
        }
    }
}