using System.Threading;

namespace static_behavior
{
    public class Service1 : IService
    {
        static int variavelestatica = 0;

        public string GetVariable()
        {
            variavelestatica++;

            Thread.Sleep(5000);

            return string.Format("Your output: {0}", variavelestatica);
        }
    }
}
