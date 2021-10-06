using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_Resolvido2_Enum_Composicao.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment ()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }

}
