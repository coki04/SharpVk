using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpVk.Generator;
using Sprache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpVk.Tests
{
    [TestClass]
    public class ParsingTests
    {
        private static readonly Parser<string> Sign = Parse.Char('-').Optional().Select(x => x.IsDefined ? "-" : "");

        private static readonly Parser<string> integerLiteral = from sign in Sign
                                                                from digits in Parse.Digit.AtLeastOnce().Text().Token()
                                                                select sign + digits;

        private static readonly Parser<string> latexExpression2 = Parse.ChainOperator(Parse.String("over").Token().Or(Parse.String("times").Token()).Text(),
                                                                                        integerLiteral,
                                                                                        (op, left, right) =>

                                                                                        {
                                                                                            return left + (op == "times" ? " x " : " / ") + right;
                                                                                        });


        private static readonly Parser<string> latexExpressionStart = from start in Parse.String("latexmath:[").Text()
                                                                      from dollar in Parse.Char('$').Optional()
                                                                      select start;

        private static readonly Parser<char> latexExpressionEnd = from dollar in Parse.Char('$').Optional()
                                                                  from end in Parse.Char(']')
                                                                  select end;

        private static readonly Parser<string> latexExpression = latexExpression2.Contained(latexExpressionStart, latexExpressionEnd);


        public static string ParsedLenField(string field)
        {
            return latexExpression.Parse(field);
        }

        [TestMethod]
        public void TestUUID()
        {
            string teststr = "latexmath:[2 over 4]";
            string exp = ParsedLenField(teststr);
        }
    }
}
