namespace DependencyInjection
{
    public class DependencySinglton : IDependencySinglton
    {
        private readonly Guid guid;
        public DependencySinglton()
        {
            guid = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return guid.ToString();
        }
    }
}
