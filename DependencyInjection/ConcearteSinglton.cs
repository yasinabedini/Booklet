namespace DependencyInjection
{
    public class ConcearteSinglton
    {
        private readonly Guid guid;
        public ConcearteSinglton()
        {
            guid = new Guid();
        }

        public string GetGuid()
        {
            return guid.ToString();
        }
    }

}
