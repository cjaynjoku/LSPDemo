namespace DemoLibrary
{
    public interface IManaged:IEmployee
    {
        public IEmployee Manager { get; set; }
        public void AssignManager(IEmployee manager);
    }
}
