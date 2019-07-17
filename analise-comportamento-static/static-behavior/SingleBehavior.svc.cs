using System.ServiceModel;

namespace static_behavior
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class SingleBehavior : ISingleBehavior
    {
        int variavel = 0;

        public string GetVariable()
        {
            variavel++;
            return string.Format("Your output: {0}", variavel);
        }
    }
}
