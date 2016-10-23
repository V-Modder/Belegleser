using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace Belegleser
{
    public class SyntaxHighlighterDotLiquid : SyntaxHighlighter
    {
        //styles
        public readonly Style Value = new TextStyle(new SolidBrush(Color.FromArgb(0, 128, 128)), null, FontStyle.Regular);
        public readonly Style SteelBlue = new TextStyle(new SolidBrush(Color.FromArgb(57, 135, 214)), null, FontStyle.Bold);
        public readonly Style Blue = new TextStyle(new SolidBrush(Color.FromArgb(0, 0, 254)), null, FontStyle.Bold);

        protected Regex DotLiquidCommentRegex;
        protected Regex DotLiquidKeywordRegex;
        protected Regex DotLiquidNumberRegex;
        protected Regex DotLiquidStringRegex;
        protected Regex DotLiquidFunctionsRegex;
        protected Regex DotLiquidBrackedRegex;
        protected string keyWords = "case|endcase|unless|endunless|else|endif|elsif|false|for|endfor|break|if|continue|assign|cycle|tablerow|endtablerow|capture|increment|then|true|decrement|comment|when";
        protected string functions = "abs|append|capitalize|ceil|date|default|divided_by|downcase|escape|escape_once|first|floor|join|last|lstrip|map|minus|modulo|newline_to_br|plus|prepend|remove|remove_first|replace|replace_first|reverse|round|rstrip|size|slice|sort|split|strip|strip_html|strip_newlines|times|truncate|truncatewords|uniq|upcase|url_encode";
        
        protected void InitDotLiquidRegex()
        {
            DotLiquidStringRegex = new Regex(@"""""|''|"".*?[^\\]""|'.*?[^\\]'", RegexCompiledOption);
            DotLiquidCommentRegex = new Regex(@"({%\s*comment\s*%}.*{%\s*endcomment\s*%})$", RegexOptions.Singleline | RegexCompiledOption);
            DotLiquidNumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b", RegexCompiledOption);
            DotLiquidBrackedRegex = new Regex(@"[{}]", RegexCompiledOption);
            DotLiquidKeywordRegex = new Regex(@"\b(" + keyWords + @")\b", RegexCompiledOption);
            DotLiquidFunctionsRegex = new Regex(@"\b(" + functions + @")\b", RegexCompiledOption);
        }


        /// <summary>
        /// Highlights DotLiquid code
        /// </summary>
        /// <param name="range"></param>
        public override void DotLiquidHighlight(Range range)
        {
            range.tb.CommentPrefix = "{%comment%}";
            range.tb.LeftBracket = '(';
            range.tb.RightBracket = ')';
            range.tb.LeftBracket2 = '{';
            range.tb.RightBracket2 = '}';
            range.tb.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;

            range.tb.AutoIndentCharsPatterns = @"^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>.+)";

            //clear style of changed range
            range.ClearStyle(StringStyle, CommentStyle, NumberStyle, KeywordStyle, FunctionsStyle);
            //
            if (DotLiquidStringRegex == null)
                InitDotLiquidRegex();
            //string highlighting
            range.SetStyle(this.Value, DotLiquidStringRegex);
            //comment highlighting
            range.SetStyle(this.GreenStyle, DotLiquidCommentRegex);
            //bracket highlighting
            range.SetStyle(this.MagentaStyle, DotLiquidBrackedRegex); 
            //number highlighting
            range.SetStyle(this.BlueStyle, DotLiquidNumberRegex);
            //keyword highlighting
            range.SetStyle(this.Blue, DotLiquidKeywordRegex);
            //functions highlighting
            range.SetStyle(this.SteelBlue, DotLiquidFunctionsRegex);
            //clear folding markers
            range.ClearFoldingMarkers();
            //set folding markers
            range.SetFoldingMarkers("{", "}"); //allow to collapse brackets block
            range.SetFoldingMarkers(@"--\[\[", @"\]\]"); //allow to collapse comment block
        }

        public List<string> WordList
        {
            get 
            {
                string all = this.functions + "|" + this.keyWords;
                List<string> list = new List<string>();
                list.AddRange(all.Split('|'));
                list.Sort();
                return list;
            }
        }
    }

    /// <summary>
    /// Language
    /// </summary>
    public enum Language
    {
        Custom,
        CSharp,
        VB,
        HTML,
        XML,
        SQL,
        PHP,
        JS,
        Lua,
        DotLiquid
    }
}
