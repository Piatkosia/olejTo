
namespace FindMeIfYouCan
{
    class VerySecureClass
    {
        public override string ToString()
        {
            return " To jest niezbyt cwane";
        }
        private string GetHiddenString()
        {
            return " Ooo to rozumiem";
        }

        private class HyperSecureClass
        {
            public override string ToString()
            {
                return " A kuku";
            }
            private string GetMoreHiddenString()
            {
                return " I co, tego nie widać?";
            }
        }
    }
}
