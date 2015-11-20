using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Constant
    {
        public Dictionary<char, int> Constants = new Dictionary<char, int>();
        public string Input { get; set; }
        public int Output { get; set; }
        public Constant()
        {

        }
        public Constant(string input)
        {
            Input = input;
        }

        public int GetExpression()
        {
            if(Input.Trim().Length == 1)
            {
                if (Char.IsLetter(char.Parse(Input.Trim()))) {
                    if (IsInList(char.Parse(Input.Trim())))
                    {
                        return GetValueOf(char.Parse(Input.Trim()));
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }
            else
            {
                var leftside = Input.Split('=')[0].Trim();
                if(leftside.Length != 1 || Input.Split('=').Length != 2)
                {
                    throw new FormatException();
                }
                else
                {
                    var rightside = Input.Split('=')[1].Trim();
                    if(rightside.Length == 0)
                    {
                        throw new FormatException();
                    }
                    try
                    {
                        for (int i = 0; i < rightside.Length; i++)
                        {
                            if (Char.IsLetter(rightside[i]))
                            {
                                if (IsInList(rightside[i]))
                                {
                                    //this line has the error
                                    //string newRightside = rightside.Insert(i, GetValueOf(rightside[i]).ToString());
                                    //rightside.Replace(i, 1);
                                    //s.Remove(3, 2).Insert(3, "ZX");
                                    rightside = rightside.Remove(i, 1).Insert(i, GetValueOf(rightside[i]).ToString());
                                }
                                else
                                {
                                    throw new FormatException();
                                }
                            }
                            else
                            {

                            }
                        }
                        ProcessInput PI = new ProcessInput(rightside);
                        Evaluate ev = new Evaluate(PI.GetFirstInputNumber(), PI.GetOperator(), PI.GetSecondInputNumber());
                        int rightsideResult = ev.Operate();
                        AddToConstants(char.Parse(leftside), rightsideResult);
                        return rightsideResult;
                    }
                    catch
                    {
                        throw new FormatException();
                    }
                }
            }
        }

        public void ChangeExpression(string input)
        {
            Input = input;
        }

        public void AddToConstants(char constant, int value)
        {
            if (!IsInList(constant))
            {
                Constants.Add(constant, value);
            }
        }

        public int GetValueOf(char constant)
        {
            if (IsInList(constant))
            {
                return Constants[Char.ToLower(constant)];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public bool IsInList(char constant)
        {
            if (Constants.ContainsKey(constant))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
