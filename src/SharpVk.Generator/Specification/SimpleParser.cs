using Sprache;
using System.Collections.Generic;
using System.Linq;

namespace SharpVk.Generator.Specification
{
    public static class SimpleParser
    {

        private static readonly Parser<LenExpression> lenExpressionParserRef = Parse.Ref(() => lenExpressionParser);

        private static readonly Parser<LenExpressionToken> lenTokenParser = Parse.LetterOrDigit.AtLeastOnce().Text().Select(x => new LenExpressionToken { Value = x });

        private static readonly Parser<LenExpressionReference> lenDereferenceParser = from left in lenTokenParser
                                                                                         from op in Parse.String("::").Or(Parse.String("->"))
                                                                                         from right in lenTokenParser
                                                                                         select new LenExpressionReference
                                                                                         {
                                                                                             LeftOperand = left,
                                                                                             RightOperand = right
                                                                                         };

        private static readonly Parser<string> Sign = Parse.Char('-').Optional().Select(x => x.IsDefined ? "-" : "");

        private static readonly Parser<LenExpressionLiteral> integerLiteral = from sign in Sign
                                                                                 from digits in Parse.Digit.AtLeastOnce().Text().Token()
                                                                                 select new LenExpressionLiteral { Value = sign + digits };

        private static readonly Parser<LenExpressionToken> latexToken = Parse.Or(Parse.String("VK\\_UUID\\_SIZE").Text().Select(x => new LenExpressionToken { Value = "VK_UUID_SIZE" }),
                                                                              Parse.LetterOrDigit.AtLeastOnce()
                                                                                                 .Where(x => char.IsLetter(x.First()))
                                                                                                 .Text()
                                                                                                 .Token()
                                                                                                 .Select(x => new LenExpressionToken { Value = x }));

        private static readonly Parser<LenExpression> latexSubexpressionRef = Parse.Ref(() => latexSubexpression);

        private static readonly Parser<LenExpression> latexUnaryOperatorExpression = latexSubexpressionRef.Contained(Parse.String("\\lceil{"), Parse.String("}\\rceil")).Token().Select(x => new LenExpressionOperator { LeftOperand = x, Operator = LenOperatorType.Ceiling });

        private static readonly Parser<LenExpression> latexPrimaryExpression = ((Parser<LenExpression>)latexToken)
                                                                                                                                    .Or(latexToken.Contained(Parse.String("\\mathit{"), Parse.String("}")))
                                                                                                                                    .Or(latexToken.Contained(Parse.String("\\textrm{"), Parse.String("}")))
                                                                                                                                    .Or(latexToken.Contained(Parse.String("\\mathtt{"), Parse.String("}")))
                                                                                                                                    .Or(integerLiteral)
                                                                                                                                    .Or(latexUnaryOperatorExpression);

        private static readonly Parser<LenExpression> latexOpExpression = Parse.ChainOperator(Parse.Or(
                                                                                                    Parse.String("\\times").Token().Return(LenOperatorType.Multiply),
                                                                                                    Parse.String("\\over").Token().Return(LenOperatorType.Divide)),
                                                                                                latexPrimaryExpression,
                                                                                                (op, left, right) => new LenExpressionOperator { LeftOperand = left, RightOperand = right, Operator = op });

        private static readonly Parser<LenExpression> latexSubexpression = latexOpExpression;

        private static readonly Parser<string> latexExpressionStart = from start in Parse.String("latexmath:[").Text()
                                                                      from dollar in Parse.Char('$').Optional()
                                                                      select start;

        private static readonly Parser<char> latexExpressionEnd = from dollar in Parse.Char('$').Optional()
                                                                  from end in Parse.Char(']')
                                                                  select end;

        private static readonly Parser<LenExpression> latexExpression = latexSubexpression.Contained(latexExpressionStart, latexExpressionEnd);

        private static readonly Parser<LenExpression> lenExpressionParser = latexExpression
                                                                                    .Or(lenDereferenceParser)
                                                                                    .Or(lenTokenParser);

        private static readonly Parser<MemberLen> lenPartParser = Parse.String("null-terminated").Select(x => new MemberLen { Type = LenType.NullTerminated })
                                                                        .Or(lenExpressionParser.Select(x => new MemberLen { Value = x, Type = LenType.Expression }));

        private static readonly Parser<IEnumerable<MemberLen>> lenParser = lenPartParser.DelimitedBy(Parse.Char(',').Token()).End();

        private static readonly Parser<string> fixedLengthParser = from open in Parse.Char('[')
                                                                   from digits in Parse.Digit.AtLeastOnce().Text()
                                                                   from close in Parse.Char(']')
                                                                   select digits;

        private static readonly Parser<string> bitfieldLengthParser = from open in Parse.Char(':')
                                                                      from digits in Parse.Digit.AtLeastOnce().Text()
                                                                      select digits;

        public static string ParseBitfieldLength(string value)
        {
            return bitfieldLengthParser.Parse(value);
        }

        public static string ParseFixedLength(string value)
        {
            return fixedLengthParser.Parse(value);
        }

        public static MemberLen[] ParsedLenField(string field)
        {
            return lenParser.Parse(field).ToArray();
        }

        public static string NormaliseComment(string comment)
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                return "-";
            }

            comment = comment.Replace("&", "&amp;");
            comment = comment.Replace("<", "&lt;");
            comment = comment.Replace(">", "&gt;");

            return comment;
        }
    }
}
